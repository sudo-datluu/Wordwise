using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordwiseLibrary.Models;

namespace WordwiseLibrary.Data.Controller
{
    public class UserController
    {
        //Singleton pattern
        private static UserController instance = null;
        private static readonly object instanceLock = new object();
        private UserController() { }
        public static UserController Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserController();
                    }
                    return instance;
                }
            }
        }

        // Create new user account
        // Return none if username existed in the database
        public User? CreateAccount(string username, string password)
        {
            using (var context = new Context())
            {
                if (!context.Users.Any(u => u.Username == username)) return null;

                var user = new User() { Username = username, Password = password };
                context.Users.Add(user);
                context.SaveChanges();
                return user;
            }
        }

        // Return the user if successfully login
        // Return none
        public User? Login(string username, string password)
        {
            using (var context = new Context())
            {
                User? user = context.Users.FirstOrDefault(
                u => u.Username == username && u.Password == password);
                return user;
            }
        }
    }
}
