using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_File
{
    public partial class Form2 : Form
    {
        string filepath = "", line = "";

        List<List<string>> list = new List<List<string>>();
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(list);
            f3.Show();
            this.Hide();
        }
        private void converte_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void btn_filename_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "TXT|*.txt";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filepath = open.FileName;
                    if (filepath != "" && filepath != null)
                    {

                        line = File.ReadAllText(filepath);
                        foreach (var rows in line.Split(Convert.ToChar(Row_Delimiter.Text)))
                        {
                            list.Add(rows.Split(Convert.ToChar(Column_Delimiter.Text)).ToList<string>());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload The File ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show("Please Enter Row Delimiter and Column Delimiter First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        }
    }


