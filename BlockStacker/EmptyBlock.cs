using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockStacker
{
    class EmptyBlock : IBlock
    {
        public bool IsFilled { get; } = false;

        public void Draw()
        {
            Console.WriteLine("---");
            Console.WriteLine("| |");
            Console.WriteLine("---");
        }
    }
}
