using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeleProducts.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Desc { get; set; }
        [MaxLength]
        public string imageURl { get; set; }
        public bool Status { get; set; }

    }
}
