using System;
using System.Collections.Generic;
using ChallengeTwo_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwo_Test
{
    [TestClass]
    public class ClaimRepository_Test

    {
        private Claim_Repository _ClaimRepo = new Claim_Repository();
       private  Claim _Claim;


        [TestInitialize]
        public void Arrange()
        {   
            _Claim = new Claim("1", TypeofClaim.Car, "car acciddent on 1465", 200.45m, DateTime.Parse("12/07/2020"), DateTime.Parse("12/07/2020"), true);
            _ClaimRepo.AddClaimToQueue(_Claim);
        }





        //Test Add Method
        [TestMethod]
         public void TestAddMethod()
         {
            Claim newclaim = new Claim("2", TypeofClaim.Car, "car acciddent on 1465", 200.45m, DateTime.Parse("12/07/2020"), DateTime.Parse("12/07/2020"), true);
            _ClaimRepo.AddClaimToQueue(newclaim);
            Claim actual = _ClaimRepo.GetClaimByID("2");
            
            
            Assert.IsNotNull(actual);



         }

        [TestMethod]
        public void TestUpdateMethod()
        {
            
            Claim claim= new Claim("2", TypeofClaim.Car, "car acciddent on 1465", 200.45m, DateTime.Parse("12/07/2020"), DateTime.Parse("12/07/2020"), true);
           bool actual= _ClaimRepo.UpdateMethod(claim, "1");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestViewListofClaim()
        {
            Queue<Claim> actual = _ClaimRepo.ViewlistofClaim();
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestVeiwnextListOfClaim()
        {   //Claim  anoitherclaim=new Claim("2", TypeofClaim.Theft, "car acciddent on 1465", 200.45m, DateTime.Parse("12/07/2020"), DateTime.Parse("12/07/2020"), true);
            
            Claim actual = _ClaimRepo.ViewNextClaim();
            Claim expexted = _Claim;
            Assert.AreEqual(actual, expexted);
        }

        [TestMethod]
        public void TestDeleteMethod()
        {
            _ClaimRepo.DeleteMethod();
            Claim actual = _ClaimRepo.GetClaimByID("1");
            Assert.IsNull(actual);

        }
       
     


    }




    
}
