using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern
{
     class ExcelReport : ReportBuilder
    {
       

        public override void SetReportHeader()
        {
            this.reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }
}
