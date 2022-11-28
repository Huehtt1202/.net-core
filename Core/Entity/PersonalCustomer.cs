using Core.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class PersonalCustomer : BaseEntity
    {
        public string? CustomerName { get; set; }
        public int? Numberphone { get; set; }
        public string BusinessSectorActivities { get; set; }
        public string NoteSummary { get; set; }
        public string SourceInformationCustomer { get; set; }
    }
}
