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
    public partial class Publishers : Form
    {
        public Publishers()
        {
            InitializeComponent();
        }

        private void Publishers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.Publisher' table. You can move, or remove it, as needed.
            this.publisherTableAdapter.Fill(this.database.Publisher);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.publisherTableAdapter.PublisherInsertQuery(nameTxt.Text,webTxt.Text,descTxt.Text);
            this.publisherTableAdapter.Fill(this.database.Publisher);

            MessageBox.Show(nameTxt.Text + " is Added successfully!");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int idx = publisherGV.CurrentRow.Index;
            string ID = publisherGV.Rows[idx].Cells[0].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            this.publisherTableAdapter.PublisherUpdateQuery(nameTxt.Text, webTxt.Text, descTxt.Text, T_ID);

            MessageBox.Show("\"" + nameTxt.Text + "\"" + " is Edited Successfully");

            this.publisherTableAdapter.Fill(this.database.Publisher);
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            int idx = publisherGV.CurrentRow.Index;
            string ID = publisherGV.Rows[idx].Cells[0].Value.ToString();
            string name = publisherGV.Rows[idx].Cells[1].Value.ToString();

            int T_ID;

            int.TryParse(ID, out T_ID);

            this.publisherTableAdapter.PublisherDeleteQuery(T_ID);
            this.publisherTableAdapter.Fill(this.database.Publisher);
            MessageBox.Show("\"" + name + "\"" + " is Deleted Successfully");
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.publisherTableAdapter.FillBy(this.database.Publisher, searchTxt.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
