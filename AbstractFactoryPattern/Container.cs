using System;
using AbstractFactoryPattern.Config;
using AbstractFactoryPattern.DataStorage;
using AbstractFactoryPattern.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactoryPattern
{
    public static class Container
    {
        private static IServiceProvider _dependencies;

        public static IServiceProvider Dependencies => _dependencies ?? (_dependencies = GetDependencies());

        private static IServiceProvider GetDependencies()
            => new ServiceCollection()
                .AddTransient<IStorage, JsonStorage>()
                .AddSingleton<JsonStorage>()
                .AddSingleton<IStorage, XmlStorage>()
                .AddSingleton<XmlStorage>()
                .AddSingleton<IStorageFactory,StorageFactory>()
                .AddSingleton<ConfigReader>()
                .AddSingleton<DataReader>()
                .AddSingleton<ConsoleUserInterface>()
                .BuildServiceProvider();
    }
}