using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public interface IFish
    {
        double FoodRequired { get; }
        string Name { get; set; }
    }
}
