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
    public partial class user3 : Form
    {
        public user3()
        {
            InitializeComponent();
            Table();
        }
            public void Table()
            {
                dataGridView1.Rows.Clear();//rmove the previous data
                Dao dao = new Dao();
                string sql = $"select [no],[bid],[datetime] from t_lend where [uid]='{Data.UID}'";
                IDataReader dc = dao.read(sql);
                while (dc.Read())
                {
                    dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
                }
                dc.Close();
                dao.DaoClose();
            }

        private void buttonBR_Click(object sender, EventArgs e)
        {
            string no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete from t_lend where [no]={no};UPDATE t_book2 set number =number+1 where id='{id}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 1)
            {
                MessageBox.Show(" returned sucessfully!");
                Table();
            }
        }
    }
}
