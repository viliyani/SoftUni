﻿using SUS.HTTP;
using SUS.MvcFramework.ViewEngine;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace SUS.MvcFramework
{
    public abstract class Controller
    {
        private SusViewEngine viewEngine;

        public Controller()
        {
            viewEngine = new SusViewEngine();
        }

        public HttpResponse View(object viewModel = null, [CallerMemberName] string viewPath = null)
        {
            var layout = System.IO.File.ReadAllText("Views/Shared/_Layout.cshtml");
            layout = layout.Replace("@RenderBody()", "___VIEW_GOES_HERE___");
            layout = viewEngine.GetHtml(layout, viewModel);

            var viewContent = System.IO.File.ReadAllText("Views/" +
                this.GetType().Name.Replace("Controller", string.Empty) + "/" +
                viewPath + ".cshtml");

            viewContent = viewEngine.GetHtml(viewContent, viewModel);

            var responseHtml = layout.Replace("___VIEW_GOES_HERE___", viewContent);

            var responseBodyBytes = Encoding.UTF8.GetBytes(responseHtml);
            var response = new HttpResponse("text/html", responseBodyBytes);

            return response;
        }

        public HttpResponse File(string filePath, string contentType)
        {
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var response = new HttpResponse(contentType, fileBytes);

            return response;
        }

        public HttpResponse Redirect(string url)
        {
            var response = new HttpResponse(HttpStatusCode.Found);
            response.Headers.Add(new Header("Location: " + url));
            return response;
        }

    }
}
