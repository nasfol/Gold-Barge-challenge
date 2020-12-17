using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo_Repository
{
    public class Claim_Repository
    {
        private Queue<Claim> claimQueue = new Queue<Claim>();

        //Create Method
        public void AddClaimToQueue(Claim newclaim)
        {
            claimQueue.Enqueue(newclaim);

        }
        //Read Method
        public Queue<Claim> ViewlistofClaim()
        {
            return claimQueue;
        }

        public Claim ViewNextClaim()
        {
            return claimQueue.Peek();

        }

        //Update Method
        public bool UpdateMethod(Claim myclaim, string claimid)
        {

            Claim oldclaim = GetClaimByID(claimid);
            if (oldclaim.ClaimID == claimid)
            {
                oldclaim.ClaimAmount = myclaim.ClaimAmount;
                oldclaim.ClaimID = myclaim.ClaimID;
                oldclaim.ClaimType = myclaim.ClaimType;
                oldclaim.DateOfClaim = myclaim.DateOfClaim;
                oldclaim.DateOfIncident = myclaim.DateOfIncident;
                oldclaim.Description = myclaim.Description;
                oldclaim.Isvalid = myclaim.Isvalid;
                return true;

            }
            else
            {
                return false;
            }

        }
        //Delete Method
        public void DeleteMethod()
        {

            claimQueue.Dequeue();
        }





        //Helper Method
        public Claim GetClaimByID(string claimid)
        {
            //ViewlistofClaim();
            foreach (Claim item in  claimQueue)
                
            {
                if (item.ClaimID == claimid)
                    return item;
            }
            return null;
        }
    }
}

