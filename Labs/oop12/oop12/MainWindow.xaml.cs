using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oop12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Boss boss = new Boss() { Width=60, Height=60 };
            Field.Children.Add(boss);

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateDialog createDialog = new CreateDialog();
                createDialog.ShowDialog();

                if (createDialog.WarriorType.SelectedIndex == 0)
                {
                    for (int i = 0; i < createDialog.WarriorCount.SelectedIndex + 1; i++)
                    {
                        Field.Children.Add(new Berserk() { Height = 60, Width = 60 });
                    }

                }
                else
                {
                    for (int i = 0; i < createDialog.WarriorCount.SelectedIndex + 1; i++)
                    {
                        Field.Children.Add(new Wizard() { Height = 60, Width = 60 });
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }       
    }
}
