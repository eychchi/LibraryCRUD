namespace LibraryCRUD
{
    partial class LibraryCRUDApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryCRUDApplication));
            InsertButton = new Button();
            SearchButton = new Button();
            DeleteButton = new Button();
            LoanID_Text = new Label();
            MemberID_Text = new Label();
            MemberName_Text = new Label();
            BookTitle_Text = new Label();
            LoanStatus_Text = new Label();
            CheckoutDate_Text = new Label();
            LoanID_Entry = new TextBox();
            MemberID_Entry = new TextBox();
            MemberName_Entry = new TextBox();
            BookTitle_Entry = new TextBox();
            LoanStatus_Entry = new TextBox();
            label7 = new Label();
            ReturnDate_Text = new Label();
            CheckoutDate_Entry = new TextBox();
            ReturnDate_Entry = new TextBox();
            dataGridView1 = new DataGridView();
            UpdateButton = new Button();
            SaveButton = new Button();
            ViewAllButton = new Button();
            CreateDB = new Button();
            DB_Entry = new TextBox();
            DisplayDB = new Button();
            label1 = new Label();
            DeleteDB = new Button();
            DeleteTableButton = new Button();
            label2 = new Label();
            DisplayTableButton = new Button();
            Table_Entry = new TextBox();
            CreateTableButton = new Button();
            ReadTableButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // InsertButton
            // 
            resources.ApplyResources(InsertButton, "InsertButton");
            InsertButton.Name = "InsertButton";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // SearchButton
            // 
            resources.ApplyResources(SearchButton, "SearchButton");
            SearchButton.Name = "SearchButton";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteButton
            // 
            resources.ApplyResources(DeleteButton, "DeleteButton");
            DeleteButton.Name = "DeleteButton";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click_1;
            // 
            // LoanID_Text
            // 
            resources.ApplyResources(LoanID_Text, "LoanID_Text");
            LoanID_Text.Name = "LoanID_Text";
            LoanID_Text.Click += label1_Click;
            // 
            // MemberID_Text
            // 
            resources.ApplyResources(MemberID_Text, "MemberID_Text");
            MemberID_Text.Name = "MemberID_Text";
            // 
            // MemberName_Text
            // 
            resources.ApplyResources(MemberName_Text, "MemberName_Text");
            MemberName_Text.Name = "MemberName_Text";
            // 
            // BookTitle_Text
            // 
            resources.ApplyResources(BookTitle_Text, "BookTitle_Text");
            BookTitle_Text.Name = "BookTitle_Text";
            // 
            // LoanStatus_Text
            // 
            resources.ApplyResources(LoanStatus_Text, "LoanStatus_Text");
            LoanStatus_Text.Name = "LoanStatus_Text";
            // 
            // CheckoutDate_Text
            // 
            resources.ApplyResources(CheckoutDate_Text, "CheckoutDate_Text");
            CheckoutDate_Text.Name = "CheckoutDate_Text";
            // 
            // LoanID_Entry
            // 
            resources.ApplyResources(LoanID_Entry, "LoanID_Entry");
            LoanID_Entry.Name = "LoanID_Entry";
            LoanID_Entry.TextChanged += LoanID_Entry_TextChanged;
            // 
            // MemberID_Entry
            // 
            resources.ApplyResources(MemberID_Entry, "MemberID_Entry");
            MemberID_Entry.Name = "MemberID_Entry";
            MemberID_Entry.TextChanged += MemberID_Entry_TextChanged;
            // 
            // MemberName_Entry
            // 
            resources.ApplyResources(MemberName_Entry, "MemberName_Entry");
            MemberName_Entry.Name = "MemberName_Entry";
            MemberName_Entry.TextChanged += MemberName_Entry_TextChanged;
            // 
            // BookTitle_Entry
            // 
            resources.ApplyResources(BookTitle_Entry, "BookTitle_Entry");
            BookTitle_Entry.Name = "BookTitle_Entry";
            BookTitle_Entry.TextChanged += LoanStatus_Entry_TextChanged;
            // 
            // LoanStatus_Entry
            // 
            resources.ApplyResources(LoanStatus_Entry, "LoanStatus_Entry");
            LoanStatus_Entry.Name = "LoanStatus_Entry";
            LoanStatus_Entry.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // ReturnDate_Text
            // 
            resources.ApplyResources(ReturnDate_Text, "ReturnDate_Text");
            ReturnDate_Text.Name = "ReturnDate_Text";
            // 
            // CheckoutDate_Entry
            // 
            resources.ApplyResources(CheckoutDate_Entry, "CheckoutDate_Entry");
            CheckoutDate_Entry.Name = "CheckoutDate_Entry";
            CheckoutDate_Entry.TextChanged += CheckoutDate_Entry_TextChanged;
            // 
            // ReturnDate_Entry
            // 
            resources.ApplyResources(ReturnDate_Entry, "ReturnDate_Entry");
            ReturnDate_Entry.Name = "ReturnDate_Entry";
            ReturnDate_Entry.TextChanged += ReturnDate_Entry_TextChanged;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UpdateButton
            // 
            resources.ApplyResources(UpdateButton, "UpdateButton");
            UpdateButton.Name = "UpdateButton";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // SaveButton
            // 
            resources.ApplyResources(SaveButton, "SaveButton");
            SaveButton.Name = "SaveButton";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ViewAllButton
            // 
            resources.ApplyResources(ViewAllButton, "ViewAllButton");
            ViewAllButton.Name = "ViewAllButton";
            ViewAllButton.UseVisualStyleBackColor = true;
            ViewAllButton.Click += ViewAllButton_Click;
            // 
            // CreateDB
            // 
            resources.ApplyResources(CreateDB, "CreateDB");
            CreateDB.Name = "CreateDB";
            CreateDB.UseVisualStyleBackColor = true;
            CreateDB.Click += CreateDB_Click;
            // 
            // DB_Entry
            // 
            resources.ApplyResources(DB_Entry, "DB_Entry");
            DB_Entry.Name = "DB_Entry";
            DB_Entry.TextChanged += CreateDB_Entry_TextChanged;
            // 
            // DisplayDB
            // 
            resources.ApplyResources(DisplayDB, "DisplayDB");
            DisplayDB.Name = "DisplayDB";
            DisplayDB.UseVisualStyleBackColor = true;
            DisplayDB.Click += DisplayDB_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // DeleteDB
            // 
            resources.ApplyResources(DeleteDB, "DeleteDB");
            DeleteDB.Name = "DeleteDB";
            DeleteDB.UseVisualStyleBackColor = true;
            // 
            // DeleteTableButton
            // 
            resources.ApplyResources(DeleteTableButton, "DeleteTableButton");
            DeleteTableButton.Name = "DeleteTableButton";
            DeleteTableButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // DisplayTableButton
            // 
            resources.ApplyResources(DisplayTableButton, "DisplayTableButton");
            DisplayTableButton.Name = "DisplayTableButton";
            DisplayTableButton.UseVisualStyleBackColor = true;
            // 
            // Table_Entry
            // 
            resources.ApplyResources(Table_Entry, "Table_Entry");
            Table_Entry.Name = "Table_Entry";
            // 
            // CreateTableButton
            // 
            resources.ApplyResources(CreateTableButton, "CreateTableButton");
            CreateTableButton.Name = "CreateTableButton";
            CreateTableButton.UseVisualStyleBackColor = true;
            // 
            // ReadTableButton
            // 
            resources.ApplyResources(ReadTableButton, "ReadTableButton");
            ReadTableButton.Name = "ReadTableButton";
            ReadTableButton.UseVisualStyleBackColor = true;
            // 
            // LibraryCRUDApplication
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReadTableButton);
            Controls.Add(DeleteTableButton);
            Controls.Add(label2);
            Controls.Add(DisplayTableButton);
            Controls.Add(Table_Entry);
            Controls.Add(CreateTableButton);
            Controls.Add(DeleteDB);
            Controls.Add(label1);
            Controls.Add(DisplayDB);
            Controls.Add(DB_Entry);
            Controls.Add(CreateDB);
            Controls.Add(ViewAllButton);
            Controls.Add(SaveButton);
            Controls.Add(UpdateButton);
            Controls.Add(ReturnDate_Entry);
            Controls.Add(CheckoutDate_Entry);
            Controls.Add(ReturnDate_Text);
            Controls.Add(label7);
            Controls.Add(LoanStatus_Entry);
            Controls.Add(BookTitle_Entry);
            Controls.Add(MemberName_Entry);
            Controls.Add(MemberID_Entry);
            Controls.Add(LoanID_Entry);
            Controls.Add(CheckoutDate_Text);
            Controls.Add(LoanStatus_Text);
            Controls.Add(BookTitle_Text);
            Controls.Add(MemberName_Text);
            Controls.Add(MemberID_Text);
            Controls.Add(LoanID_Text);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteButton);
            Controls.Add(SearchButton);
            Controls.Add(InsertButton);
            Name = "LibraryCRUDApplication";
            Load += LibraryCRUDApplication_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InsertButton;
        private Button SearchButton;
        private Button UpdateButton;
        private Button DeleteButton;
        private Label LoanID_Text;
        private Label MemberID_Text;
        private Label MemberName_Text;
        private Label BookTitle_Text;
        private Label LoanStatus_Text;
        private Label CheckoutDate_Text;
        private TextBox LoanID_Entry;
        private TextBox MemberID_Entry;
        private TextBox MemberName_Entry;
        private TextBox BookTitle_Entry;
        private TextBox LoanStatus_Entry;
        private Label label7;
        private Label ReturnDate_Text;
        private TextBox CheckoutDate_Entry;
        private TextBox ReturnDate_Entry;
        private DataGridView dataGridView1;
        private Button SaveButton;
        private Button ViewAllButton;
        private Button CreateDB;
        private TextBox DB_Entry;
        private Button DisplayDB;
        private Label label1;
        private Button DeleteDB;
        private Button DeleteTableButton;
        private Label label2;
        private Button DisplayTableButton;
        private TextBox Table_Entry;
        private Button CreateTableButton;
        private Button ReadTableButton;
    }
}