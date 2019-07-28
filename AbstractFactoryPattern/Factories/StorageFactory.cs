using AbstractFactoryPattern.DataStorage;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactoryPattern.Factories
{
    public class StorageFactory : IStorageFactory
    {
        public IStorage Create(string type = "")
        {
            if (type.Equals("config")) return Container.Dependencies.GetRequiredService<JsonStorage>();

            return Container.Dependencies.GetRequiredService<IStorage>();
        }
    }
}