using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using MyMefContract;

namespace SimpleMefSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
            
            Console.WriteLine("Start calculation.");

            var result = program.Calculator.GetNumber(10, 10);
            Console.WriteLine("The calculation result: {0}", result);


            Console.WriteLine("End Calculation.");

            Console.ReadLine();
        }

        private void Run()
        {
            var catalog = new DirectoryCatalog(".\\");
            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);
        }

        [Import]
        public ICalculator Calculator { get; set; }
    }
}
