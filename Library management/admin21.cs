using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class admin21 : Form
    {
        
        public admin21()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBID.Text != "" && textBoxName.Text != "" && textBoxAuthor.Text != "" && textBoxPress.Text != "" && textBoxInstock.Text != "")
            {
                Dao dao = new Dao();
                string sql = $"insert into t_book2 values('{textBoxBID.Text}','{textBoxName.Text}','{textBoxAuthor.Text}','{textBoxPress.Text}',{textBoxInstock.Text})";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("Added sucessfully!");
                }
                else
                {
                    MessageBox.Show("Added failure!");
                }
                textBoxBID.Text = "";
                textBoxName.Text = "";
                textBoxAuthor.Text = "";
                textBoxPress.Text = "";
                textBoxInstock.Text = "";
            }
            else
            {
                MessageBox.Show("entry cannot be empty!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBID.Text = "";
            textBoxName.Text = "";
            textBoxAuthor.Text = "";
            textBoxPress.Text = "";
            textBoxInstock.Text = "";
        }
    }
}
