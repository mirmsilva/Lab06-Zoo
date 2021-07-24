using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals.Aviary

{
    public class Turkey : Bird, IHabit
    {
        public override string Color { get; set; } = "brown";

        public void Fast()
        {
            Console.WriteLine("Turkeys are fast during Thanksgiving Time");
        }

        void IHabit.Diet()
        {
            Console.WriteLine("We eat worms!");
        }

        public void Nocturnal()
        {
            Console.WriteLine("We Sleep at night");
        }

        public override void LaysEggs()
        {
            Console.WriteLine("We lay big eggs!");
        }
    }
}
