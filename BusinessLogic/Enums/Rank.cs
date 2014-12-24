using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Enums
{
	public enum Rank
	{
		[Display(Name = "-Select Rank-")]
		Default,
		One,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King,
		Ace
	}
}