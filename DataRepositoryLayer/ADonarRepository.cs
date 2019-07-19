using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public class ADonarRepository : InterDonationRepository
    {
        bool Insert(DonationByNgo d)
        {
            try
            {
                string query = "INSERT into DonationNGOgivenByTable VALUES ('" + d.DonationId + "', '" + d.DonationTitle + "', '" + d.RecieverId + "', '" + d.GivenTime + "', '" + d.DonationItem + "')";
                DatabaseConnectionClass dcc = new DatabaseConnectionClass();
                dcc.ConnectWithDB();
                int x = dcc.ExecuteSQL(query);
                return true;
            }
            catch (Exception exa)
            {
                return false;
            }
        }
        //  }
        //}
        public bool Update(Donarpeople dp)
        {
            try
            {
                string query2 = "UPDATE DonatorInfoTable SET DonarName = '" + dp.DonarName + "', DonarPhoneno = " + dp.DonarPhoneno + "WHERE  DonarId = '" + dp.DonarId + "'";
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

        public bool Insert(Donarpeople dp)
        {
            throw new NotImplementedException();
        }

        bool InterDonationRepository.Insert(DonationByNgo d)
        {
            throw new NotImplementedException();
        }
    }
}

