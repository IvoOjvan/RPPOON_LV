using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    interface IRegistrationValidator
    {
        bool IsUserEntryValid(UserEntry entry);
    }
}
