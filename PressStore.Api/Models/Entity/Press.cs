using PressStore.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PressStore.Api.Models.Entity
{
    public class Press
    {
      
        public string pressID { get; set; }
        public string PressName { get; set; }
       
        public string Photo { get; set; }
        public decimal Price { get; set; }
        public ICollection<PressCompany> PressCompanies { get; set; }
        public ICollection<User> Users { get; set; }
        public Abonnement Abonnement { get; set; }
        public Order Order { get; set; }
        public DateTime date { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

       
    }
}
