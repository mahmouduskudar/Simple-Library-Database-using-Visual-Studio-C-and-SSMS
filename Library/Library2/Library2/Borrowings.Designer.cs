namespace Library2
{
    partial class Borrowings
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
            this.dltBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.borrowGV = new System.Windows.Forms.DataGridView();
            this.borrowingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database = new Library2.Database();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.DateTimePicker();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.borrowingTableAdapter = new Library2.DatabaseTableAdapters.BorrowingTableAdapter();
            this.bookTableAdapter = new Library2.DatabaseTableAdapters.BookTableAdapter();
            this.memberTableAdapter = new Library2.DatabaseTableAdapters.MemberTableAdapter();
            this.bookList = new System.Windows.Forms.ComboBox();
            this.memberList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(810, 499);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(360, 100);
            this.dltBtn.TabIndex = 15;
            this.dltBtn.Text = "DELETE";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(407, 499);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(360, 100);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(10, 499);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(360, 100);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // borrowGV
            // 
            this.borrowGV.AllowUserToAddRows = false;
            this.borrowGV.AllowUserToDeleteRows = false;
            this.borrowGV.AutoGenerateColumns = false;
            this.borrowGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.borrowGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.borrowingIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.borrowingdateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn});
            this.borrowGV.DataSource = this.borrowingBindingSource;
            this.borrowGV.Location = new System.Drawing.Point(12, 12);
            this.borrowGV.Name = "borrowGV";
            this.borrowGV.ReadOnly = true;
            this.borrowGV.Size = new System.Drawing.Size(1160, 278);
            this.borrowGV.TabIndex = 16;
            this.borrowGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowGV_CellClick);
            // 
            // borrowingIDDataGridViewTextBoxColumn
            // 
            this.borrowingIDDataGridViewTextBoxColumn.DataPropertyName = "Borrowing_ID";
            this.borrowingIDDataGridViewTextBoxColumn.HeaderText = "Borrowing_ID";
            this.borrowingIDDataGridViewTextBoxColumn.Name = "borrowingIDDataGridViewTextBoxColumn";
            this.borrowingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.borrowingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member_ID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowingdateDataGridViewTextBoxColumn
            // 
            this.borrowingdateDataGridViewTextBoxColumn.DataPropertyName = "Borrowing_date";
            this.borrowingdateDataGridViewTextBoxColumn.HeaderText = "Borrowing_date";
            this.borrowingdateDataGridViewTextBoxColumn.Name = "borrowingdateDataGridViewTextBoxColumn";
            this.borrowingdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "Due_Date";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataMember = "Borrowing";
            this.borrowingBindingSource.DataSource = this.database;
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(73, 311);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(1099, 27);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Borrowing Date";
            // 
            // borrowDate
            // 
            this.borrowDate.Location = new System.Drawing.Point(130, 371);
            this.borrowDate.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.borrowDate.MinDate = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(200, 27);
            this.borrowDate.TabIndex = 21;
            this.borrowDate.Value = new System.DateTime(2024, 5, 25, 0, 0, 0, 0);
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(130, 424);
            this.dueDate.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.dueDate.MinDate = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(200, 27);
            this.dueDate.TabIndex = 22;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.database;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Member";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.database;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "ISBN";
            // 
            // borrowingTableAdapter
            // 
            this.borrowingTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // bookList
            // 
            this.bookList.DataSource = this.bookBindingSource;
            this.bookList.DisplayMember = "Title";
            this.bookList.FormattingEnabled = true;
            this.bookList.Location = new System.Drawing.Point(451, 376);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(303, 28);
            this.bookList.TabIndex = 30;
            this.bookList.ValueMember = "ISBN";
            // 
            // memberList
            // 
            this.memberList.DataSource = this.memberBindingSource;
            this.memberList.DisplayMember = "name";
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(876, 373);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(294, 28);
            this.memberList.TabIndex = 31;
            this.memberList.ValueMember = "Member_ID";
            // 
            // Borrowings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1192, 619);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dueDate);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrowGV);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Borrowings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrowings";
            this.Load += new System.EventHandler(this.Borrowings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView borrowGV;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker borrowDate;
        private System.Windows.Forms.DateTimePicker dueDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Database database;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private DatabaseTableAdapters.BorrowingTableAdapter borrowingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DatabaseTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DatabaseTableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.ComboBox bookList;
        private System.Windows.Forms.ComboBox memberList;
    }
}