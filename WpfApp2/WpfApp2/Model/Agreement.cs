using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class Agreement
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        public int Number { get; set; }
        public DateTime DataOpen { get; set; }
        public DateTime DataClose { get; set; }
        public Agreement() { }
        public Agreement(int id, int perid, int typeid,
        int statusid, int number, DateTime dopen, DateTime dclose)
        {
            this.Id = id;
            this.PersonId = perid;
            this.TypeId = typeid;
            this.StatusId = statusid;
            this.Number = number;
            this.DataOpen = dopen;
            this.DataClose = dclose;
        }
    }
}
