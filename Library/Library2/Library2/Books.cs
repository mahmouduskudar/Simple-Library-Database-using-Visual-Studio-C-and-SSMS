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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.database1.Authors);
            // TODO: This line of code loads data into the 'database.Author_Book' table. You can move, or remove it, as needed.
            this.author_BookTableAdapter.Fill(this.database.Author_Book);
            this.authorsTableAdapter.Fill(this.database.Authors);
            this.publisherTableAdapter.Fill(this.database.Publisher);
            this.bookTableAdapter.Fill(this.database.Book);

            publisherList.SelectedItem = null;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            object x = publisherList.SelectedValue;

            int i;
            if (available.Checked) { i = 1; } else { i = 0; }
            this.bookTableAdapter.BookInsertQuery(isbnTxt.Text, titleTxt.Text, (int?)x, i);
            MessageBox.Show("\"" + isbnTxt.Text + "\"" + " is Added Successfully");
            this.bookTableAdapter.Fill(this.database.Book);
            this.publisherTableAdapter.Fill(this.database.Publisher);

            var row = authorList.SelectedItems.Cast<DataRowView>();
            foreach (var item in row)
            {
                int aitem = (int)(item.Row[0]);
                this.author_BookTableAdapter.ABInsertQuery((int?)aitem, isbnTxt.Text);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            object x = publisherList.SelectedValue;

            int i;
            if (available.Checked) { i = 1; } else { i = 0; }

            this.bookTableAdapter.BookUpdateQuery(isbnTxt.Text, titleTxt.Text, (int?)x, i);
            MessageBox.Show("\"" + isbnTxt.Text + "\"" + " is Edited Successfully");
            this.bookTableAdapter.Fill(this.database.Book);

            isbnTxt.Clear();
            titleTxt.Clear();
            available.Checked = false;
            publisherList.SelectedItem = null;
        }

        private void bookGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = bookGV.Rows[e.RowIndex];
                isbnTxt.Text = row.Cells[0].Value.ToString();
                titleTxt.Text = row.Cells[1].Value.ToString();
                publisherList.SelectedValue = row.Cells[2].Value;
                if (row.Cells[3].Value.Equals(0)) { available.Checked = false; } else { available.Checked = true; }
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.BookDeleteQuery(isbnTxt.Text);
            MessageBox.Show("\"" + isbnTxt.Text + "\"" + " is Deleted Successfully");
            this.bookTableAdapter.Fill(this.database.Book);

            isbnTxt.Clear();
            titleTxt.Clear();
            available.Checked = false;
            publisherList.SelectedItem = null;
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy(this.database.Book, searchTxt.Text, searchTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
