using AbstractFactoryPattern.DataStorage;

namespace AbstractFactoryPattern.Factories
{
    public interface IStorageFactory
    {
        IStorage Create(string type="");
    }
}