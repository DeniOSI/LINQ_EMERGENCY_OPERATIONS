﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_EMERGENCY_OPERATION
{
    class KeyEqu : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return Int32.Parse(x) == Int32.Parse(y);
        }

        public int GetHashCode(string obj)
        {
            return Int32.Parse(obj).ToString().GetHashCode();
       }
    }
}
