using System;
using System.Collections.Generic;
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

            foreach (var calculator in program.Calculators)
            {
                var result = calculator.Value.GetNumber(10, 10);
                Console.WriteLine("The {0} calculation result: {1}", calculator.Metadata.CalculationType, result);               
            }

            Console.WriteLine("End Calculation.");

            Console.ReadLine();
        }

        private void Run()
        {
            var catalog = new DirectoryCatalog(".\\");
            var container = new CompositionContainer(catalog);

            container.ComposeParts(this);
        }

        [ImportMany]
        public IEnumerable<Lazy<ICalculator, ICaculatorMetadata>> Calculators { get; set; }
    }
}
