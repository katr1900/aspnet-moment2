using System;
using System.Collections.Generic;

namespace Moment2.Models
{
    public class SeaFood : Food
    {
        public SeaFood()
        {
          
        }

        public List<SeaFood> SeaFoods { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public List<SeaFood> GetAll()
        {
            if (SeaFoods == null)
            {
                SeaFoods = new List<SeaFood>
                {
                   new SeaFood
                   {
                       Id = 2,
                       Name = "Crab",
                       Price = 99
                   },
                    new SeaFood
                   {
                       Id = 3,
                       Name = "Lobster",
                       Price = 299
                   }
                };
            }
          
            return SeaFoods;
        }
        public void Save(SeaFood seaFood)
        {
            this.GetAll();
            SeaFoods.Add(seaFood);
        }
    }
}
