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
        private Department deparment;
        private uint salary;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime BeginWork { get => beginWork; set => beginWork = value; }
        public Department Department { get => deparment; set => deparment = value; }
        public uint Salary { get => salary; set => salary = value; }

        protected Employee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Department department, uint salary)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Gender = gender;
            Birthday = birthday;
            BeginWork = beginWork;
            Department = department;
            Salary = salary;
        }
        protected Employee(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            Name = info.GetString("Name");
            Phone = info.GetString("Phone");
            Email = info.GetString("Email");
            Address = info.GetString("Address");
            Gender = info.GetBoolean("Gender");
            Birthday = info.GetDateTime("Birthday");
            BeginWork = info.GetDateTime("BeginWork");
            Department = (Department)info.GetValue("Department",typeof(Department));
            Salary = info.GetUInt32("Salary");
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
            info.AddValue("Salary",Salary);
        }
        public abstract bool Find(string keyword);
        public abstract string GetInfo();

        
    }
}