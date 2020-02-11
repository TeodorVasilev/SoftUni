namespace MortalEngines.Repositories.Contracts
{
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Repository { get; }

        void Add(T item);

        bool Contains(string item);

        T Get(string item);
    }
}
