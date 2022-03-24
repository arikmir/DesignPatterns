using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Design_Patterns.BuilderDesignPattern
{
    //Builder -  abstract class

    //https://dotnettutorials.net/lesson/builder-design-pattern/
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public abstract void SetReportType();


        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }

    }
}
