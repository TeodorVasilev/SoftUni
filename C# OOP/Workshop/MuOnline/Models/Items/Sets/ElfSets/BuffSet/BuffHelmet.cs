namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
	public class BuffHelmet : Item
	{
		private const int strengthPoints = 23;
		private const int agilityPoints = 15;
		private const int energyPoints = 5;
		private const int staminaPoints = 5;

		public BuffHelmet()
			: base(strengthPoints, agilityPoints, energyPoints, staminaPoints)
		{
		}
	}
}
