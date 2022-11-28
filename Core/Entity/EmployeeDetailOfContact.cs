using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public partial class EmployeeDetailOfContact : BaseEntity
    {
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public virtual Employee Employee { get; set; }
        public string? ContractId { get; set; }
        public virtual Contract Contract  { get; set; }
        public double? PercentageValue { get; set; } // mô tả giá trị (%) mà nhân viên đó được hưởng theo hợp đồng
        public double? ValueOfContract { get; set; }
        public double? Value { get { return (ValueOfContract * PercentageValue / 100); } }
    }
}
