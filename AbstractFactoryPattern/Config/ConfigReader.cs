using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Config
{
    public class ConfigReader
    {
        private readonly IStorageFactory _storageFactory;

        public ConfigReader(IStorageFactory storageFactory)
        {
            _storageFactory = storageFactory;
        }

        public string GetConfig()
        {
            var factory = _storageFactory.Create("config");
            return factory.Deserialize();
        }
    }
}