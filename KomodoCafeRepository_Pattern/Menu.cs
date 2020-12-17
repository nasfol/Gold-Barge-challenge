using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeRepository_Pattern
{

    public class Menu
    {
        public List<string> Ingredients { get; set; } = new List<string>();
        public string Mealname { get; set; }
        public string MealDescription { get; set; } 
        public decimal Price { get; set; }
        public int MealNumber { get; set; }


        public Menu() { }
        public Menu(List<string> ingredients,string mealname, string mealdescription,decimal price,int mealnumber)

        {
            Ingredients = ingredients;
            Mealname = mealname;
            MealDescription = mealdescription;
            MealNumber = mealnumber;
            Price = price;
            

        }
        

        

    }
   

   


        
    
  
}
