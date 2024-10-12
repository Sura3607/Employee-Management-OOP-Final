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
        public ParttimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department deparment, uint salary, int worktime) 
            : base(id, name, phone, email, address, gender, birthday, beginWork, deparment, salary)
        {
            this.worktime = worktime;
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
        //Tính lương theo giờ làm việc, lấy lương của đối tượng tính với giờ làm 
        public double CalculateSalary()
        {
            throw new NotImplementedException();
        }
        //Tìm theo id,tên, email,phone 
        public override bool Find(string keyword)
        {
            throw new NotImplementedException();
        }
        //trả về sao cho đẹp là được
        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
        //Thêm vào listProject một project mới
        public override void AddProject(Project project)
        {
            throw new NotImplementedException();
        }
    }
}
