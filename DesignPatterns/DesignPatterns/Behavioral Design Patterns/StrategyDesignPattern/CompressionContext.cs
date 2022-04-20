using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.StrategyDesignPattern
{
    public class CompressionContext
    {
        private ICompression _compression;

        public CompressionContext(ICompression Compression)
        {
            this._compression = Compression;
        }

        public void CreateArchive(string fileName)
        {
            this._compression.CompressFolder(fileName);
        }
    }
}
