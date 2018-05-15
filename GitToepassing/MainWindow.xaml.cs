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

namespace GitToepassing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToonBerichten_Click(object sender, RoutedEventArgs e)
        {
            lstBerichten.Items.Add("Welkom !");
            lstBerichten.Items.Add("Welcome !");
            lstBerichten.Items.Add("Bienvenue !");
            lstBerichten.Items.Add("Wilcommen !");
            lstBerichten.Items.Add("Benvenuto !");
            lstBerichten.Items.Add("Welgekomen !");
        }
    }
}
