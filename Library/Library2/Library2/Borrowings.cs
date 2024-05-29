using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library2
{
    public partial class Borrowings : Form
    {
        public Borrowings()
        {
            InitializeComponent();
        }

        private void Borrowings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.database.Member);
            // TODO: This line of code loads data into the 'database.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.database.Book);
            // TODO: This line of code loads data into the 'database.Borrowing' table. You can move, or remove it, as needed.
            this.borrowingTableAdapter.Fill(this.database.Borrowing);

            memberList.SelectedItem = null;
            bookList.SelectedItem = null;
            borrowDate.Value = DateTime.Today;
            dueDate.Value = DateTime.Today;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            object x = memberList.SelectedValue;
            string y = bookList.SelectedValue.ToString();
            var bDate = borrowDate.Value.Date.ToShortDateString();
            var dDate = dueDate.Value.Date.ToShortDateString();

            if (this.database.Book.Any(b => b.Available == 1))
            {
                this.borrowingTableAdapter.BorrowingInsertQuery((int?)x, y, bDate, dDate);
                this.bookTableAdapter.BookAvaUpdateQuery(0, y);
            }
            else
            {
                MessageBox.Show("Book is reserved");
            }



            MessageBox.Show( "This Borrwoing is Added Successfully");

            this.borrowingTableAdapter.Fill(this.database.Borrowing);
            this.bookTableAdapter.Fill(this.database.Book);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            object x = memberList.SelectedValue;
            string y = bookList.SelectedValue.ToString();
            var bDate = borrowDate.Value.Date.ToShortDateString();
            var dDate = dueDate.Value.Date.ToShortDateString();

            int idx = borrowGV.CurrentRow.Index;
            string ID = borrowGV.Rows[idx].Cells[0].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            this.borrowingTableAdapter.BorrowUpdateQuery((int?)x, y, bDate, dDate, T_ID);

            MessageBox.Show("This Borrwoing is Updated Successfully");

            this.borrowingTableAdapter.Fill(this.database.Borrowing);

            memberList.SelectedItem = null;
            bookList.SelectedItem = null;
            borrowDate.Value = DateTime.Today;
            dueDate.Value = DateTime.Today;
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            string y = bookList.SelectedValue.ToString();

            int idx = borrowGV.CurrentRow.Index;
            string ID = borrowGV.Rows[idx].Cells[0].Value.ToString();
            int.TryParse(ID, out int T_ID);

            this.borrowingTableAdapter.BorrowDeleteQuery(T_ID);
            this.bookTableAdapter.BookAvaUpdateQuery(1, y);

            MessageBox.Show("This Borrowing is Deleted Successfully");
            this.borrowingTableAdapter.Fill(this.database.Borrowing);

            memberList.SelectedItem = null;
            bookList.SelectedItem = null;
            borrowDate.Value = DateTime.Today;
            dueDate.Value = DateTime.Today;
        }

        private void borrowGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = borrowGV.Rows[e.RowIndex];
                memberList.SelectedValue = row.Cells[1].Value;
                bookList.SelectedValue = row.Cells[2].Value;
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.borrowingTableAdapter.FillBy(this.database.Borrowing, searchTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
