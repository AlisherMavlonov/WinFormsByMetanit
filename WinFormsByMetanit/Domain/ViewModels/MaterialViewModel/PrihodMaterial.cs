using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsByMetanit.Domain.ViewModels.MaterialViewModel
{
    public class PrihodMaterial
    {
        public int Ramka { get; set; }
        public int Ugolok { get; set; }
        public double Germetik { get; set; }
        public double Gel { get; set; }

        public int Prostoy { get; set; }
        public int RefYod { get; set; }
        public int Zerkalo { get; set; }
        public int RefSaf { get; set; }
        public int YodProstoy { get; set; }
        public int YodTanirovka { get; set; }
    }
}
