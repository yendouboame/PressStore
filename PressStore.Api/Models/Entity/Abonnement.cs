using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PressStore.Api.Models.Entity
{
    public class Abonnement
    {
        public string Id { get; set; }
        
        
        public string TypeAbonement { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Press> Presses { get; set; }
        public virtual ICollection<User> Users { get; set; }


        public virtual ICollection<Operation> Operations { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
