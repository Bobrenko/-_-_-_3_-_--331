using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel;
using WpfApp2.Model;

namespace WpfApp2.Helper
{
    public class FindPerson
    {
        int id;
        public FindPerson(int id)
        {
            this.id = id;
        }
        public bool PersonPredicate(Person shifer)
        {
            return shifer.Id == id;
        }
    }
}
