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
using System.Xml;

namespace Project_File
{
    public partial class Form3 : Form
    {
        List<List<string>> list1 = new List<List<string>>();
     
        public Form3()
        {
            InitializeComponent();
            unique_groupbox.Hide();
            default_groupbox.Hide();
            notnullgroupbox.Hide();
            //less_thannandmorethanORequal.Hide();
            //morethanandlessthanORequal.Hide();
            checks.Hide();
            second_check.Hide();
            check2_label.Hide();
            


        }
        public Form3 (List<List<string>> lis){
            list1 = lis;
            InitializeComponent();
            unique_groupbox.Hide();
            default_groupbox.Hide();
            notnullgroupbox.Hide();
            //less_thannandmorethanORequal.Hide();
            //morethanandlessthanORequal.Hide();
            checks.Hide();
            second_check.Hide();
            check2_label.Hide();
        }

        private void but_Done_Click(object sender, EventArgs e)
        {

        }

        private void uniqe_CheckedChanged(object sender, EventArgs e)
        {
            if (uniqe.Checked)
            {
                unique_groupbox.Show();

            }
            else
            {
                unique_groupbox.Hide();

            }
        }

        private void defau_CheckedChanged(object sender, EventArgs e)
        {
            if (defau.Checked)
            {
                default_groupbox.Show();
            }
            else
            {
                default_groupbox.Hide();

            }
        }

        private void notnul_CheckedChanged(object sender, EventArgs e)
        {

            if (notnul.Checked)
            {
                notnullgroupbox.Show();
            }
            else
            {
                notnullgroupbox.Hide();

            }
        }

        private void check_radioo_CheckedChanged(object sender, EventArgs e)
        {

            if (check_box.Checked)
            {
                checks.Show();
            }
            else
            {
                checks.Hide();

            }
        }

     

        private void more_thann_CheckedChanged(object sender, EventArgs e)
        {

            check2_label.Show();
            second_check.Show();

        }

        private void moreorequal_CheckedChanged(object sender, EventArgs e)
        {

            check2_label.Hide();
            second_check.Hide();
        }

        private void lessorequal_CheckedChanged(object sender, EventArgs e)
        {

            check2_label.Hide();
            second_check.Hide();
        }

        private void morethanandlessthan_CheckedChanged(object sender, EventArgs e)
        {

            check2_label.Show();
            second_check.Show();

        }

        private void morethanORequalandlessthanORequal_CheckedChanged(object sender, EventArgs e)
        {

            check2_label.Show();
            second_check.Show();

        }

        private void morethanandlessthanORequal_CheckedChanged(object sender, EventArgs e)
        {

            check2_label.Show();
            second_check.Show();

        }

        private void morethann_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Hide();
            second_check.Hide();
        }

        private void lessthann_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Hide();
            second_check.Hide();
        }

        private void equall_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Hide();
            second_check.Hide();
        }

        private void converte_Click(object sender, EventArgs e)
        {

            bool x1 = true, y = true, z = true;
            if (uniqe.Checked == true)
            {
                if (Unique() == false)
                {
                    MessageBox.Show("The Column Is Not Uniqe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    x1 = false;
                }
            }
            if (defau.Checked == true)
            {
                list1 = Default(list1);
            }
            if (notnul.Checked == true)
            {
                if (Not_Null() == true)
                {
                    MessageBox.Show("Found Null In This Column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    y = false;
                }

            }
            if (check_box.Checked==true)

            {

                if (check() == false)
                {
                    MessageBox.Show("The Check is False", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    z = false;
                }
            }
            if((x1==true) && (y==true) && (z==true))
            {
                if (!File.Exists(xml_name.Text + ".xml"))
                {
                    XmlWriter writer = XmlWriter.Create(xml_name.Text + ".xml");
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Table");
                    for (int i = 0; i < list1.Count; i++)
                    {

                        writer.WriteStartElement("Row" + (i + 1));

                        for (int x = 0; x < list1[i].Count; x++)
                        {

                            writer.WriteStartElement("Column" + (x + 1));
                            writer.WriteString(list1[i][x]);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                    writer.Close();
                    MessageBox.Show("Convarted Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The File Is Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool Unique()
        {
            int num = Convert.ToInt32(num_column.Text);
            bool unique = true;
            HashSet<string> s = new HashSet<string>();
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1[j][num - 1] == "" || list1[j][num - 1] == " " || list1[j][num - 1] == null)
                {

                    list1.RemoveAt(j);
                    j--;
                }
                else
                {
                    s.Add(list1[j][num - 1]);
                }
            }
            if (s.Count == list1.Count)
            {
                unique = true;
            }
            else
            {
                unique = false;
            }
            return unique;
        }
        public bool Not_Null()
        {
            int num = Convert.ToInt32(num_co.Text.ToString());
            bool not_null = true;
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1[j][num - 1] == null || list1[j][num - 1] == " " || list1[j][num - 1] == "")
                {
                    not_null = true;
                    break;
                }
                else
                {

                    not_null = false;
                }

            }

            return not_null;
        }
        public List<List<string>> Default(List<List<string>> list)
        {
            int num = Convert.ToInt32(num_col.Text);
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j][num - 1] == null || list[j][num - 1] == "" || list[j][num - 1] == " ")
                {
                    list[j][num - 1] = default_value.Text;
                }
            }
            return list;
        }
        public bool check()
        {


            bool chea = false;
            int num = Convert.ToInt32(colum_num.Text);
            for (int j = 0; j < list1.Count; j++)
            {
                if (list1[j][num - 1] == "" || list1[j][num - 1] == " " || list1[j][num - 1] == null)
                {
                    list1.RemoveAt(j);
                    j--;
                }
            }
            if (morethanandlessthan.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) < Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) > Convert.ToInt32(second_check.Text))
                        {
                            chea = true;
                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (morethann.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) > Convert.ToInt32(FValue_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (moreorequal.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) >= Convert.ToInt32(FValue_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (morethanORequalandlessthanORequal.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) >= Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) <= Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (lessthann.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) < Convert.ToInt32(FValue_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (lessorequal.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) <= Convert.ToInt32(FValue_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (equall.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) == Convert.ToInt32(FValue_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {

                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (list1[j][num - 1] == FValue_check.Text)
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
            }
            else if (less_thannandmorethanORequal.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) >= Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) < Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (morethanandlessthanORequal.Checked)
            {
                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) > Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) <= Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (morethanlessorequal.Checked)
            {

                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) < Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) >= Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (moreorequalandlessorequal.Checked)
            {

                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) <= Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) >= Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (morethanorequalandlessthan.Checked)
            {

                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) <= Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) > Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else if (lessthanandmorethan.Checked) {

                try
                {
                    for (int j = 0; j < list1.Count; j++)
                    {
                        if (Convert.ToInt32(list1[j][num - 1]) > Convert.ToInt32(FValue_check.Text) && Convert.ToInt32(list1[j][num - 1]) < Convert.ToInt32(second_check.Text))
                        {
                            chea = true;

                        }
                        else
                        {
                            chea = false;
                            break;
                        }
                    }
                    return chea;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This Column is String Not Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                return chea;
            }
            return chea;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void morethanlessorequal_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Show();
            second_check.Show();
        }

        private void morethanorequalandlessthan_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Show();
            second_check.Show();
        }

        private void moreorequalandlessorequal_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Show();
            second_check.Show();
        }

        private void lessthanandmorethan_CheckedChanged(object sender, EventArgs e)
        {
            check2_label.Show();
            second_check.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}

