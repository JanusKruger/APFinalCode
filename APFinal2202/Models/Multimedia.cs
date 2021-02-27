using System;
using System.ComponentModel.DataAnnotations;

namespace APFinal2202.Models
{
    public class Multimedia
    {
        public Multimedia()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        public byte[] Content { get; set; }

        public string FileName { get; set; }

        public string Type { get; set; }
    }
}