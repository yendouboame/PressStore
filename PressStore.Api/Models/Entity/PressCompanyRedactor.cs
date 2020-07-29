using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressStore.Api.Models.Entity
{
    public class PressCompanyRedactor
    {
        public string Id { get; set; }
        public DateTime date { get; set; }
        public virtual User User { get; set; }
        public virtual PressCompany PressCompany { get; set; }
       

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
