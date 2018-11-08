using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternVisitor
{
    class Members
    {
        private List<Member> _members = new List<Member>();

        public void Attach(Member member)
        {
            _members.Add(member);
        }

        public void Detach(Member member)
        {
            _members.Remove(member);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Member m in _members)
            {
                m.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
