using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    interface IPasswordValidationService
    {
        bool IsValidPassword(String candidate);
    }
}
