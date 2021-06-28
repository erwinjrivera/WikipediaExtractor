using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikipediaExtractor.Model.Template;

namespace WikipediaExtractor.View
{
    public interface ITempateManager
    {
        List<Template> Templates { set; }
        string Name { set; }
        string Description { set; }
        List<Field> Fields { set; }

        object GetSelectedTemplate();
    }
}
