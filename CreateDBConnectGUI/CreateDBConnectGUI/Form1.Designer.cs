namespace CreateDBConnectGUI
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
            this.small_NewWordsDataSet = new CreateDBConnectGUI.Small_NewWordsDataSet();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter = new CreateDBConnectGUI.Small_NewWordsDataSetTableAdapters.WordsTableAdapter();
            this.tableAdapterManager = new CreateDBConnectGUI.Small_NewWordsDataSetTableAdapters.TableAdapterManager();
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
            this.AddWord = new System.Windows.Forms.TextBox();
            this.AddSynonym = new System.Windows.Forms.TextBox();
            this.AddEntry = new System.Windows.Forms.Button();
            this.SynonymText = new System.Windows.Forms.Label();
            this.WordText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteWord = new System.Windows.Forms.TextBox();
            this.DeleteEntry = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateEntry = new System.Windows.Forms.Button();
            this.UpdateSynonyms = new System.Windows.Forms.TextBox();
            this.UpdateWord = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchWord = new System.Windows.Forms.TextBox();
            this.SearchSynonyms = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.small_NewWordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingNavigator)).BeginInit();
            this.wordsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // small_NewWordsDataSet
            // 
            this.small_NewWordsDataSet.DataSetName = "Small_NewWordsDataSet";
            this.small_NewWordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.small_NewWordsDataSet;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CreateDBConnectGUI.Small_NewWordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.wordsBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.wordsBindingNavigator.TabIndex = 0;
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
            this.wordsDataGridView.Size = new System.Drawing.Size(300, 83);
            this.wordsDataGridView.TabIndex = 1;
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
            // AddWord
            // 
            this.AddWord.Location = new System.Drawing.Point(82, 23);
            this.AddWord.Name = "AddWord";
            this.AddWord.Size = new System.Drawing.Size(131, 20);
            this.AddWord.TabIndex = 2;
            // 
            // AddSynonym
            // 
            this.AddSynonym.Location = new System.Drawing.Point(82, 60);
            this.AddSynonym.Name = "AddSynonym";
            this.AddSynonym.Size = new System.Drawing.Size(131, 20);
            this.AddSynonym.TabIndex = 3;
            // 
            // AddEntry
            // 
            this.AddEntry.Location = new System.Drawing.Point(24, 95);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(189, 23);
            this.AddEntry.TabIndex = 4;
            this.AddEntry.Text = "Add Entry";
            this.AddEntry.UseVisualStyleBackColor = true;
            this.AddEntry.Click += new System.EventHandler(this.AddEntry_Click);
            // 
            // SynonymText
            // 
            this.SynonymText.AutoSize = true;
            this.SynonymText.Location = new System.Drawing.Point(21, 63);
            this.SynonymText.Name = "SynonymText";
            this.SynonymText.Size = new System.Drawing.Size(58, 13);
            this.SynonymText.TabIndex = 5;
            this.SynonymText.Text = "Synonyms:";
            this.SynonymText.Click += new System.EventHandler(this.SynonymText_Click);
            // 
            // WordText
            // 
            this.WordText.AutoSize = true;
            this.WordText.Location = new System.Drawing.Point(21, 26);
            this.WordText.Name = "WordText";
            this.WordText.Size = new System.Drawing.Size(36, 13);
            this.WordText.TabIndex = 6;
            this.WordText.Text = "Word:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WordText);
            this.groupBox1.Controls.Add(this.SynonymText);
            this.groupBox1.Controls.Add(this.AddEntry);
            this.groupBox1.Controls.Add(this.AddSynonym);
            this.groupBox1.Controls.Add(this.AddWord);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 133);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Entry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Word:";
            // 
            // DeleteWord
            // 
            this.DeleteWord.Location = new System.Drawing.Point(80, 35);
            this.DeleteWord.Name = "DeleteWord";
            this.DeleteWord.Size = new System.Drawing.Size(131, 20);
            this.DeleteWord.TabIndex = 9;
            // 
            // DeleteEntry
            // 
            this.DeleteEntry.Location = new System.Drawing.Point(22, 61);
            this.DeleteEntry.Name = "DeleteEntry";
            this.DeleteEntry.Size = new System.Drawing.Size(189, 23);
            this.DeleteEntry.TabIndex = 10;
            this.DeleteEntry.Text = "Delete Entry";
            this.DeleteEntry.UseVisualStyleBackColor = true;
            this.DeleteEntry.Click += new System.EventHandler(this.DeleteEntry_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteEntry);
            this.groupBox2.Controls.Add(this.DeleteWord);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Entry";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.UpdateEntry);
            this.groupBox3.Controls.Add(this.UpdateSynonyms);
            this.groupBox3.Controls.Add(this.UpdateWord);
            this.groupBox3.Location = new System.Drawing.Point(350, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 133);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Word:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Synonyms:";
            // 
            // UpdateEntry
            // 
            this.UpdateEntry.Location = new System.Drawing.Point(24, 95);
            this.UpdateEntry.Name = "UpdateEntry";
            this.UpdateEntry.Size = new System.Drawing.Size(189, 23);
            this.UpdateEntry.TabIndex = 4;
            this.UpdateEntry.Text = "Update Entry";
            this.UpdateEntry.UseVisualStyleBackColor = true;
            this.UpdateEntry.Click += new System.EventHandler(this.UpdateEntry_Click);
            // 
            // UpdateSynonyms
            // 
            this.UpdateSynonyms.Location = new System.Drawing.Point(82, 60);
            this.UpdateSynonyms.Name = "UpdateSynonyms";
            this.UpdateSynonyms.Size = new System.Drawing.Size(131, 20);
            this.UpdateSynonyms.TabIndex = 3;
            // 
            // UpdateWord
            // 
            this.UpdateWord.Location = new System.Drawing.Point(82, 23);
            this.UpdateWord.Name = "UpdateWord";
            this.UpdateWord.Size = new System.Drawing.Size(131, 20);
            this.UpdateWord.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SearchSynonyms);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.SearchButton);
            this.groupBox4.Controls.Add(this.SearchWord);
            this.groupBox4.Location = new System.Drawing.Point(268, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(230, 177);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Query";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Synonyms:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(24, 148);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(189, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchWord
            // 
            this.SearchWord.Location = new System.Drawing.Point(82, 23);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.Size = new System.Drawing.Size(131, 20);
            this.SearchWord.TabIndex = 2;
            // 
            // SearchSynonyms
            // 
            this.SearchSynonyms.Location = new System.Drawing.Point(82, 63);
            this.SearchSynonyms.Multiline = true;
            this.SearchSynonyms.Name = "SearchSynonyms";
            this.SearchSynonyms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchSynonyms.Size = new System.Drawing.Size(131, 65);
            this.SearchSynonyms.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 412);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wordsDataGridView);
            this.Controls.Add(this.wordsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.small_NewWordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingNavigator)).EndInit();
            this.wordsBindingNavigator.ResumeLayout(false);
            this.wordsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Small_NewWordsDataSet small_NewWordsDataSet;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private Small_NewWordsDataSetTableAdapters.WordsTableAdapter wordsTableAdapter;
        private Small_NewWordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox AddWord;
        private System.Windows.Forms.TextBox AddSynonym;
        private System.Windows.Forms.Button AddEntry;
        private System.Windows.Forms.Label SynonymText;
        private System.Windows.Forms.Label WordText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteWord;
        private System.Windows.Forms.Button DeleteEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateEntry;
        private System.Windows.Forms.TextBox UpdateSynonyms;
        private System.Windows.Forms.TextBox UpdateWord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchWord;
        private System.Windows.Forms.TextBox SearchSynonyms;
    }
}

