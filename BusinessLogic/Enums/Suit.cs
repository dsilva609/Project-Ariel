using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Enums
{
	public enum Suit
	{
		[Display(Name = "-Select Suit-")]
		Default,
		Heart,
		Diamond,
		Club,
		Spade
	}
}