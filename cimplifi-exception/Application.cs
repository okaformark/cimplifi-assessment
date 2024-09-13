using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_exception
{
    public class Application
    {
        private readonly IAgeValidation _ageValidation;

        public Application(IAgeValidation ageValidation) => _ageValidation = ageValidation;

        public void ValidateAge(int age)
        {
            try
            {
                _ageValidation.ValidateAge(age);
                Console.WriteLine($"{age} is a valid age");
            }
            catch (InvalidAgeException ex)
            {

                Console.WriteLine($"Error: {ex.Message}"); ;
            }
        }
    }
}
