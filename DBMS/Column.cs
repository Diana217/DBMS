namespace DBMS
{
    internal class Column
    {
        public string ColName;
        public Type ColType;
        public string TypeName;

        public Column(string name, string type)
        {
            ColName = name;
            TypeName = type;

            switch (type)
            {
                case "Integer":
                    ColType = new TypeInteger();
                    break;
                case "Real":
                    ColType = new TypeReal();
                    break;
                case "Char":
                    ColType = new TypeChar();
                    break;
                case "String":
                    ColType = new TypeString();
                    break;
                case "Enum":
                    ColType = new TypeEnum();
                    break;
                case "Email":
                    ColType = new TypeEmail();
                    break;
                default:
                    ColType = new TypeString();
                    break;
            }
        }
    }
}
