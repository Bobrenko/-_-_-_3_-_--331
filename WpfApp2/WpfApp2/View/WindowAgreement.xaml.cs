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
    /// Логика взаимодействия для WindowAgreement.xaml
    /// </summary>
    public partial class WindowAgreement : Window
    {
        public WindowAgreement()
        {
            InitializeComponent();
            AgreementViewModel vmAgreement = new AgreementViewModel();
            StatusViewModel vmStatus = new StatusViewModel();
            TypeViewModel vmType = new TypeViewModel();
            PersonViewModel vmPerson = new PersonViewModel();
            List<AStatus> status = new List<AStatus>();
            List<AType> type = new List<AType>();
            List<Person> person = new List<Person>();
            foreach (AStatus r in vmStatus.ListStatus)
            {
                status.Add(r);
                
            }
            foreach (AType r in vmType.ListType)
            {
                type.Add(r);

            }
            foreach (Person r in vmPerson.ListPerson)
            {
                person.Add(r);

            }
            ObservableCollection<AgreementDPO> agreements = new ObservableCollection<AgreementDPO>();
            FindStatus finders;
            FindType findert;
            FindPerson finderp;
            foreach (var p in vmAgreement.ListAgreement)
            {
                finders = new FindStatus(p.StatusId);
                findert = new FindType(p.TypeId);
                finderp = new FindPerson(p.PersonId);
                AStatus stat = status.Find(new Predicate<AStatus>(finders.StatusPredicate));
                AType typ = type.Find(new Predicate<AType>(findert.TypePredicate));
                Person per = person.Find(new Predicate<Person>(finderp.PersonPredicate));
                agreements.Add(new AgreementDPO
                {
                    Id = p.Id,
                    PersonId = per.Shifer,
                    TypeId = typ.Type,
                    StatusId = stat.Status,
                    Number = p.Number,
                    DataOpen = p.DataOpen,
                    DataClose = p.DataClose
                });
            }
            Agreement.ItemsSource = agreements;
        }
    }
}
