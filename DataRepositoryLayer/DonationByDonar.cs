using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
   public class DonationByDonar
    {
        private string donarId;
        private string donarname;
        private string donationId;
        private string donationTitle;
         private string bkashNo;
        private DateTime givenTime;
        private double donateddollars;
        private string donarphone;



        public string DonarId
        {
            get { return donarId; }
            set { donarId = value; }
        }
        public string DonarName
        {
            get { return donarname; }
            set { donarname = value; }
        }

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
        public string  Donarphone
        {
            get { return donarphone; }
            set { donarphone = value; }
        }
        public string BKashRefferNo
        {
            get { return bkashNo; }
           set { bkashNo = value; }
        }
        public DateTime GivenTime
        {
            get { return givenTime; }
            set { givenTime = value; }
        }
        public double Donateddollars
        {
            get { return donateddollars; }
            set { donateddollars = value; }
        }
    }
}
