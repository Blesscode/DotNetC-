using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_FileHandling
{
    internal class FilesHandling
    {
        public void FilesOperations()
        {
            //path
             string mainPath = @"E:\DotNetC-\Company\Employee\Isha.txt";
            //E
            if (!File.Exists(mainPath))
            {
                //C
                File.Create(mainPath).Close();
                Console.WriteLine("File not found so creating");
            }
            //U
            File.WriteAllText(mainPath, "Hello I am isha , A .net and spring boot developer");
            //System.IO.IOException: 'The process cannot access the file 'E:\DotNetC-\Company\Employee\Isha.txt' because it is being used by another process.'

            //R
            File.ReadAllText(mainPath);
            //D
           // File.Delete(mainPath);
        }
    }
}
