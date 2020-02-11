namespace MortalEngines.Core.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICommandInterpreter
    {
        string Read(string[] args);
    }
}
