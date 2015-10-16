namespace AbstractFactory
{
    class CocaColaFactory : AbstractFactory
    {
        internal CocaColaWater CocaColaWater
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        internal ColcaColaBottle ColcaColaBottle
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
            return new CocaColaWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new ColcaColaBottle();
        }
    }
}