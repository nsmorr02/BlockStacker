using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockStacker
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            List<IBlock> blockStack = new List<IBlock>();

            do
            {
                Console.Clear();
                DrawBlocks(blockStack);
                option = SelectMenuOption();
                switch (option)
                {
                    case "1":
                        blockStack.Add(new EmptyBlock());
                        break;
                    case "2":
                        blockStack.Add(new FilledBlock());
                        break;
                    case "3":
                        blockStack.Clear();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            } while (option != "4");
        }

        private static void DrawBlocks(List<IBlock> blockStack)
        {
            foreach (IBlock block in blockStack)
            {
                block.Draw();
            }
            if(blockStack.Count > 0)
            {
                Console.WriteLine("There are " + blockStack.Count + " blocks: " + GetEmptyCount(blockStack) + " Empty blocks and " + GetFilledCount(blockStack) + " Filled blocks.");

            }
        }

        private static int GetFilledCount(List<IBlock> blockStack)
        {
            int filledCount = 0;
            foreach(IBlock block in blockStack)
            {
                if(block.IsFilled)
                {
                    filledCount++;
                }
            }
            return filledCount;
        }

        private static int GetEmptyCount(List<IBlock> blockStack)
        {
            int emptyCount = 0;
            foreach (IBlock block in blockStack)
            {
                if (!block.IsFilled)
                {
                    emptyCount++;
                }
            }
            return emptyCount;
        }

        private static string SelectMenuOption()
        {
            string option;
            Console.WriteLine("Select an Option: ");
            Console.WriteLine("1: Add Empty Box; 2: Add Filled Box; 3: Clear boxes; 4: Quit");
            option = Console.ReadLine();
            return option;
        }
    }
}
