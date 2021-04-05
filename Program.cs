using Polymorphism_Example.Database;
using Polymorphism_Example.Interfaces;
using Polymorphism_Example.Services;
using Polymorphism_Example.Services.Inheritance;
using System;
using System.Collections.Generic;

namespace Polymorphism_Example
{
    class Program
    {
        private static readonly DatabaseSample _databaseSampleInjection = new DatabaseSample();
        private static readonly DerivedService _derivedServiceInjection = new DerivedService();
        private static readonly int _ageExample = 22;

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
            _derivedServiceInjection.ValidateAge(_ageExample);
        }
    }
}
