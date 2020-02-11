namespace MortalEngines.Repositories
{
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MachineRepository : IRepository<IMachine>
    {
        private readonly List<IMachine> machines;

        public MachineRepository()
        {
            this.machines = new List<IMachine>();
        }

        public IReadOnlyCollection<IMachine> Repository 
            => this.machines.AsReadOnly();

        public void Add(IMachine machine)
        {
            if(machine == null)
            {
                throw new NullReferenceException("Machine cannot be null");
            }

            this.machines.Add(machine);
        }

        public bool Contains(string machineName)
        {
            if(string.IsNullOrWhiteSpace(machineName))
            {
                throw new ArgumentNullException("Machine name cannot be null");
            }

            var targetMachine = this.machines.FirstOrDefault(m => m.Name == machineName);

            if (targetMachine != null)
            {
                return true;
            }

            return false;
        }

        public IMachine Get(string machineName)
        {
            if (string.IsNullOrWhiteSpace(machineName))
            {
                throw new ArgumentNullException("Machine name cannot be null");
            }

            var targetMachine = this.machines.FirstOrDefault(x => x.Name == machineName);

            return targetMachine;
        }
    }
}
