using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManagementLogic
{
    [Serializable]
    public class FulltimeEmployee : Employee, ICalSalary,ISerializable
    {
        private int senority;
        public int Senority { get => senority; }
        public FulltimeEmployee() : base() { }
        public FulltimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department deparment, uint salary) 
            : base(id, name, phone, email, address, gender, birthday, DateTime.Now, deparment, 5000000)
        {
            senority = (DateTime.Now.Year - BeginWork.Year);
            if (DateTime.Now.DayOfYear < BeginWork.DayOfYear)
            {
                senority--;
            }
        }

        [JsonConstructor]
        public FulltimeEmployee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department department, uint salary, int senority)
        : base(id, name, phone, email, address, gender, birthday, beginWork, department, salary)
        {
            this.senority = senority;
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
        //Tính lương dựa theo thâm niên tự tạo hợp lí là được
        public double CalculateSalary()
        {
            return Salary * (senority / 5) * 1.1;
        }
        //Tìm theo id, tên, email, phone
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
