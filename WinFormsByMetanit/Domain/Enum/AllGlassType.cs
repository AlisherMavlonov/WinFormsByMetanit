using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsByMetanit.Domain.Enum
{
    public enum AllGlassType
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
        

        [Display(Name = "Рефленный йодовый зеркало")]
        RefYodZerkalo,

        [Display(Name = "Рефленный сафед зеркало")]
        RefSafZerkalo,

        [Display(Name = "Зеркало зеркало")]
        ZerkaloZerkalo,
    }
}
