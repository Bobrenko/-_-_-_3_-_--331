using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp2.Model;


namespace WpfApp2.ViewModel
{
    public class AgreementViewModel
    {
        public ObservableCollection<Agreement> ListAgreement { get; set; } = new ObservableCollection<Agreement>();
        public AgreementViewModel()
        {
            this.ListAgreement.Add(
                new Agreement
                {
                    Id = 1,
                    PersonId = 1,
                    TypeId = 1,
                    StatusId = 1,
                    Number = 3455334,
                    DataOpen = new DateTime(2012, 02, 12),
                    DataClose = new DateTime(2013, 04, 24)
                });
            this.ListAgreement.Add(
                new Agreement
                {
                    Id = 2,
                    PersonId = 2,
                    TypeId = 2,
                    StatusId = 1,
                    Number = 2679823,
                    DataOpen = new DateTime(2013, 03, 21),
                    DataClose = new DateTime(2013, 08, 15)
                });
            this.ListAgreement.Add(
                new Agreement
                {
                    Id = 3,
                    PersonId = 3,
                    TypeId = 3,
                    StatusId = 2,
                    Number = 9801234,
                    DataOpen = new DateTime(2012, 06, 11),
                    DataClose = new DateTime(2015, 07, 22)
                });
            this.ListAgreement.Add(
                new Agreement
                {
                    Id = 4,
                    PersonId = 4,
                    TypeId = 3,
                    StatusId = 1,
                    Number = 2736649,
                    DataOpen = new DateTime(2014, 09, 30),
                    DataClose = new DateTime(2015, 12, 27)
                });
        }
    }
}
