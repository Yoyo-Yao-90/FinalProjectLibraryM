using Library_management.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management
{
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
        }
        private void admin2_Load(object sender, EventArgs e)
        {
            Table();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//get the book id
        }
        //read the data from sql and show in the table
        public void Table()
        {
            dataGridView1.Rows.Clear();//rmove the previous data
            Dao dao = new Dao();
            string sql = "select * from t_book2";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        //search by book id
        public void TableID()
        {
            dataGridView1.Rows.Clear();//rmove the previous data
            Dao dao = new Dao();
            MessageBox.Show(textBox1.Text);
            string sql = "";
            if(textBox1.Text=="")
            {
               sql = $"select * from t_book2";
            }
            else 
            {
                sql = $"select * from t_book2 where id='{textBox1.Text}'";
            }
            // string sql = $"select * from t_book2 where id='{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        public void TableName()
        {
            dataGridView1.Rows.Clear();//rmove the previous data
            Dao dao = new Dao();
            string sql = "";
            if (textBox2.Text == "")
            {
                sql = $"select * from t_book2";
            }
            else
            {
                sql = $"select * from t_book2 where name like'%{textBox2.Text}%'";
            }
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }




        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//get book id
                DialogResult dr = MessageBox.Show("Confirm delete ?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_book2 where id='{id}' ";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("deleted!");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("deleted failure!");
                    }
                    dao.DaoClose();
                }
            }

            catch
            {
                MessageBox.Show("Plsease select the record you want to delete firstly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
      

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            admin21 a = new admin21();
            a.ShowDialog();
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                admin22 admin = new admin22(id, name, author, press, number);// switch to  admin 22 form
                admin.ShowDialog();
                Table();// refresh table  
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//get the book id
        }

        private void btnBNumS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            TableID();
        }

        private void btnBNamS_Click(object sender, EventArgs e)
        {
            TableName();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Table();
            //textBox1.Text = " ";
            //textBox2.Text = " ";
            
        }

        private void buttonEE_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";    //current sheet name
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)  //Row 
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++) //Column
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application == file name 
            // workbook.SaveAs("C:\\Users\\pxpon\\Desktop\\Georgian College\\1st semester\\NET PROGRAMMING USING C#\\Final Project\\Library Management\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
            // save the excel file to the directory of the source file
            string pathBinDebug = Directory.GetCurrentDirectory();
            string pathExcelFile = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(pathBinDebug))) + @"\output.xls";
            // workbook.SaveAs(pathExcelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // workbook.Close();
            // app.Quit();
            app.DisplayAlerts = false;
            if (File.Exists(pathExcelFile)) File.Delete(pathExcelFile);
            workbook.SaveAs(pathExcelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
            workbook.Close();
            app.Quit();
            MessageBox.Show("Excel file output.xls is saved to "+pathExcelFile);
        }

        private void buttonEJ_Click(object sender, EventArgs e)
        {   
            // export rows in dataGridView1 to json file content
            JArray products = new JArray();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                JObject product = JObject.FromObject(new
                {   
                    ID = row.Cells[0].Value,
                    Name = row.Cells[1].Value,
                    Author = row.Cells[2].Value,
                    Press = row.Cells[3].Value,
                    InStock = row.Cells[4].Value
                });
                products.Add(product);
            }

            string jsonData = JsonConvert.SerializeObject(products);

            // save the json file to the directory of the source file
            string pathBinDebug = Directory.GetCurrentDirectory();
            string pathJsonFile = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(pathBinDebug))) + @"\output.json";
            File.WriteAllText(pathJsonFile, jsonData);
            MessageBox.Show("Json file output.json is saved to " + pathJsonFile);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            txtFile.Text = openFileDialog1.FileName;
            string filePath = txtFile.Text;
            DataTable dt = new DataTable();
            if(filePath!="")
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    //first line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //For Data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    dgvImport.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please select a file!");
            }
        }
    } 
}

      

       