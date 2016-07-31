using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   interface Interface1
    {
        int test1();
        //int test1();

    }

    interface Interface2: Interface1
    {
       int test5();
       
    }

    interface Interface3 : Interface1
    {
        int test5();

    }

}
