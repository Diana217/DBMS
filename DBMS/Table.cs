namespace DBMS
{
    internal class Table
    {
        public string TableName;
        public List<Column> Columns;
        public List<Row> Rows;

        public Table(string name)
        {
            TableName = name;
            Columns = new List<Column>();
            Rows = new List<Row>();
        }
    }
}
