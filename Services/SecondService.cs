using System.Linq;
using Polymorphism_Example.Interfaces;
using Polymorphism_Example.Database;
using Polymorphism_Example.Models;

namespace Polymorphism_Example.Services
{
    public class SecondService : ISomethingValidator
    {
        private readonly DatabaseSample _dataInput;
        private readonly string _validationRule = "Some Input Starts with B";
        public SecondService(DatabaseSample dataInput)
        {
            _dataInput = dataInput;
        }
        public ValidationModel ValidateSomething()
        {
            return new ValidationModel
            {
                IsValidated = _dataInput.GetData().FirstOrDefault(x => x.StartsWith("B")) != null,
                ValidationMessage = _validationRule
            };
        }
    }
}
