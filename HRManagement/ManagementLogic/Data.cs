using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ManagementLogic
{
    public class Data
    {
        static private string accountFilePath = "accounts.json";

        //Luu data cần có một đối tượng management đg tồn tại
        public void SaveData(Management management,string FilePath)
        {
            string json = JsonSerializer.Serialize(management, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
        //LoadData từ hệ thống
        static public Management LoadData(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<Management>(json);
            }
            return new Management();
        }

        //Save và Load dữ liệu các đối tượng Account từ một file riêng
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
                return JsonSerializer.Deserialize<List<Account>>(json);
            }
            return new List<Account>(); 
        }
    }
}
