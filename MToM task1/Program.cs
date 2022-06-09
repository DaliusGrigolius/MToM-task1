using DataAccess;
using DataAccess.Entities;
using System;
using System.IO;
using File = DataAccess.Entities.File;

namespace MToM_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] filePaths = Directory.GetFiles(@"C:\Users\Administrator\Desktop\Daleus\");

            //FilesDbContext filesDbContext = new FilesDbContext();

            //for (int i = 0; i < filePaths.Length; i++)
            //{
            //    var file = new File
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = Path.GetFileName(filePaths[i]),
            //        Size = new FileInfo(filePaths[i]).Length,
            //        FullPath = filePaths[i],
            //    };

            //    filesDbContext.Files.Add(file);
            //}

            //filesDbContext.SaveChanges();

            FilesDbContext filesDbContext = new FilesDbContext();

            string[] filePaths = Directory.GetFiles(@"C:\Users\Administrator\Desktop\Daleus\", "*", SearchOption.AllDirectories);

            for (int i = 0; i < filePaths.Length; i++)
            {
                var folderis = new Folderis
                {
                    Id = Guid.NewGuid(),
                    Name = Path.GetFileName(Path.GetDirectoryName(filePaths[i])),
                };

                filesDbContext.Folders.Add(folderis);

                var file = new File
                {
                    Id = Guid.NewGuid(),
                    Name = Path.GetFileName(filePaths[i]),
                    Size = new FileInfo(filePaths[i]).Length,
                    FullPath = filePaths[i],
                    FolderId = folderis.Id,
                };

                filesDbContext.Files.Add(file);
            }

            filesDbContext.SaveChanges();
        }
    }
}
