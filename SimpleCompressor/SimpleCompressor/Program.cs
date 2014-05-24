using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleCompressor
{
    class Program
    {
        private static Boolean DEBUG = true;

        static void Main()
        {
            String curDir = "C:\\Share";
            Logger(curDir);
            string[] subdirectoryEntries = Directory.GetDirectories(curDir);

            for (int i = 0; i < subdirectoryEntries.Count(); i++)
            {
                Logger(subdirectoryEntries[i]);
            }

            String latestFolderPath = subdirectoryEntries[subdirectoryEntries.Count() - 1];

            //압축 풀기 : ZipManager.UnZipFiles(@"D:\ZipTest\zipFile\Video.zip", @"D:\ZipTest\unzipFolder\", "ab123#", false);
            //압축 하기 : ZipManager.ZipFiles(@"D:\ZipTest\unzipFolder\", @"D:\ZipTest\zipFile\Video.zip", "ab123#", false);

            String folderName = latestFolderPath.Replace(Path.GetDirectoryName(latestFolderPath), "");
            folderName = folderName.Replace("\\", "");

            Logger("");
            Logger("folderName:" + folderName);
            Logger("");
            Logger("Zip Bin Folder");
            ZipManager.ZipFiles(latestFolderPath, curDir + "\\" + folderName + ".zip", "", false);
            Logger("");
            Logger("Zip WorkSpace Folder");
            String workSpacePath = "C:\\Program Files (x86)\\Jenkins\\jobs\\yamang\\workspace\\YaMang";
            ZipManager.ZipFiles(workSpacePath, curDir + "\\" + folderName + "_workspace.zip", "", false);
            
            Logger("DONE");

            //Console.ReadLine();
        }

        private static void Logger(String message)
        {
            if (DEBUG)
            {
                Console.WriteLine(message);
            }
        }

    }
}
