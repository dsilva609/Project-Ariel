namespace UI.Models
{
	public class CardViewModel
	{
		public string Name { get; set; }

		public int ID { get; set; }

		public string Description { get; set; }

		//	public Expansion Expansion { get; set; }
		//needs display name
		public string ExpansionString { get; set; }

		//needs display name

		public string CardTypeString { get; set; }

		public bool IsActive { get; set; }

		public string ViewTitle { get; set; }
	}
}