using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManagementLogic
{
    [Serializable]
    public class Account : ISerializable
    {
        private string username;
        private string password;
        private const string FilePath = "Data.json";
        public string UserName { get => username; }
        public Account(string username, string password)
        {
            if (!IsValidPasswordCreate(password))
            {
                throw new Exception("Invalid password: must contain an uppercase letter and a special character.");
            }
            this.username = username;
            this.password = password;
        }
        public Account() { }
        public Account(SerializationInfo info, StreamingContext context)
        {
            username = info.GetString("username");
            password = info.GetString("password");
        }
        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", username);
            info.AddValue("password", password);
        }
        public string GetFilePath()
        {
            return FilePath;
        }
        public bool IsValidUsername(string username)
        {
            return this.username == username;
        }
        private bool IsValidPasswordCreate(string password)
        {
            return !string.IsNullOrEmpty(password) &&
                   password.Any(char.IsUpper) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
        public bool IsValidPassword(string password)
        {
            return this.password == password;
        }
        public void ChangePassword(string currentPassword, string newPassword)
        {
            if (!IsValidPassword(currentPassword))
            {
                throw new Exception();
            }
            if (!IsValidPasswordCreate(newPassword))
            {
                throw new Exception();
            }
            this.password = newPassword;
        }
    }
}
