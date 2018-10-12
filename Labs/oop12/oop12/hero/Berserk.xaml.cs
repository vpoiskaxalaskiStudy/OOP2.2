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
    /// Логика взаимодействия для Berserk.xaml
    /// </summary>
    public partial class Berserk : UserControl
    {
        public Berserk()
        {
            AbstractFactory.Warrior berserk = new AbstractFactory.Warrior(new AbstractFactory.BerserkFactory());
            berserk.Hit();
            berserk.Move();

            InitializeComponent();
            this.ToolTip = berserk.protection.ToString();

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    AbstractFactory.IPrototype item = new AbstractFactory.Warrior(new AbstractFactory.BerserkFactory());
        //    AbstractFactory.IPrototype clonedItem = item.Clone();
        //}
    }
}
