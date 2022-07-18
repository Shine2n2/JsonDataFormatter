using System.Collections.Generic;

namespace JsonDataReader.Models
{
    public class JsonDataModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
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
