using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.ViewModel;
using WpfApp2.Model;

namespace WpfApp2.Helper
{
    public class FindType
    {
        int id;
        public FindType(int id)
        {
            this.id = id;
        }
        public bool TypePredicate(AType type)
        {
            return type.Id == id;
        }
    }
}
