using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Compound
    {
        public Compound(string p_chemical)
        {
            this.m_chemical = p_chemical;
        }

        protected string m_chemical;
        protected float m_boilingPoint;
        protected float m_meltingPoint;
        protected double m_molecularWeight;
        protected string m_molecularFormula;

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", m_chemical);
        }

    }
}
