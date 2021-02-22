using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace APFinal2202.Helpers
{
    public static class StringExtensions
    {
        public static string Humanize(this string source)
        {
            var parts = Regex.Split(source, @"(?<!^)(?=[A-Z])");
            return string.Join(" ", parts);
        }

        public static string RemoveExtension(this string source)
        {
            var extensions = new[] { ".jpg", ".png" };
            var extension = extensions.FirstOrDefault(source.EndsWith);
            return source.Replace(extension ?? "", "");
        }

        public static double GetDouble(this string source)
        {
            var value = 0.0;
            if (string.IsNullOrEmpty(source))
            {
                return value;
            }

            double.TryParse(source, out value);
            return value;
        }

        public static DateTime GetDateTime(this string source)
        {
            return DateTime.Parse(source);
        }

        public static string GetName<T>(this string value)
        {
            var names = Enum.GetNames(typeof(T));
            var trimmedName = value.TrimSpaces();
            return names.FirstOrDefault(it => it.Equals(trimmedName));
        }

        public static string TrimSpaces(this string value)
        {
            if (!value.Contains(" "))
            {
                return value;
            }

            var parts = value.Split(' ');
            return string.Join("", parts);
        }
    }
}