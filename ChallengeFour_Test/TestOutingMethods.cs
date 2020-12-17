using System;
using System.Collections.Generic;
using ChallengeFour_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeFour_Test
{
    [TestClass]
    public class TestOutingMethods

    {
        Outing_Repository _Repository = new Outing_Repository();

        List<Outing> _OutingList = new List<Outing>();
        [TestMethod]
        public void TestAddMethod()
        {
            Outing myouting = new Outing();

          
            int firstcount=_Repository.AddOutingToList(myouting);

            int actual = firstcount;
           int expected = 1;
            Assert.AreEqual(expected, actual);

        }      
    }
}
