using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PressStore.Api.Models.Entity
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Orderprice { get; set; }
        public DateTime date { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
