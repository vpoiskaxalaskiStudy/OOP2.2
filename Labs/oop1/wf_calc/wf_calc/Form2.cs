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
    public partial class Form2 : Form
    {
        int[] array;
        private delegate void Comparator();
        bool flag = false;
        Comparator comparator;

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Generation_Click(object sender, EventArgs e)
        {
            try
            {
                int collectionSize = int.Parse(CollectionSize.Text);
                array = new int[collectionSize];
                Random random = new Random();

                for (int i = 0; i < collectionSize; i++)
                {
                    array[i] = random.Next(0, 500);
                    screen1.Text += array[i].ToString() + "\r\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Sort()
        {
            if(flag == false)
            {
                screen2.Text += "Сортировка по возрастанию: \r\n";

                try
                {
                    var orderArray = array.OrderBy(i => i);

                    foreach (int item in orderArray)
                    {
                        screen2.Text += item + "\r\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                screen2.Text += "Сортировка по убыванию: \r\n";
                try
                {
                    var orderArray = array.OrderByDescending(i => i);

                    foreach (int item in orderArray)
                    {
                        screen2.Text += item + "\r\n";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SortByOder_Click(object sender, EventArgs e)
        {
            flag = false;
            comparator = Sort;
            comparator();
        }

        private void SortByDescending_Click(object sender, EventArgs e)
        {
            flag = true;
            comparator = Sort;
            comparator();
        }

        private void Max_Click(object sender, EventArgs e)
        {
            try
            {
                var maxItem = array.Max();

                screen2.Text = "Максимальный элемент: " + maxItem.ToString() + "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Odd_Click(object sender, EventArgs e)
        {
            try
            {
                screen2.Text = "Чётные элементы: " + "\r\n";
                var oddArray = array.Where(i => i%2==0);

                foreach (int item in oddArray)
                {
                    screen2.Text += item + "\r\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Average_Click(object sender, EventArgs e)
        {
            try
            {
                var maxItem = array.Average();

                screen2.Text = "Среднее арифметическое: " + maxItem.ToString() + "\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
