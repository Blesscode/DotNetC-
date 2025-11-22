using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_FileHandling
{
    internal class DirectoryHandling
    {
        
       public void DirectoryOperations()
        {
            //Create 
            String path = @"E:\\DotNetC-\\TestDirectory";
            string mainPath = @"E:\DotNetC-\Company";
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory does not exist. Creating...");
                Directory.CreateDirectory(path);
            } else{
                //Delete
                Console.WriteLine("Directory already exists. Deleting...");
                Directory.Delete(path, true);

            }
            //Create
            Directory.CreateDirectory(mainPath);

            //Create sub-directories
                //1. path build
                    String EmployeeDirPath=Path.Combine(mainPath, "Employee");
                    String HrDirPath = Path.Combine(mainPath, "HR");
                //2. dir build
                    Directory.CreateDirectory(EmployeeDirPath);
                    Directory.CreateDirectory(HrDirPath);
            //1. direct build
            Directory.CreateDirectory(@"E:\DotNetC-\Company\Accounts");
            //Directory Info of createddirectory
            DirectoryInfo directoryInfo = new DirectoryInfo(mainPath);
            DirectoryInfo[] subDir=directoryInfo.GetDirectories();
            foreach(DirectoryInfo i in subDir)
            {
                Console.WriteLine($"{i.FullName}");
                Console.WriteLine(i.Name);
                Console.WriteLine(i.CreationTime);
                Console.WriteLine(i.Parent);
            }

            }

        


    }
}
