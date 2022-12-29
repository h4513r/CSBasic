using OopEncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapsulationCont_;

internal class Weed : Plant
{
    static void Main(string[] args)
    {
        Weed weed = new();
        weed.Protected();
        weed.ProtectedInternal();
        //weed.PrivateProtected(); trong cùng đồ án mới dùng
        weed.Public();
    }
}
