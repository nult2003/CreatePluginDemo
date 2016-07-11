using CustomPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlugin
{
    class EditorContext : IPluginContext
    {
        private string m_CurrentText = string.Empty;
        public EditorContext(string CurrentEditorText)
        {
            m_CurrentText = CurrentEditorText;
        }
        public string CurrentDocumentText
        {
            get
            {
                return m_CurrentText;
            }
            set
            {
                m_CurrentText = value;
            }
        }
    }

}
