using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    public class Tank
    {
        private List<IFish> fish = new List<IFish>();

        public Tank Add(IFish fish)
        {
            this.fish.Add(fish);
            return this;
        }

        public int Count => this.fish.Count;
        public IReadOnlyList<IFish> Fish => this.fish;

        public double Feed() => Math.Round(this.fish.Sum(f => f.FoodRequired), 3);
    }
}
