using SUS.HTTP;
using SUS.MvcFramework;
using System;

namespace MyFirstMvcApp.Controllers
{
    public class StaticFilesController : Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            return File("wwwroot/favicon.ico", "image/vnd.microsoft.icon");
        }

        public HttpResponse BootstrapCss(HttpRequest arg)
        {
            return File("wwwroot/css/bootstrap.min.css", "text/css");
        }

        public HttpResponse CustomCss(HttpRequest arg)
        {
            return File("wwwroot/css/custom.css", "text/css");
        }

        public HttpResponse CustomJs(HttpRequest arg)
        {
            return File("wwwroot/js/custom.js", "text/javascript");
        }

        public HttpResponse BootstrapJs(HttpRequest arg)
        {
            return File("wwwroot/js/bootstrap.bundle.min.js", "text/javascript");
        }
    }
}
