using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AnimalWorld
    {
        private Herbivore m_herbivore;
        private Carnivore m_carnivore;

        public AnimalWorld(ContinentFactory p_factory)
        {
            m_carnivore = p_factory.CreateCarnivore();
            m_herbivore = p_factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            m_carnivore.Eat(m_herbivore);
        }
    }
}
