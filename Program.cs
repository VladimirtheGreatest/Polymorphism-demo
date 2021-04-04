using Polymorphism_Example.Database;
using Polymorphism_Example.Interfaces;
using Polymorphism_Example.Services;
using System;
using System.Collections.Generic;

namespace Polymorphism_Example
{
    class Program
    {
        private static readonly DatabaseSample _databaseSampleInjection = new DatabaseSample();
  
        static void Main(string[] args)
        {
            var services = new List<ISomethingValidator>
            {
                new FirstService(_databaseSampleInjection),
                new SecondService(_databaseSampleInjection),
                new ThirdService(_databaseSampleInjection),
            };

            foreach (var service in services)
            {
                var serviceValidatedSomething = service.ValidateSomething();
                if (serviceValidatedSomething.IsValidated)
                {
                    Console.WriteLine(serviceValidatedSomething.ValidationMessage);
                }

            }
        }
    }
}
