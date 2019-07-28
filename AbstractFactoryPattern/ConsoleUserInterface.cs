using System;
using AbstractFactoryPattern.Config;

namespace AbstractFactoryPattern
{
    public class ConsoleUserInterface
    {
        private readonly ConfigReader _configReader;
        private readonly DataReader _dataReader;

        public ConsoleUserInterface(ConfigReader configReader, DataReader dataReader)
        {
            _configReader = configReader;
            _dataReader = dataReader;
        }

        public void Run()
        {
            LoadConfig();
            LoadData();
        }

        public void LoadConfig()
        {
            var config = _configReader.GetConfig();
            Console.WriteLine("Loading config:" + config);
        }

        public void LoadData()
        {
            var data = _dataReader.GetData();
            Console.WriteLine("Loading data:" + data);
        }
    }
}