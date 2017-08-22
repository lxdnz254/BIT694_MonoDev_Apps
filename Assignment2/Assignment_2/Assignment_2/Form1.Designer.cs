namespace Assignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.FolderOutput = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FileOutput = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTerms = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.newWordsDataSet = new Assignment_2.NewWordsDataSet();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter = new Assignment_2.NewWordsDataSetTableAdapters.WordsTableAdapter();
            this.tableAdapterManager = new Assignment_2.NewWordsDataSetTableAdapters.TableAdapterManager();
            this.wordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.wordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.wordsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.AddEntryWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddEntrySynonyms = new System.Windows.Forms.TextBox();
            this.AddEntry = new System.Windows.Forms.Button();
            this.AddEntryBox = new System.Windows.Forms.GroupBox();
            this.DeleteEntryBox = new System.Windows.Forms.GroupBox();
            this.DeleteEntry = new System.Windows.Forms.Button();
            this.DeleteEntryWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateEntryBox = new System.Windows.Forms.GroupBox();
            this.UpdateEntry = new System.Windows.Forms.Button();
            this.UpdateEntrySynonyms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateEntryWord = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.QueryEntryBox = new System.Windows.Forms.GroupBox();
            this.QueryEntry = new System.Windows.Forms.Button();
            this.QueryEntrySynonyms = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.QueryEntryWord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckSynonyms = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.newWordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingNavigator)).BeginInit();
            this.wordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).BeginInit();
            this.AddEntryBox.SuspendLayout();
            this.DeleteEntryBox.SuspendLayout();
            this.UpdateEntryBox.SuspendLayout();
            this.QueryEntryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select A Folder:";
            // 
            // FolderOutput
            // 
            this.FolderOutput.Location = new System.Drawing.Point(40, 171);
            this.FolderOutput.Name = "FolderOutput";
            this.FolderOutput.Size = new System.Drawing.Size(302, 20);
            this.FolderOutput.TabIndex = 1;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(345, 171);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(66, 23);
            this.SelectFolder.TabIndex = 2;
            this.SelectFolder.Text = "Select";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // FileOutput
            // 
            this.FileOutput.FormattingEnabled = true;
            this.FileOutput.Location = new System.Drawing.Point(40, 264);
            this.FileOutput.Name = "FileOutput";
            this.FileOutput.ScrollAlwaysVisible = true;
            this.FileOutput.Size = new System.Drawing.Size(374, 121);
            this.FileOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Terms:";
            // 
            // SearchTerms
            // 
            this.SearchTerms.Location = new System.Drawing.Point(119, 206);
            this.SearchTerms.Name = "SearchTerms";
            this.SearchTerms.Size = new System.Drawing.Size(177, 20);
            this.SearchTerms.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(40, 232);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(371, 23);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // newWordsDataSet
            // 
            this.newWordsDataSet.DataSetName = "NewWordsDataSet";
            this.newWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.newWordsDataSet;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Assignment_2.NewWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WordsTableAdapter = this.wordsTableAdapter;
            // 
            // wordsBindingNavigator
            // 
            this.wordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.wordsBindingNavigator.BindingSource = this.wordsBindingSource;
            this.wordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.wordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.wordsBindingNavigatorSaveItem});
            this.wordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wordsBindingNavigator.Name = "wordsBindingNavigator";
            this.wordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wordsBindingNavigator.Size = new System.Drawing.Size(710, 25);
            this.wordsBindingNavigator.TabIndex = 7;
            this.wordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // wordsBindingNavigatorSaveItem
            // 
            this.wordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("wordsBindingNavigatorSaveItem.Image")));
            this.wordsBindingNavigatorSaveItem.Name = "wordsBindingNavigatorSaveItem";
            this.wordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.wordsBindingNavigatorSaveItem.Text = "Save Data";
            this.wordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.wordsBindingNavigatorSaveItem_Click);
            // 
            // wordsDataGridView
            // 
            this.wordsDataGridView.AutoGenerateColumns = false;
            this.wordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.wordsDataGridView.DataSource = this.wordsBindingSource;
            this.wordsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.wordsDataGridView.Name = "wordsDataGridView";
            this.wordsDataGridView.Size = new System.Drawing.Size(284, 102);
            this.wordsDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Word";
            this.dataGridViewTextBoxColumn1.HeaderText = "Word";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Synonyms";
            this.dataGridViewTextBoxColumn2.HeaderText = "Synonyms";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Word:";
            // 
            // AddEntryWord
            // 
            this.AddEntryWord.Location = new System.Drawing.Point(81, 22);
            this.AddEntryWord.Name = "AddEntryWord";
            this.AddEntryWord.Size = new System.Drawing.Size(112, 20);
            this.AddEntryWord.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Synonyms:";
            // 
            // AddEntrySynonyms
            // 
            this.AddEntrySynonyms.Location = new System.Drawing.Point(81, 48);
            this.AddEntrySynonyms.Name = "AddEntrySynonyms";
            this.AddEntrySynonyms.Size = new System.Drawing.Size(112, 20);
            this.AddEntrySynonyms.TabIndex = 12;
            // 
            // AddEntry
            // 
            this.AddEntry.Location = new System.Drawing.Point(20, 74);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(173, 23);
            this.AddEntry.TabIndex = 13;
            this.AddEntry.Text = "Add Entry";
            this.AddEntry.UseVisualStyleBackColor = true;
            this.AddEntry.Click += new System.EventHandler(this.AddEntry_Click);
            // 
            // AddEntryBox
            // 
            this.AddEntryBox.Controls.Add(this.AddEntry);
            this.AddEntryBox.Controls.Add(this.AddEntrySynonyms);
            this.AddEntryBox.Controls.Add(this.label4);
            this.AddEntryBox.Controls.Add(this.AddEntryWord);
            this.AddEntryBox.Controls.Add(this.label3);
            this.AddEntryBox.Location = new System.Drawing.Point(492, 28);
            this.AddEntryBox.Name = "AddEntryBox";
            this.AddEntryBox.Size = new System.Drawing.Size(206, 109);
            this.AddEntryBox.TabIndex = 14;
            this.AddEntryBox.TabStop = false;
            this.AddEntryBox.Text = "Add Entry";
            // 
            // DeleteEntryBox
            // 
            this.DeleteEntryBox.Controls.Add(this.DeleteEntry);
            this.DeleteEntryBox.Controls.Add(this.DeleteEntryWord);
            this.DeleteEntryBox.Controls.Add(this.label6);
            this.DeleteEntryBox.Location = new System.Drawing.Point(492, 143);
            this.DeleteEntryBox.Name = "DeleteEntryBox";
            this.DeleteEntryBox.Size = new System.Drawing.Size(206, 91);
            this.DeleteEntryBox.TabIndex = 15;
            this.DeleteEntryBox.TabStop = false;
            this.DeleteEntryBox.Text = "Delete Entry";
            // 
            // DeleteEntry
            // 
            this.DeleteEntry.Location = new System.Drawing.Point(20, 54);
            this.DeleteEntry.Name = "DeleteEntry";
            this.DeleteEntry.Size = new System.Drawing.Size(173, 23);
            this.DeleteEntry.TabIndex = 13;
            this.DeleteEntry.Text = "Delete Entry";
            this.DeleteEntry.UseVisualStyleBackColor = true;
            this.DeleteEntry.Click += new System.EventHandler(this.DeleteEntry_Click);
            // 
            // DeleteEntryWord
            // 
            this.DeleteEntryWord.Location = new System.Drawing.Point(81, 22);
            this.DeleteEntryWord.Name = "DeleteEntryWord";
            this.DeleteEntryWord.Size = new System.Drawing.Size(112, 20);
            this.DeleteEntryWord.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Word:";
            // 
            // UpdateEntryBox
            // 
            this.UpdateEntryBox.Controls.Add(this.UpdateEntry);
            this.UpdateEntryBox.Controls.Add(this.UpdateEntrySynonyms);
            this.UpdateEntryBox.Controls.Add(this.label7);
            this.UpdateEntryBox.Controls.Add(this.UpdateEntryWord);
            this.UpdateEntryBox.Controls.Add(this.label8);
            this.UpdateEntryBox.Location = new System.Drawing.Point(492, 240);
            this.UpdateEntryBox.Name = "UpdateEntryBox";
            this.UpdateEntryBox.Size = new System.Drawing.Size(206, 109);
            this.UpdateEntryBox.TabIndex = 16;
            this.UpdateEntryBox.TabStop = false;
            this.UpdateEntryBox.Text = "Update Entry";
            // 
            // UpdateEntry
            // 
            this.UpdateEntry.Location = new System.Drawing.Point(20, 74);
            this.UpdateEntry.Name = "UpdateEntry";
            this.UpdateEntry.Size = new System.Drawing.Size(173, 23);
            this.UpdateEntry.TabIndex = 13;
            this.UpdateEntry.Text = "Update Entry";
            this.UpdateEntry.UseVisualStyleBackColor = true;
            this.UpdateEntry.Click += new System.EventHandler(this.UpdateEntry_Click);
            // 
            // UpdateEntrySynonyms
            // 
            this.UpdateEntrySynonyms.Location = new System.Drawing.Point(81, 48);
            this.UpdateEntrySynonyms.Name = "UpdateEntrySynonyms";
            this.UpdateEntrySynonyms.Size = new System.Drawing.Size(112, 20);
            this.UpdateEntrySynonyms.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Synonyms:";
            // 
            // UpdateEntryWord
            // 
            this.UpdateEntryWord.Location = new System.Drawing.Point(81, 22);
            this.UpdateEntryWord.Name = "UpdateEntryWord";
            this.UpdateEntryWord.Size = new System.Drawing.Size(112, 20);
            this.UpdateEntryWord.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Word:";
            // 
            // QueryEntryBox
            // 
            this.QueryEntryBox.Controls.Add(this.QueryEntry);
            this.QueryEntryBox.Controls.Add(this.QueryEntrySynonyms);
            this.QueryEntryBox.Controls.Add(this.label9);
            this.QueryEntryBox.Controls.Add(this.QueryEntryWord);
            this.QueryEntryBox.Controls.Add(this.label10);
            this.QueryEntryBox.Location = new System.Drawing.Point(492, 355);
            this.QueryEntryBox.Name = "QueryEntryBox";
            this.QueryEntryBox.Size = new System.Drawing.Size(206, 145);
            this.QueryEntryBox.TabIndex = 17;
            this.QueryEntryBox.TabStop = false;
            this.QueryEntryBox.Text = "Query Entry";
            // 
            // QueryEntry
            // 
            this.QueryEntry.Location = new System.Drawing.Point(20, 116);
            this.QueryEntry.Name = "QueryEntry";
            this.QueryEntry.Size = new System.Drawing.Size(173, 23);
            this.QueryEntry.TabIndex = 13;
            this.QueryEntry.Text = "Query Entry";
            this.QueryEntry.UseVisualStyleBackColor = true;
            this.QueryEntry.Click += new System.EventHandler(this.QueryEntry_Click);
            // 
            // QueryEntrySynonyms
            // 
            this.QueryEntrySynonyms.Location = new System.Drawing.Point(81, 48);
            this.QueryEntrySynonyms.Multiline = true;
            this.QueryEntrySynonyms.Name = "QueryEntrySynonyms";
            this.QueryEntrySynonyms.Size = new System.Drawing.Size(112, 62);
            this.QueryEntrySynonyms.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Synonyms:";
            // 
            // QueryEntryWord
            // 
            this.QueryEntryWord.Location = new System.Drawing.Point(81, 22);
            this.QueryEntryWord.Name = "QueryEntryWord";
            this.QueryEntryWord.Size = new System.Drawing.Size(112, 20);
            this.QueryEntryWord.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Word:";
            // 
            // CheckSynonyms
            // 
            this.CheckSynonyms.AutoSize = true;
            this.CheckSynonyms.Location = new System.Drawing.Point(302, 209);
            this.CheckSynonyms.Name = "CheckSynonyms";
            this.CheckSynonyms.Size = new System.Drawing.Size(112, 17);
            this.CheckSynonyms.TabIndex = 18;
            this.CheckSynonyms.Text = "Include Synonyms";
            this.CheckSynonyms.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 511);
            this.Controls.Add(this.CheckSynonyms);
            this.Controls.Add(this.QueryEntryBox);
            this.Controls.Add(this.UpdateEntryBox);
            this.Controls.Add(this.DeleteEntryBox);
            this.Controls.Add(this.AddEntryBox);
            this.Controls.Add(this.wordsDataGridView);
            this.Controls.Add(this.wordsBindingNavigator);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchTerms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileOutput);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.FolderOutput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newWordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingNavigator)).EndInit();
            this.wordsBindingNavigator.ResumeLayout(false);
            this.wordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).EndInit();
            this.AddEntryBox.ResumeLayout(false);
            this.AddEntryBox.PerformLayout();
            this.DeleteEntryBox.ResumeLayout(false);
            this.DeleteEntryBox.PerformLayout();
            this.UpdateEntryBox.ResumeLayout(false);
            this.UpdateEntryBox.PerformLayout();
            this.QueryEntryBox.ResumeLayout(false);
            this.QueryEntryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderOutput;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox FileOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTerms;
        private System.Windows.Forms.Button Search;
        private NewWordsDataSet newWordsDataSet;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private NewWordsDataSetTableAdapters.WordsTableAdapter wordsTableAdapter;
        private NewWordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator wordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton wordsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView wordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddEntryWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddEntrySynonyms;
        private System.Windows.Forms.Button AddEntry;
        private System.Windows.Forms.GroupBox AddEntryBox;
        private System.Windows.Forms.GroupBox DeleteEntryBox;
        private System.Windows.Forms.Button DeleteEntry;
        private System.Windows.Forms.TextBox DeleteEntryWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox UpdateEntryBox;
        private System.Windows.Forms.Button UpdateEntry;
        private System.Windows.Forms.TextBox UpdateEntrySynonyms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpdateEntryWord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox QueryEntryBox;
        private System.Windows.Forms.Button QueryEntry;
        private System.Windows.Forms.TextBox QueryEntrySynonyms;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox QueryEntryWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CheckSynonyms;
    }
}

