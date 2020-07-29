using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PressStore.Api.Models.Entity
{
    public class Operation
    {
        public string OperatioId {get; set;}
        public string Montant { get; set; }
        public string typeoperation { get; set; }
        public  Order Order { get; set; }
        public 
        public  Abonnement Abonnement { get; set; }

        


        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
