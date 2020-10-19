using System;
using System.Linq;

namespace Automated.Test.Configuration
{
    public static class Extensions
    {
        public static int ApenasNumeros(this string value)
        {
            return Convert.ToInt16(new string(value.Where(char.IsDigit).ToArray()));
        }
    }
}