using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.AdapterRealTimeExample
{
    public class FrenchSpeaker : IFrenchSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : " + Words);
            ITarget target = new Translator();
            string replyFromJohn = target.TranslateAndTellOtherPerson(Words, "English");
            return replyFromJohn;
        }

        public string AnswerForQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis très bien";
            }
            return reply;
        }
    }
}
