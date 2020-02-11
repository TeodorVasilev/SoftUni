namespace MortalEngines.Models
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Fighter : BaseMachine, IFighter
    {
        private const double DefaultInitialHealthPoints = 200;
        private const bool DefaultAggressiveMode = true;

        private bool aggressiveMode;

        public Fighter(string name, double attackPoints, double defencePoints) 
            : base(name, attackPoints, defencePoints, DefaultInitialHealthPoints)
        {
            this.AggressiveMode = DefaultAggressiveMode;
        }
        //TODO: not sure test
        public bool AggressiveMode
        {
            get => this.aggressiveMode;

            private set
            {
                this.aggressiveMode = value;

                if(this.aggressiveMode == true)
                {
                    this.AttackPoints += 50;
                    this.DefensePoints -= 25;
                }
                else
                {
                    this.AttackPoints -= 50;
                    this.DefensePoints += 25;
                }
            }
        }

        public string AggressiveModeToString()
        {
            if(this.AggressiveMode)
            {
                return "ON";
            }

            return "OFF";
        }
        //Try another way to change points when switching modes
        public void ToggleAggressiveMode()
        {
            if(this.aggressiveMode == true)
            {
                this.aggressiveMode = false;

                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
            else
            {
                this.aggressiveMode = true;

                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.AggressiveMode)
            {
                sb.AppendLine($" *Aggressive: ON");
            }
            else
            {
                sb.AppendLine($" *Aggressive: OFF");
            }

            return base.ToString() + sb.ToString();
        }
    }
}
