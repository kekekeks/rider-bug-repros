using System;
using System.Collections.Generic;
using System.Linq;

namespace RiderLinqWtf
{
    public class Foo
    {
        public int Bar { get; set; }
    }
    
    public class Tet
    {
        public static int Wat(Dictionary<string, Foo> lst)
        {
            return lst.FirstOrDefault(x => x.Value.Bar == 1).Value.Bar;
        }
    }
}