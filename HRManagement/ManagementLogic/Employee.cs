using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public abstract class Employee : ISerializable
    {
        private string id;
        private string name;
        private string phone;
        private string email;
        private string address;
        private bool gender;
        private DateTime birthday ;
        private DateTime beginWork ;
        private Department department;
        private List<Project> projects;
        private uint salary;

        //Them điều kiện cho việc set, của các thuộc tính -Email-Phone-Năm sinh phải đủ tuổi lao động-Salary ko được thấp hơn lương cơ bản.
        public string Id
        {
            get => id;
            set
            {
                //Kiểm tra xem có rỗng hoặc null không?
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Id không được để trống");
                id = value; 
            } 
        }
        public string Name
        {
            get => name;
            set
            {
                //Kiểm tra xem có rỗng hoặc null không?
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ten khong duoc de trong");
                name = value;
            }
        }
        public string Phone 
        {
            get => phone;
            set
            {
                // Kiểm tra chuỗi rỗng hoặc null
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Số điện thoại không hợp lệ: không được để trống.");

                // Kiểm tra độ dài của chuỗi phải là 10
                if (value.Length != 10)
                    throw new ArgumentException("Số điện thoại phải có đúng 10 chữ số.");

                // Kiểm tra tất cả các ký tự phải là số
                foreach (char ch in value)
                {
                    if (!char.IsDigit(ch))
                    {
                        throw new ArgumentException("Số điện thoại chỉ được chứa các chữ số.");
                    }
                }

                phone = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                // Kiểm tra chuỗi không rỗng hoặc không chứa chỉ khoảng trắng
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Email không được để trống.");

                // Kiểm tra email có định dạng @gmail.com
                if (!value.EndsWith("@gmail.com"))
                    throw new ArgumentException("Email phải có dạng @gmail.com.");

                email = value;
            }
        }
        public string Address { get => address; set => address = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Birthday
        {
            get => birthday;
            set
            {
                //Kiểm tra xem có đủ tuỏi lao động hay không?
                if (DateTime.Now.Year - value.Year < 18)
                    throw new ArgumentException("Chưa đủ tuỏi lao động");
                else if (DateTime.Now.Year - value.Year==18 && DateTime.Now.Month <value.Month)
                    throw new ArgumentException("Chưa đủ tuỏi lao động");
                else if (DateTime.Now.Year - value.Year == 18 && DateTime.Now.Month == value.Month && DateTime.Now.Day<value.Day)
                    throw new ArgumentException("Chưa đủ tuỏi lao động");
                birthday = value;
            }
        }
        public DateTime BeginWork { get => beginWork; set => beginWork = value; }
        public Department Department 
        { 
            get => department; 
            set
            {
                if (department != null && value != null)
                    throw new ArgumentException("Nhân viên này đang ở trong một phòng ban khác");
                department = value;
            } 
        }
        public uint Salary
        {
            get => salary;
            set
            {
                if (value <= 2340000)
                    throw new ArgumentException($"Lương không được thấp hơn mức lương cơ bản là 2340000 VND.");
                salary = value;
            } 
        }
        public List<Project> Projects { get => projects;}

        protected Employee() { }

        protected Employee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department department, uint salary)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.birthday = birthday;
            this.beginWork = beginWork;
            this.department = department;
            this.projects = new List<Project>();
            this.salary = salary;
        }

        [JsonConstructor]
        protected Employee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department department, uint salary, List<Project> projects = null)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.gender = gender;
            this.birthday = birthday;
            this.beginWork = beginWork;
            this.department = department;
            this.projects = projects ?? new List<Project>(); // Nếu projects null thì khởi tạo mới
            this.salary = salary;
        }
        protected Employee(SerializationInfo info, StreamingContext context)
        {
            id = info.GetString("Id");
            name = info.GetString("Name");
            phone = info.GetString("Phone");
            email = info.GetString("Email");
            address = info.GetString("Address");
            gender = info.GetBoolean("Gender");
            birthday = info.GetDateTime("Birthday");
            beginWork = info.GetDateTime("BeginWork");
            department = (Department)info.GetValue("Department",typeof(Department));
            projects = (List<Project>)info.GetValue("Project",typeof (List<Project>));
            salary = info.GetUInt32("Salary");
        }
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Phone",Phone);
            info.AddValue("Email",Email);
            info.AddValue("Gender",Gender);
            info.AddValue("Birthday", Birthday);
            info.AddValue("BeginWord",BeginWork);
            info.AddValue("Department", Department);
            info.AddValue("Projects", Projects);
            info.AddValue("Salary",Salary);
        }
        public abstract void AddProject(Project project);
        //tạo abstract void RemoveProject
        public abstract bool Find(string keyword);
        public abstract string GetInfo();
    }
}
