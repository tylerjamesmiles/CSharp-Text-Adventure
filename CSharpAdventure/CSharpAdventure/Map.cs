using System;
using System.Numerics;
using System.Reflection.Metadata;

class Map
{
    private Player Player = new Player(new Vector2(3, 4));

    private Vector2 vMapSize = new Vector2(10, 10);
    public bool bQuit = false;

    public void Render()
    {
        Console.Clear();
        for (int y = 0; y < vMapSize.y; y++)
        {
            for (int x = 0; x < vMapSize.x; x++)
            {
                if (Player.vPos.Equals(new Vector2(x, y)))
                    Console.Write('x');
                else
                    Console.Write('.');

                Console.Write(' ');
            }
            Console.Write('\n');
        }
    }

    public void Update()
    {
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.W: Player.Move(new Vector2(0, -1)); break;
            case ConsoleKey.A: Player.Move(new Vector2(-1, 0)); break;
            case ConsoleKey.S: Player.Move(new Vector2(0, 1)); break;
            case ConsoleKey.D: Player.Move(new Vector2(1, 0)); break;
        }
    }
}
