using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
   public class EnrollingProjectData
    {

        private string projectName;
        private string totalAmount;
        private string willServe;
        private string duration;
        private String createdate;

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public string TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
        public string WillServe
        {
            get { return willServe; }
            set { willServe = value; }
        }
        public String Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public String Createdate
        {
            get { return createdate; }
            set { createdate = value; }
        }

    }

}

