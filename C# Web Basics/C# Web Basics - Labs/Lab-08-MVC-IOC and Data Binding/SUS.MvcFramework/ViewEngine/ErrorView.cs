using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SUS.MvcFramework.ViewEngine
{
    public class ErrorView : IView
    {
        private readonly IEnumerable<string> errors;
        private readonly string csharpCode;

        public ErrorView(IEnumerable<string> errors, string csharpCode)
        {
            this.errors = errors;
            this.csharpCode = csharpCode;
        }

        public string ExecuteTemplate(object viewModel, string user)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"<h1>View compile {errors.Count()} errors:</h1><ul>");

            foreach (var error in errors)
            {
                sb.AppendLine($"<li>{error}</li>");
            }

            sb.AppendLine($"</ul><pre>{csharpCode}</pre>");

            return sb.ToString();
        }
    }
}
