using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    internal class Register
    {
        public Dictionary<string, User> users = new();

        public bool CheckAcaunt(string userName)
        {
            return users.ContainsKey(userName);           
        }

        public void Registration(string userName, string email, string password, double balance)
        {
            User userInfo = new(email, password, balance, userName);  
            users.Add(userName, userInfo);
      
        }       
        public bool Autorization(string userName, string pass)
        {
            User user = users[userName];

            if (user.Password.Equals(pass))
            {
                return true;
            }
            else
            {
                return false;   
            } 
        }  
        
        public User GetUser(string UserName)
        {
            return users[UserName];
        }
    }
}