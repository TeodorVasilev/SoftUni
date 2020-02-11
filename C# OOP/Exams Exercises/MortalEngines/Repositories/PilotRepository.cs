namespace MortalEngines.Repositories
{
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PilotRepository : IRepository<IPilot>
    {
        private readonly List<IPilot> pilots;

        public PilotRepository()
        {
            this.pilots = new List<IPilot>();
        }

        public IReadOnlyCollection<IPilot> Repository
            => this.pilots.AsReadOnly();

        public void Add(IPilot pilot)
        {
            if(pilot == null)
            {
                throw new NullReferenceException("Pilot cannot be null");
            }

            this.pilots.Add(pilot);
        }

        //string null chek
        public bool Contains(string pilotName)
        {
            if (string.IsNullOrWhiteSpace(pilotName))
            {
                throw new ArgumentNullException("Pilot name cannot be null");
            }

            var targetPilot = this.pilots.FirstOrDefault(x => x.Name == pilotName);

            if(targetPilot != null)
            {
                return true;
            }

            return false;
        }

        public IPilot Get(string pilotName)
        {
            if(string.IsNullOrWhiteSpace(pilotName))
            {
                throw new ArgumentNullException("Pilot name cannot be null");
            }

            var targetPilot = this.pilots.FirstOrDefault(x => x.Name == pilotName);

            return targetPilot;
        }
    }
}
