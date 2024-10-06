﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace ManagementLogic
{
    public class Employee
    {
        private static int _nextId = 1;
        public string Id;
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public bool Gender { get; private set; }
        public DateTime Birthday { get; internal set; }
        public DateTime BeginWork { get; internal set; }
        public IDeparment Deparment { get; private set; }
        public uint BaseSalary { get; private set; }
        public byte AnnualLeave = 12;

        public string Duty { get; private set; }
        public Employee(string name, string phone, string email, string address, bool gender, DateTime birthday, DateTime beginWork, IDeparment deparment, uint baseSalary, string duty = "")
        {
            Id = GenerateId();
            Name = name;
            Phone = phone;
            Email = email;
            Address = address;
            Gender = gender;
            Birthday = birthday;
            BeginWork = beginWork;
            Deparment = deparment;
            BaseSalary = baseSalary;
            Duty = duty;
        }

        private string GenerateId()
        {
            string id = $"{_nextId:D4}";
            _nextId++;
            return id;
        }
        public void UpdateName(string name)
        {
            Name = name;
        }
        public void UpdatePhone(string phone)
        {
            Phone = phone;
        }
        public void UpdateEmail(string email)
        {
            Email = email;
        }
        public void UpdateAddress(string address)
        {
            Address = address;
        }
        public void UpdateDaparment(IDeparment deparment)
        {
            Deparment = deparment;
        }
        public void UpdateBaseSalary(uint baseSalary)
        {
            BaseSalary = baseSalary;
        }

        public bool Find(string keyword)
        {
            return Id.IndexOf(keyword) >= 0
                || Name.IndexOf(keyword) >= 0
                || Phone.IndexOf(keyword) >= 0
                || Email.IndexOf(keyword) >= 0;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}