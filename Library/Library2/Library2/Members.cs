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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.database.Member);
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter.FillBy(this.database.Member, searchTxt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int x = 0;
            if(adminBtn.Checked)
                x = 1;
            else if(memberBtn.Checked)
                x = 0;
            this.memberTableAdapter.MemberInsertQuery(nameTxt.Text, emailTxt.Text, addressTxt.Text,x);
            MessageBox.Show("\"" + nameTxt.Text + "\"" + " is Added Successfully");
            this.memberTableAdapter.Fill(this.database.Member);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int idx = memberGV.CurrentRow.Index;
            string ID = memberGV.Rows[idx].Cells[0].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            int x = 0;
            if (adminBtn.Checked)
                x = 1;
            else if (memberBtn.Checked)
                x = 0;

            this.memberTableAdapter.MemberUpdateQuery(nameTxt.Text, emailTxt.Text, addressTxt.Text, x, T_ID);

            MessageBox.Show("\"" + nameTxt.Text + "\"" + " is Edited Successfully");

            this.memberTableAdapter.Fill(this.database.Member);

            nameTxt.Clear();
            emailTxt.Clear();
            addressTxt.Clear();
            adminBtn.Checked = false;
            memberBtn.Checked = false;
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            int idx = memberGV.CurrentRow.Index;
            string ID = memberGV.Rows[idx].Cells[0].Value.ToString();
            string name = memberGV.Rows[idx].Cells[1].Value.ToString();
            int T_ID;
            int.TryParse(ID, out T_ID);

            this.memberTableAdapter.MemberDeleteQuery(T_ID);
            MessageBox.Show("\"" + name + "\"" + " is Deleted Successfully");
            this.memberTableAdapter.Fill(this.database.Member);

            nameTxt.Clear();
            emailTxt.Clear();
            addressTxt.Clear();
            adminBtn.Checked = false;
            memberBtn.Checked = false;
        }

        private void memberGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = memberGV.Rows[e.RowIndex];
                nameTxt.Text = row.Cells[1].Value.ToString();
                emailTxt.Text = row.Cells[2].Value.ToString();
                addressTxt.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.Equals(1))
                {
                    memberBtn.Checked = false;
                    adminBtn.Checked = true;
                }
                else
                {
                    adminBtn.Checked = false;
                    memberBtn.Checked = true;
                }
            }
        }
    }
}
