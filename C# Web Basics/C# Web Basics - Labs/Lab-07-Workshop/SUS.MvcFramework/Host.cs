using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SUS.MvcFramework
{
    public class Host
    {
        public static async Task CreateHostAsync(IMvcApplication application, int port)
        {
            List<Route> routeTable = new List<Route>();

            AutoRegisterStaticFiles(routeTable);
            AutoRegisterRoutes(routeTable, application);

            application.ConfigureServices();
            application.Configure(routeTable);

            Console.WriteLine("All Registered Routes:");
            foreach (var route in routeTable)
            {
                Console.WriteLine($"{route.Method} - {route.Path}");
            }

            IHttpServer server = new HttpServer(routeTable);

            await server.StartAsync(port);
        }

        private static void AutoRegisterStaticFiles(List<Route> routeTable)
        {
            var staticFiles = Directory.GetFiles("wwwroot", "*", SearchOption.AllDirectories);

            foreach (var staticFile in staticFiles)
            {
                var url = staticFile
                    .Replace("wwwroot", string.Empty)
                    .Replace("\\", "/");

                routeTable.Add(new Route(url, HttpMethod.Get, (request) =>
                {
                    var fileContent = File.ReadAllBytes(staticFile);
                    var fileExtension = new FileInfo(staticFile).Extension;

                    var contentType = "";

                    switch (fileExtension)
                    {
                        case ".txt":
                            contentType = "text/plain";
                            break;
                        case ".js":
                            contentType = "text/javascript";
                            break;
                        case ".css":
                            contentType = "text/css";
                            break;
                        case ".jpg":
                            contentType = "image/jpeg";
                            break;
                        case ".jpeg":
                            contentType = "image/jpeg";
                            break;
                        case ".png":
                            contentType = "image/png";
                            break;
                        case ".gif":
                            contentType = "image/gif";
                            break;
                        case ".ico":
                            contentType = "image/vnd.microsoft.icon";
                            break;
                        case ".html":
                            contentType = "text/html";
                            break;
                        default:
                            contentType = "text/plain";
                            break;
                    }

                    return new HttpResponse(contentType, fileContent, HttpStatusCode.Ok);
                }));
            }
        }

        private static void AutoRegisterRoutes(List<Route> routeTable, IMvcApplication application)
        {
            // routeTable.Add(new Route("/cards/all", HttpMethod.Get, new CardsController().All));

            var controllerTypes = application.GetType().Assembly.GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract && x.IsSubclassOf(typeof(Controller)));

            foreach (var controllerType in controllerTypes)
            {
                Console.WriteLine(controllerType.Name);
                var methods = controllerType.GetMethods()
                    .Where(x => x.IsPublic && !x.IsStatic && x.DeclaringType == controllerType
                        && !x.IsAbstract && !x.IsConstructor && !x.IsSpecialName);
                foreach (var method in methods)
                {
                    var url = "/" + controllerType.Name.Replace("Controller", string.Empty)
                        + "/" + method.Name;
                    url = url.ToLower();

                    var attribute = method.GetCustomAttributes(false).Where(x => x.GetType().IsSubclassOf(typeof(BaseHttpAttribute)))
                        .FirstOrDefault() as BaseHttpAttribute;

                    var httpMethod = HttpMethod.Get;

                    if (attribute != null)
                    {
                        httpMethod = attribute.Method;
                    }

                    if (!string.IsNullOrEmpty(attribute?.Url))
                    {
                        url = attribute.Url;
                    }

                    routeTable.Add(new Route(url, httpMethod, (request) =>
                    {
                        var instance = Activator.CreateInstance(controllerType) as Controller;
                        instance.Request = request;
                        var response = method.Invoke(instance, new object[] { }) as HttpResponse;

                        return response;
                    }));

                    Console.WriteLine(" - " + url);
                }


            }

        }
    }
}
