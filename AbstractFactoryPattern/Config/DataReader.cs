using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Config
{
    public class DataReader
    {
        private readonly IStorageFactory _storageFactory;

        public DataReader(IStorageFactory storageFactory)
        {
            _storageFactory = storageFactory;
        }

        public string GetData()
        => _storageFactory.Create().Deserialize();
    }
}