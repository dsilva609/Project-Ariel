using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessLogic.Models
{
	public class Player
	{
		[Required]
		public string Name { get; set; }
		public int ID { get; set; }
		[Display(Name = "Active")]
		public bool IsActive { get; set; }
	}
}