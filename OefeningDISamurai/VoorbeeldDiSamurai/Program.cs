using Ninject;
using System;

namespace VoorbeeldDiSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new DI container
            var kernel = new StandardKernel();
            //Tell the container to resolve an instance of the Sword class when it's asked for an IWeapon
            kernel.Bind<IWeapon>().To<Sword>();
            kernel.Bind<IWeapon>().To<Dagger>();

            //Ask the container to get in instance of the Samurai class and to resolve all of it's dependencies
            //var warrior = kernel.Get<Samurai>();
            //warrior.Attack("the evildoers");
            //Console.ReadLine();

            //Oefening DI Samurai

            kernel.Bind<IWeapon>().To<Gun>().Kernel.Bind<ITrigger>().To<AutomaticTrigger>();
            var Gunner = kernel.Get<Samurai>();
            Gunner.Attack("Snipper");
        }
    }
}
