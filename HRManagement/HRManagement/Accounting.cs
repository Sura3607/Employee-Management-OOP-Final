using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement
{
    public class Accounting : IDeparment
    {
        public string Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public Employee Leader => throw new NotImplementedException();

        public List<Employee> Employees => throw new NotImplementedException();

        public bool AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Find(string key)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetALL()
        {
            throw new NotImplementedException();
        }

        public bool RemoveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}