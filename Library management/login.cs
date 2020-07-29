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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonLognin_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "")
            {
                Login();
               
            }
            else
            {
                MessageBox.Show("User and password cannot be empy, please enter!");
            }
        }

        //logn in method and check whether it can logn in and return value
        public void Login()
        {
           
            //User
            if (radioButtonUser.Checked== true)
            {
                Dao dao = new Dao();
                string sql = "select* from t_user where id='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);

                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();

                    MessageBox.Show("login Successfully!");
                    user1 user = new user1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                    


                }
                else
                {
                    MessageBox.Show("Login failure!");

                }
                dao.DaoClose();


            }
            //Admin
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select* from t_admin where id='" + textBox1.Text + "'and password='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("login Successfully!");
                    admin1 a = new admin1();
                    //this.Hide();
                    a.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Login failure!");
                    
                }
                dao.DaoClose();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
