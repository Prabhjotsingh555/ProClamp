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

        [StringLength(60, MinimumLength = 3)] //add for regular expression, length and required
        [Required]
        public string Name { get; set; } //for product name
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //add for regular expression, length and required
        [Required]
        [StringLength(30)]
        public string Type { get; set; }  // for product type

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //add for regular expression, length and required
        [Required]
        [StringLength(30)]
        public string Material { get; set; } // for material type

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")] //add for regular expression, length and required
        [Required]
        [StringLength(30)]
        public string Application { get; set; } // for product apllication

        [Column(TypeName = "decimal(18, 2)")]
        [Range(0.0, 5.0, ErrorMessage = "The value must be between 0.1 and 5.0")]
        public decimal Rating { get; set; } // new rating field i added in eighth step     

        [Display(Name = "Weight In LB")] //add for regular expression, length and required
        [Column(TypeName = "decimal(18, 2)")]
        public decimal WeightInLB { get; set; } //for weight

        [Column(TypeName = "decimal(18, 2)")] //add for data annotation attribute
        public decimal Price { get; set; } // for price

        [Display(Name = "JawOpening In Inches")] //add for regular expression, length and required
        [Column(TypeName = "decimal(18, 2)")]
        public decimal JawOpeningInInches { get; set; } // for jawopening capacity

        [Display(Name = "Release Date")] //add for data annotation attribute
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } // for date

    }
}
