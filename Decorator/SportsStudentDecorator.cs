using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SportsStudentDecorator : StudentDecorator
    {
        public string Games { get; set; }

        public SportsStudentDecorator(Student p_student) : base(p_student)
        {
        }

        public override string DisplayInformation()
        {
            var result = base.DisplayInformation();
            result = result + " games are " + Games;
            return result;
        }
    }
}
