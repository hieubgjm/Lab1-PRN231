﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects
{
    public class Products
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [StringLength(144)]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public required int CategoryId { get; set; }
        [Required]
        public int UnitsInStock { get; set;}
        [Required]
        public decimal UnitPrice { get; set; }
		public virtual Category Category { get; set; }
    }
}

