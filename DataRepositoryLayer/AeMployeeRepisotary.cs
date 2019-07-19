using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
    {
        public class AeMployeeRepisotary : InterEmpRepository
    {
      

        public bool UserLoginVerification(Employee obj)
        {
            string query = "SELECT * from EmployeeTable WHERE EmployeeId= '" + obj.EmployeeId + "' AND EmployeePassword= '" + obj.EmployeePassword + "'";
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            if (sdr.Read())
            {
                obj.EmployeeId = sdr["EmployeeId"].ToString();
                obj.Phoneno = sdr["Phoneno"].ToString();

                obj.EmployeeName = sdr["EmployeeName"].ToString();
                obj.Salary = Convert.ToDouble(sdr["Salary"]);
                //obj.Area = sdr[" Area"].ToString();
                dcc.CloseConnection();
                return true;
            }
            else
            {
                dcc.CloseConnection();
                return false;
            }
        }

   //     public bool Update(Employee user)
    //    {
      //      throw new NotImplementedException();
     //   }

        //  DonationByNgo
        public bool Insert(DonationByNgo dp)
        {
            try
            {
               // GiveBYID
                string query = "INSERT into DonationNGOgivenByTable VALUES ('" + dp.DonationId + "', '" + dp.DonationTitle + "', '" + dp.RecieverId + "', '" + dp.GivenTime + "', '" + dp.DonationItem + "','" + dp.RecieverPhone + "','" + dp.GiveBYID + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exam)
            {
                return false;
            }
        }
     


        public List<DonationByDonar> GetALLDonarGivenDonation()
        {
            string query = "SELECT * from DonarGivenItemTable";
            List<DonationByDonar> asdList = new List<DonationByDonar>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                DonationByDonar bez = new DonationByDonar();
                bez.DonarName = sdr["DonarName"].ToString();

                bez.DonationTitle = sdr["DonationTitle"].ToString();

                bez.DonarId = sdr["DonarId"].ToString();
                bez.Donateddollars = Convert.ToDouble(sdr["Donateddollars"]);
                bez.Donarphone = sdr["Donarphone"].ToString();

                bez.GivenTime = Convert.ToDateTime(sdr["GivenTime"]);

                bez.DonationId = sdr["DonationId"].ToString();
                bez.BKashRefferNo = sdr["BKashRefferNo"].ToString();

                asdList.Add(bez);



               // asdList.Add(a);
            }
            return asdList;
        }

      
        //string query12 = "SELECT * from DonarGivenItemTable WHERE DonarId LIKE '%" + text + "%' OR BkashNo LIKE '%" + text + "%'  DonationId LIKE '%" + text + "%' OR DonationTitle LIKE '%" + text + "%' OR DonarName LIKE '%" + text + "%' OR GivenTime LIKE '%" + text + "%'  OR Donarphone LIKE '%" + text + "%'   OR Donateddollars LIKE '%" + text + "%'";
        public List<DonationByDonar> SearchALLDonarDonation(String text)
        {
            // string query = "SELECT * from RequestedDonationTable WHERE  RecieverPhoneNo LIKE '%" + text + "%' OR RecieverId LIKE '%" + text + "%' OR RecieverGood LIKE '%" + text + "%' OR RecieverName LIKE '%" + text + "%'  OR RecieverArea LIKE '%" + text + "%' OR RequestId LIKE '%" + text + "%'  OR RequestedDate LIKE '%" + text + "%'";


            // string query = "SELECT * from DonarGivenItemTable WHERE DonarId LIKE '%" + text + "%' OR DonarName LIKE '%" + text + "%' OR DonationTitle LIKE '%" + text + "%' OR Donateddollars LIKE '%" + text + "%' OR Donarphone LIKE '%" + text + "%' OR GivenTime LIKE '%" + text + "%' OR DonationId LIKE '%" + text + "%' OR  BkashNo LIKE '%" + text + "%'  ";
            string query = "SELECT * from DonarGivenItemTable WHERE DonarId LIKE '%" + text + "%' OR DonarName LIKE '%" + text + "%'  OR DonationTitle LIKE '%" + text + "%' OR Donateddollars LIKE '%" + text + "%' OR Donarphone LIKE '%" + text + "%' OR GivenTime LIKE '%" + text + "%' OR DonationId LIKE '%" + text + "%'  OR BKashRefferNo LIKE '%" + text + "%' ";



            List<DonationByDonar> asdxList = new List<DonationByDonar>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                DonationByDonar bez = new DonationByDonar();
                bez.DonarName = sdr["DonarName"].ToString();

                bez.DonationTitle = sdr["DonationTitle"].ToString();

                bez.DonarId = sdr["DonarId"].ToString();
                bez.Donateddollars = Convert.ToDouble(sdr["Donateddollars"]);
                bez.Donarphone = sdr["Donarphone"].ToString();

                bez.GivenTime = Convert.ToDateTime(sdr["GivenTime"]);

                bez.DonationId = sdr["DonationId"].ToString();
                bez.BKashRefferNo = sdr["BKashRefferNo"].ToString();

                asdxList.Add(bez);



                // asdList.Add(a);
            }
            return asdxList;
        }

        public List<RequestedDonation> GetALLRequestedDonation()
        {
            string query = "SELECT * from RequestedDonationTable";
            List<RequestedDonation> asdList = new List<RequestedDonation>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                RequestedDonation a = new RequestedDonation();
                a.RecieverId = sdr["RecieverId"].ToString();

                a.RecieverGood = sdr["RecieverGood"].ToString();

                a.RecieverName = sdr["RecieverName"].ToString();
                a.RecieverArea = sdr["RecieverArea"].ToString();
                a.RecieverPhoneNo = sdr["RecieverPhoneNo"].ToString();

                a.RequestedDate = Convert.ToDateTime(sdr["RequestedDate"]);

                a.RequestId = sdr["RequestId"].ToString();

                asdList.Add(a);
            }
            return asdList;
        }
      //  DonationByDonar


        public List<RequestedDonation> SearchALLRequestedDonation(String text)
        {
            string query = "SELECT * from RequestedDonationTable WHERE  RecieverPhoneNo LIKE '%" + text + "%' OR RecieverId LIKE '%" + text + "%' OR RecieverGood LIKE '%" + text + "%' OR RecieverName LIKE '%" + text + "%'  OR RecieverArea LIKE '%" + text + "%' OR RequestId LIKE '%" + text + "%'  OR RequestedDate LIKE '%" + text + "%'";
            List<RequestedDonation> asdList = new List<RequestedDonation>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                RequestedDonation a = new RequestedDonation();
                a.RecieverId = sdr["RecieverId"].ToString();

                a.RecieverGood = sdr["RecieverGood"].ToString();

                a.RecieverName = sdr["RecieverName"].ToString();
                a.RecieverArea = sdr["RecieverArea"].ToString();
                a.RecieverPhoneNo = sdr["RecieverPhoneNo"].ToString();
                a.RequestedDate = Convert.ToDateTime(sdr["RequestedDate"]);

                a.RequestId = sdr["RequestId"].ToString();

                asdList.Add(a);
            }
            return asdList;
        }

        public List<EnrollingProjectData> GetallEnrollingProjectdata()
        {
            string query = "SELECT * from EnrollingprojectTable";
            List<EnrollingProjectData> asList = new List<EnrollingProjectData>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                EnrollingProjectData a = new EnrollingProjectData();
                a.ProjectName = sdr["ProjectName"].ToString();

                a.TotalAmount = sdr["TotalAmount"].ToString();

                a.WillServe = sdr["WillServe"].ToString();
                a.Duration = sdr["Duration"].ToString();

                a.Createdate = sdr["Createdate"].ToString();


                asList.Add(a);
            }
            return asList;
        }
        public List<EnrollingProjectData> searchProjectdata(string text)
        {
            string query = "SELECT * from EnrollingprojectTable WHERE projectName LIKE '%" + text + "%' OR totalAmount LIKE '%" + text + "%' OR willServe LIKE '%" + text + "%' OR duration LIKE '%" + text + "%'  OR createdate LIKE '%" + text + "%'" ;
            List<EnrollingProjectData> asList = new List<EnrollingProjectData>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                EnrollingProjectData a = new EnrollingProjectData();
                a.ProjectName = sdr["ProjectName"].ToString();
               
                a.TotalAmount = sdr["TotalAmount"].ToString();

                a.WillServe = sdr["WillServe"].ToString();
                   a.Duration = sdr["Duration"].ToString();

                   a.Createdate = sdr["Createdate"].ToString();
              

                asList.Add(a);
            }
            return asList;
        }

        
       public List<DonationByNgo> GetAllDonation()
                        {
                            string query22 = "SELECT * from DonationNGOgivenByTable";
                            List<DonationByNgo> bList = new List<DonationByNgo>();

                            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                            dcc.ConnectWithDB();
                     SqlDataReader sdr = dcc.GetData(query22);
                       while (sdr.Read())
                            {
                                DonationByNgo bd = new DonationByNgo();
                                   bd.DonationId = Convert.ToString(sdr["DonationId"]);
                                bd.DonationTitle = Convert.ToString(sdr["DonationTitle"]);
               bd.RecieverId = Convert.ToString(sdr["RecieverId"]);
                                bd.GivenTime = Convert.ToString(sdr["GivenTime"]);
               bd.DonationItem = Convert.ToString(sdr["DonationItem"]);
               bd.RecieverPhone = Convert.ToString(sdr["RecieverPhone"]);
                bd.GiveBYID = Convert.ToString(sdr["GiveBYID"]);


                bList.Add(bd);
                            }
                            return bList;
                        }

        public List<DonationByNgo> SearchAllDonation(String text) //GiveBYID
        {
            string query22 = "SELECT * from DonationNGOgivenByTable   WHERE DonationId LIKE '%" + text + "%' OR DonationTitle LIKE '%" + text + "%' OR RecieverId LIKE '%" + text + "%' OR GivenTime LIKE '%" + text + "%'  OR DonationItem LIKE '%" + text + "%' OR GiveBYID LIKE '%" + text + "%'  OR RecieverPhone LIKE '%" + text + "%'";
            List<DonationByNgo> bList = new List<DonationByNgo>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query22);
            while (sdr.Read())
            {
                DonationByNgo bd = new DonationByNgo();
                bd.DonationId = Convert.ToString(sdr["DonationId"]);
                bd.DonationTitle = Convert.ToString(sdr["DonationTitle"]);
                bd.RecieverId = Convert.ToString(sdr["RecieverId"]);
                bd.GivenTime = Convert.ToString(sdr["GivenTime"]);
                bd.DonationItem = Convert.ToString(sdr["DonationItem"]);
                bd.RecieverPhone = Convert.ToString(sdr["RecieverPhone"]);
                bd.GiveBYID = Convert.ToString(sdr["GiveBYID"]);


                bList.Add(bd);
            }
            return bList;
        }
     
        public List<RecieverPeople> searchRecieverPeople(string text)
        {
            string query13 = "SELECT RecieverId,RecieverName,RecieverArea,RecieverPhoneNo from RecieverPeopleTable WHERE RecieverId LIKE '%" + text + "%'  OR RecieverName LIKE '%" + text + "%'  OR RecieverArea LIKE '%" + text + "%' OR RecieverPhoneNo LIKE '%" + text + "%' ";
            List<RecieverPeople> modifiedNewList = new List<RecieverPeople>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query13);
            while (sdr.Read())
            {
                RecieverPeople obj = new RecieverPeople();
                obj.RecieverId = sdr["RecieverId"].ToString();
                obj.RecieverName = sdr["RecieverName"].ToString();
                obj.RecieverArea = sdr["RecieverArea"].ToString();
                obj.RecieverPhoneNo = sdr["RecieverPhoneNo"].ToString();

                 modifiedNewList.Add(obj);
            }
            return modifiedNewList;
        }


        public List<RecieverPeople> GetallRecieverPeople()
        {
            string query = "SELECT RecieverId,RecieverName,RecieverArea,RecieverPhoneNo from RecieverPeopleTable ";
            List<RecieverPeople> asamList = new List<RecieverPeople>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
            {
                RecieverPeople ba = new RecieverPeople();
              

                ba.RecieverId = sdr["RecieverId"].ToString();
                 ba.RecieverName = sdr["RecieverName"].ToString();

                ba.RecieverArea = sdr["RecieverArea"].ToString();
                ba.RecieverPhoneNo = sdr["RecieverPhoneNo"].ToString();

            


                asamList.Add(ba);
            }
            return asamList;
        }
        public bool DeleteReciever(string RecieverIdtext)
        {
            try
            {
                string query = "DELETE From RecieverPeopleTable WHERE RecieverId='" + RecieverIdtext + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Insert(UpcomingEvent dpa)
        {
            try
            {
                //String combo1 = Convert.ToString(this.DonationTitleCombobox.SelectedItem);  RecieverPhone
                string query = "INSERT into UpcomingEventTable VALUES ('" + dpa.ProjectID + "', '" + dpa.Projectname + "', '" + dpa.Projectarea + "', '" + dpa.ProposedDate + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exfa)
            {
                return false;
            }
        }
        public bool Delete(string ProjectIdtext)
        {
            try
            {
                string query = "DELETE From UpcomingEventTable WHERE ProjectID='" + ProjectIdtext + "'";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Updatex(UpcomingEvent xaxxc)
        {
            try
            {
                string query2 = "UPDATE UpcomingEventTable SET Projectname = '" + xaxxc.Projectname + "', Projectarea = '" + xaxxc.Projectarea + "',ProposedDate = '" + xaxxc.ProposedDate + "'  WHERE  ProjectID = '" + xaxxc.ProjectID + "'";
                // string query2 = "UPDATE UpcomingEvent SET Projectname = '" + tas.Projectname + "', Projectarea = "' + tas.Projectarea "'  WHERE  ProposedDate = '" + tas.ProposedDate + "';
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query2);
                return true;
            }
            catch (Exception exasz)
            {
                return false;
            }
        }

        public bool Updater(Employee pas22nd)
        {
            try
            {
                string query2 = "UPDATE EmployeeTable SET EmployeePassword = '" + pas22nd.EmployeePassword + "'  WHERE  EmployeeId = '" + pas22nd.EmployeeId + "'";
                
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query2);
                return true;
            }
            catch (Exception exasjuz)
            {
                return false;
            }
        }
        public List<UpcomingEvent> GetAllUpcomingList()
        {
            string query22 = "SELECT * from UpcomingEventTable";
            List<UpcomingEvent> bList = new List<UpcomingEvent>();

            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query22);
            while (sdr.Read())
            {
                UpcomingEvent a = new UpcomingEvent();
                //  a.ProjectId = sdr["ProjectId"].ToString();

                a.Projectname = sdr["Projectname"].ToString();

                a.Projectarea = sdr["Projectarea"].ToString();
                a.ProjectID = sdr["ProjectId"].ToString();

                a.ProposedDate = Convert.ToDateTime(sdr["ProposedDate"]);


                bList.Add(a);
            }
            return bList;
        }
        //}
        public List<UpcomingEvent> searchUpcomingEvent(string text)
        {
            string query = "SELECT * from UpcomingEventTable WHERE Projectname LIKE '%" + text + "%' OR Projectarea LIKE '%" + text + "%' OR ProposedDate LIKE '%" + text + "%'   OR ProjectId LIKE '%" + text + "%'";
            List<UpcomingEvent> asList = new List<UpcomingEvent>();
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);
            while (sdr.Read())
             {
                UpcomingEvent a = new UpcomingEvent();
              //  a.ProjectId = sdr["ProjectId"].ToString();

                a.Projectname = sdr["Projectname"].ToString();

                a.Projectarea = sdr["Projectarea"].ToString();
                a.ProjectID = sdr["ProjectId"].ToString();

                a.ProposedDate = Convert.ToDateTime(sdr["ProposedDate"]);


                asList.Add(a);
             }
            return asList;
           }

        public List<DonationByDonar> SearchALLDonarGivenDonation(string text)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee user)
        {
            throw new NotImplementedException();
        }
    }


    
    }




