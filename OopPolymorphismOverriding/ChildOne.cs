using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverriding;
internal class ChildOne : Parent
{

    //viết lại phương thức của cha
    public override void Display() => Console.WriteLine("childone display");

    public new void Show() => Console.WriteLine("childone show");
}

