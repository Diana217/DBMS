namespace DBMS
{
    internal class TypeInteger : Type
    {
        public override bool Validate(string value)
        {
            int buf;
            if (int.TryParse(value, out buf)) 
                return true;
            return false;
        }
    }
}
