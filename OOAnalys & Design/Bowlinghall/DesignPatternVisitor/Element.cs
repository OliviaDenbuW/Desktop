using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternVisitor
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
