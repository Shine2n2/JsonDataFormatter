using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace JsonDataMgt.Handlers
{


    public class JsonConverter:IJsonConverter
        {
                      
            public async Task<List<T>> ReadJson<T>(string jsonFile)
            {
                var readText = await File.ReadAllTextAsync(jsonFile);
                var objects = new List<T>();
                var serializer = new JsonSerializer();
                using (var stringReader = new StringReader(readText))
                using (var jsonReader = new JsonTextReader(stringReader))
                {
                    jsonReader.SupportMultipleContent = true;
                    while (jsonReader.Read())
                    {
                        T json = serializer.Deserialize<T>(jsonReader);
                        objects.Add(json);
                    }
                }
                return objects;
            }
           
        }
    
}
