using System;

namespace ConsoleApp1
{
    class Dog : IAnimal
    {
        public int Legs { get; } = 4;

        public bool Eat(IFood food, DateTime scheduledTime)
        {
            if (food.isHealthy && scheduledTime >= DateTime.Now)
            {
                return true;
            }

            return false;
        }

        public void EatBreakfast()
        {
            var banana = new Banana();
            Eat(banana, DateTime.Now);
        }
    }
}
