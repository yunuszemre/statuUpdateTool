using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuUpdateTool
{
    public class CityModel
    {
        public string City { get; set; }
        public string Town { get; set; }
        public string? Mahalle { get; set; }
        public string? EvetHayır { get; set; }
        public bool HayirSayisiSifirMi { get; set; }
        public override string ToString()
        {
            return $"{City} {Town} {Mahalle} {EvetHayır} {HayirSayisiSifirMi}";
        }
    }
}
