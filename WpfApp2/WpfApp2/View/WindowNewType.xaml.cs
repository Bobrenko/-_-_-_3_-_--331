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
using System.Windows.Shapes;
using WpfApp2.View;
using WpfApp2.ViewModel;
using System.Collections.ObjectModel;
using WpfApp2.Model;
using WpfApp2.Helper;

namespace WpfApp2.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewType.xaml
    /// </summary>
    public partial class WindowNewType : Window
    {
        public WindowNewType()
        {
            InitializeComponent();
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

    }
}
