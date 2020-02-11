namespace MortalEngines
{
    using MortalEngines.Core;
    using MortalEngines.Models;
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using MortalEngines.Core.Contracts;
    using MortalEngines.Repositories.Contracts;
    using MortalEngines.Entities.Contracts;
    using MortalEngines.Repositories;

    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();

            engine.Run();
        }
    }
}