using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
namespace Project_File
{
    public partial class Form4 : Form
    {
        List<List<string>> list = new List<List<string>>();
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_filename_Click(object sender, EventArgs e)
        {

        try { 
            string filepath;
            int sheet_num;
            sheet_num = Convert.ToInt32( sheet_numb.Text);
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel|*.xlsx";
            if (open.ShowDialog() == DialogResult.OK)
            {
                 filepath = open.FileName;
                if (filepath != "" && filepath != null)
                {
                    Excel ex = new Excel(filepath, sheet_num);
                    list = ex.readAll();
                }
            }
            else
            {
                    MessageBox.Show("Please Upload The File ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            catch (Exception ex) { MessageBox.Show("Please Enter Sheet Number First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }




}

private void converte_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3(list);
            f3.Show();
            this.Hide();

        }
    }
}
