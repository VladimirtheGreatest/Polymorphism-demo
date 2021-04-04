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
                new FirstService(),
                new SecondService(),
                new ThirdService(),
            };

            foreach (var service in services)
            {
                var serviceValidatedSomething = service.ValidateSomething(_databaseSampleInjection.GetData());
                if (serviceValidatedSomething.IsValidated)
                {
                    Console.WriteLine(serviceValidatedSomething.ValidationMessage);
                }

            }
        }
    }
}
