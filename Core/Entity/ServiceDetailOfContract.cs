using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public partial class ServiceDetailOfContract : BaseEntity
    {
        public string? ContractId { get; set; }
        public virtual Contract Contract { get; set; }
        public string? ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public double? ServicePrice { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime ? EndDate { get; set; }
        public virtual Service Service { get; set; }
        public int ? ActiveTimeService { get; set; }
        public double ? Discount { get; set; }
        public double ? TotalValue { get; set; }


    }
}
