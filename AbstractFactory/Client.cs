using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        private AbstractWarer water;
        private AbstractBottle bottle;

        public Client(AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        internal AbstractFactory AbstractFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal AbstractWarer AbstractWarer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Run()
        {
            bottle.Interact(water);
        }
    }
}
