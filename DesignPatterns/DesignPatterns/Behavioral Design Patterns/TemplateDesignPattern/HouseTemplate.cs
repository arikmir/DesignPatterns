using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.TemplateDesignPattern
{
    public abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            this.BuildFoundation();
            this.BuildPillars();
            this.BuildWalls();
            this.BuildWindows();
            Console.WriteLine("House is built");
        }

        protected abstract void BuildFoundation();
        protected abstract void BuildPillars();
        protected abstract void BuildWalls();
        protected abstract void BuildWindows();


    }
}
