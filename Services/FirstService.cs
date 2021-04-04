using Polymorphism_Example.Database;
using Polymorphism_Example.Interfaces;
using Polymorphism_Example.Models;
using System.Linq;


namespace Polymorphism_Example.Services
{
    public class FirstService : ISomethingValidator
    {
        private readonly DatabaseSample _dataInput;
        private readonly string _validationRule = "Some Input Starts with A";
        public FirstService(DatabaseSample dataInput)
        {
            _dataInput = dataInput;
        }
        public ValidationModel ValidateSomething()
        {
            return new ValidationModel
            {
                IsValidated = _dataInput.GetData().FirstOrDefault(x => x.StartsWith("A")) != null,
                ValidationMessage = _validationRule
            };
        }
    }
}
