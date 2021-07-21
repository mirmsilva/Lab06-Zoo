using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals.Aviary

{
    public class Turkey : Bird
    {
        public override string Color { get; set;} = "brown"

        public override LaysEggs()
        {
            Console.WriteLine("Turkeys Lay Eggs");
        }

        
    }
}
