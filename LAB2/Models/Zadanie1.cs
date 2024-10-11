using System.ComponentModel.DataAnnotations;

namespace Zadanie1.Models
{
    public class Calculation
    {
        [Required]
        [Display(Name = "Liczba 1")]
        public double Number1 { get; set; }

        [Required]
        [Display(Name = "Liczba 2")]
        public double Number2 { get; set; }

        public double Result { get; set; }

        public void Add()
        {
            Result = Number1 + Number2;
        }
    }
}