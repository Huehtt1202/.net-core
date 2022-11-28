using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    public class BaseEntity<T> : IBaseEntity<T>
    {
        public T? Id { get; set; }
        public string? CreatorUserName {get; set; }
        public DateTime? CreationTime { get; set; }
        public string? LastModifierUserName { get; set; }
        public DateTime? ModificationTime { get; set; }
        public string? DeletedUserName { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
    public class BaseEntity : BaseEntity<string>
    {
        [Key]
        string Id = Guid.NewGuid().ToString();

    }
}
