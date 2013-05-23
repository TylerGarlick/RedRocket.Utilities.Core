using System;
using System.Linq;
using JetBrains.Annotations;

public static class StringExtensions
{
    [StringFormatMethod("input")]
    public static string P(this string input, params object[] args)
    {
        return string.Format(input, args);
    }

    public static string ToCamelCase(this string input, params string[] separators)
    {
        var output = string.Empty;
        if (!string.IsNullOrEmpty(input))
        {
            var elements = input.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < elements.Length; i++)
            {
                var element = elements.ElementAt(i);
                var elementCharacters = element.ToCharArray();
                if (elementCharacters.Any() && char.IsLetter(elementCharacters.First()) && char.IsLower(elementCharacters.First()))
                    elementCharacters[0] = Char.ToUpper(elementCharacters[0]);

                elements[i] = new string(elementCharacters);
            }
            return string.Join(string.Empty, elements);
        }
        return output;
    }
}