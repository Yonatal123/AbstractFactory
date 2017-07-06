using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Document
    {
        private List<Page> m_pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return m_pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
