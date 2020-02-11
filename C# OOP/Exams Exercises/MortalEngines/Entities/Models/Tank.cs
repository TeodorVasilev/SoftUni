namespace MortalEngines.Models
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tank : BaseMachine, ITank
    {
        private const double DefaultInitialHealthPoints = 100;
        private const bool DefaultDefenseMode = true;

        private bool defenseMode;

        public Tank(string name, double attackPoints, double defencePoints) 
            : base(name, attackPoints, defencePoints, DefaultInitialHealthPoints)
        {
            this.DefenseMode = DefaultDefenseMode;
        }

        public bool DefenseMode
        {
            get => this.defenseMode;

            private set
            {
                this.defenseMode = value;

                if (this.defenseMode == true)
                {
                    this.AttackPoints -= 40;
                    this.DefensePoints += 30;
                }
                else
                {
                    this.AttackPoints += 40;
                    this.DefensePoints -= 30;
                }
            }   
        }
        //Try another way to change points when switching modes
        public void ToggleDefenseMode()
        {
            if (this.defenseMode == true)
            {
                this.defenseMode = false;

                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
            else
            {
                this.defenseMode = true;

                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.DefenseMode)
            {
                sb.AppendLine($" *Defense: ON");
            }
            else
            {
                sb.AppendLine($" *Defense: OFF");
            }

            return base.ToString() + sb.ToString();
        }
    }
}
