using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    interface IItem
    {
        double Accept(IVisitor visitor);
    }
}
