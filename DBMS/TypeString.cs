namespace DBMS
{
    internal class TypeString : Type
    {
        public override bool Validate(string value)
        {
            return true;
        }
    }
}
