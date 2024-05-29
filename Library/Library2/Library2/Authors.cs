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
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.database.Authors);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.authorsTableAdapter.AuthorInsertQuery(nameTxt.Text, bioTxt.Text);
            MessageBox.Show("\"" + nameTxt.Text + "\"" + " is Added Successfully");
            this.authorsTableAdapter.Fill(this.database.Authors);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int idx = authorGV.CurrentRow.Index;
            string ID = authorGV.Rows[idx].Cells[0].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            this.authorsTableAdapter.AuthorUpdateQuery(nameTxt.Text, bioTxt.Text, T_ID);
            MessageBox.Show("\"" + nameTxt.Text + "\"" + " is Edited Successfully");
            this.authorsTableAdapter.Fill(this.database.Authors);

            nameTxt.Clear();
            bioTxt.Clear();
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            int idx = authorGV.CurrentRow.Index;
            string ID = authorGV.Rows[idx].Cells[0].Value.ToString();
            string name = authorGV.Rows[idx].Cells[1].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            this.authorsTableAdapter.AuthorDeleteQuery(T_ID);
            MessageBox.Show("\"" + name + "\"" + " is Deleted Successfully");
            this.authorsTableAdapter.Fill(this.database.Authors);

            nameTxt.Clear();
            bioTxt.Clear();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.authorsTableAdapter.FillBy(this.database.Authors, searchTxt.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void authorGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = authorGV.Rows[e.RowIndex];
                nameTxt.Text = row.Cells[1].Value.ToString();
                bioTxt.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
