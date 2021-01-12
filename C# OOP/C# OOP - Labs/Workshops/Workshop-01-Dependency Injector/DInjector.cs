using DIContainer.Injectors;
using DIContainer.Modules;

namespace DIContainer
{
    public class DInjector
    {
        public static Injector CreateInjector(IModule module)
        {
            module.Configure();
            return new Injector(module);
        }
    }
}
