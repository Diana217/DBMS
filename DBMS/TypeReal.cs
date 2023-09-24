namespace DBMS
{
    internal class TypeReal : Type
    {
        public override bool Validate(string value)
        {
            double buf;
            if (double.TryParse(value, out buf)) 
                return true;
            return false;
        }
    }
}
