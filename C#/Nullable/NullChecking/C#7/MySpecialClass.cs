using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullChecking.CSharp7
{
    internal class MySpecialClass
    {
        public string Name { get; }

        public MySpecialClass(string name)
        {
            Name = name;
        }

        public static bool operator ==(MySpecialClass left, MySpecialClass right)
        {
            return true;
        }

        public static bool operator !=(MySpecialClass left, MySpecialClass right)
        {
            return true;
        }
    }
}
