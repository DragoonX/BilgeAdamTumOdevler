using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit_Coop_Sim
{
    public class MaleRabbit : Rabbit
    {
        public MaleRabbit()
        {

            this.Life = Statistics.malelifetime;
            this.Age = 0;

        }
        public MaleRabbit(int _life, int _age)
        {
            this.Age = _age;
            this.Life = _life;
        }
    }
}
