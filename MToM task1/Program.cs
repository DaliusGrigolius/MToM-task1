using DataAccess;
using System;
using System.IO;
using File = DataAccess.Entities.File;

namespace MToM_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles(@"C:\Users\Administrator\Desktop\Daleus\");

            FilesDbContext filesDbContext = new FilesDbContext();

            for (int i = 0; i < filePaths.Length; i++)
            {
                var file1 = new File
                {
                    Id = Guid.NewGuid(),
                    Name = Path.GetFileName(filePaths[i]),
                    Size = new System.IO.FileInfo(filePaths[i]).Length,
                    FullPath = filePaths[i]
                };

                filesDbContext.Files.Add(file1);
            }

            filesDbContext.SaveChanges();
        }
    }
}
