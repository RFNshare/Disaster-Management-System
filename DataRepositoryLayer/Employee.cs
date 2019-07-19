using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepositoryLayer
{
    public class Employee
    {
        private string employeeId;
        private string employeepassword;
        private string employeeName;
        private double salary;
        private string area;
        private string phoneno;

        private string givenBY;
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeePassword
        {
            get { return employeepassword; }
            set { employeepassword = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }
      
    }
}
