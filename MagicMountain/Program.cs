using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game MagicMountain = new Game();

            //while (MagicMountain.GetIsPlaying())
            //{
                MagicMountain.Play();
            //}

            PressAKey();
        }

        static void PressAKey()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("Press a key to continue");
            Console.ReadKey();
        }
    }
}
