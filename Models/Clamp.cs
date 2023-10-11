using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProClamp.Models
{
    public class Clamp
    {
        public int ID { get; set; } //for id

        public string Name { get; set; } //for product name

        [Display(Name = "Release Date")] //add for data annotation attribute
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } // for date
        public string Type { get; set; }  // for product type
        public string Material { get; set; } // for material type

        [Column(TypeName = "decimal(18, 2)")]
        public decimal WeightInLB { get; set; } //for weight

        [Column(TypeName = "decimal(18, 2)")] //add for data annotation attribute
        public decimal Price { get; set; } // for price

        [Column(TypeName = "decimal(18, 2)")]
        public decimal JawOpeningInInches { get; set; } // for jawopening capacity
        public string Application { get; set; } // for product apllication
        public string Rating { get; set; } // new rating field i added in eighth step
    }
}
