using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class Person
    {
        public int Id { get; set; }
        public int Shifer { get; set; }
        public int Inn { get; set; }
        public string Type { get; set; }
        public DateTime Data { get; set; }
        public Person() { }
        public Person(int id, int shifer, int inn,
        string type, DateTime data)
        {
            this.Id = id;
            this.Shifer = shifer;
            this.Inn = inn;
            this.Type = type;
            this.Data = data;
        }
    }
}
