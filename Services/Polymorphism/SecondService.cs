using System.Linq;
using Polymorphism_Example.Interfaces;
using Polymorphism_Example.Database;
using Polymorphism_Example.Models;
using System.Collections.Generic;

namespace Polymorphism_Example.Services
{
    public class SecondService : ISomethingValidator
    {
        private readonly string _validationRule = "Some Input Starts with B";
    
        public ValidationModel ValidateSomething(List<string> listToValidate)
        {
            return new ValidationModel
            {
                IsValidated = listToValidate.FirstOrDefault(x => x.StartsWith("B")) != null,
                ValidationMessage = _validationRule
            };
        }
    }
}
