using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PressStore.Api.Models.Entity
{
    public class PressCompany
    {

        public string pressCompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Categorie { get; set; }
        public virtual ICollection<PressCompanyRedactor> PressCompanyReadactors { get; set; }
        public virtual Favoris favoris { get; set; }
        public virtual Press Press { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
