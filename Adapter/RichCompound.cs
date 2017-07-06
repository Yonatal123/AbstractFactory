using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RichCompound : Compound
    {
        public RichCompound(string p_chemical) : base(p_chemical)
        {
        }

        public override void Display()
        {
            m_bank = new ChemicalDataBank();
            m_boilingPoint = m_bank.GetCriticalPoint(m_chemical, "B");
            m_meltingPoint = m_bank.GetCriticalPoint(m_chemical, "M");
            m_molecularWeight = m_bank.GetMolecularWeight(m_chemical);
            m_molecularFormula = m_bank.GetMolecularStructure(m_chemical);

            base.Display();
            Console.WriteLine(" Formula: {0}", m_molecularFormula);
            Console.WriteLine(" Weight : {0}", m_molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", m_meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", m_boilingPoint);
        }

        private ChemicalDataBank m_bank;
    }
}
