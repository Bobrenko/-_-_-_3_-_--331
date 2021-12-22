using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class AType
    {
        public int Id { get; set; }
        public string NameType { get; set; }
        public AType() { }
        public AType(int id, string type1)
        {
            this.Id = id;
            this.NameType = type1;
        }
        public AType ShallowCopy()
        {
            return (AType)this.MemberwiseClone();
        }
    }
}
