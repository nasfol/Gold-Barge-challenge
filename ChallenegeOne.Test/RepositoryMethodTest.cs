using System;
using System.Collections.Generic;
using KomodoCafeRepository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallenegeOne.Test
{


    [TestClass]
    public class RepositoryMethodTest

    {
        public Menu _meal;
        public Menu_Repository _Menumethod = new Menu_Repository();


        [TestInitialize]
        public void Arrange()


        {

          
            _meal = new Menu(new List<string>() {"oli","pepper","tomato" },"food", "type", 1.5m, 3);
            _Menumethod.AddMealtoMenu(_meal);
           





        }




        [TestMethod]
        public void TestAddMethod()
        {
            Menu meal = new Menu(new List<string>() { "oli", "pepper", "tomato" }, "food", "type", 1.5m, 2);
            
           
            _Menumethod.AddMealtoMenu(meal);
            Menu newmeal = _Menumethod.GetmealbyMealNumber(2);
            Assert.IsNotNull(newmeal);



        }

        [TestMethod]
        public void TestUpdatemethod()
        {
            Menu meal = new Menu();
            meal.Ingredients.Add("oil");
            Menu meal2 = new Menu(meal.Ingredients, "food", "for", 1.5m, 1);
            //_Menumethod.AddMealtoMenu(meal2);
            bool actual = _Menumethod.UpdateMealfromMenu(3, meal2);
            Assert.IsTrue(actual);
        }

        
        [TestMethod]

        public void TestDeleteMethod()

        {
            Menu _meal2 = new Menu(new List<string>() { "oli", "pepper", "tomato" }, "food", "type", 1.5m, 4);
            _Menumethod.AddMealtoMenu(_meal2);
            bool actual= _Menumethod.DeleteMealFromMenu(4);
            Assert.IsTrue(actual);
            
        }

        
           

                

        
    }

}

