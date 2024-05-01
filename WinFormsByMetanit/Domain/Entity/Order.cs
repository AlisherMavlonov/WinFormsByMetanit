using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Enum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsByMetanit.Domain.Entity
{
    public class Order
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public Client Client{ get; set; }
        public StatusOrder StatusOrder { get; set; }
        //public DateTime DateCreadeOrder { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        //public double RashodiOrder { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }


    }
}
