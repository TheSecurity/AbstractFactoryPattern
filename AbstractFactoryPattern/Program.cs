using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactoryPattern
{
    public class Program
    {
        public static void Main()
            => Container.Dependencies.GetRequiredService<ConsoleUserInterface>().Run();
    }
}
