using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Repository
{
    class UserRepository
    {
        
        private static List<User> users = new List<User>();

       
        public bool RegisterUser(string email, string password, string name)
        {
            
            if (users.Any(u => u.email == email))
            {
                return false; 
            }


            User newUser = new User { email = email, Password = password, name = name }; 
            users.Add(newUser);
            return true; 
        }

       
        public User AuthenticateUser(string login, string password)
        {
            
            return users.FirstOrDefault(u => u.email == login && u.Password == password); 
        }
    }

   
    public class User
    {
        public string email { get; set; }
        public string Password { get; set; }
        public string name { get; set; } 
    }


}


