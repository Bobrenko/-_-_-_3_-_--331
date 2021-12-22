using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    public class StatusViewModel
    {
        public ObservableCollection<AStatus> ListStatus { get; set; } = new ObservableCollection<AStatus>();
        public StatusViewModel()
        {
            this.ListStatus.Add(
                new AStatus
                {
                    Id = 1,
                    Status = "Действует",
                });
            this.ListStatus.Add(
                new AStatus
                {
                    Id = 2,
                    Status = "Блокирован",
                }); 
        }
        /// <summary>
        /// Нахождение максимального Id
        /// </summary>
        /// <returns></returns>
        public int MaxId()
        {
            int max = 0;
            foreach (var r in this.ListStatus)
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
