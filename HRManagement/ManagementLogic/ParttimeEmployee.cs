using System;
using System.Runtime.Serialization;

namespace ManagementLogic
{
    public class ParttimeEmployee : Employee, ICalSalary
    {
        private int worktime;
        public int Worktime { get => worktime; set => worktime = value; }
        public ParttimeEmployee():base(){}
        public ParttimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department deparment, uint salary = 25000, int worktime = 0) 
            : base(id, name, phone, email, address, gender, birthday, beginWork, deparment, 25000)
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
            info.AddValue("Worktime",Worktime);
        }
        //Tính lương theo giờ làm việc, lấy lương của đối tượng tính với giờ làm 
        public double CalculateSalary()
        {
            return Salary*worktime;
        }
        //Tìm theo id,tên, email,phone 
        public override bool Find(string keyword)
        {
            return Id.IndexOf(keyword) >= 0 ||
                   Name.IndexOf(keyword) >= 0 ||
                   Email.IndexOf(keyword) >= 0 ||
                   Phone.IndexOf(keyword) == 10;
        }
        //Trả về một chuỗi, lầm sao đẹp nhất có thể 
        public override string GetInfo()
        {
            return $"ID:{Id}] \n Tên nhân viên:{Name} \n Email: {Email} \n Số điện thoại: {Phone}";
        }

        //Thêm vào listProject một project mới
        public override void AddProject(Project project)
        {
            if (Projects.Contains(project))
                throw new Exception("Project đã tồn tại trong danh sách.");
            Projects.Add(project);
        }
    }
}
