using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLogic
{
    public class Run // main thuc thi hanh dong ow day, tien xu li
    {
        private Management management = null;
        private static Run instance;
        private Run() { }
        public static Run Instance 
        {
            get
            {
                if(instance == null)
                    instance = new Run();
                return instance;
            }
        }
        public void Login(string username, string password)
        {
            List<Account> accounts = Data.LoadAccounts();

            Account account = null;
            foreach(Account a in accounts)
            {
                if(a.UserName == username)
                {
                    account = a;
                    break;
                }
            }
            if (account == null || !account.IsValidPassword(password))
            {
                throw new Exception("Tài khoản hoặc mật khẩu sai");
            }
            
            management = Data.LoadData(account.GetFilePath());
            management.SetFilePath(account.GetFilePath());
            management.SetCurrentAccount(account);
        }
        public void AddADMIN(string username, string password)
        {
            try
            {
                management.AddADMIN(username, password);
            }
            catch (Exception e) { }
        }
        public void ChangePass(string password, string newPassword)
        {
            try
            {
                management.ChangePasssword(password, newPassword);
            }
            catch (Exception e) { }
        }
        public List<Employee> FindEmployees(string keyword = "")
        {
            return new List<Employee>();
        }
        public List<Department> FindIDeparment(string keyword = "")
        {
            return new List<Department>();
        }
        
    }
}
