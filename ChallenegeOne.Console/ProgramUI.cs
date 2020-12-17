using KomodoCafeRepository_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallenegeOne_Console 
{
    class ProgramUI

    {
        private Menu_Repository _MenuRepo = new Menu_Repository();

        public void Run()
        {
            Menu();
        }

        public void Menu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {//This  take input from user as an interger for the Menu option
                Console.WriteLine("Select a Menu Option:\n" +
                    "1.Add Meal To Menu\n" +
                    "2.Read Meal on Menu\n" +
                    "3.Update Meal on Menu\n" +
                    "4.Delete Meal From Menu\n" +
                    "5.View Meal by Meal Number\n" +
                    "6.Exit");
                //The menu option is passed into the Switch method
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddMealToMenu();
                        break;
                    case "2":
                        ReadMealonMenu();
                        break;
                    case "3":
                        UpdateMealonMenu();
                        break;
                    case "4":
                        DeleteMealFromMenu();
                        break;
                    case "5":
                        ViewMeralByMealNUmber();
                        break;
                    //when keeprunning is false, the loop stop running and the program breaks out of the loop
                    case "6":
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A number on The Menu List");
                        break;



                }
                //when the code in the case finish running, press any key  to continue
                Console.WriteLine("please press any Key to Continue");
                //Console.Readkey takes in the key as a prompt
                Console.ReadKey();
                //console.clear(),This clears the  menu option that would be printed in continuation of the loop
                Console.Clear();


            }



        }

        public void AddMealToMenu()
        {
            Menu meal = new Menu();
            Console.WriteLine("Enter the Meal ID:");
            meal.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            meal.Mealname = Console.ReadLine();
            Console.WriteLine("Enter the Meal Price");
            meal.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Meal description");
            meal.MealDescription = Console.ReadLine();

            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("Enter the meal Ingredients and  no to  exit");
                string response = Console.ReadLine();

                if (response.ToLower() == "no")
                {
                    keeprunning = false;
                }
                else
                {
                    meal.Ingredients.Add(response);
                }



            }
            _MenuRepo.AddMealtoMenu(meal);

        }

        public void ReadMealonMenu()

        {
            List<Menu> Menulist = _MenuRepo.ReadListofMealonMenu();
            foreach (Menu menu in Menulist)
            {
                Console.WriteLine($"{menu.Mealname},{menu.MealNumber}");
            }
        }


        public void UpdateMealonMenu()

        {
            ReadMealonMenu();
            Menu meal = new Menu();
            Console.WriteLine("Ether the Meal number  to be Updated ");
            int response2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Meal ID:");
            meal.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name");
            meal.Mealname = Console.ReadLine();
            Console.WriteLine("Enter the Meal Price");
            meal.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Meal description");
            meal.MealDescription = Console.ReadLine();

            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("Enter the meal Ingredients and  no to  exit");
                string response = Console.ReadLine();

                if (response.ToLower() == "no")
                {
                    keeprunning = false;
                }
                else
                {
                    meal.Ingredients.Add(response);
                }


            }
            bool update = _MenuRepo.UpdateMealfromMenu(response2, meal);
            if (update == true)
            {
                Console.WriteLine("The Update is succesful");
            }
            else
            {
                Console.WriteLine("update Failed");
            }
        }
        public void DeleteMealFromMenu()
        {
            ReadMealonMenu();
            
            Console.WriteLine("Please Enter the Meal ID for the meal to be deleted");
            int response = int.Parse(Console.ReadLine());
            bool deleted = _MenuRepo.DeleteMealFromMenu(response);
            if (deleted == true)
            {
                Console.WriteLine("Meal deleted sucesfully");
            }
            else
            {
                Console.WriteLine("Delete Failed");
            }
            
        }
        public void ViewMeralByMealNUmber()
        {
            ReadMealonMenu();
            Console.WriteLine("Enter the Meal Id  form the meal");
            int response = int.Parse(Console.ReadLine());
            Menu meal = _MenuRepo.GetmealbyMealNumber(response);
            if (meal != null)
            {
                Console.WriteLine($"Here is the meal:{meal.Mealname}");
            }
            else
            {
                Console.WriteLine($"There is no Menu item with this Meal number:{response}");
            }
        }
    }
}
