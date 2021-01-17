using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MondayLesson.Models
{
    public class FoodMenu
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Size { get; set; }

        public int Calories { get; set; }

        public int Grams { get; set; }
    }
}
