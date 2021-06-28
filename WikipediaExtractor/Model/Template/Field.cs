using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     
namespace WikipediaExtractor.Model.Template
{
    public class Field
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public FieldType Type { get; set; }

        [JsonProperty("xPath")]
        public string XPath { get; set; }

        [JsonProperty("innerText")]
        public string InnerText { get; set; }
    }
}
