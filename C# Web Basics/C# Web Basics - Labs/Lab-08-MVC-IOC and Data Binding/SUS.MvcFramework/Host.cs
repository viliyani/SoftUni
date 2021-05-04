using SUS.HTTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SUS.MvcFramework
{
    public class Host
    {
        public static async Task CreateHostAsync(IMvcApplication application, int port)
        {
            List<Route> routeTable = new List<Route>();
            IServiceCollection serviceCollection = new ServiceCollection();

            AutoRegisterStaticFiles(routeTable);

            application.ConfigureServices(serviceCollection);
            application.Configure(routeTable);

            AutoRegisterRoutes(routeTable, application, serviceCollection);

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

        private static void AutoRegisterRoutes(List<Route> routeTable, IMvcApplication application, IServiceCollection serviceCollection)
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

                    routeTable.Add(new Route(url, httpMethod, request => ExecuteAction(request, controllerType, method, serviceCollection)));

                    Console.WriteLine(" - " + url);
                }


            }

        }

        private static HttpResponse ExecuteAction(HttpRequest request, Type controllerType, MethodInfo action, IServiceCollection serviceCollection)
        {
            var instance = serviceCollection.CreateInstance(controllerType) as Controller;
            instance.Request = request;

            var arguments = new List<object>();
            var parameters = action.GetParameters();
            foreach (var parameter in parameters)
            {
                var httpParameterValue = GetParameterFromRequest(request, parameter.Name);
                var parameterValue = Convert.ChangeType(httpParameterValue, parameter.ParameterType);

                if (parameterValue == null && parameter.ParameterType != typeof(string))
                {
                    // complex type
                    parameterValue = Activator.CreateInstance(parameter.ParameterType);
                    var properties = parameter.ParameterType.GetProperties();
                    foreach (var property in properties)
                    {
                        var propertyHttpParameterValue = GetParameterFromRequest(request, parameter.Name);
                        var propertyParameterValue = Convert.ChangeType(propertyHttpParameterValue, property.PropertyType);
                        property.SetValue(parameterValue, propertyParameterValue);
                    }
                }

                arguments.Add(parameterValue);
            }

            var response = action.Invoke(instance, arguments.ToArray()) as HttpResponse;

            return response;
        }

        private static string GetParameterFromRequest(HttpRequest request, string parameterName)
        {
            parameterName = parameterName.ToLower();

            if (request.FormData.Any(x => x.Key.ToLower() == parameterName))
            {
                return request.FormData
                    .FirstOrDefault(x => x.Key.ToLower() == parameterName).Value;
            }

            if (request.QueryData.Any(x => x.Key.ToLower() == parameterName))
            {
                return request.QueryData
                    .FirstOrDefault(x => x.Key.ToLower() == parameterName).Value;
            }

            return null;
        }
    }
}
