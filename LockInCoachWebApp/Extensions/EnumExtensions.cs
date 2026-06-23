using Microsoft.AspNetCore.Components;

namespace LockInCoachWebApp.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDisplayString<T>(this IEnumerable<T> values, string separator = ", ")
            where T : Enum
            => string.Join(separator, values);

        public static MarkupString ToDisplayBadges<T>(this IEnumerable<T> values)
            where T : Enum
        {
            var badges = string.Join(" ", values.Select(v =>
                $"<span class=\"badge bg-secondary\">{v}</span>"));
            return new MarkupString(badges);
        }
    }
}
