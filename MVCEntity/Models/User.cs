using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEntity.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-zА-Яа-я]+[А-Яа-яa-zA-Z""'\s-]*$", ErrorMessage = "First name must contain only letters")]
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}