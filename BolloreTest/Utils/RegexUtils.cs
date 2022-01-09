using System.Text.RegularExpressions;

namespace BolloreTest.Utils
{
    public static class RegexUtils
    {
        public static string RegexReplaceExo1(string source)
        {
            const string pattern = @"[js]|[ch]+";
            return Regex.Replace(source, pattern, "z");
        }
    }
}