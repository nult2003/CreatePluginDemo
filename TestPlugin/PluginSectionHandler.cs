using CustomPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestPlugin
{
    class PluginSectionHandler : IConfigurationSectionHandler
    {
        public PluginSectionHandler()
        {
        }
        public object Create(object parent, object configContext, XmlNode section)
        {
            //Derived from CollectionBase
            ICollection<IPlugin> plugins = new List<IPlugin>();
            //PluginCollection plugins = new PluginCollection();
            foreach (XmlNode node in section.ChildNodes)
            {
                try
                {
                    //Use the Activator class's 'CreateInstance' method
                    //to try and create an instance of the plugin by
                    //passing in the type name specified in the attribute value
                    object plugObject =
                              Activator.CreateInstance(Type.GetType(node.Attributes["type"].Value));

                    //Cast this to an IPlugin interface and add to the collection
                    IPlugin plugin = (IPlugin)plugObject;
                    plugins.Add(plugin);
                }
                catch (Exception e)
                {
                    //Catch any exceptions
                    //but continue iterating for more plugins
                }
            }
            return plugins;
        }
    }
}
