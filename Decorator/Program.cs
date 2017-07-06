using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentConcrete stdRam = new StudentConcrete { Age = 10, Name = "Ram", Grade = "One" };
            var stdRamInformation = stdRam.DisplayInformation();
            Console.WriteLine(stdRamInformation);

            ScienceStudentDecorator stdScienceRam = new ScienceStudentDecorator(stdRam) { Labs = "Biology" };
            var stdScienceRamInformation = stdScienceRam.DisplayInformation();
            Console.WriteLine(stdScienceRamInformation);

            SportsStudentDecorator stdSportsRam = new SportsStudentDecorator(stdScienceRam) { Games = "Cricket" };
            var stdSportsRamInformation = stdSportsRam.DisplayInformation();
            Console.WriteLine(stdSportsRamInformation);

            Console.ReadLine();
        }
    }
}
