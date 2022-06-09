using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccess.Entities
{
    public class File
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string FullPath { get; set; }

        [ForeignKey("Folderis")]
        public Guid FolderId { get; set; }
        public Folderis Folderis { get; set; }
    }
}
