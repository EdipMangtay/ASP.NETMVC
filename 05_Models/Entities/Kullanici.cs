using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _05_Models.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }

        [Required,DataType(DataType.EmailAddress)] //Attribute
        public string Email { get; set; }

        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required,StringLength(30)]
        public string FirstName { get; set; }
        
        [Required, StringLength(30)]
        public string LastName { get; set; }
        
        [Required,StringLength(200)]
        public string Address { get; set; }
        
        [Required,StringLength(11)]
        public string Phone { get; set; }
    }
}