namespace MuOnline.Models.Items.Sets.ElfSets.BuffSet
{
	public class BuffPants : Item
	{
		private const int strengthPoints = 10;
		private const int agilityPoints = 13;
		private const int energyPoints = 20;
		private const int staminaPoints = 5;

		public BuffPants()
			: base(strengthPoints, agilityPoints, energyPoints, staminaPoints)
		{
		}
	}
}
