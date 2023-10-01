namespace DBMS
{
    internal class DBManager
    {
        Database db;

        public bool CreateDB(string dbname)
        {
            if (dbname.Equals("")) 
                return false;

            db = new Database(dbname);
            return true;
        }

        public bool AddTable(string tname)
        {
            if (tname.Equals("")) 
                return false;
            if (db == null) 
                return false;
            if(db.Tables.Where(x => x.TableName == tname).Count() > 0)
                return false;

            db.Tables.Add(new Table(tname));
            return true;
        }

        public Table GetTable(int index)
        {
            if (index == -1) 
                index = 0;
            return db.Tables[index];
        }

        public bool AddColumn(int tIndex, string cname, string ctype)
        {
            if (db == null) 
                return false;
            if (db.Tables.Count <= 0) 
                return false;
            if (db.Tables[tIndex].Columns.Where(x => x.ColName == cname).Count() > 0)
                return false;

            db.Tables[tIndex].Columns.Add(new Column(cname, ctype));
            for (int i = 0; i < db.Tables[tIndex].Rows.Count; ++i)
            {
                db.Tables[tIndex].Rows[i].RowValues.Add("");
            }
            return true;
        }

        public bool AddRow(int tIndex)
        {
            if (db == null) 
                return false;
            if (db.Tables.Count <= 0) 
                return false;
            if (db.Tables[tIndex].Columns.Count <= 0) 
                return false;

            db.Tables[tIndex].Rows.Add(new Row());
            for (int i = 0; i < db.Tables[tIndex].Columns.Count; ++i)
            {
                db.Tables[tIndex].Rows.Last().RowValues.Add("");
            }
            return true;
        }

        public bool ChangeValue(string newValue, int tIndex, int cIndex, int rIndex)
        {
            if (db.Tables[tIndex].Columns[cIndex].ColType.Validate(newValue))
            {
                db.Tables[tIndex].Rows[rIndex].RowValues[cIndex] = newValue;
                return true;
            }
            return false;
        }

        public void DeleteRow(int tIndex, int rIndex)
        {
            db.Tables[tIndex].Rows.RemoveAt(rIndex);
        }

        public void DeleteColumn(int tIndex, int cIndex)
        {
            db.Tables[tIndex].Columns.RemoveAt(cIndex);
            for (int i = 0; i < db.Tables[tIndex].Rows.Count; ++i)
            {
                db.Tables[tIndex].Rows[i].RowValues.RemoveAt(cIndex);
            }
        }

        public void DeleteTable(int tIndex)
        {
            db.Tables.RemoveAt(tIndex);
        }

        char sep = '$';
        char space = '#';
        public void SaveDB(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(db.DBName);
            foreach (Table t in db.Tables)
            {
                sw.WriteLine(sep);
                sw.WriteLine(t.TableName);
                foreach (Column c in t.Columns)
                {
                    sw.Write(c.ColName + space);
                }
                sw.WriteLine();
                foreach (Column c in t.Columns)
                {
                    sw.Write(c.TypeName + space);
                }
                sw.WriteLine();
                foreach (Row r in t.Rows)
                {
                    foreach (string s in r.RowValues)
                    {
                        sw.Write(s + space);
                    }
                    sw.WriteLine();
                }
            }
            sw.Close();
        }

        public void OpenDB(string path)
        {
            StreamReader sr = new StreamReader(path);
            string file = sr.ReadToEnd();
            string[] parts = file.Split(sep);

            db = new Database(parts[0]);

            for (int i = 1; i < parts.Length; ++i)
            {
                parts[i] = parts[i].Replace("\r\n", "\r");
                List<string> buf = parts[i].Split('\r').ToList();
                buf.RemoveAt(0);
                buf.RemoveAt(buf.Count - 1);

                if (buf.Count > 0)
                {
                    db.Tables.Add(new Table(buf[0]));
                }
                if (buf.Count > 2)
                {
                    string[] cname = buf[1].Split(space);
                    string[] ctype = buf[2].Split(space);
                    int length = cname.Length - 1;
                    for (int j = 0; j < length; ++j)
                    {
                        db.Tables[i - 1].Columns.Add(new Column(cname[j], ctype[j]));
                    }

                    for (int j = 3; j < buf.Count; ++j)
                    {
                        db.Tables[i - 1].Rows.Add(new Row());
                        List<string> values = buf[j].Split(space).ToList();
                        values.RemoveAt(values.Count - 1);
                        db.Tables[i - 1].Rows.Last().RowValues.AddRange(values);
                    }
                }
            }
            sr.Close();
        }

        public List<string> GetTableNameList()
        {
            List<string> tables = new List<string>();
            foreach (Table t in db.Tables)
                tables.Add(t.TableName);
            return tables;
        }

        public List<string> GetTablesFieldsList(string tname1, string tname2)
        {
            var table1 = db.Tables.Where(x => x.TableName == tname1).FirstOrDefault();
            var table2 = db.Tables.Where(x => x.TableName == tname2).FirstOrDefault();
            List<string> colNames = new List<string>();
            if (table1 != null && table2 != null)
            {
                if (table1.Columns.Count > 0 && table2.Columns.Count > 0)
                    colNames = table1.Columns.Select(x => x.ColName).Intersect(table2.Columns.Select(x => x.ColName)).ToList();
            }
            return colNames;
        }

        public Table UnionOfTables(string tname1, string tname2, string field)
        {
            var table1 = db.Tables.Where(x => x.TableName == tname1).FirstOrDefault();
            var table2 = db.Tables.Where(x => x.TableName == tname2).FirstOrDefault();
            Table table = new Table("Union");
            if (table1 != null && table2 != null)
            {
                if (table1.Columns.Select(x => x.ColName).Contains(field) && table2.Columns.Select(x => x.ColName).Contains(field))
                {
                    table.Columns = table1.Columns.Union(table2.Columns).ToList();
                    var col1 = table1.Columns.Where(x => x.ColName == field).FirstOrDefault();
                    var col2 = table2.Columns.Where(x => x.ColName == field).FirstOrDefault();
                    if (col1 != null && col2 != null) 
                    {
                        var ind1 = table1.Columns.IndexOf(col1);
                        var ind2 = table2.Columns.IndexOf(col2);
                        if (ind1 != -1 && ind2 != -1)
                        {
                            foreach (var row1 in table1.Rows)
                            {
                                var value1 = row1.RowValues[ind1];
                                foreach (var row2 in table2.Rows)
                                {
                                    var value2 = row2.RowValues[ind2];
                                    if (value1 == value2)
                                    {
                                        var newRow = new Row();
                                        newRow.RowValues.AddRange(row1.RowValues);
                                        newRow.RowValues.AddRange(row2.RowValues);
                                        table.Rows.Add(newRow);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int columnIndexToRemove = -1;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                if (table.Columns[i].ColName == field)
                {
                    columnIndexToRemove = i;
                    break;
                }
            }
            if (columnIndexToRemove != -1)
            {
                table.Columns.RemoveAt(columnIndexToRemove);
                foreach (var row in table.Rows)
                {
                    if (row.RowValues.Count > columnIndexToRemove)
                    {
                        row.RowValues.RemoveAt(columnIndexToRemove);
                    }
                }
            }

            db.Tables.Add(table);
            return table;
        }
    }
}
