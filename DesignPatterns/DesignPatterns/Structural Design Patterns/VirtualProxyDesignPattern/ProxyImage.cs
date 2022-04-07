using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.VirtualProxyDesignPattern
{
    //https://dotnettutorials.net/lesson/proxy-design-pattern-real-time-example/
    public class ProxyImage : IImage
    {
        private RealImage realImage = null;
        private string _fileName { get; set; }

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(_fileName);
            }

            realImage.DisplayImage();
        }
    }
}
