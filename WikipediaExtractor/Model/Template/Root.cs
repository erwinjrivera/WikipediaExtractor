using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaExtractor.Model.Template
{
    public class Root
    {
        [JsonProperty("templates")]
       
        public List<Template> Templates { get; set; }
    }
}
