namespace DBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            butOpen = new Button();
            butCreate = new Button();
            butAddColumn = new Button();
            butAddRow = new Button();
            tbCreateDBName = new TextBox();
            butAddTable = new Button();
            tbAddTableName = new TextBox();
            dataGridView = new DataGridView();
            cbTypes = new ComboBox();
            tbAddColumnName = new TextBox();
            butDeleteColumn = new Button();
            butDeleteRow = new Button();
            butDeleteTable = new Button();
            sfdSaveDB = new SaveFileDialog();
            butSaveDB = new Button();
            ofdOpenDB = new OpenFileDialog();
            label1 = new Label();
            lblDbName = new Label();
            ofdChooseFilePath = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Location = new Point(10, 117);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(916, 18);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 100);
            tabPage2.TabIndex = 0;
            // 
            // butOpen
            // 
            butOpen.Location = new Point(11, 10);
            butOpen.Margin = new Padding(3, 2, 3, 2);
            butOpen.Name = "butOpen";
            butOpen.Size = new Size(66, 27);
            butOpen.TabIndex = 1;
            butOpen.Text = "Open";
            butOpen.UseVisualStyleBackColor = true;
            butOpen.Click += butOpen_Click;
            // 
            // butCreate
            // 
            butCreate.Location = new Point(283, 11);
            butCreate.Margin = new Padding(3, 2, 3, 2);
            butCreate.Name = "butCreate";
            butCreate.Size = new Size(80, 26);
            butCreate.TabIndex = 2;
            butCreate.Text = "Create DB";
            butCreate.UseVisualStyleBackColor = true;
            butCreate.Click += butCreate_Click;
            // 
            // butAddColumn
            // 
            butAddColumn.Location = new Point(706, 9);
            butAddColumn.Margin = new Padding(3, 2, 3, 2);
            butAddColumn.Name = "butAddColumn";
            butAddColumn.Size = new Size(94, 28);
            butAddColumn.TabIndex = 3;
            butAddColumn.Text = "Add column";
            butAddColumn.UseVisualStyleBackColor = true;
            butAddColumn.Click += butAddColumn_Click;
            // 
            // butAddRow
            // 
            butAddRow.Location = new Point(950, 10);
            butAddRow.Margin = new Padding(3, 2, 3, 2);
            butAddRow.Name = "butAddRow";
            butAddRow.Size = new Size(89, 27);
            butAddRow.TabIndex = 4;
            butAddRow.Text = "Add row";
            butAddRow.UseVisualStyleBackColor = true;
            butAddRow.Click += butAddRow_Click;
            // 
            // tbCreateDBName
            // 
            tbCreateDBName.Location = new Point(190, 16);
            tbCreateDBName.Margin = new Padding(3, 2, 3, 2);
            tbCreateDBName.Name = "tbCreateDBName";
            tbCreateDBName.Size = new Size(88, 23);
            tbCreateDBName.TabIndex = 5;
            // 
            // butAddTable
            // 
            butAddTable.Location = new Point(447, 7);
            butAddTable.Margin = new Padding(3, 2, 3, 2);
            butAddTable.Name = "butAddTable";
            butAddTable.Size = new Size(103, 28);
            butAddTable.TabIndex = 6;
            butAddTable.Text = "Add table";
            butAddTable.UseVisualStyleBackColor = true;
            butAddTable.Click += butAddTable_Click;
            // 
            // tbAddTableName
            // 
            tbAddTableName.Location = new Point(556, 14);
            tbAddTableName.Margin = new Padding(3, 2, 3, 2);
            tbAddTableName.Name = "tbAddTableName";
            tbAddTableName.Size = new Size(117, 23);
            tbAddTableName.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(11, 140);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(915, 275);
            dataGridView.TabIndex = 8;
            dataGridView.CellBeginEdit += dataGridView_CellBeginEdit;
            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            // 
            // cbTypes
            // 
            cbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypes.FormattingEnabled = true;
            cbTypes.Items.AddRange(new object[] { "Integer", "Real", "Char", "String", "Enum", "Email" });
            cbTypes.Location = new Point(806, 16);
            cbTypes.Margin = new Padding(3, 2, 3, 2);
            cbTypes.Name = "cbTypes";
            cbTypes.Size = new Size(106, 23);
            cbTypes.TabIndex = 9;
            // 
            // tbAddColumnName
            // 
            tbAddColumnName.Location = new Point(806, 46);
            tbAddColumnName.Margin = new Padding(3, 2, 3, 2);
            tbAddColumnName.Name = "tbAddColumnName";
            tbAddColumnName.Size = new Size(106, 23);
            tbAddColumnName.TabIndex = 10;
            // 
            // butDeleteColumn
            // 
            butDeleteColumn.Location = new Point(706, 79);
            butDeleteColumn.Margin = new Padding(3, 2, 3, 2);
            butDeleteColumn.Name = "butDeleteColumn";
            butDeleteColumn.Size = new Size(102, 26);
            butDeleteColumn.TabIndex = 13;
            butDeleteColumn.Text = "Delete column";
            butDeleteColumn.UseVisualStyleBackColor = true;
            butDeleteColumn.Click += butDeleteColumn_Click;
            // 
            // butDeleteRow
            // 
            butDeleteRow.Location = new Point(950, 46);
            butDeleteRow.Margin = new Padding(3, 2, 3, 2);
            butDeleteRow.Name = "butDeleteRow";
            butDeleteRow.Size = new Size(89, 28);
            butDeleteRow.TabIndex = 14;
            butDeleteRow.Text = "Delete row";
            butDeleteRow.UseVisualStyleBackColor = true;
            butDeleteRow.Click += butDeleteRow_Click;
            // 
            // butDeleteTable
            // 
            butDeleteTable.Location = new Point(447, 42);
            butDeleteTable.Margin = new Padding(3, 2, 3, 2);
            butDeleteTable.Name = "butDeleteTable";
            butDeleteTable.Size = new Size(103, 28);
            butDeleteTable.TabIndex = 15;
            butDeleteTable.Text = "Delete table";
            butDeleteTable.UseVisualStyleBackColor = true;
            butDeleteTable.Click += butDeleteTable_Click;
            // 
            // butSaveDB
            // 
            butSaveDB.Location = new Point(82, 10);
            butSaveDB.Margin = new Padding(3, 2, 3, 2);
            butSaveDB.Name = "butSaveDB";
            butSaveDB.Size = new Size(68, 27);
            butSaveDB.TabIndex = 16;
            butSaveDB.Text = "Save";
            butSaveDB.UseVisualStyleBackColor = true;
            butSaveDB.Click += butSaveDB_Click;
            // 
            // ofdOpenDB
            // 
            ofdOpenDB.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 66);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 17;
            label1.Text = "Database: ";
            // 
            // lblDbName
            // 
            lblDbName.AutoSize = true;
            lblDbName.Location = new Point(82, 66);
            lblDbName.Name = "lblDbName";
            lblDbName.Size = new Size(0, 15);
            lblDbName.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 376);
            Controls.Add(lblDbName);
            Controls.Add(label1);
            Controls.Add(butSaveDB);
            Controls.Add(butDeleteTable);
            Controls.Add(butDeleteRow);
            Controls.Add(butDeleteColumn);
            Controls.Add(tbAddColumnName);
            Controls.Add(cbTypes);
            Controls.Add(dataGridView);
            Controls.Add(tbAddTableName);
            Controls.Add(butAddTable);
            Controls.Add(tbCreateDBName);
            Controls.Add(butAddRow);
            Controls.Add(butAddColumn);
            Controls.Add(butCreate);
            Controls.Add(butOpen);
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "DBMS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button butOpen;
        private Button butCreate;
        private Button butAddColumn;
        private Button butAddRow;
        private TextBox tbCreateDBName;
        private Button butAddTable;
        private TextBox tbAddTableName;
        private DataGridView dataGridView;
        private ComboBox cbTypes;
        private TextBox tbAddColumnName;
        private OpenFileDialog ofdChooseFilePath;
        private Button butDeleteColumn;
        private Button butDeleteRow;
        private Button butDeleteTable;
        private SaveFileDialog sfdSaveDB;
        private Button butSaveDB;
        private OpenFileDialog ofdOpenDB;
        private Label label1;
        private Label lblDbName;
    }
}