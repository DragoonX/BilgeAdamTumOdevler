namespace Rabbit_Coop_Sim
{
    public class FemaleRabbit : Rabbit
    {
        private int TimeOfPregnancy;
        private int LoseOfFertility;
        private bool isPregnant;

        public FemaleRabbit()
        {

            this.Life = Statistics.FemaleLife;
            this.LoseOfFertility = Statistics.LoseOfFertility;
            this.TimeOfPregnancy = Statistics.TimeOfPregnancy;
            this.Age = 0;
            this.isPregnant = false;

        }

        public FemaleRabbit(int _timeofPregnancy, int _loseofFertility, int _age, int _lifetime, bool _isPregnant)
        {
            this.TimeOfPregnancy = _timeofPregnancy;
            this.LoseOfFertility = _loseofFertility;
            this.Age = _age;
            this.Life = _lifetime;
            this.isPregnant = _isPregnant;
        }

        public int getTimeofPregnancy()
        {
            return TimeOfPregnancy;
        }

        public void setTimeofPregnancy(int timeofPregnancy)
        {
            this.TimeOfPregnancy = timeofPregnancy;
        }

        public int getLoseofFertility()
        {
            return LoseOfFertility;
        }

        public void setLoseofFertility(int loseofFertility)
        {
            this.LoseOfFertility = loseofFertility;
        }

        public bool isPregnantF()
        {
            return isPregnant;
        }

        public void setPregnant(bool isPregnant)
        {
            this.isPregnant = isPregnant;
        }

    }
}
