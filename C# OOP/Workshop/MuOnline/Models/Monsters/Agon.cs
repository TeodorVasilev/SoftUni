namespace MuOnline.Models.Monsters
{
    public class Agon : Monster
    {
        private const int attackPoints = 20;
        private const int vitalityPoints = 50;

        public Agon() 
            : base(attackPoints, vitalityPoints)
        {
        }
    }
}
