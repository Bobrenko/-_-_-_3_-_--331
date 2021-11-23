using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    public class PersonViewModel
    {
        public ObservableCollection<Person> ListPerson { get; set; } = new ObservableCollection<Person>();
        public PersonViewModel()
        {
            this.ListPerson.Add(
                new Person
                {
                    Id = 1,
                    Shifer = 7890012,
                    Inn = 770013009,
                    Type = "Физическое лицо",
                    Data = new DateTime(2011, 01, 11),
                });
            this.ListPerson.Add(
                new Person
                {
                    Id = 2,
                    Shifer = 3409125,
                    Inn = 886908659,
                    Type = "Юридическое лицо",
                    Data = new DateTime(2012, 02, 20),
                });
            this.ListPerson.Add(
                new Person
                {
                    Id = 3,
                    Shifer = 1209763,
                    Inn = 244789082,
                    Type = "Юридическое лицо",
                    Data = new DateTime(2013, 01, 09),
                });
            this.ListPerson.Add(
                new Person
                {
                    Id = 4,
                    Shifer = 2856480,
                    Inn = 899809832,
                    Type = "Физическое лицо",
                    Data = new DateTime(2011, 03, 20),
                });
        }
    }
}
