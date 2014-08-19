using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectAriel.Models
{
	public class Player
	{
		[Required]
		public string Name { get; set; }
		public int ID { get; set; }
		public bool IsActive { get; set; }
	}
}