using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class BusinessCustomer : BaseEntity
    {
        public string? CompanyName { get; set; }
        public string TaxCode { get; set; }
        public int? Hotline { get; set; }
        public string? BusinessSectorActivities { get; set; }
        public string LegalRepresentative { get; set; }
        public string PersonToContact { get; set; } //The person is contacted to counseling service
        public int Numberphone { get; set; }
        public string SourceInformationCustomer { get; set; }
    }
}
