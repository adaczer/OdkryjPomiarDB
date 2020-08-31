using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPomiar.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Display(Name ="Imię")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string FirstName { get; set; }

        [Display(Name ="Nazwisko")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string LastName { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Email { get; set; }

        [Display(Name ="Pakiet")]
        public int Package { get; set; }


    }


    //public enum Package
    //{
    //    Smart = 1,
    //    Professional = 2,
    //    Gold = 3
    //}
}