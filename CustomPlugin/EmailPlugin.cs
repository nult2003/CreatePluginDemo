using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomPlugin
{
    public class EmailPlugin : IPlugin
    {
        public EmailPlugin()
        {

        }
        public string Name
        {
            get
            {
                return "Email Parsing Plugin";
            }
        }

        public void PerformAction(IPluginContext context)
        {
            context.CurrentDocumentText = ParseEmails(context.CurrentDocumentText);
        }

        private string ParseEmails(string text)
        {
            const string emailPattern = @"\w+@\w+\.\w+((\.\w+)*)?";
            MatchCollection emails = Regex.Matches(text, emailPattern, RegexOptions.IgnoreCase);

            StringBuilder emailString = new StringBuilder();
            foreach(Match email in emails)
            {
                emailString.Append(email.Value + Environment.NewLine);
            }

            return emailString.ToString();
        }
    }
}
