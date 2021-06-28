using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikipediaExtractor.Model.Template;
using WikipediaExtractor.View;

namespace WikipediaExtractor.Controller
{
    public class TemplateManagerController
    {
        private ITempateManager _view;
        private Root _model;
        public TemplateManagerController(ITempateManager view, Root model)
        {
            _view = view;
            _model = model;
        }

        public void Initialize()
        {
            string templatesJson = Properties.Settings.Default.Templates;

            _model = JsonConvert.DeserializeObject<Root>(templatesJson);
            _view.Templates = _model.Templates;

            foreach (var template in _model.Templates)
            {
                template.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(Model_PropertyChanged);
            }
        }

        public void DisplayTemplateDetails(Template template)
        {
            _view.Name = template.Name;
            _view.Description = template.Description;
            _view.Fields = template.Fields;
        }

        private void Model_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Name":

                    break;
                case "Description":

                    break;
            }
        }

        public void UpdateName(string name)
        {
            if (_view.GetSelectedTemplate() != null)
                ((Template)_view.GetSelectedTemplate()).Name = name;
        }

        public void UpdateDescription(string description)
        {
            if (_view.GetSelectedTemplate() != null)
                ((Template)_view.GetSelectedTemplate()).Description = description;
        }
    }
}
