using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternVisitor
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
