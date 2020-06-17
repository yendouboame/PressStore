using PressStore.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PressStore.Api.Models.Entity
{
    public class Press
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string PressName { get; set; }

        [Required]
        public DateTime PressDate { get; set; }

        [Required]
        public ImageFormatLimitationException Photo { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
