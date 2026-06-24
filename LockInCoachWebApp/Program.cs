using LockInCoachWebApp.Components;
using LockInCoachWebApp.Services.Interfaces;
using LockInCoachWebApp.Services.Local;
using LockInCoachWebApp.Services.Stubs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("LockInCoachWebAppContext") ?? throw new InvalidOperationException("Connection string 'LockInCoachWebAppContext' not found.");

builder.Services.AddDbContextFactory<LockInCoachWebAppContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

#region Stub
builder.Services.AddSingleton<IAthleteService, AthleteServiceStub>();
builder.Services.AddSingleton<IExerciseService, ExerciseServiceStub>();
builder.Services.AddSingleton<ITrainingProgramService, TrainingProgramServiceStub>();
#endregion

#region LOCAL DB
/*
builder.Services.AddScoped<IAthleteService, AthleteLocalService>();
*/
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseMigrationsEndPoint();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
