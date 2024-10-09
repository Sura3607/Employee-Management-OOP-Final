using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLogic
{
    public class ParttimeEmployee : Employee, ICalSalary
    {
        int worktime;
        public ParttimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Deparment deparment, uint salary) 
            : base(id, name, phone, email, address, gender, birthday, beginWork, deparment, salary)
        {

        }

        public double CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public override bool Find(string keyword)
        {
            throw new NotImplementedException();
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
