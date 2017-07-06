using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class ScienceStudentDecorator : StudentDecorator
    {
        public string Labs { get; set; }

        public ScienceStudentDecorator(Student p_student) : base(p_student)
        {
        }

        public override string DisplayInformation()
        {
            var result = base.DisplayInformation();
            result = result + " labs are " + Labs;
            return result;
        }
    
    }
}
