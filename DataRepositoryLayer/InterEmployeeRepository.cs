using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public interface InterEmployeeRepository
    {

     
            bool Insert(DonationByNgo d);
           // bool Update(Employee d);
          //  bool Delete(string employeeId);
          //  Employee GetEmployee(string employeeId);
            List<Employee> GetAllEmployee();
       
    }
}
