using Raiding.Core;
using Raiding.Core.Contracts;

namespace Raiding
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
