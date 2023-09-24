using System.Text.RegularExpressions;

namespace DBMS
{
    internal class TypeEmail : Type
    {
        public override bool Validate(string value)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(value, pattern);
        }
    }
}
