using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace ManagementLogic
{
    public abstract class Employee
    {
        private string id;
        private string name;
        private string phone;
        private string email;
        private string address;
        private bool gender;
        private DateTime birthday ;
        private DateTime beginWork ;
        private Deparment deparment;
        private uint salary;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime BeginWork { get => beginWork; set => beginWork = value; }
        public Deparment Deparment { get => deparment; set => deparment = value; }
        public uint Salary { get => salary; set => salary = value; }

        protected Employee(string id, string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, Deparment deparment, uint salary)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Gender = gender;
            Birthday = birthday;
            BeginWork = beginWork;
            Deparment = deparment;
            Salary = salary;
        }

        public abstract bool Find(string keyword);
        public abstract string GetInfo();

    }
}