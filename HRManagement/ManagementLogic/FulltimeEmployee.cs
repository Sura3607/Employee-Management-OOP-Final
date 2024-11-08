using System;
using System.Runtime.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class FulltimeEmployee : Employee, ISerializable,ICalSalary
    {
        private int senority;
        public int Senority { get => senority; set => senority = value; }
        public FulltimeEmployee() : base() { }
        public FulltimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department deparment, uint salary = 5000000) 
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
            info.AddValue("Senority",Senority);
        }
        public double CalculateSalary()
        {
            return Salary + ((double)senority / 5) * Salary;
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
            foreach (Project p in Projects)
            {
                if (p.Id == project.Id)
                {
                    throw new Exception("Project đã tồn tại trong danh sách.");
                }
            }

            Projects.Add(project);
        }
    }
}
