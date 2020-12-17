using ChallengeTwo_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Console
{
    class ProgramUI
    {
        Claim_Repository _claimRepository = new Claim_Repository();

        public void Run()
        {
            Menu();
        }
        private void Menu()

        {
            bool keeprunning = true;
            while (keeprunning)
            {

                Console.WriteLine("Select A Menu Option:\n" +
                     "1.See All Claims\n" +
                     "2.Take Care of next claim\n" +
                     "3.Enter a new Claim\n" +
                     "4.Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        SeeallClaims();
                        break;
                    case "2":
                        TakeCareofNextClaim();
                        break;
                    case "3":
                        AddClaim();
                        break;
                    case "4":
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Nunber on the Menu");
                        break;

                }
                Console.WriteLine("Please Press Any Key To Continue");
                Console.ReadKey();
                Console.Clear();


            }
        }
       
        public void AddClaim()
        {
            Claim newclaim = new Claim();
            Console.WriteLine("Enter the claim ID");
            newclaim.ClaimID = Console.ReadLine();
            Console.WriteLine("Select Clam Type :\n" +
                "1.Car\n" +
                "2.Home\n" +
                "3.Theft");
            string stringasclaimtype = Console.ReadLine();
            switch (stringasclaimtype)
            {
                case "1":
                    newclaim.ClaimType = TypeofClaim.Car;
                    break;
                case "2":
                    newclaim.ClaimType = TypeofClaim.Home;
                    break;
                case "3":
                    newclaim.ClaimType = TypeofClaim.Theft;
                    break;
            }
            Console.WriteLine("Enter the claim description");
            newclaim.Description = Console.ReadLine();
            Console.WriteLine("Enter Claim Amount");
            newclaim.ClaimAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the incident Date: mm/dd/yyyy");
            newclaim.DateOfIncident = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the claim Date: mm/dd/yyyy");
            newclaim.DateOfClaim = DateTime.Parse(Console.ReadLine());
            TimeSpan Interval = newclaim.DateOfClaim - newclaim.DateOfIncident;
            if (Interval.Days > 0 && Interval.Days<30)
            {
                newclaim.Isvalid = true;
                Console.WriteLine("This Claim is Valid");
            }
            else
            {
                Console.WriteLine("This Claim is not valid");
                newclaim.Isvalid = false;
            }
            _claimRepository.AddClaimToQueue(newclaim);
        }

        public void SeeallClaims()
        {
            Queue<Claim> newqueueclaim = new Queue<Claim>();
            List<Claim> newlist = new List<Claim>();
            newqueueclaim = _claimRepository.ViewlistofClaim();
            newlist = newqueueclaim.ToList();
            Console.WriteLine($"{"CliamID",-10}{"Type",-12}{"Description",-25}{"Amount",-12}{"DateOfAccident",-18}{"DateOfClaim",-18}{"IsValid"}");
            foreach (Claim claim in newlist)
            {
                Console.WriteLine($"{claim.ClaimID,-10}{claim.ClaimType,-12}{claim.Description.Remove(20),-25}{"$"+claim.ClaimAmount,-12}{claim.DateOfIncident.ToString("MM/dd/yyyy"),-18}{claim.DateOfClaim.ToString("MM/dd/yyyy"),-18}{claim.Isvalid}");
            }
        }


        public void TakeCareofNextClaim()
        {
            
            Claim newqueueclaim=  _claimRepository.ViewNextClaim();
            Console.WriteLine("Here are the details of the next claim to be handled");
            Console.WriteLine($"{"ClaimID:"}{newqueueclaim.ClaimID}\n" +
                $"{"Type:"}{newqueueclaim.ClaimType}\n" +
                $"{"Description:"}{newqueueclaim.Description}\n" +
                $"{"Amount:"}{newqueueclaim.ClaimAmount}\n" +
                $"{"DateOfAccident:"}{newqueueclaim.DateOfIncident}\n" +
                $"{"DateOfClaim:"}{newqueueclaim.DateOfClaim}\n" +
                $"{"Type:"}{newqueueclaim.ClaimType}");
            Console.WriteLine("Do You want to deal with this claim now(y/n)");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                _claimRepository.DeleteMethod();
            }
            
            
           
            

            


        }
    }
}
 