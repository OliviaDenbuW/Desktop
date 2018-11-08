using System;

namespace Fortknox
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string SocialSecurityNr { get; set; }

        public Member(int id, string name, string address, string socialSecurityNr)
        {
            Id = id;
            Name = name;
            Address = address;
            SocialSecurityNr = socialSecurityNr;
        }

        public void AttendCup(Member currentMember)
        {
            
        }

        public void ThrowBall(Member currentMember)
        {

        }
    }
}
