using ProjectAriel.Enums;
using System.ComponentModel.DataAnnotations;

namespace ProjectAriel.Models
{
	public class Card
	{
		[Required]
		public string Name { get; set; }
		public int ID { get; set; }
		public string Description { get; set; }
		[Display(Name = "Type")]
		public CardType Cardtype { get; set; }
		public Suit Suit { get; set; }
		public Rank Rank { get; set; }
		[Display(Name = "Image Location")]
		public string ImageLocation { get; set; }

		[Display(Name = "Active")]
		public bool IsActive { get; set; }
	}
}