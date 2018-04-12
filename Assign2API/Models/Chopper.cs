using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assign2API.Models
{
    [Table("Chopper")]
    public class Chopper
    {
        [Key]
        public int ChopperId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal price { get; set; }
    }
}
