namespace MuOnline.Models.Monsters
{
    public class Crypta : Monster
    {
        private const int attackPoints = 10;
        private const int vitalityPoints = 10;

        public Crypta() 
            : base(attackPoints, vitalityPoints)
        {
        }
    }
}
