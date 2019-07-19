using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
  public   class UpcomingEvent
    {

        private string projectname;
        private string projectID;
        private string projectarea;
        private DateTime proposedDate;
       // private string area;
      //  private string phoneno;


        public string Projectname
        {
            get { return projectname; }
            set { projectname = value; }
        }
        public string ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }
       
        public string Projectarea
        {
            get { return projectarea; }
            set { projectarea = value; }
        }
        public DateTime ProposedDate
        {
            get { return proposedDate; }
            set { proposedDate = value; }
        }
    }
}

