using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCEntity.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Created Date")]
        public DateTime DateCreated { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}