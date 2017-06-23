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

        public Tank Add<T>(T fish) where T : IFish, new() //this forces the implementing class to have a default ctor, which in turn makes deseralization easier
        {
            this.fish.Add(fish);
            return this;
        }

        public int Count => this.fish.Count;
        public IReadOnlyList<IFish> Fish => this.fish;

        public double Feed() => Math.Round(this.fish.Sum(f => f.FoodRequired), 3);
    }
}
