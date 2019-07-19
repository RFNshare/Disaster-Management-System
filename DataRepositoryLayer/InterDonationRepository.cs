using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
   public  interface InterDonationRepository
    {

      
            bool Insert(DonationByNgo d);

        bool Update(Donarpeople dp);



    }
}
