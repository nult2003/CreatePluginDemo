using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugin
{
    interface IConfigurationSectionHandler
    {
        object Create(object parent, object configContext, System.Xml.XmlNode section);
    }
}
