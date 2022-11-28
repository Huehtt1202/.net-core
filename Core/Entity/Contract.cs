using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Contract : BaseEntity
    {
        public string? PartnerId { get; set; }
        public virtual ICollection<PersonalCustomer> PersonalCustomer { get; set; }  
        public virtual ICollection<BusinessCustomer> BusinessCustomer { get; set; }
        public int? ServiceCount { get; set; }
        public double? TotalValue { get; set; }
        public double? VAT { get; set; }
        public double? FinallyValue { get; set; }
        public virtual Service Service { get; set; }
        public DateTime ? StartTime { get; set; }
    }
}
