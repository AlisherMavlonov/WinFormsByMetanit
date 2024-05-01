using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsByMetanit.Domain.Enum
{
    public enum GlassTypePaket
    {


        [Display(Name = "Простой")]
        Prostoy,

        [Display(Name = "Рефленный йодовый")]
        RefYod,

        [Display(Name = "Рефленный йодовый зеркало")]
        RefYodZerkalo,

        [Display(Name = "Рефленный сафед")]
        RefSaf,

        [Display(Name = "Рефленный сафед зеркало")]
        RefSafZerkalo,

        [Display(Name = "Йодовый простой")]
        YodProstoy,

        [Display(Name = "Йодовый танировка")]
        YodTanirovka,

        [Display(Name = "Зеркало зеркало")]
        ZerkaloZerkalo,


    }
}
