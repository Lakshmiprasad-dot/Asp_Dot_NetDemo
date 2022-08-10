﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FoodCourt.Web.Models
{
    [Table(name: "Customers Details")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        virtual public string CustomerName { get; set; }

        public virtual long CustomerPhone { get; set; }

        public virtual string Address { get; set; }

        

    }

}
