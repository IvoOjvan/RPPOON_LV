using System;
using System.Collections.Generic;
using System.Text;

namespace Posjetitelj
{
    interface IVisitor
    {
        double Visit(DVD DVDItem);
        double Visit(VHS VHSItem);
    }
}
