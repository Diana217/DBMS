namespace DBMS
{
    internal class TypeChar : Type
    {
        public override bool Validate(string value)
        {
            char buf;
            if (char.TryParse(value, out buf)) 
                return true;
            return false;
        }
    }
}
