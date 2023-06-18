using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace statuUpdateTool.Models
{
    public partial class PostaKoduIdBilgili
    {
        [Key]
        public string Id { get; set; }
        public long? Plaka { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? SemtBucakBelde { get; set; }
        public string? Mahalle { get; set; }
        public string? Pk { get; set; }
    }
}
