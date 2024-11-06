using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ManagementLogic
{
    [Serializable]
    public class Data
    {
        static private string accountFilePath = GetAccountFilePath();

        private static string GetAccountFilePath()
        {
            // Đường dẫn trong thư mục hiện tại
            string localPath = Path.Combine(AppContext.BaseDirectory, "accounts.json");

            // Đường dẫn tương đối từ thư mục chứa shortcut (.exe ở /HR_Management)
            string debugPath = Path.Combine(Directory.GetParent(AppContext.BaseDirectory)?.FullName ?? string.Empty,
                                            @"HRManagement\Managenment_Windows\bin\Debug\accounts.json");

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

        //D:\Project_Management\HR_Management\HRManagement\Managenment_Windows\bin\Debug
        public void SaveData(Management management,string FilePath)
        {
            string json = JsonSerializer.Serialize(management, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
        //LoadData from D:\Project_Management\HR_Management\HRManagement\Managenment_Windows\bin\Debug
        static public Management LoadData(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<Management>(json);
            }
            return new Management();
        }

        //D:\Project_Management\HR_Management\HRManagement\Managenment_Windows\bin\Debug
        static public void SaveAccounts(List<Account> accounts)
        {
            string json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(accountFilePath, json);
        }
        static public List<Account> LoadAccounts()
        {
            if (File.Exists(accountFilePath))
            {
                string json = File.ReadAllText(accountFilePath);
                List<Account> accounts = JsonSerializer.Deserialize<List<Account>>(json);
                return accounts;
            }
            return new List<Account>(); 
        }
    }
}
