using SnakeWorkshop.Core;
using SnakeWorkshop.GameObjects;
using SnakeWorkshop.Utilities;

namespace SnakeWorkshop
{
    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(60, 20);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(snake, wall);
            engine.Run();
        }
    }
}
