using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
   public  class Donarpeople
    {
        
        private string donarId;
        private string donarpassword;
        private string donarName;
       // private
         private string donarPhoneno;
        private string organization;


        public string DonarId
        {
            get { return donarId; }
            set { donarId = value; }
        }
        public string Donarpassword
        {
            get { return donarpassword; }
            set { donarpassword = value; }
        }
        public string DonarName
        {
            get { return donarName; }
            set { donarName = value; }
        }
        public String DonarPhoneno
        {
            get { return donarPhoneno; }
            set { donarPhoneno = value; }
        }
        public string Organization
        {
            get { return organization; }
            set { organization = value; }
        }

    }
}

