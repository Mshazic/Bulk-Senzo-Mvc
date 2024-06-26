using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Name")]
		[MaxLength(30)]
		public required string Name { get; set; }
        [DisplayName("DisplayOrder")]
		[Range(1,100,ErrorMessage ="Display Order must be between 1-100" )]
        public int DisplayOrder { get; set; }
	}
}

