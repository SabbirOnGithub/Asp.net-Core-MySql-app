using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class OwnerForCreationDto
    {
        [Required(ErrorMessage = "AccountType is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string AccountType { get; set; }

        [Required(ErrorMessage = "Date of Creation is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address cannot be loner then 100 characters")]
        public string Address { get; set; }
    }
}
