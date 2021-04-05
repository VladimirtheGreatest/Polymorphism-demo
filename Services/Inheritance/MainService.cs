

using System;

namespace Polymorphism_Example.Services.Inheritance
{
    public class MainService
    {
        protected string message  = "You can pass";
        public virtual void ValidateAge(int age)
        {
             Console.WriteLine(message);
        }
    }
}
