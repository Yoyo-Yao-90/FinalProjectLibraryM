using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
        }

        private void findAndBorrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 u2 = new user2();
            u2.ShowDialog();
        }

        private void myBookBorrowAndReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 u3 = new user3();
            u3.ShowDialog();
        }
    }
}
