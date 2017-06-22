using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class BabelFish : IFish
    {
        public double FoodRequired => 0.3;

        public string Name { get; set; }
    }
}
