using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern
{
    //Product
    public class Report
    {
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public string ReportType { get; set; }


        public void DisplayReport()
        {
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
            Console.WriteLine("Report Type :" + ReportType);
        }

    }
}
