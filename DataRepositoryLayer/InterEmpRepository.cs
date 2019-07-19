using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public interface InterEmpRepository
    {

     
        bool UserLoginVerification(Employee obj);
         bool Update(Employee user);

        bool Insert(DonationByNgo dp);

        List<DonationByDonar> GetALLDonarGivenDonation();


        List<DonationByDonar> SearchALLDonarGivenDonation(String text);


      
    }
}
