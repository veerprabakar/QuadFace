using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QuadFace.Models
{
    public class SampleData
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 40 characters.")]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataOfBirth { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }
    }
}