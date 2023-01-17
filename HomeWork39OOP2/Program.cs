using System.ComponentModel.DataAnnotations.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        int minValueX = 10;
        int maxValueX = 20;
        int minValueY = 5;
        int maxValueY = 25;
        char playerSymbol = '@';

        Random random = new Random();

        int playerXPosition = random.Next(minValueX, maxValueX);
        int playerYPosition = random.Next(minValueY, maxValueY);

        Renderer renderer = new Renderer();

        Player player = new Player(playerXPosition, playerYPosition);

        renderer.DrawPlayerPosition(player.X,player.Y, playerSymbol);
    }

    class Renderer
    {
        public void DrawPlayerPosition(int x, int y, char playerSymbol)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(playerSymbol);
            Console.ReadKey(true);
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}