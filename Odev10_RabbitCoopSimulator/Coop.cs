using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit_Coop_Sim
{
    public class Coop
    {
        public List<MaleRabbit> maleRabbits = new List<MaleRabbit>();
        public List<FemaleRabbit> femaleRabbits = new List<FemaleRabbit>();
        public int percentageofRabbitsBorn;
        public int numberofNewbornRabbits;

        public Coop()
        {
            this.numberofNewbornRabbits = Statistics.NumberOfNewbornRabbits;
            this.percentageofRabbitsBorn = Statistics.PercentageOfRabbitsBorn;
        }

        public Rabbit getGenderRabbits(Gender gender)
        {
            Rabbit rabbit = null;
            if (gender.Equals(Gender.MALE))
            {
                maleRabbits.Add(new MaleRabbit());
            }
            else if (gender.Equals(Gender.FEMALE))
            {
                femaleRabbits.Add(new FemaleRabbit());
            }

            return rabbit;
        }

        public int getPercentageofRabbitsBorn()
        {
            return percentageofRabbitsBorn;
        }

        public void setPercentageofRabbitsBorn(int percentageofRabbitsBorn)
        {
            this.percentageofRabbitsBorn = percentageofRabbitsBorn;
        }

        public int getNumberofNewbornRabbits()
        {
            return numberofNewbornRabbits;
        }

        public void setNumberofNewbornRabbits(int numberofNewbornRabbits)
        {
            this.numberofNewbornRabbits = numberofNewbornRabbits;
        }

    }
}
