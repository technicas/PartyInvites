using System;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Plese enter your name")]
        public string Name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Plese enter your email address")]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Plese enter your phone number")]
        public string Phone
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Plese specify whether you'll attend")]
        public bool? WillAttend
        {
            get;
            set;
        }

        public GuestResponse()
        {

        }
    }
}
