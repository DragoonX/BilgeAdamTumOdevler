using System;

namespace Rabbit_Coop_Sim
{
    public class Statistics
    {
        private static Statistics singleton = new Statistics();
        public static int MaleLife;
        public static int FemaleLife;
        public static int TimeOfPregnancy;
        public static int LoseOfFertility;
        public static int PercentageOfRabbitsBorn;
        public static int NumberOfNewbornRabbits;

        private Statistics() { }

        public static Statistics getInstance()
        {
            return singleton;
        }

        public void getStaticInformations()
        {
            try
            {
                MaleLife = 12;
                FemaleLife = 12;
                NumberOfNewbornRabbits = 4;
                PercentageOfRabbitsBorn = 25;
                TimeOfPregnancy = 1;
                LoseOfFertility = 8;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
}