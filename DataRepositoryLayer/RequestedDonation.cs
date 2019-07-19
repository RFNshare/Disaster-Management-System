using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
   public class RequestedDonation
    {
        
        private string recieverId;
       
        private string recieverArea;

        private string recieverPhoneno;
        private string recieverGood;
        private string requestid;
        private DateTime requestedDate;


        public string RecieverId
        {
            get { return recieverId; }
            set { recieverId = value; }
        }
        public string RecieverGood
        {
            get { return recieverGood; }
            set { recieverGood = value; }
        }
       public string RecieverName
        {
        get { return recieverId; }
           set { recieverId = value; }
      }



        public string RecieverArea
        {
            get { return recieverArea; }
            set { recieverArea = value; }
        }
        public string RecieverPhoneNo
        {
            get { return recieverPhoneno; }
            set { recieverPhoneno = value; }
        }

        public DateTime RequestedDate
        {
            get { return requestedDate; }
            set { requestedDate = value; }
        }
        public string RequestId
        {
            get { return requestid; }
            set { requestid = value; }
        }
    }
}
   