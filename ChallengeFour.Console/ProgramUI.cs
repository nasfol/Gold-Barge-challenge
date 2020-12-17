using ChallengeFour_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFour_Console 
{
    public class ProgramUI
    {

        Outing_Repository _OutingRepo = new Outing_Repository();
        public void Run()
        {
            Seed();
            Menu();

        }

        private void Menu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {
                Console.WriteLine("Select A Menu Option:\n" +
                    "1.Display A List of All Outings.\n" +
                    "2.Add Individual Outing to A List.\n" +
                    "3.Display Total Cost for All Outing.\n" +
                    "4.Display Total Outing Cost By Type.\n" +
                    "5.Exit.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayListOfOuting();
                        break;
                    case "2":
                        AddIndividualOutingToAList();
                        break;
                    case "3":
                        DisplayTotalCostForAllOuting();
                        break;
                    case "4":
                        DsipalyTotalOutingCostByType();
                        break;
                    case "5":
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a Valid Menu Option");
                        break;



                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }
            
        }

        private void AddIndividualOutingToAList()
        {
            // Event Type
            Console.WriteLine("Select the Event type\n"+
                "1.Golf\n"+
                "2.Bowling\n"+
                "3.Amusement_paark\n"+
                "4. Concert");
            string TypeofEventasString  = Console.ReadLine();
            int intasTypeofevent = int.Parse(TypeofEventasString);
            Outing firstouting = new Outing();
            firstouting.EventType = (TypeofEvent)intasTypeofevent;

            //Number of Attendee
            Console.Write("Enter the Number of Attendee: ");
           string Stringasnumberofattendee  = Console.ReadLine();
            int numberofattendee = int.Parse(Stringasnumberofattendee);
            firstouting.NumberOfAttendee = numberofattendee;

            //Cost Per Person
            Console.Write("Enter the Cost per person : ");
            string stringascostperperson = Console.ReadLine();
            decimal costperperson = decimal.Parse(stringascostperperson);
            firstouting.CostperPerson = costperperson;

            //Date of Event
            Console.Write("Enter the Date of the Event(mm/dd/yyyy):");
            DateTime date = DateTime.Parse(Console.ReadLine());
            //  string stringasTotalcostfortheevnt = Console.ReadLine();
            //  decimal TotalCostofEvent = decimal.Parse(stringasTotalcostfortheevnt);
            firstouting.TotalCostforEvent = firstouting.NumberOfAttendee * firstouting.CostperPerson;


            //Call the Add Method and the outing to List

            _OutingRepo.AddOutingToList(firstouting);


        }

        private void DisplayListOfOuting()
        {
            Console.Clear();
            //Call the Display Method from _OutingRepo
            List<Outing> OutingList = _OutingRepo.DisplayListOfOuting();
            Console.WriteLine($"{"S/N",-8}{"Number of Attendee",-30}{"Cost Per Person",-25}{"Total cost Of event",-25}{"Event Type",-20}{"Date of event"}");


            foreach (Outing outing in OutingList)
            {
                // The will create serial number for each outing
                Console.WriteLine($"{outing.OutingId,-8}{outing.NumberOfAttendee,-30}${outing.CostperPerson,-25}${outing.TotalCostforEvent,-25}{outing.EventType,-20}{outing.Date.ToString("MM/dd/yyyy")}");
            }

        }

        private void DisplayTotalCostForAllOuting()
        {
            // Call Calculate All Outingcost Method from __OutingRepo
           decimal totaloutingcost = _OutingRepo.CalculateAllOuting();
            Console.WriteLine($"Combined Cost of Outing for the Year is :${totaloutingcost}");

        }
        private void DsipalyTotalOutingCostByType()
        {
            Console.Clear();
              Console.WriteLine("Select the Event type\n"+
                "1.Golf\n"+
                "2.Bowling\n"+
                "3.Amusement_paark\n"+
                "4. Concert");

            int inputEventType = int.Parse(Console.ReadLine());
            TypeofEvent typeofEvent = (TypeofEvent)inputEventType;

            decimal combinedCosts = _OutingRepo.GetOutingCost(typeofEvent);
            Console.WriteLine($"The Total Cost for {typeofEvent}: {combinedCosts}");
        }

        private void Seed()
        {
            Outing outing1 = new Outing(300, 5.27m, new DateTime(2020, 12, 7), TypeofEvent.Bowling);
            Outing outing2 = new Outing(300, 50.27m, new DateTime(2020, 12, 7), TypeofEvent.Amusement_park);
            Outing outing3 = new Outing(300, 157.27m, new DateTime(2020, 12, 7), TypeofEvent.Concert);

            _OutingRepo.AddOutingToList(outing1);
            _OutingRepo.AddOutingToList(outing2);
            _OutingRepo.AddOutingToList(outing3);
        }


    }
}
