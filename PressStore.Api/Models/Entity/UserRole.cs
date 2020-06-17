using Microsoft.AspNetCore.Identity;
using PressStore.Api.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PressStore.Api.Models.Entity
{
    public class UserRole : IdentityUserRole<string>, IBaseEntity
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }

}
