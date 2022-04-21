using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
