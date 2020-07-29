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
    public partial class admin22 : Form
    {
        string ID="";

        public admin22()
        {
            InitializeComponent();
        }

        public admin22(string id, string name, string author,string press,string number)
        {
            InitializeComponent();
            ID= textBoxBID.Text = id;
            textBoxName.Text = name;
            textBoxAuthor.Text = author;
            textBoxPress.Text = press;
            textBoxInstock.Text = number;

        }

     

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            string sql = $"update t_book2 set id='{textBoxBID.Text}',[name]='{textBoxName.Text}', author='{textBoxAuthor.Text}', press='{textBoxPress.Text}',number={textBoxInstock.Text} where id='{ID}'";
            Dao dao = new Dao();
            if (dao.Execute(sql)> 0)
            {
                MessageBox.Show("Modfied successfully!");
                this.Close();
            }
        }
    }
}
