using System;
using System.Collections.Generic;

namespace MinecraftPlayers.Services
{
    static class Utils
    {
        public static int ParseInt(string intString)
        {
            int parsedResult = 0;
            int.TryParse(intString, out parsedResult);
            return parsedResult;
        }

        public static void FillListWithEnumValues<T>(IList<string> list)
        {
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                list.Add(value.ToString());
            }
        }

        public static string GetHexString(this Xamarin.Forms.Color color)
        {
            var red = (int)(color.R * 255);
            var green = (int)(color.G * 255);
            var blue = (int)(color.B * 255);
            var alpha = (int)(color.A * 255);
            var hex = $"#{alpha:X2}{red:X2}{green:X2}{blue:X2}";

            return hex;
        }
    }
}
