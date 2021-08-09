using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals.Aviary

{
    public class Flamingo : Bird
    {
        public override string Color { get; set; } = "pink";

        public override void LaysEggs()
        {
            Console.WriteLine("Were aren't sure if flamingoes lay eggs");
        }
    }
}
