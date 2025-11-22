using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DIRECTORY OPERATIONS
            DirectoryHandling directoryHandling = new DirectoryHandling();
            directoryHandling.DirectoryOperations();

            //FILE HANDLING
            FilesHandling filesHandling = new FilesHandling();
            filesHandling.FilesOperations();
        }
    }
}
