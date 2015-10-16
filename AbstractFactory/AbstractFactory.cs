using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract AbstractWarer CreateWater();
        public abstract AbstractBottle CreateBottle();
    }
}
