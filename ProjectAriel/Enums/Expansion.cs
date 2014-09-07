using System.ComponentModel.DataAnnotations;

namespace ProjectAriel.Enums
{
	public enum Expansion
	{
		[Display(Name = "-Select Expansion-")]
		Default,
		Standard,
		[Display(Name = "High Noon")]
		HighNoon,
		[Display(Name = "Dodge City")]
		DodgeCity,
		[Display(Name = "A Fistful Of Cards")]
		AFistfulOfCards,
		[Display(Name = "Wild West Show")]
		WildWestShow,
		[Display(Name = "Gold Rush")]
		GoldRush,
		[Display(Name = "Valley Of Shadows")]
		ValleyOfShadows,
		[Display(Name = "El Dorado")]
		ElDorado,
		[Display(Name = "Death Mesa")]
		DeathMesa,
		[Display(Name = "Robber's Roost")]
		RobbersRoost
	}
}