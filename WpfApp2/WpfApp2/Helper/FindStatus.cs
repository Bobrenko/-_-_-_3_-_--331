using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel;
using WpfApp2.Model;

namespace WpfApp2.Helper
{
    public class FindStatus
    {
        int id;
        public FindStatus(int id)
        {
            this.id = id;
        }
        public bool StatusPredicate(AStatus status)
        {
            return status.Id == id;
        }

    }
}
