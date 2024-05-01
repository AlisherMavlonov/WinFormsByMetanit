using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsByMetanit.Domain.Enum
{
    public enum LayerGrass
    {
        [Display(Name = "Пакет")]
        TwoLayer,      //Пакет

        [Display(Name = "Одинар")]
        Single,    //Одинар



    }
}
