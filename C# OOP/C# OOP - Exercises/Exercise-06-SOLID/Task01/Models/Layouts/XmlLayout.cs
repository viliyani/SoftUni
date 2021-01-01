using System;
using Logger.Models.Contracts;
using System.Text;

namespace Logger.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format => GetFormat();

        private string GetFormat()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<log>");
            sb.AppendLine("\t<date>{0}</date>");
            sb.AppendLine("\t<level>{1}</level>");
            sb.AppendLine("\t<message>{2}</message>");
            sb.AppendLine("</log>");

            return sb.ToString();
        }
    }
}
