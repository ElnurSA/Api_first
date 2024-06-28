using System;
using System.ComponentModel.DataAnnotations;

namespace API_First.Models
{
	public class Category : BaseEntity
	{
		[Required(ErrorMessage ="Cannot be empty")]
		public string Name { get; set; }

	}
}



