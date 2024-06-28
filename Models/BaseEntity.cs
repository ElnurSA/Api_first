using System;
namespace API_First.Models
{
	public abstract class BaseEntity
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
	}
}

