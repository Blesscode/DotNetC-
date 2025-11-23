using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PartialClassAndMethod
{
    internal class PartialClass
    {
        /*
         DEF:
            it allows a single class to be split into 2 
            2 ppl work on it 
            and at the end when compiled the files are merged as a single class

        PROBLEMS:
            [1] Same method is defined in both files => 🚫 Compiler error
            [2] One developer modifies a property and the other doesn’t => No compiler error, but logical mismatch may occur. "YOU NEED TO QUARDINATE "
         */
    }
}
