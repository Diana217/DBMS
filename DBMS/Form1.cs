namespace DBMS
{
    public partial class Form1 : Form
    {
        DBManager dbManager = new DBManager();
        string cellOldValue = "";
        string cellNewValue = "";
        public Form1()
        {
            InitializeComponent();
            cbTypes.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void butCreate_Click(object sender, EventArgs e)
        {
            if (dbManager.CreateDB(tbCreateDBName.Text))
            {
                lblDbName.Text = tbCreateDBName.Text;
                tableToolStripMenuItem.Visible = true;
            }
            tabControl.TabPages.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            tbCreateDBName.Visible = false;
            butCreate.Visible = false;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            if (index != -1)
                VisualTable(dbManager.GetTable(index));
        }

        void VisualTable(Table t)
        {
            try
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                foreach (Column c in t.Columns)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = c.ColName;
                    column.HeaderText = c.ColName;
                    dataGridView.Columns.Add(column);
                }

                foreach (Row r in t.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    foreach (string s in r.RowValues)
                    {
                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = s;
                        row.Cells.Add(cell);
                    }
                    try
                    {
                        dataGridView.Rows.Add(row);
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellOldValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cellNewValue = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
            if (!dbManager.ChangeValue(cellNewValue, tabControl.SelectedIndex, e.ColumnIndex, e.RowIndex))
            {
                dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellOldValue;
            }

            int index = tabControl.SelectedIndex;
            if (index != -1)
                VisualTable(dbManager.GetTable(index));
        }

        private void butAddColumn_Click(object sender, EventArgs e)
        {
            if (dbManager.AddColumn(tabControl.SelectedIndex, tbAddColumnName.Text, cbTypes.Text))
            {
                int index = tabControl.SelectedIndex;
                if (index != -1)
                    VisualTable(dbManager.GetTable(index));
            }
        }

        private void butDeleteColumn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Columns.Count == 0) return;
            try
            {
                if (dataGridView.CurrentCell != null)
                {
                    dbManager.DeleteColumn(tabControl.SelectedIndex, dataGridView.CurrentCell.ColumnIndex);
                }
            }
            catch { }

            int index = tabControl.SelectedIndex;
            if (index != -1)
            {
                VisualTable(dbManager.GetTable(index));
                if (dataGridView.Columns.Count == 0)
                    butDeleteColumn.Visible = false;
            }
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            if (dbManager.AddTable(tbAddTableName.Text))
            {
                tabControl.TabPages.Add(tbAddTableName.Text);
                tbAddTableName.Visible = false;
                butCreateTable.Visible = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdOpenDB.Filter = "tdb files (*.tdb)|*.tdb";
            ofdOpenDB.FilterIndex = 1;
            ofdOpenDB.RestoreDirectory = true;

            if (ofdChooseFilePath.ShowDialog() == DialogResult.OK)
            {
                dbManager.OpenDB(ofdChooseFilePath.FileName);
            }

            tabControl.TabPages.Clear();
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            List<string> buf = dbManager.GetTableNameList();
            foreach (string s in buf)
                tabControl.TabPages.Add(s);

            int index = tabControl.SelectedIndex;
            if (index != -1)
                VisualTable(dbManager.GetTable(index));
            lblDbName.Text = ofdChooseFilePath.FileName;
            tableToolStripMenuItem.Visible = true;
            tbCreateDBName.Visible = false;
            butCreate.Visible = false;
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbCreateDBName.Visible = true;
            butCreate.Visible = true;
            lblDbName.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;

            sfdSaveDB.Filter = "tdb files (*.tdb)|*.tdb";
            sfdSaveDB.FilterIndex = 1;
            sfdSaveDB.RestoreDirectory = true;
            sfdSaveDB.FileName = tbCreateDBName.Text;

            if (sfdSaveDB.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = sfdSaveDB.OpenFile()) != null)
                {
                    myStream.Close();
                    dbManager.SaveDB(sfdSaveDB.FileName);
                }
            }
        }

        private void createToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tbAddTableName.Visible = true;
            butCreateTable.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabCount == 0) return;
            try
            {
                dbManager.DeleteTable(tabControl.SelectedIndex);
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
            }
            catch { }
            if (tabControl.TabCount == 0) return;

            int index = tabControl.SelectedIndex;
            if (index != -1)
                VisualTable(dbManager.GetTable(index));
        }

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbTypes.Visible = true;
            tbAddColumnName.Visible = true;
            butAddColumn.Visible = true;
        }

        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dbManager.AddRow(tabControl.SelectedIndex))
            {
                int index = tabControl.SelectedIndex;
                if (index != -1)
                {
                    VisualTable(dbManager.GetTable(index));
                    butDeleteRow.Visible = true;
                }
            }
        }
        private void butDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0) return;
            try
            {
                dbManager.DeleteRow(tabControl.SelectedIndex, dataGridView.CurrentCell.RowIndex);
            }
            catch { }

            int index = tabControl.SelectedIndex;
            if (index != -1)
            {
                VisualTable(dbManager.GetTable(index));
                if (dataGridView.Rows.Count == 0)
                    butDeleteRow.Visible = false;
            }
        }

        private void unionOfTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblTable1.Visible = true;
            cbTable1.Visible = true;
            butChooseTable2.Visible = true;
            cbTable1.Items.AddRange(dbManager.GetTableNameList().ToArray());
        }

        private void butChooseTable2_Click(object sender, EventArgs e)
        {
            lblTable2.Visible = true;
            cbTable2.Visible = true;
            butChooseField.Visible = true;
            var list = dbManager.GetTableNameList();
            list.Remove(cbTable1.Text);
            cbTable2.Items.AddRange(list.ToArray());
        }

        private void butChooseField_Click(object sender, EventArgs e)
        {
            lblField.Visible = true;
            cbFields.Visible = true;
            butUnion.Visible = true;
            cbFields.Items.AddRange(dbManager.GetTablesFieldsList(cbTable1.Text, cbTable2.Text).ToArray());
        }

        private void butUnion_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add(dbManager.UnionOfTables(cbTable1.Text, cbTable2.Text, cbFields.Text).TableName);
        }
    }
}