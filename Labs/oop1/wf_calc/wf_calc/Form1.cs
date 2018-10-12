using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabSymbol_Click(object sender, EventArgs e)
        {

        }
        private void tabReplace_Click(object sender, EventArgs e)
        {

        }

        private void CalculateConcat_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ResultStringlbl.Text = String1txtb.Text + String2txtb.Text;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void calculateReplace_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ReplaceResult_lbl.Text = String_lbl.Text.Replace(replacedString_txtb.Text, newString_txtb.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void calculateRemove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                if (int.TryParse(count_txtb.Text, out count))
                {
                    if (int.Parse(index_cmb.Text) - 1 + count <= String_lbl.Text.Length)
                    {
                        removeResult_lbl.Text = String_lbl.Text.Remove(int.Parse(index_cmb.Text) - 1, count);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void calculateSymbol_btn_Click(object sender, EventArgs e)
        {
            try
            {
                symbol_lbl.Text = string2_lbl.Text[int.Parse(Indexcmb.Text)].ToString();
            }
          catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateLenght_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Resultlbl.Text = line_txtb.Text.Length.ToString();
            }            
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void DoublingVowels_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String str3 = "";
                    for (int i = 0; i < str1.Text.Length; i++)
                    {
                        str3 += str1.Text[i];
                        if (str1.Text[i] == 'a' || str1.Text[i] == 'e' || str1.Text[i] == 'y' || str1.Text[i] == 'u' || str1.Text[i] == 'i' ||
                           str1.Text[i] == 'o' || str1.Text[i] == 'у' || str1.Text[i] == 'е' || str1.Text[i] == 'ы' || str1.Text[i] == 'а' ||
                           str1.Text[i] == 'о' || str1.Text[i] == 'э' || str1.Text[i] == 'я' || str1.Text[i] == 'и' || str1.Text[i] == 'ю')
                        {
                            str3 += str1.Text[i];
                        }
                    }
                    result.Text = str3;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
