using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.StrategyDesignPattern
{
    public interface ICompression
    {
        void CompressFolder(string fileName);
    }
}
