using System;
using System.ComponentModel.DataAnnotations;

namespace API_First.Models
{
	public class City : BaseEntity
	{
		[Required]
		public string Name { get; set; }
	}
}

