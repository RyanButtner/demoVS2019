using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAnimal
    {
        int Legs { get; }
        bool Eat(IFood food, DateTime scheduledTime);
    }
}
