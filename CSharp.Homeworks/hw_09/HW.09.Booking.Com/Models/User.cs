using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._09.Booking.Com.Models
{
    internal class User
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public double Balance { get; set; }
    
        public User(string email, string password, double balance, string name)
        {
            Id = Guid.NewGuid();
            Name = name;    
            Email = email;
            Password = password;
            Balance = balance;
        }
        
        public void Pay(double cost)
        {
            Balance -= cost;
        }  
        
    }
}