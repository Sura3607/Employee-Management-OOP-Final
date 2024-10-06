using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementLogic
{
    public interface IDeparment
    {
        string Id { get; }
        string Name { get; }
        Employee Leader { get; }
        List<Employee> Employees { get; }
        bool AddEmployee(Employee employee);
        bool RemoveEmployee(Employee employee);
        bool Find(string keywork);
        List<Employee> GetALL();
    }
}