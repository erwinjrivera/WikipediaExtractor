using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikipediaExtractor.Controller;
using WikipediaExtractor.Model.Template;
using WikipediaExtractor.View;

namespace WikipediaExtractor
{
    public partial class FormTemplateManager : Form, ITempateManager
    {
        private TemplateManagerController _controller;
        private bool _initialized = false;
        public FormTemplateManager()
        {
            InitializeComponent();
        }

        private void FormTemplateManager_Load(object sender, EventArgs e)
        {
            _controller = new TemplateManagerController(this, new Root());
            _controller.Initialize();

            listBox1.DisplayMember = "Name";

            _initialized = true;
        }

        public List<Template> Templates
        {
            set
            {
                var x = string.Empty;
                listBox1.DataSource = value;
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = (Template)listBox1.SelectedItem;

            _controller.DisplayTemplateDetails(item);
        }

        public string Name
        {
            set
            {
                txtName.Text = value;
            }
        }

        public string Description
        {
            set
            {
                txtDescription.Text = value;
            }
        }

        public void SetSelectedType(FieldType item)
        {
           
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<Field> Fields
        {
            set
            {
                dataGridView1.DataSource = value;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (_initialized)
                _controller.UpdateName(txtName.Text);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (_initialized)
                _controller.UpdateDescription(txtDescription.Text);
        }
        
        public object GetSelectedTemplate()
        {
            return listBox1.SelectedItem;
        }
    }
}
