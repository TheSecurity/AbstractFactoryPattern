namespace AbstractFactoryPattern.DataStorage
{
    public class XmlStorage : IStorage
    {
        public string Deserialize()
            => "Deserializing with XML";
    }
}