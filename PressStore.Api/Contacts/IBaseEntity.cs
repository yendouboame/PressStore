using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressStore.Api.Contacts
{
    public interface IBaseEntity
    {
       
        string Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime DeletedAt { get; set; }
    }
}
