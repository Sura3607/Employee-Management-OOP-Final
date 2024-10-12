using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;

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
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime BeginWork { get => beginWork; set => beginWork = value; }
        public Department Department { get => department; set => department = value; }
        public uint Salary { get => salary; set => salary = value; }
        public List<Project> Projects { get => projects; set => projects = value; }

        //Khi tạoh đối tượng mới sẽ mặch định projects của đối tượng là rỗng 
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
        public abstract bool Find(string keyword);
        public abstract string GetInfo();
    }
}