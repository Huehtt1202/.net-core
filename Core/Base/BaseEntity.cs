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
        public T? Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? CreatorUserName {get; set; }
        public DateTime? CreationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? LastModifierUserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModificationTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? DeletedUserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeleteTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool? IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
    public class BaseEntity : BaseEntity<string>
    {
        [Key]
        string Id = Guid.NewGuid().ToString();

    }
}
