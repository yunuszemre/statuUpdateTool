using System;
using System.Collections.Generic;

namespace statuUpdateTool.Models
{
    public partial class HjHizmetBoLgeleri
    {
        public string Şube { get; set; } = null!;
        public string Şehir { get; set; } = null!;
        public string İlçe { get; set; } = null!;
        public string Mahalle { get; set; } = null!;
        public string DağıtımAlanıİçerisindeMi { get; set; } = null!;
    }
}
