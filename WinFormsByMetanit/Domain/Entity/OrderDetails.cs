using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Enum;

namespace WinFormsByMetanit.Domain.Entity
{
    public class OrderDetails
    {
        public long? Id { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public LayerGrass LayerGrass { get; set; }
        public int Quantity = 1;
        public GlassTypeOdinar? GlassTypeOdinar { get; set; }
        public GlassTypePaket? GlassTypePaket { get; set; }
        public double Price { get; set; }
        public Order Order { get; set; }





    }
}
