using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeRepository_Pattern
{
    public class Menu_Repository
    {
        private List<Menu> _Menulist = new List<Menu>();
        //Add meal to Menu List
        public void AddMealtoMenu(Menu meal)
        {
            _Menulist.Add(meal);

        }

        //Read the list of meal on Menu
        public List<Menu> ReadListofMealonMenu()
        {
            return _Menulist;
        }

        //Update Meal from Menu
        public bool UpdateMealfromMenu(int mealnumber,Menu meal)
        {
            Menu oldmeal = GetmealbyMealNumber(mealnumber);
            if (oldmeal == null)
            {
                return false;

            }
            else
            {
                oldmeal.Ingredients = meal.Ingredients;
                oldmeal.MealDescription = meal.MealDescription;
                oldmeal.Mealname = meal.Mealname;
                oldmeal.Price = meal.Price;
                oldmeal.MealNumber = meal.MealNumber;

                return true;
            }

        }



        //Delete Meal from Menu
        public bool DeleteMealFromMenu(int mealnumber)

        {
            Menu meal = GetmealbyMealNumber(mealnumber);
            if (meal != null)
            {
               _Menulist.Remove(meal);
                return true;
            }

            return false;
        }



        //Helper Method
        public Menu GetmealbyMealNumber(int mealnumber)
        {
            foreach(Menu meal in _Menulist)
            {
                if(meal.MealNumber==mealnumber)
                {
                    return meal;
                }
            }
            return null;
        }


        // Add IngedientToIngrerientList
        public List<string> Addtoingredientlist(string ingredient)
        {
            Menu meal = new Menu();
            meal.Ingredients.Add(ingredient);
            return meal.Ingredients;

        }

    }
}
