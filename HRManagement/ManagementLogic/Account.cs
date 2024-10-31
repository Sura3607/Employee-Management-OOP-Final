using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class Account : ISerializable
    {
        private string username;
        private string password;
        private const string FileName = "Data.json";
        public string UserName { get => username; }
        public string Password { get => password; }

        //Do ko thể set qua property json cần có 1 contructor để làm việc đó
        [JsonConstructor]
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
            string localPath = Path.Combine(AppContext.BaseDirectory, FileName);
            string debugPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)?.FullName ?? string.Empty,
                                            @"HRManagement\Managenment_Windows\bin\Debug\", FileName);

            // Kiểm tra nếu file tồn tại ở đường dẫn hiện tại hoặc đường dẫn debug
            if (File.Exists(localPath))
            {
                return localPath;
            }
            else if (File.Exists(debugPath))
            {
                return debugPath;
            }

            return localPath;
        }

        public bool IsValidUsername(string username)
        {
            return this.username == username;
        }
        private bool IsValidPasswordCreate(string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                bool hasUpperCase = false;
                bool hasSpecialCharacter = false;

                foreach (char ch in password)
                {
                    if (char.IsUpper(ch))
                    {
                        hasUpperCase = true;
                    }
                    if (!char.IsLetterOrDigit(ch))
                    {
                        hasSpecialCharacter = true;
                    }

                    // Nếu đã thỏa mãn cả 2 điều kiện, có thể dừng vòng lặp
                    if (hasUpperCase && hasSpecialCharacter)
                    {
                        break;
                    }
                }

                return hasUpperCase && hasSpecialCharacter;
            }

            return false;
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
