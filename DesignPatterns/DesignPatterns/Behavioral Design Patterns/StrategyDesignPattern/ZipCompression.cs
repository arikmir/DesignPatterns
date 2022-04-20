using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.StrategyDesignPattern
{
    public class ZipCompression : ICompression
    {
        public void CompressFolder(string fileName)
        {
            Console.WriteLine("Folder is compressed using zip approach: '" + fileName
                                                                           + ".zip' file is created");
        }
    }
}
