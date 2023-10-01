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
            butCreate = new Button();
            butAddColumn = new Button();
            tbCreateDBName = new TextBox();
            tbAddTableName = new TextBox();
            dataGridView = new DataGridView();
            cbTypes = new ComboBox();
            tbAddColumnName = new TextBox();
            butDeleteColumn = new Button();
            butDeleteRow = new Button();
            sfdSaveDB = new SaveFileDialog();
            ofdOpenDB = new OpenFileDialog();
            label1 = new Label();
            lblDbName = new Label();
            ofdChooseFilePath = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            createTSMI = new ToolStripMenuItem();
            openTSMI = new ToolStripMenuItem();
            saveTSMI = new ToolStripMenuItem();
            tableToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            addColumnToolStripMenuItem = new ToolStripMenuItem();
            addRowToolStripMenuItem = new ToolStripMenuItem();
            unionOfTablesToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            butCreateTable = new Button();
            cbTable1 = new ComboBox();
            lblTable1 = new Label();
            lblTable2 = new Label();
            cbTable2 = new ComboBox();
            butUnion = new Button();
            cbFields = new ComboBox();
            lblField = new Label();
            butChooseTable2 = new Button();
            butChooseField = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Location = new Point(11, 156);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(893, 24);
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
            // butCreate
            // 
            butCreate.Location = new Point(221, 38);
            butCreate.Name = "butCreate";
            butCreate.Size = new Size(91, 35);
            butCreate.TabIndex = 2;
            butCreate.Text = "Create DB";
            butCreate.UseVisualStyleBackColor = true;
            butCreate.Visible = false;
            butCreate.Click += butCreate_Click;
            // 
            // butAddColumn
            // 
            butAddColumn.Location = new Point(333, 115);
            butAddColumn.Name = "butAddColumn";
            butAddColumn.Size = new Size(121, 35);
            butAddColumn.TabIndex = 3;
            butAddColumn.Text = "Add column";
            butAddColumn.UseVisualStyleBackColor = true;
            butAddColumn.Visible = false;
            butAddColumn.Click += butAddColumn_Click;
            // 
            // tbCreateDBName
            // 
            tbCreateDBName.Location = new Point(102, 42);
            tbCreateDBName.Name = "tbCreateDBName";
            tbCreateDBName.Size = new Size(100, 27);
            tbCreateDBName.TabIndex = 5;
            tbCreateDBName.Visible = false;
            // 
            // tbAddTableName
            // 
            tbAddTableName.Location = new Point(102, 91);
            tbAddTableName.Name = "tbAddTableName";
            tbAddTableName.Size = new Size(100, 27);
            tbAddTableName.TabIndex = 7;
            tbAddTableName.Visible = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(13, 187);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(891, 367);
            dataGridView.TabIndex = 8;
            dataGridView.CellBeginEdit += dataGridView_CellBeginEdit;
            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            // 
            // cbTypes
            // 
            cbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypes.FormattingEnabled = true;
            cbTypes.Items.AddRange(new object[] { "Integer", "Real", "Char", "String", "Enum", "Email" });
            cbTypes.Location = new Point(333, 37);
            cbTypes.Name = "cbTypes";
            cbTypes.Size = new Size(121, 28);
            cbTypes.TabIndex = 9;
            cbTypes.Visible = false;
            // 
            // tbAddColumnName
            // 
            tbAddColumnName.Location = new Point(333, 80);
            tbAddColumnName.Name = "tbAddColumnName";
            tbAddColumnName.Size = new Size(121, 27);
            tbAddColumnName.TabIndex = 10;
            tbAddColumnName.Visible = false;
            // 
            // butDeleteColumn
            // 
            butDeleteColumn.Location = new Point(910, 186);
            butDeleteColumn.Name = "butDeleteColumn";
            butDeleteColumn.Size = new Size(117, 35);
            butDeleteColumn.TabIndex = 13;
            butDeleteColumn.Text = "Delete column";
            butDeleteColumn.UseVisualStyleBackColor = true;
            butDeleteColumn.Visible = false;
            butDeleteColumn.Click += butDeleteColumn_Click;
            // 
            // butDeleteRow
            // 
            butDeleteRow.Location = new Point(910, 115);
            butDeleteRow.Name = "butDeleteRow";
            butDeleteRow.Size = new Size(117, 35);
            butDeleteRow.TabIndex = 14;
            butDeleteRow.Text = "Delete row";
            butDeleteRow.UseVisualStyleBackColor = true;
            butDeleteRow.Visible = false;
            butDeleteRow.Click += butDeleteRow_Click;
            // 
            // ofdOpenDB
            // 
            ofdOpenDB.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 45);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 17;
            label1.Text = "Database: ";
            // 
            // lblDbName
            // 
            lblDbName.AutoSize = true;
            lblDbName.Location = new Point(96, 45);
            lblDbName.Name = "lblDbName";
            lblDbName.Size = new Size(0, 20);
            lblDbName.TabIndex = 18;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, tableToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1305, 28);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createTSMI, openTSMI, saveTSMI });
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(46, 24);
            openToolStripMenuItem.Text = "File";
            // 
            // createTSMI
            // 
            createTSMI.Name = "createTSMI";
            createTSMI.Size = new Size(135, 26);
            createTSMI.Text = "Create";
            createTSMI.Click += createToolStripMenuItem_Click;
            // 
            // openTSMI
            // 
            openTSMI.Name = "openTSMI";
            openTSMI.Size = new Size(135, 26);
            openTSMI.Text = "Open";
            openTSMI.Click += openToolStripMenuItem_Click;
            // 
            // saveTSMI
            // 
            saveTSMI.Name = "saveTSMI";
            saveTSMI.Size = new Size(135, 26);
            saveTSMI.Text = "Save";
            saveTSMI.Click += saveToolStripMenuItem_Click;
            // 
            // tableToolStripMenuItem
            // 
            tableToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, deleteToolStripMenuItem, addColumnToolStripMenuItem, addRowToolStripMenuItem, unionOfTablesToolStripMenuItem });
            tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            tableToolStripMenuItem.Size = new Size(58, 24);
            tableToolStripMenuItem.Text = "Table";
            tableToolStripMenuItem.Visible = false;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(193, 26);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click_1;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(193, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // addColumnToolStripMenuItem
            // 
            addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            addColumnToolStripMenuItem.Size = new Size(193, 26);
            addColumnToolStripMenuItem.Text = "Add column";
            addColumnToolStripMenuItem.Click += addColumnToolStripMenuItem_Click;
            // 
            // addRowToolStripMenuItem
            // 
            addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            addRowToolStripMenuItem.Size = new Size(193, 26);
            addRowToolStripMenuItem.Text = "Add row";
            addRowToolStripMenuItem.Click += addRowToolStripMenuItem_Click;
            // 
            // unionOfTablesToolStripMenuItem
            // 
            unionOfTablesToolStripMenuItem.Name = "unionOfTablesToolStripMenuItem";
            unionOfTablesToolStripMenuItem.Size = new Size(193, 26);
            unionOfTablesToolStripMenuItem.Text = "Union of tables";
            unionOfTablesToolStripMenuItem.Click += unionOfTablesToolStripMenuItem_Click;
            // 
            // butCreateTable
            // 
            butCreateTable.Location = new Point(221, 89);
            butCreateTable.Name = "butCreateTable";
            butCreateTable.Size = new Size(91, 33);
            butCreateTable.TabIndex = 20;
            butCreateTable.Text = "Add table";
            butCreateTable.UseVisualStyleBackColor = true;
            butCreateTable.Visible = false;
            butCreateTable.Click += buttonAddTable_Click;
            // 
            // cbTable1
            // 
            cbTable1.FormattingEnabled = true;
            cbTable1.Location = new Point(544, 41);
            cbTable1.Name = "cbTable1";
            cbTable1.Size = new Size(151, 28);
            cbTable1.TabIndex = 21;
            cbTable1.Visible = false;
            // 
            // lblTable1
            // 
            lblTable1.AutoSize = true;
            lblTable1.Location = new Point(488, 45);
            lblTable1.Name = "lblTable1";
            lblTable1.Size = new Size(56, 20);
            lblTable1.TabIndex = 22;
            lblTable1.Text = "Table 1";
            lblTable1.Visible = false;
            // 
            // lblTable2
            // 
            lblTable2.AutoSize = true;
            lblTable2.Location = new Point(488, 80);
            lblTable2.Name = "lblTable2";
            lblTable2.Size = new Size(56, 20);
            lblTable2.TabIndex = 23;
            lblTable2.Text = "Table 2";
            lblTable2.Visible = false;
            // 
            // cbTable2
            // 
            cbTable2.FormattingEnabled = true;
            cbTable2.Location = new Point(544, 75);
            cbTable2.Name = "cbTable2";
            cbTable2.Size = new Size(151, 28);
            cbTable2.TabIndex = 24;
            cbTable2.Visible = false;
            // 
            // butUnion
            // 
            butUnion.Location = new Point(710, 109);
            butUnion.Name = "butUnion";
            butUnion.Size = new Size(156, 29);
            butUnion.TabIndex = 25;
            butUnion.Text = "Union";
            butUnion.UseVisualStyleBackColor = true;
            butUnion.Visible = false;
            butUnion.Click += butUnion_Click;
            // 
            // cbFields
            // 
            cbFields.FormattingEnabled = true;
            cbFields.Location = new Point(544, 110);
            cbFields.Name = "cbFields";
            cbFields.Size = new Size(151, 28);
            cbFields.TabIndex = 26;
            cbFields.Visible = false;
            // 
            // lblField
            // 
            lblField.AutoSize = true;
            lblField.Location = new Point(488, 113);
            lblField.Name = "lblField";
            lblField.Size = new Size(41, 20);
            lblField.TabIndex = 27;
            lblField.Text = "Field";
            lblField.Visible = false;
            // 
            // butChooseTable2
            // 
            butChooseTable2.Location = new Point(710, 40);
            butChooseTable2.Name = "butChooseTable2";
            butChooseTable2.Size = new Size(156, 29);
            butChooseTable2.TabIndex = 28;
            butChooseTable2.Text = "Choose second table";
            butChooseTable2.UseVisualStyleBackColor = true;
            butChooseTable2.Visible = false;
            butChooseTable2.Click += butChooseTable2_Click;
            // 
            // butChooseField
            // 
            butChooseField.Location = new Point(710, 74);
            butChooseField.Name = "butChooseField";
            butChooseField.Size = new Size(156, 29);
            butChooseField.TabIndex = 29;
            butChooseField.Text = "Choose field";
            butChooseField.UseVisualStyleBackColor = true;
            butChooseField.Visible = false;
            butChooseField.Click += butChooseField_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 501);
            Controls.Add(butChooseField);
            Controls.Add(butChooseTable2);
            Controls.Add(lblField);
            Controls.Add(cbFields);
            Controls.Add(butUnion);
            Controls.Add(cbTable2);
            Controls.Add(lblTable2);
            Controls.Add(lblTable1);
            Controls.Add(cbTable1);
            Controls.Add(butCreateTable);
            Controls.Add(lblDbName);
            Controls.Add(label1);
            Controls.Add(butDeleteRow);
            Controls.Add(butDeleteColumn);
            Controls.Add(tbAddColumnName);
            Controls.Add(cbTypes);
            Controls.Add(dataGridView);
            Controls.Add(tbAddTableName);
            Controls.Add(tbCreateDBName);
            Controls.Add(butAddColumn);
            Controls.Add(butCreate);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "DBMS";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button butCreate;
        private Button butAddColumn;
        private TextBox tbCreateDBName;
        private TextBox tbAddTableName;
        private DataGridView dataGridView;
        private ComboBox cbTypes;
        private TextBox tbAddColumnName;
        private OpenFileDialog ofdChooseFilePath;
        private Button butDeleteColumn;
        private Button butDeleteRow;
        private SaveFileDialog sfdSaveDB;
        private OpenFileDialog ofdOpenDB;
        private Label label1;
        private Label lblDbName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openTSMI;
        private ToolStripMenuItem saveTSMI;
        private FontDialog fontDialog1;
        private ToolStripMenuItem createTSMI;
        private ToolStripMenuItem tableToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button butCreateTable;
        private ToolStripMenuItem addColumnToolStripMenuItem;
        private ToolStripMenuItem addRowToolStripMenuItem;
        private ToolStripMenuItem unionOfTablesToolStripMenuItem;
        private ComboBox cbTable1;
        private Label lblTable1;
        private Label lblTable2;
        private ComboBox cbTable2;
        private Button butUnion;
        private ComboBox cbFields;
        private Label lblField;
        private Button butChooseTable2;
        private Button butChooseField;
    }
}