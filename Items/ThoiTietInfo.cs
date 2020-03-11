using System;
using System.Collections.Generic;
using System.Text;

namespace Items
{
    public class ThoiTietInfo
    {
        public string latitude { set; get; }
        public string longitude { set; get; }
        public string timezone { set; get; }
        public List<currently> currently { set; get; }
        public List<hourly> hourly { set; get; }
        public List<daily> daily { set; get; }
        public List<flags> flags { set; get; }
        public string offset { set; get; }

    }
    
    
}
