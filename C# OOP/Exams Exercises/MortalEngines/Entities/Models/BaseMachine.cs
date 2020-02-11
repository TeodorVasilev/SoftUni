namespace MortalEngines.Models
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;
        private readonly IList<string> targets;
        private double healthPoints;
        private double attackPoints;
        private double defencePoints;

        public BaseMachine(string name, double attackPoints, double defencePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot 
        { 
            get => this.pilot; 
          
            set
            {
                if(value == null)
                {
                    throw new NullReferenceException("Pilot cannot be null.");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get => this.healthPoints;

            set => this.healthPoints = value;
        }

        public double AttackPoints
        {
            get => this.attackPoints;

            internal set => this.attackPoints = value;
        }

        public double DefensePoints
        {
            get => this.defencePoints;

            internal set => this.defencePoints = value;
        }

        public IList<string> Targets
        {
            get => this.targets;
        }

        public void Attack(IMachine target)
        {
            if(target == null)
            {
                throw new NullReferenceException("Target cannot be null");
            }

            double damagePoints = Math.Abs(this.AttackPoints - target.DefensePoints);

            target.HealthPoints -= damagePoints;

            if(target.HealthPoints < 0)
            {
                target.HealthPoints = 0;
            }

            this.Targets.Add(target.Name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints}");
            sb.AppendLine($" *Attack: {this.AttackPoints}");
            sb.AppendLine($" *Defence: {this.DefensePoints}");

            if(this.Targets.Count == 0)
            {
                sb.AppendLine(" *Targets: None");
            }
            else
            {
                sb.AppendLine($" *Targets: {string.Join(" ", this.Targets)}");
            }

            return sb.ToString();
        }
    }
}
