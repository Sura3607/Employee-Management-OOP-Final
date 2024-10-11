using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLogic
{
    public class ParttimeEmployee : Employee, ICalSalary
    {
        private int worktime;
        public int Worltime { get => worktime; }
        public ParttimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department deparment, uint salary) 
            : base(id, name, phone, email, address, gender, birthday, beginWork, deparment, salary)
        {

        }
        public ParttimeEmployee(SerializationInfo info, StreamingContext context)  : base(info, context) 
        {
            worktime = info.GetInt32("Worktime");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Worktime",worktime);
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
