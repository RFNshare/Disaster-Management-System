using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public interface InterDonarRepository
    {

        bool Insert(Donarpeople dp);
       // bool Insert(DonationByDonar dd);

       // DonationByDonar GetDonation(string donationId);
      //  List<DonationByNgo> GetAllDonation();
    }
}
