using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuUpdateTool
{
    public class CityModel
    {
        [Key]
        public string Id { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string? Mahalle { get; set; }
        public string? EvetHayır { get; set; }
        public bool HayirSayisiSifirMi { get; set; }
        public bool? IsSuccess { get; set; }
        public override string ToString()
        {
            return $"{City} {Town} {Mahalle} {EvetHayır} {HayirSayisiSifirMi}";
        }
    }
}
