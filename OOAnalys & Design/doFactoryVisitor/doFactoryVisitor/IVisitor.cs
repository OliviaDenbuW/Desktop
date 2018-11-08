using System;
using System.Collections.Generic;
using System.Text;

namespace doFactoryVisitor
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
