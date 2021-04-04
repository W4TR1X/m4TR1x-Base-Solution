using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Extensions
{
    public static class StringExtensions
    {
        public static string DeTurkish(this string text)
        {
            return text
                .Replace("Ş", "S")
                .Replace("Ç", "C")
                .Replace("İ", "I")
                .Replace("Ğ", "G")
                .Replace("Ü", "U")
                .Replace("Ö", "O")
                .Replace("ş", "s")
                .Replace("ç", "c")
                .Replace("ı", "i")
                .Replace("ğ", "g")
                .Replace("ü", "u")
                .Replace("ö", "o");
        }

        public static string AsUrlString(this string value)
        {
            if (value.Length == 0)
            {
                throw new ArgumentNullException();
            }

            value = value.ToLower()
                //Replacing
                .Replace(" ", "-")
                .Replace("ç", "c")
                .Replace("ş", "s")
                .Replace("ü", "u")
                .Replace("ğ", "g")
                .Replace("ı", "i")
                .Replace("ö", "o")
                //Removing
                .Replace("'", "")
                .Replace("\"", "")
                .Replace("\\", "");

            if (value.Length > 45)
            {
                value = value.Substring(0, 45);
            }

            value += "-" + new Random().Next(1000, 9999);

            return value;
        }

        public static string ToTitleCase(this string textValue)
        {
            if (textValue == null) return textValue;

            var values = textValue.Trim().Split(" ");
            var result = "";

            foreach (var value in values)
            {
                if (value != null && value.Any())
                {
                    if (value.Length == 1)
                    {
                        result += value.ToUpper() + " ";
                        continue;
                    }

                    result += value[0].ToString().ToUpper() + value.Substring(1).ToLower() + " ";
                }
            }

            return result.TrimEnd(' ');
        }
    }
}
