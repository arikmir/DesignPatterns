using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.AdapterRealTimeExample
{
    public interface IFrenchSpeaker
    {
        string AskQuestion(string Words);
        string AnswerForQuestion(string Words);
    }
}
