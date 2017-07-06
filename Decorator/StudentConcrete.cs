using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StudentConcrete : Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public override string DisplayInformation()
        {
            return Name + " who is " + Age + " years old in grade: " + Grade;
        }
    }
}
