using System;
using JetBrains.Annotations;

namespace RedRocket
{
    public static class StringExtensions
    {
        [StringFormatMethod("str")]
        public static string P(this string str, params object[] args)
        {
            return String.Format(str, args);
        }
    }
}