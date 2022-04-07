using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.VirtualProxyDesignPattern
{
    public class RealImage : IImage
    {
        private string _fileName { get; set; }

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk();
        }
        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + _fileName);
        }

            public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + _fileName);
        }
    }
}
