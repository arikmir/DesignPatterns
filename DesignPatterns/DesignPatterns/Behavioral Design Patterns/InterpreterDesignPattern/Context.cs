using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Design_Patterns.InterpreterDesignPattern
{
    public class Context
    {
        public string expression { get; set; }

        public DateTime date { get; set; }

        public Context(DateTime Date)
        {
            date = Date;
        }
    }
}
