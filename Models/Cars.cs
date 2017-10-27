using System;
using System.ComponentModel.DataAnnotations;

namespace SPVT.Models
{
    public class Cars
    {
        public int Id { get; set; }

       
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public int Year { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Make { get; set; }

        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Model { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }

        [Display(Name=" License Plate")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string licensePlate { get; set; }

        
    }
}