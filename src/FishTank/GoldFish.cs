using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class GoldFish : IFish
    {
        public double FoodRequired => 0.1;

        public string Name { get; set; }
    }
}
