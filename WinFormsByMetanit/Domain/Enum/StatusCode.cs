using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsByMetanit.Domain.Enum
{
    public enum StatusCode
    {
        Ok = 200,
        UserAlreadyExists = 1,
        UserNotFaund = 2,
        ClientAlreadyExists = 3,
        ClientNotFaund = 4,
        InternalServerError = 500,


    }
}
