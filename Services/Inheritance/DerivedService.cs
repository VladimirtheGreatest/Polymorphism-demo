using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Example.Services.Inheritance
{
    public class DerivedService : MainService
    {
        private string Id = "ABC";
        public override void ValidateAge(int age)
        {
            base.ValidateAge(age);
            Console.WriteLine("Your user ID is: {0}", Id);
        }
    }
}
