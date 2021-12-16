//Jayden Wigley
//Login Application
//12-7-21
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDKMaybe
{
    class SignUpAccess
    {
        public static List<LoginModel> LoadUser()
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.Query<LoginModel>("select * from Passwordmanager", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveUser(LoginModel user)
        {
            try
            {
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    conn.Execute("insert into Passwordmanager(Username, Password) values (@Username, @Password)", user);
                }
                MessageBox.Show("Account Successfully Created");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                Console.WriteLine(ex);
                MessageBox.Show("That Account Username is already in use");
            }
        }
        public static void DeleteUser(LoginModel user)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                Console.WriteLine($"DELETING: {user.UserName}");
                conn.Execute("DELETE from Passwordmanager where Username = @Username", user);
            }
            MessageBox.Show("Account Successfully Deleted");
        }
        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PasswordManager"].ConnectionString;
        }
    }
}
