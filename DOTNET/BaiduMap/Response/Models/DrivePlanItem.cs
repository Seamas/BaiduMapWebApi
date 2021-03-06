using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response.Models
{
    public class DrivePlanItem
    {
        public string Restriction { get; set; }
        public int? Total { get; set; }
        public List<DriveRoute> Routes { get; set; }
    }
}
