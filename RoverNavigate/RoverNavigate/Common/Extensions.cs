using System;
using System.Collections.Generic;
using System.Text;

namespace RoverNavigate.Common
{
    public static class Extensions
    {
        public static string Reverse(this string value)
        {
            char[] arr = value.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
