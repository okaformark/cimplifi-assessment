using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_exception
{
    public class AgeValidation : IAgeValidation
    {
        public AgeValidation() { }
        public void ValidateAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException($"The age {age} is not valid. It must be between 0 and 120.");
            }
        }
    }
}
