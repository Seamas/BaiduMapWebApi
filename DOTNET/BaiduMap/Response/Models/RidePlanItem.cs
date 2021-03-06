using System;
using System.Collections.Generic;
using System.Text;

namespace BaiduMap.Response.Models
{
    public class RidePlanItem 
    {
        public List<RideRoute> Routes { get; set; }
        public OriginPoint Origin { get; set; }
        public DestinationPoint Destination { get; set; }
    }
}
