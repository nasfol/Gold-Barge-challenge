using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_Repository
{
    public enum TypeofEvent
    {
        Golf=1,
        Bowling,
        Amusement_park ,
        Concert

    }

   public class Outing
   {
        public int OutingId { get; set; }
        public int NumberOfAttendee { get; set; }
        public decimal CostperPerson { get; set; }
        public decimal TotalCostforEvent { get; set; }
        public TypeofEvent EventType { get; set; }
        public DateTime Date { get; set; }


        public  Outing() { }

        public  Outing(int numberofAttendee,decimal costperPerson,DateTime date,TypeofEvent eventtype)
        {
            NumberOfAttendee = numberofAttendee;
            CostperPerson = costperPerson;
            Date = date;
            EventType = eventtype;
            TotalCostforEvent = costperPerson * numberofAttendee;
            //TotalCostforEvent =costperPerson*GetCost(EventType);
        }


        //public decimal GetCost(TypeofEvent typeofEvent)
        //{
        //    switch (typeofEvent)
        //    {
        //        case TypeofEvent.Golf:
        //            return 300.00m;
        //        case TypeofEvent.Bowling:
        //            return 500.00m;
        //        case TypeofEvent.Amusement_park:
        //            return 1000.00m;
        //        case TypeofEvent.Concert:
        //            return 5000m;
        //        default:
        //            return 0.0m;
        //    }
        //}
    }
    

    
}
