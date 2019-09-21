using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Sep19_DemoConstStaticReadonly
{
    class StaticConstReadOnlyClass
    {
        public const float constantVariable = 3.14f;
        public readonly string readOnlyVariable = "Old Name";
        public static int staticVariable = 12;

        public StaticConstReadOnlyClass()
        {
            readOnlyVariable = "New Company";
        }
    }
}
