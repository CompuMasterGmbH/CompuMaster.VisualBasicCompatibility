using System;

namespace CompuMaster.VisualBasicCompatibility
{
    public static class Strings
    {
        public static string Left(string value, int number)
        {
            if (value == null)
                return "";
            else if (number >= value.Length)
                return value;
            else
                return value.Substring(0, number);
        }

        public static string Right(string value, int number)
        {
            if (value == null)
                return "";
            else if (number >= value.Length)
                return value;
            else
                return value.Substring(value.Length - number);
        }

        public static string Space(int number)
        {
            return "".PadLeft(number);
        }

        public static string Mid(string text, int startPosition)
        {
            if (text == null)
                return null;
            else if (startPosition > text.Length)
                return "";
            else
                return text.Substring(startPosition - 1);
        }

        public static string Mid(string text, int startPosition, int length)
        {
            if (text == null)
                return "";
            else if (startPosition > text.Length)
                return "";
            else
            {
                int MaxReadLength = System.Math.Min(text.Length - (startPosition - 1), length);
                return text.Substring(startPosition - 1, MaxReadLength);
            }
        }

        public static string Replace(string value, string search, string replacement)
        {
            if (value == null)
                return null;
            else if (value == null)
                return "";
            else
                return value.Replace(search, replacement);
        }

        public static string Trim(string value)
        {
            if (value == null)
                return "";
            else
                return value.Trim();
        }

        public static int Len(object value)
        {
            if (value == null)
                return 0;
            else if (value.GetType() == typeof(string))
                return System.Convert.ToString(value).Length;
            else if (value.GetType() == typeof(byte))
                return 1;
            else if (value.GetType() == typeof(int))
                return 4;
            else if (value.GetType() == typeof(float))
                return 4;
            else if (value.GetType() == typeof(long))
                return 8;
            else if (value.GetType() == typeof(decimal))
                return 8;
            else if (value.GetType() == typeof(DateTime))
                return 8;
            else if (value.GetType() == typeof(TimeSpan))
                return 0;
            else
                throw new NotSupportedException();
        }

        public static string StrDup(int number, char character)
        {
            System.Text.StringBuilder Result = new System.Text.StringBuilder();
            for (int MyCounter = 0; MyCounter <= number - 1; MyCounter++)
                Result.Append(character);
            return Result.ToString();
        }

        public static int InStr(string value, string search)
        {
            if (value == null)
                return 0;
            else if(value == "")
                return 0;
            else
                return value.IndexOf(search) + 1;
        }

        public static string LSet(string value, int length)
        {
            if (value == null && length > 0)
                return Space(length);
            else if (value == null)
                return "";
            else if (length == 0)
                return string.Empty;
            else if (length < value.Length)
                return value.Substring(0, length);
            else
                return value + Space(length - value.Length);
        }

        public static string RSet(string value, int length)
        {
            if (value == null && length > 0)
                return Space(length);
            else if (value == null)
                return "";
            else if (length == 0)
                return string.Empty;
            else if (length < value.Length)
                return value.Substring(0, length);
            else
                return Space(length - value.Length) + value;
        }

        public static string LCase(string value)
        {
            if (value == null)
                return string.Empty;
            else
                return value.ToLowerInvariant();
        }

        public static string UCase(string value)
        {
            if (value == null)
                return string.Empty;
            else
                return value.ToUpperInvariant();
        }
    }
}
