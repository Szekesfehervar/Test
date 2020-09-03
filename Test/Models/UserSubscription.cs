using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class UserSubscription
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Jmeno { get; set; }
        [Required]
        public string Prijmeni { get; set; }
        
    }
}
