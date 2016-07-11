using CustomPlugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPlugin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExecutePlugin(IPlugin plugin)
        {
            //create a context object to pass to the plugin
            EditorContext context = new EditorContext(txtText.Text);

            //The plugin Changes the Text property of the context
            plugin.PerformAction(context);
            txtText.Text = context.CurrentDocumentText;
        }

        private void txtText_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String ClassName = "CustomPlugin.EmailPlugin, CustomPlugin";
                IPlugin plugin = (IPlugin)Activator.CreateInstance(Type.GetType(ClassName));

                ExecutePlugin(plugin);
            }
        }
    }

}
