using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Angular4DotNetWebAPI.Models.Students
{
    public class StudentVm
    {
        [Required(ErrorMessage="Plese Enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Plese Enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Plese Enter Email")]
        [RegularExpression(@"^[a-zA-Z0-9'._%+-]+@[a-zA-Z0-9-][a-zA-Z0-9.-]*\.[a-zA-Z]{2,9}$", ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Plese Enter Password")]
        public string Password { get; set; }
    }
}