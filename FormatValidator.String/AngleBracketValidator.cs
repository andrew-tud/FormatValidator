using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace FormatValidator.String
{
    public class AngleBracketValidator : IValidator
    {
        public readonly string pattern = @"^(?:[^<>]*<[^<>]*>[^<>]*)*$";
        public bool Validate(string input)
        {
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            } 
            else if (NoAngleBrackets(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NoAngleBrackets(string input)
        {
            return input.IndexOf('<') == -1 && input.IndexOf('>') == -1;
        }
    }
}