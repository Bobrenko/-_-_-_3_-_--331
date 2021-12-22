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
    /// Логика взаимодействия для WindowStatus.xaml
    /// </summary>
    public partial class WindowStatus : Window
    {
        StatusViewModel vmStatus;
        public WindowStatus()
        {
            InitializeComponent();
            vmStatus = new StatusViewModel();
            Status.ItemsSource = vmStatus.ListStatus;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        { 
            
            
            WindowNewStatus wnRole = new WindowNewStatus
            {
                Title = "Новый статус",
                Owner = this
            };     

            int maxIdStatus = vmStatus.MaxId() + 1;
            AStatus status = new AStatus
            {
                Id = maxIdStatus
            };
            wnRole.DataContext = status;
            if (wnRole.ShowDialog() == true)
            {
                vmStatus.ListStatus.Add(status);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
           
            
            WindowNewStatus wnRole = new WindowNewStatus
            {
                Title = "Редактирование статуса",
                Owner = this
            };
            AStatus status = Status.SelectedItem as AStatus;
            if (status != null)
            {
                AStatus tempRole = status.ShallowCopy();
                wnRole.DataContext = tempRole;
                if (wnRole.ShowDialog() == true)
                {
                    // сохранение данных
                    status.Status = tempRole.Status;
                    Status.ItemsSource = null;
                    Status.ItemsSource = vmStatus.ListStatus;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать статус для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
           
            
            AStatus status = (AStatus)Status.SelectedItem;
            if (status != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по статусу: " +
                status.Status, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmStatus.ListStatus.Remove(status);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать статус для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
