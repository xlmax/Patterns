using System;

namespace AbstractFactory
{
    internal class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWarer water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}