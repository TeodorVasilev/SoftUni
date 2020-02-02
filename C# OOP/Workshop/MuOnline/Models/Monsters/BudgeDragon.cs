namespace MuOnline.Models.Monsters
{
    public class BudgeDragon : Monster
    {
        private const int attackPoints = 20;
        private const int vitalityPoints = 50;

        public BudgeDragon()
            : base(attackPoints, vitalityPoints)
        {
        }
    }
}
