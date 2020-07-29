using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressStore.Api.Models.Entity
{
    public class Favoris
    {
        public string Id { get; set; }
        public int TotalFavoris { get; set; }

        public virtual ICollection<PressCompany> pressCompanies { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
