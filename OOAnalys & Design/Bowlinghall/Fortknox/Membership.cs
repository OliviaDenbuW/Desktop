using System;
using System.Collections.Generic;
using System.Text;

namespace Fortknox
{
    public class Membership
    {
        public Member CurrentMember { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Membership()
        {

        }

        public Membership(Member newMember)
        {
            CurrentMember = newMember;
        }

        public void EndMembership(Member currentMember)
        {

        }

        public void CheckTimeLeft(Member currentMember)
        {

        }
    }
}
