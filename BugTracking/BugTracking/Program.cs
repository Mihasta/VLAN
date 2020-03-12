using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            using (BTContext db = new BTContext())
            {
                User admin = new User { Name = "admin", 
                                        Surname = "admin", 
                                        Login = "admin", 
                                        Password = "123", 
                                        Status = UserStatus.Admin, 
                                        Mail = "admin@mail.ru", 
                                        PhoneNumber = "+79666666666" 
                                      };
                db.Users.Add(admin);
                db.SaveChanges();
                Console.WriteLine("Успешно добавлено");
            }
        }
    }
}
