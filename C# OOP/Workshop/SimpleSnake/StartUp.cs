namespace SimpleSnake
{
    using SimpleSnake.Constants;
    using SimpleSnake.Core;
    using SimpleSnake.GameObjects;
    using Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            DrawManager drawManager = new DrawManager();
            Snake snake = new Snake();
            Coordinate boardCoordinate = new Coordinate(GameConstant.Board.DefaultBoardWidth, GameConstant.Board.DefaultBoardHeight);

            Engine engine = new Engine(drawManager, snake, boardCoordinate);

            engine.Run();
        }
    }
}
