using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = DataAccess.Entities.File;


namespace DataAccess.Entities
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string FullPath { get; set; }

        [ForeignKey("File")]
        public Guid FileId { get; set; }
        public File FileName { get; set; }
    }
}
