using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class AStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public AStatus() { }
        public AStatus(int id, string status)
        {
            this.Id = id;
            this.Status = status;
        }
    }
}
