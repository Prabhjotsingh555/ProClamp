using System;
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

        [DataType(DataType.Date)]
        public DateTime Date { get; set; } // for date
        public string Type { get; set; }  // for product type
        public string Material { get; set; } // for material type
        public decimal WeightInLB { get; set; } //for weight
        public decimal Price { get; set; } // for price
        public decimal JawOpeningInInches { get; set; } // for jawopening capacity
        public string Application { get; set; } // for product apllication
    }
}
