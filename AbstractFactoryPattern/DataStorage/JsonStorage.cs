namespace AbstractFactoryPattern.DataStorage
{
    public class JsonStorage : IStorage
    {
        public string Deserialize()
            => "Deserializing with JSON";
    }
}