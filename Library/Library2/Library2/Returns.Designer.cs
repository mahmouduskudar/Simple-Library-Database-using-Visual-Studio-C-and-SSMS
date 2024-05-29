namespace Library2
{
    partial class Returns
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
            this.BorrowList = new System.Windows.Forms.ComboBox();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database = new Library2.Database();
            this.label4 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnGV = new System.Windows.Forms.DataGridView();
            this.returnIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penaltyAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dltBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.returnTableAdapter = new Library2.DatabaseTableAdapters.ReturnTableAdapter();
            this.borrowingTableAdapter = new Library2.DatabaseTableAdapters.BorrowingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BorrowList
            // 
            this.BorrowList.DataSource = this.borrowingBindingSource;
            this.BorrowList.DisplayMember = "Borrowing_ID";
            this.BorrowList.FormattingEnabled = true;
            this.BorrowList.Location = new System.Drawing.Point(486, 376);
            this.BorrowList.Name = "BorrowList";
            this.BorrowList.Size = new System.Drawing.Size(268, 28);
            this.BorrowList.TabIndex = 39;
            this.BorrowList.ValueMember = "Borrowing_ID";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Borrowing";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(130, 371);
            this.returnDate.MaxDate = new System.DateTime(2035, 12, 31, 0, 0, 0, 0);
            this.returnDate.MinDate = new System.DateTime(2024, 5, 16, 0, 0, 0, 0);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 27);
            this.returnDate.TabIndex = 36;
            this.returnDate.Value = new System.DateTime(2024, 5, 25, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "retuning Date";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(73, 311);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(1099, 27);
            this.searchTxt.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Search";
            // 
            // returnGV
            // 
            this.returnGV.AllowUserToAddRows = false;
            this.returnGV.AllowUserToDeleteRows = false;
            this.returnGV.AutoGenerateColumns = false;
            this.returnGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnIDDataGridViewTextBoxColumn,
            this.borrowingIDDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.penaltyAmountDataGridViewTextBoxColumn});
            this.returnGV.DataSource = this.returnBindingSource;
            this.returnGV.Location = new System.Drawing.Point(12, 12);
            this.returnGV.Name = "returnGV";
            this.returnGV.ReadOnly = true;
            this.returnGV.Size = new System.Drawing.Size(1160, 278);
            this.returnGV.TabIndex = 32;
            this.returnGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnGV_CellClick);
            // 
            // returnIDDataGridViewTextBoxColumn
            // 
            this.returnIDDataGridViewTextBoxColumn.DataPropertyName = "Return_ID";
            this.returnIDDataGridViewTextBoxColumn.HeaderText = "Return_ID";
            this.returnIDDataGridViewTextBoxColumn.Name = "returnIDDataGridViewTextBoxColumn";
            this.returnIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // borrowingIDDataGridViewTextBoxColumn
            // 
            this.borrowingIDDataGridViewTextBoxColumn.DataPropertyName = "Borrowing_ID";
            this.borrowingIDDataGridViewTextBoxColumn.HeaderText = "Borrowing_ID";
            this.borrowingIDDataGridViewTextBoxColumn.Name = "borrowingIDDataGridViewTextBoxColumn";
            this.borrowingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return_Date";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // penaltyAmountDataGridViewTextBoxColumn
            // 
            this.penaltyAmountDataGridViewTextBoxColumn.DataPropertyName = "Penalty_Amount";
            this.penaltyAmountDataGridViewTextBoxColumn.HeaderText = "Penalty_Amount";
            this.penaltyAmountDataGridViewTextBoxColumn.Name = "penaltyAmountDataGridViewTextBoxColumn";
            this.penaltyAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnBindingSource
            // 
            this.returnBindingSource.DataMember = "Return";
            this.returnBindingSource.DataSource = this.database;
            // 
            // dltBtn
            // 
            this.dltBtn.Location = new System.Drawing.Point(810, 499);
            this.dltBtn.Name = "dltBtn";
            this.dltBtn.Size = new System.Drawing.Size(360, 100);
            this.dltBtn.TabIndex = 43;
            this.dltBtn.Text = "DELETE";
            this.dltBtn.UseVisualStyleBackColor = true;
            this.dltBtn.Click += new System.EventHandler(this.dltBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(407, 499);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(360, 100);
            this.editBtn.TabIndex = 42;
            this.editBtn.Text = "EDIT";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(10, 499);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(360, 100);
            this.addBtn.TabIndex = 41;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // returnTableAdapter
            // 
            this.returnTableAdapter.ClearBeforeFill = true;
            // 
            // borrowingTableAdapter
            // 
            this.borrowingTableAdapter.ClearBeforeFill = true;
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.dltBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.BorrowList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnGV);
            this.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Returns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.Returns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox BorrowList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView returnGV;
        private System.Windows.Forms.Button dltBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private Database database;
        private System.Windows.Forms.BindingSource returnBindingSource;
        private DatabaseTableAdapters.ReturnTableAdapter returnTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penaltyAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private DatabaseTableAdapters.BorrowingTableAdapter borrowingTableAdapter;
    }
}