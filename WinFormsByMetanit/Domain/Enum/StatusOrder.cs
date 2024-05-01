using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsByMetanit.Domain.Enum
{
    public enum StatusOrder
    {
        [Display(Name = "Готова")]
        ready,
        [Display(Name = "Не готова")]
        notReady,
    }
}
