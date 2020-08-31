using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebPomiar.Models
{
    public class Message
    {

        [Key]
        public int MessageId { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string FirstName { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Email { get; set; }


        [Display(Name = "Treść wiadomości")]
        [Required(ErrorMessage = "To pole jest wymagane")]
        public string Text { get; set; }

        }



}