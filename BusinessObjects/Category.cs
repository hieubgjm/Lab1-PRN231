using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects
{
	public class Category
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CategoryID { get; set; }
		[Required]
		[StringLength(144)]
		public string CategoryName { get; set; }

		public virtual ICollection<Products> Products { get; set; }
	}
}

