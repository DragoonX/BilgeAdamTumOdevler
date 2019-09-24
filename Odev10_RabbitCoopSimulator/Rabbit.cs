namespace Rabbit_Coop_Sim
{
    public abstract class Rabbit
    {
        protected int Life;
        protected int Age;

        public int getAge()
        {
            return Age;
        }
        public void setAge(int age)
        {
            this.Age = age;
        }
        public int getLife()
        {
            return Life;
        }
        public void setLife(int Life)
        {
            this.Life = Life;
        }
    }
}
