using System.ComponentModel.DataAnnotations;
namespace ProjectAriel.Enums
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