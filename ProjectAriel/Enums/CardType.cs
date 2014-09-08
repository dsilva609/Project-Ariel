using System.ComponentModel.DataAnnotations;
namespace ProjectAriel.Enums
{
	public enum CardType
	{
		[Display(Name = "-Select Card Type-")]
		Default,
		Basic,
		Alcohol,
		Draw,
		[Display(Name = "Time Delay")]
		TimeDelay,
		Weapon,
		Equipment,
		[Display(Name = "Target All")]
		TargetAll,
		Role,
		Event
	}
}