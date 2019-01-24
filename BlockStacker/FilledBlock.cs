using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockStacker
{
    class FilledBlock : IBlock
    {
        public bool IsFilled { get; } = true;
        
        public FilledBlock()
        {
            IsFilled = true;
        }

        public void Draw()
        {
            Console.WriteLine("---");
            Console.WriteLine("|*|");
            Console.WriteLine("---");
        }
    }
}
