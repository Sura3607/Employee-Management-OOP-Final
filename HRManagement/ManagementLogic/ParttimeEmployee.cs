using System;
using System.Runtime.Serialization;

namespace ManagementLogic
{
    public class ParttimeEmployee : Employee
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
        public override double CalculateSalary()
        {
            return Salary*worktime;
        }
        public override bool Find(string keyword)
        {
            return Id.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   Email.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   Phone.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) == 10;
        }
        public override void AddProject(Project project)
        {
            if (Projects.Contains(project))
                throw new Exception("Project đã tồn tại trong danh sách.");
            Projects.Add(project);
        }
    }
}
