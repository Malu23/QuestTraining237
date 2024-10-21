using System;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
   
    public static class StringExtensionMethods
    {
        public static string TitleCase(this string str)
        {
            if (string.IsNullOrEmpty(str))  
            {
                return string.Empty; 
            }

            var words = str.Split(' '); 
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word)) 
                {
                    sb.Append(char.ToUpper(word.First()) + word.Substring(1).ToLower() + " ");
                }
            }

            return sb.ToString().TrimEnd(); 
        }
    }
}
