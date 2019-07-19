using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
   public class RecieverPeople
    {

        private string recieverId;
        private string recieverpassword;
        private string recieverName;
       
        private string recieverArea;
       
        private string recieverPhoneno;


        public string RecieverId
        {
            get { return recieverId; }
            set { recieverId = value; }
        }
        public string RecieverPassword
        {
            get { return recieverpassword; }
            set { recieverpassword = value; }
        }
        public string RecieverName
        {
            get { return recieverName; }
            set { recieverName = value; }
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
    }
}
