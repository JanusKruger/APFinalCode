using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

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

        public string FileName { get; set; }

        public Url Link { get; set; }

        public string Type { get; set; }

        public byte[] Content { get; set; }
    }
}