using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    public class TypeViewModel
    {
        public ObservableCollection<AType> ListType { get; set; } = new ObservableCollection<AType>();
        public TypeViewModel()
        {
            this.ListType.Add(
                new AType
                {
                    Id = 1,
                    NameType = "Дилерский",
                });
            this.ListType.Add(
                new AType
                {
                    Id = 2,
                    NameType = "Брокерский",
                });
            this.ListType.Add(
                new AType
                {
                    Id = 3,
                    NameType = "Управление",
                }); 
        }
        /// <summary>
        /// Нахождение максимального Id
        /// </summary>
        /// <returns></returns>
        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListType)
            {
                if (max < r.Id)
                {
                    max = r.Id;
                };
            }
            return max;
        }
    }
}
