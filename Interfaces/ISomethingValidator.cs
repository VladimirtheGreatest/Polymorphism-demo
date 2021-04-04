using Polymorphism_Example.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Example.Interfaces
{
    public interface ISomethingValidator
    {
        ValidationModel ValidateSomething(List<string> listToValidate);
    }
}
