﻿using System.Collections.Generic;

namespace JsonDataReader.Models
{
    public class JsonDataModel
    {
        
        public class Openinghour
        {
            public string type { get; set; }
            public string value { get; set; }
        }

        public class Root
        {
            public string dayofweek { get; set; }
            public List<Openinghour> openinghour { get; set; }
        }


    }
}
