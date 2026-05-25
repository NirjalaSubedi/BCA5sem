using System;

namespace MyExtensions
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            string[] words = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
    
}