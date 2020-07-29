using Microsoft.AspNetCore.Identity;
using PressStore.Api.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressStore.Api.Models.Entity
{
    public class User:IdentityUser,IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Flooz { get; set; }
        public string Tmoney { get; set; }

        public bool IsBanned { get; set; }
        public bool IsActived { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<PressCompanyRedactor> PressCompanyRedactors { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> UserLogins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> UserTokens { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> UserClaims { get; set; }

        public  Abonnement Abonnement { get; set; }
        public  Favoris Favoris { get; set; }
        public  Press Press { get; set; }
        public  Order Order { get; set; }

        public DateTime CreatedAt { get ; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
