using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.FMEA.Shared.Models.Master
{
    public class SiteMasterDO
    {
        public string Site_Number { get; set; }
        public string Site_Desc { get; set; }
        public string Site_Abbr { get; set; }
        public bool? Site_Operational { get; set; }
        public bool Update_Operational { get; set; }
    }
}
