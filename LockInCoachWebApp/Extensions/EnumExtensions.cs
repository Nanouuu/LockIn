using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDisplayString<T>(this IEnumerable<T> values, string separator = ", ")
            where T : Enum
            => string.Join(separator, values);
    }
}
