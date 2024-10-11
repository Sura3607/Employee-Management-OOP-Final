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
        public Run() { }
        public void Login(string username, string password)
        {
            List<Account> accounts = Data.LoadAccounts();

            Account account = accounts.Find(a => a.IsValidUsername(username));
            if (account == null)
            {
                throw new Exception("Username does not exist.");
            }
            if (!account.IsValidPassword(password))
            {
                throw new Exception("Login failed: Incorrect password.");
            }

            management = Data.LoadData(account.GetFilePath());
            management.SetFilePath(account.GetFilePath());
            
        }
        public void SignUp(string username, string password)
        {
            try
            {
                List<Account> accounts = Data.LoadAccounts();
                if (accounts.Exists(a => a.IsValidUsername(username)))
                {
                    throw new Exception("Username already exists.");
                }
                accounts.Add(new Account(username, password));
                Data.SaveAccounts(accounts);
            }
            catch(Exception ex)
            {

            }
        }
        
    }
}
