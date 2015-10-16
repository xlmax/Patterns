namespace AbstractFactory
{
    internal class PepsiFactory : AbstractFactory
    {
        internal PepsiWater PepsiWater
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal PepsiBottle PepsiBottle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public override AbstractWarer CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
    }
}