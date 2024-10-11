using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLogic
{
    [Serializable]
    public class FulltimeEmployee : Employee, ICalSalary,ISerializable
    {
        private int senority;
        public int Senority { get => senority; }
        public FulltimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department deparment, uint salary) 
            : base(id, name, phone, email, address, gender, birthday, beginWork, deparment, salary)
        {
            senority = (DateTime.Now.Year - BeginWork.Year);
            if (DateTime.Now.DayOfYear < BeginWork.DayOfYear)
            {
                senority--;
            }
        }
        public FulltimeEmployee(SerializationInfo info, StreamingContext context) : base(info, context) 
        {
            senority = info.GetInt32("Senority");
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Senority",senority);
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
