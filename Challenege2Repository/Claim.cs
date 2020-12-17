using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repository
{
    public enum TypeofClaim
    {
        Car=1,
        Home,
        Theft,

    }
    public class Claim
    {
        public string ClaimID { get; set; }
        public TypeofClaim ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool Isvalid { get; set; }

        public Claim() { }

        public Claim(string claimID,TypeofClaim claimtype,string description,decimal claimamount,DateTime dateofincident,DateTime dateofclaim,bool isvalid)
        {
            ClaimID = claimID;
            ClaimType = claimtype;
            Description = description;
            ClaimAmount = claimamount;
            DateOfIncident = dateofincident;
            DateOfClaim = dateofclaim;
            Isvalid = isvalid;
        }

       

    }
    

}
