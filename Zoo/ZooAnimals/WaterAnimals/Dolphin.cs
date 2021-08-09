using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.ZooAnimals
{
    public class Dolphin : AquaticAnimals
    {
        //You can override abstracts at different levels
        public override string Color { get; set; } = "grey";

        public override string TypeOfWater { get; set; } = "Salty Ocean Water";
    }
}
