using System;

namespace CSharpAdventure
{
    class Program
    {
        static void Main()
        {
            Map map = new Map();
            while (true)
            {
                map.Render();
                map.Update();


                if (map.bQuit)
                    break;
            }

        }
    }
}
