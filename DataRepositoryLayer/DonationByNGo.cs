using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public class DonationByNgo
    {
        private string donationId;
        private String employeeId;
        private string donationTitle;
        private string recieverId;
         private String giveBYID;
        private string givenTime;
        private String recieverPhone;
        private string donationItem;

        public string DonationId
        {
            get { return donationId; }
            set { donationId = value; }
        }
        public string DonationTitle
        {
            get { return donationTitle; }
            set { donationTitle = value; }
        }
        public string RecieverId
        {
            get { return recieverId; }
            set { recieverId = value; }
        }
        public String GivenTime
        {
            get { return givenTime; }
            set { givenTime = value; }
        }
        public String DonationItem
        {
            get { return donationItem; }
            set { donationItem = value; }
        }
        public String RecieverPhone
        {
            get { return recieverPhone; }
            set { recieverPhone = value; }
        }
        public string GiveBYID
        {
            get { return giveBYID; }
            set { giveBYID = value; }
        }
    }
}
