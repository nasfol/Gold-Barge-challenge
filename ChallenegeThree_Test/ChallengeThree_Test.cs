using System;
using System.Collections.Generic;
using ChallengeThree_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallenegeThree_Test
{
    [TestClass]
    public class ChallengeThree_Test
    {
        Dictionary<int, List<string>> Dictionary1 = new Dictionary<int, List<string>>();
        
       private BadgeRepository _BadgeRepository = new BadgeRepository();
        [TestInitialize]
        public void Arrange()
        {
            
            Badge yourbadge = new Badge(new List<string> { "Ai", "A2", "A3" }, 4);
            Badge anotherbadge=new Badge(new List<string> { "Ai", "A2", "A3" }, 8);
            _BadgeRepository.AddBadgetoDic(anotherbadge);
            _BadgeRepository.AddBadgetoDic(yourbadge);
           
        }
      

        [TestMethod]
        public void TestAddMethod()
        {
            
            Badge badge = new Badge(new List<string> { "A1", "A2" }, 9);
                 _BadgeRepository.AddBadgetoDic(badge);
            Dictionary<int, List<string>> badges = _BadgeRepository.ReadBadgefromDIC();
            int actual = badges.Count;
            int exxpected = 3;
            Assert.AreEqual(exxpected, actual);

        }

        [TestMethod]
        public void TestReadMethod()
        {
            Dictionary<int, List<string>> badges = _BadgeRepository.ReadBadgefromDIC();
            int actual = badges.Count;
            int exxpected = 2;
            Assert.AreEqual(exxpected, actual);
        }

        [TestMethod]
        public void TestAddDoorToBadgeMethod()
        {
            KeyValuePair<int, List<string>> oldbadge = _BadgeRepository.GetBadgeFrommDIcByBadgeID(8);
            List<string> DoorList = oldbadge.Value;
            DoorList.Add("A9");
            int count = 0;
            count = DoorList.Count;
            int expected = 4;
            Assert.AreEqual(expected, count);

        }
        [TestMethod]
        public void TestRemoveDoorFromBadgeMethod()
        {
            KeyValuePair<int, List<string>> oldbadge = _BadgeRepository.GetBadgeFrommDIcByBadgeID(8);
            List<string> DoorList = oldbadge.Value;
            DoorList.Remove("A3");
            int actual = DoorList.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        







    }



}
