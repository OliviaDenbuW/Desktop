using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternVisitor
{
    abstract class Member
    {
        private int _id;
        private string _name;
        private string _address;
        private string _socialSecurityNr;

        public Member(int id, string name, string address, string socialSecurityNr)
        {
            _id = id;
            _name = name;
            _address = address;
            _socialSecurityNr = socialSecurityNr;
        }

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or sets address
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
}
