using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    public interface IBaseEntity <T>
    {
        T? Id { get; set; }
        string? CreatorUserName { get; set; }
        DateTime? CreationTime { get; set; }
        string? LastModifierUserName { get; set; }
        DateTime? ModificationTime { get; set; }
        string? DeletedUserName { get; set; }
        DateTime? DeleteTime { get; set; }
        bool? IsDeleted { get; set; }
    }
}
