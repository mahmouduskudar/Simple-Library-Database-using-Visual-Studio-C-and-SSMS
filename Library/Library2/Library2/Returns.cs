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
    public partial class Returns : Form
    {
        public Returns()
        {
            InitializeComponent();
        }

        private void Returns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.Borrowing' table. You can move, or remove it, as needed.
            this.borrowingTableAdapter.Fill(this.database.Borrowing);
            // TODO: This line of code loads data into the 'database.Return' table. You can move, or remove it, as needed.
            this.returnTableAdapter.Fill(this.database.Return);

            returnDate.Value = DateTime.Today;

        }

        private void addBtn_Click(object sender, EventArgs e)
        { 
            int borrowingID = (int)BorrowList.SelectedValue;

            var borrowing = this.database.Borrowing.FirstOrDefault(b => b.Borrowing_ID == borrowingID);
            if (borrowing == null)
            {
                MessageBox.Show("Invalid borrowing record.");
                return;
            }

            DateTime rDate = returnDate.Value.Date;

            double penaltyAmount = CalculatePenalty(borrowing.Due_Date, rDate);

            this.returnTableAdapter.ReturnInsertQuery(borrowingID, rDate.ToShortDateString(), penaltyAmount);

            MessageBox.Show("Return added successfully.");
            this.returnTableAdapter.Fill(this.database.Return);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int idx = returnGV.CurrentRow.Index;
            string ID = returnGV.Rows[idx].Cells[0].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            int borrowingID = (int)BorrowList.SelectedValue;

            var borrowing = this.database.Borrowing.FirstOrDefault(b => b.Borrowing_ID == borrowingID);
            if (borrowing == null)
            {
                MessageBox.Show("Invalid borrowing record.");
                return;
            }

            DateTime rDate = returnDate.Value.Date;

            double penaltyAmount = CalculatePenalty(borrowing.Due_Date, rDate);

            this.returnTableAdapter.ReturnUpdateQuery(borrowingID, rDate.ToShortDateString(), penaltyAmount, T_ID);
            MessageBox.Show("Return Edited Successfully");
            this.returnTableAdapter.Fill(this.database.Return);
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            int idx = returnGV.CurrentRow.Index;
            string ID = returnGV.Rows[idx].Cells[0].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            this.returnTableAdapter.ReturnDeleteQuery(T_ID);
            MessageBox.Show("Return Deleted Successfully");
            this.returnTableAdapter.Fill(this.database.Return);
        }

        private void returnGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = returnGV.Rows[e.RowIndex];
                BorrowList.SelectedValue = row.Cells[1].Value;

            }
        }

        private double CalculatePenalty(DateTime dueDate, DateTime returnDate)
        {
            // Define penalty rule: $2 per day for late returns
            double penaltyPerDay = 2.0;

            // Calculate the difference in days between due date and return date
            TimeSpan difference = returnDate - dueDate;
            int daysLate = difference.Days;

            // Calculate penalty amount
            double penaltyAmount = Math.Max(0, daysLate) * penaltyPerDay;

            return penaltyAmount;
        }
    }
}
