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
using WpfApp2.View;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Agreement_OnClick(object sender, RoutedEventArgs e)
        {
            WindowAgreement wAgreement = new WindowAgreement();
            wAgreement.Show();
        }
        private void Person_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPerson wPerson = new WindowPerson();
            wPerson.Show();
        }
        private void Status_OnClick(object sender, RoutedEventArgs e)
        {
            WindowStatus wStatus = new WindowStatus();
            wStatus.Show();
        }
        private void Type_OnClick(object sender, RoutedEventArgs e)
        {
            WindowType wType = new WindowType();
            wType.Show();
        }
    }
}
