using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsByMetanit.Domain.Enum
{
    public enum GlassTypeOdinar
    {
        [Display(Name = "Простой")]
        Prostoy,

        [Display(Name = "Рефленный йодовый")]
        RefYod,

        [Display(Name = "Рефленный сафед")]
        RefSaf,

        [Display(Name = "Йодовый простой")]
        YodProstoy,

        [Display(Name = "Йодовый танировка")]
        YodTanirovka,

        [Display(Name = "Зеркало")]
        Zerkalo,
    }
}
