using Polymorphism_Example.Database;
using Polymorphism_Example.Interfaces;
using Polymorphism_Example.Models;
using System.Collections.Generic;
using System.Linq;


namespace Polymorphism_Example.Services
{
    public class FirstService : ISomethingValidator
    {
        public readonly string _validationRule = "Some Input Starts with A";
 
        public ValidationModel ValidateSomething(List<string> listToValidate)
        {
            return new ValidationModel
            {
                IsValidated = listToValidate.FirstOrDefault(x => x.StartsWith("A")) != null,
                ValidationMessage = _validationRule
            };
        }
    }
}
