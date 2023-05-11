using System;
using System.ComponentModel.DataAnnotations;

namespace razorbooklist.Models
{
	public class Category
	{
		[Key]
		public object MyProperty { get; set; }
		[Required]
		public String  Name { get; set; }

		public int DisplayOrder { get; set; }

		public DateTime CreatedDateTime { get; set; } = DateTime.Now;

	}
}

