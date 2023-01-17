using System.ComponentModel.DataAnnotations.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        int minValuePositionX = 10;
        int maxValuePositionX = 20;
        int minValuePositionY = 5;
        int maxValuePositionY = 25;
        char playerSymbol = '@';

        Random random = new Random();

        int playerPositionX = random.Next(minValuePositionX, maxValuePositionX);
        int playerPositionY = random.Next(minValuePositionY, maxValuePositionY);

        Renderer renderer = new Renderer();

        Player player = new Player(playerPositionX, playerPositionY);

        renderer.DrawPlayerPosition(player.PositionX,player.PositionY, playerSymbol);
    }

    class Renderer
    {
        public void DrawPlayerPosition(int positionX, int positionY, char playerSymbol)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(positionX, positionY);
            Console.WriteLine(playerSymbol);
            Console.ReadKey(true);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
}