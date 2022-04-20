using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.StrategyDesignPattern
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string fileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + fileName
                                                                           + ".rar' file is created");
        }
    }
}
