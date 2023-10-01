namespace DBMS
{
    public class Database
    {
        public string DBName;
        public List<Table> Tables;

        public Database(string name)
        {
            DBName = name;
            Tables = new List<Table>();
        }
    }
}
