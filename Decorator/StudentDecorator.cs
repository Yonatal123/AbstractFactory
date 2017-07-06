using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StudentDecorator : Student
    {
        Student m_baseStudent = null;
        protected StudentDecorator(Student p_student)
        {
            m_baseStudent = p_student;
        }
        public override string DisplayInformation()
        {
            string baseInformation = m_baseStudent.DisplayInformation();
            return baseInformation;
        }
    }
}
