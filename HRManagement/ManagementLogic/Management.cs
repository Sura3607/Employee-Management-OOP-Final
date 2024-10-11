using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;

namespace ManagementLogic
{
    [Serializable]
    public class Management : ISerializable
    {
        private List<Employee> employeesList= new List<Employee>();
        private List<Department> departmentList = new List<Department>();
        private List<Project> projectList = new List<Project>();
        Data data = new Data();
        private string filePath;

        public Management() { }
        public Management(SerializationInfo info, StreamingContext context)
        {
            employeesList = (List<Employee>)info.GetValue("Employees",typeof(List<Employee>));
            departmentList = (List<Department>)info.GetValue("Departments",typeof (List<Department>));
            projectList = (List<Project>)info.GetValue("Projects",typeof(List<Project>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Employees", employeesList);
            info.AddValue("Departmants", departmentList);
            info.AddValue("Projects",projectList);
        } 
        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
        }
        public void SaveData()
        {
            data.SaveData(this,this.filePath);
        }
        public List<Employee> FindEmployee(string keyword,List<Employee> employlist)
        {
            List<Employee> l = new List<Employee>();
            foreach(Employee e in employlist)
            {
                if (e.Find(keyword))
                {
                    l.Add(e);
                }
            }
            return l;
        }
        public List<Department> FindIDeparment(string keyword)
        {
            List<Department> l = new List<Department>();
            foreach (Department d in departmentList)
            {
                if (d.Find(keyword))
                {
                    l.Add(d);
                }
            }
            return l;
        }

        public void Add(Employee e)
        {

        }
        public void Add(Department d)
        {

        }
        public void Remove(Employee e)
        {

        }
        public void Remove(Department d)
        {

        }
        public void UpdateSalary(Employee e)
        {

        }
    }
}