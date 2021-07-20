using System;
using Zoo.ZooAnimals;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolphin dollFin = new Dolphin();
            dollFin.CanSwim(true);
            dollFin.LivesInOcean();
            dollFin.IsZooAnimal();
        }
    }
}
