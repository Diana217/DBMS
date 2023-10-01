using DBMS;
namespace UnitTests
{
    [TestFixture]
    public class DBManagerTests
    {
        private DBManager dbManager;
        private Table table1;
        private Table table2;
        private Table table3;

        [SetUp]
        public void Setup()
        {
            dbManager = new DBManager();
            dbManager.db = new Database("Test DB");

            table1 = new Table("Table1");
            table1.Columns.Add(new Column("ID", "Integer"));
            table1.Columns.Add(new Column("Name", "String"));

            Row row = new Row();
            row.RowValues.AddRange(new List<string>() { "1", "John" });
            table1.Rows.Add(row);

            row = new Row();
            row.RowValues.AddRange(new List<string>() { "2", "Alice" });
            table1.Rows.Add(row);

            table2 = new Table("Table2");
            table2.Columns.Add(new Column("ID", "Integer"));
            table2.Columns.Add(new Column("Age", "Integer"));

            row = new Row();
            row.RowValues.AddRange(new List<string>() { "1", "25" });
            table2.Rows.Add(row);

            row = new Row();
            row.RowValues.AddRange(new List<string>() { "2", "30" });
            table2.Rows.Add(row);

            table3 = new Table("Table3");
            table3.Columns.Add(new Column("ID", "Integer"));
            table3.Columns.Add(new Column("Name", "String"));

            dbManager.db.Tables.Add(table1);
            dbManager.db.Tables.Add(table2);
            dbManager.db.Tables.Add(table3);
        }

        [Test]
        public void TestUnionOfTables()
        {
            Table resultTable = dbManager.UnionOfTables("Table1", "Table2", "ID");

            Assert.That(resultTable.TableName, Is.EqualTo("Union"));
            Assert.That(resultTable.Rows.Count, Is.EqualTo(2));
            Assert.That(resultTable.Columns.Count, Is.EqualTo(3));

            Assert.IsTrue(resultTable.Columns.Any(c => c.ColName == "ID"));
            Assert.IsTrue(resultTable.Columns.Any(c => c.ColName == "Name"));
            Assert.IsTrue(resultTable.Columns.Any(c => c.ColName == "Age"));
        }

        [Test]
        public void TestAddRow()
        {
            int tIndex = 2;
            bool result = dbManager.AddRow(tIndex);

            Assert.IsTrue(result);
            Table testTable = dbManager.db.Tables[tIndex];
            Assert.That(testTable.Rows.Count, Is.EqualTo(1));

            int expectedColumnCount = testTable.Columns.Count;
            Assert.That(expectedColumnCount, Is.EqualTo(testTable.Rows[0].RowValues.Count));
            foreach (var value in testTable.Rows[0].RowValues)
            {
                Assert.That(value, Is.EqualTo(""));
            }
        }

        [Test]
        public void TestAddColumn()
        {
            int tIndex = 2;

            string columnName = "Age";
            string columnType = "Integer";

            bool result = dbManager.AddColumn(tIndex, columnName, columnType);

            Assert.IsTrue(result);

            Table testTable = dbManager.db.Tables[tIndex];
            Assert.That(testTable.Columns.Count, Is.EqualTo(3));

            Column addedColumn = testTable.Columns[2];
            Assert.That(addedColumn.ColName, Is.EqualTo(columnName));
            Assert.That(addedColumn.ColType, Is.TypeOf<TypeInteger>());

            foreach (var row in testTable.Rows)
            {
                Assert.That(row.RowValues[2], Is.EqualTo(""));
            }
        }
    }
}