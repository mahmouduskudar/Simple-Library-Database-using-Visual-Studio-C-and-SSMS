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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Authors authors = new Authors();
            authors.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Borrowings books = new Borrowings();
            books.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Publishers publishers = new Publishers();
            publishers.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Returns returns = new Returns();
            returns.ShowDialog();
        }
    }
}
