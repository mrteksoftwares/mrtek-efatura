using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MrTEK_EFatura
{
    class clsMember
    {
        public clsMember()
        {

        }
        public clsMember(string display,object value)
        {
            _valueMember = value;
            _displayMember = display;
        }
        object _valueMember;
        public object valueMember { 
            get {return _valueMember;}
            set { _valueMember = value; }
        }

        string _displayMember;
        public string displayMember
        {
            get { return _displayMember; }
            set { _displayMember = value; }
        }

        public override string ToString()
        {
            return _displayMember;
        }
    }
}
