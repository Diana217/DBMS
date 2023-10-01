namespace DBMS
{
    internal class TypeEnum : Type
    {
        public override bool Validate(string value)
        {
            string[] buf = value?.Split(',');
            if (buf != null && buf.Length == 0) 
                return false;
            return true;
        }
    }
}
