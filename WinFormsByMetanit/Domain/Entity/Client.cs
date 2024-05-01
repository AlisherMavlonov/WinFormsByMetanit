using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsByMetanit.Domain.Entity
{
    public class Client
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }

        public Client()
        {
            Orders = new List<Order>();
        }
    }
}
