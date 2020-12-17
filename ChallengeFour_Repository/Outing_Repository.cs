using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_Repository
{
    public   class Outing_Repository
    {
        private List<Outing> OutingList = new List<Outing>();
        int count = 0;
        // Add method 
        public void AddOutingToList(Outing firstOuting)
        {
            count++;
            firstOuting.OutingId = count;
            OutingList.Add(firstOuting);

            
            
            

        }

        // Read Method
        public List<Outing>  DisplayListOfOuting()
        {
            return OutingList;
        }

        //Update Method
        public decimal  CalculateAllOuting()
        {
            DisplayListOfOuting();
            decimal count = 0.0m;
            foreach(Outing outing in OutingList)
            {

                count = count + outing.TotalCostforEvent;
                

            }
            return count;
        }

        public decimal GetOutingCost(TypeofEvent typeOfEvent)
        {
            decimal value = 0.0m;
            foreach (var outing in OutingList)
            {
                if (outing.EventType== typeOfEvent)
                {
                    decimal Nvalue = outing.TotalCostforEvent;
                    return Nvalue;
                    
                }
            }
            return value;
        }

        //public decimal CalculateallOutingcostbyType()
        //{
           

        //    decimal amusementparkcost = 0.0m;

        //    decimal bowlingcost = 0.0m;
        //    decimal concertcost = 0.0m;
        //    decimal gulfcost = 0.0m;

        //    /*foreach (Outing outing in OutingList)
        //    {
        //        if(outing.EventType==eventtype)
        //        count = count + outing.TotalCostforEvent;

        //    }*/

        //    foreach (Outing outing in OutingList)
        //    {
        //        if (outing.EventType == TypeofEvent.Amusement_park)
        //        {
        //            //decimal response1 = 0m;
        //            amusementparkcost = amusementparkcost + outing.TotalCostforEvent;
        //            return amusementparkcost;

        //        }
        //        else if (outing.EventType == TypeofEvent.Bowling)
        //        {
        //            //decimal response2 = 0m;
        //            bowlingcost = bowlingcost + outing.TotalCostforEvent;
        //            return bowlingcost;
        //        }
        //        else if (outing.EventType == TypeofEvent.Golf)
        //        {
        //            //decimal response3 = 0m;
        //            gulfcost = gulfcost + outing.TotalCostforEvent;
        //            return gulfcost;
        //        }
        //        else if (outing.EventType == TypeofEvent.Concert)
        //        {
        //            //decimal response4 = 0m;
        //            concertcost = concertcost + outing.TotalCostforEvent;
        //            return concertcost;
        //        }

        //    }
        //    return concertcost;









        //}





    }

}
