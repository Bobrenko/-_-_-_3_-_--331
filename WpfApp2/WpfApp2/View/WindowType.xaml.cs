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
    /// Логика взаимодействия для WindowType.xaml
    /// </summary>
    public partial class WindowType : Window
    {
        TypeViewModel vmType;
        public WindowType()
        {
            InitializeComponent();
            vmType = new TypeViewModel();
            IvType.ItemsSource = vmType.ListType;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
    
            WindowNewType wnRole = new WindowNewType
            {
                Title = "Новый тип",
                Owner = this
            };
            // формирование кода новой должности
            int maxIdType = vmType.MaxId() + 1;
            AType role = new AType
            {
                Id = maxIdType
            };
            wnRole.DataContext = role;
            if (wnRole.ShowDialog() == true)
            {
                vmType.ListType.Add(role);
            }
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            
            WindowNewType wnRole = new WindowNewType
            {
                Title = "Редактирование типа",
                Owner = this
            };
            AType role = IvType.SelectedItem as AType;
            if (role != null)
            {
                AType tempRole = role.ShallowCopy();
                wnRole.DataContext = tempRole;
                if (wnRole.ShowDialog() == true)
                {
                    // сохранение данных
                    role.NameType = tempRole.NameType;
                    IvType.ItemsSource = null;
                    IvType.ItemsSource = vmType.ListType;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            
            AType role = (AType)IvType.SelectedItem;
            if (role != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по типу: " +
                role.NameType, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmType.ListType.Remove(role);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
