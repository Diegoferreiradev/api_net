using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiNet.Models
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [MaxLength(50, ErrorMessage = "The name field supports only {1} characters")]
        public string Name { get; set; }

        [MaxLength(80, ErrorMessage = "The name field supports only {1} characters")]
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
