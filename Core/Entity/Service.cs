using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Service : BaseEntity
    {
        public string? ServiceName { get; set; }
        public string Summary { get; set; }
        public double? Price { get; set; }
    }
}
