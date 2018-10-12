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
    /// Логика взаимодействия для Wizard.xaml
    /// </summary>
    public partial class Wizard : UserControl
    {
        public Wizard()
        {
            AbstractFactory.Warrior elf = new AbstractFactory.Warrior(new AbstractFactory.WizardFactory());
            elf.Hit();
            elf.Move();

            InitializeComponent();
            this.ToolTip = elf.protection.ToString();
        }
    }
}
