using Ninject;
using System;

namespace FileStore
{
    class Program
    {
        static void Main(string[] args)
        {

            IKernel kernel = new StandardKernel();
            kernel.Bind<IPrinter>().To<FilePrinter>();
            var arrayStore = kernel.Get<ArrayStore>();

            arrayStore.Store(new string[] { "Volvo", "BMW", "Ford", "Mazda" });

        }
    }
}
