using System.ComponentModel.DataAnnotations;

namespace ProjectAriel.Models
{
	public class Card
	{
		[Required]
		public string Name { get; set; }
		public int ID { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public char Suit { get; set; }
		public char Rank { get; set; }
		public string ImageLocation { get; set; }

		[Display(Name = "Active")]
		public bool IsActive { get; set; }
	}
}