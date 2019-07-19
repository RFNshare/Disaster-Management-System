using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public interface InterRecieverPeople
    {

        
        bool Insert(RecieverPeople d);
        bool Update(RecieverPeople d);
        bool Delete(string RecieverPeopleId);
        RecieverPeople GetRecieverPeople(string RecieverPeopleId);
        List<RecieverPeople> GetAllRecieverPeople();

    }
}
