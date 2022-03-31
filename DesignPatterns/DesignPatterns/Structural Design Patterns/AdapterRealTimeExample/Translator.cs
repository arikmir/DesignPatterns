using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.AdapterRealTimeExample
{
    public class Translator : ITarget
    {
        static Dictionary<string, string> EnglishToFrench = new Dictionary<string, string>();
        static Dictionary<string, string> FrenchToEnglish = new Dictionary<string, string>();

        EnglishSpeaker englishSpeaker = new EnglishSpeaker();
        FrenchSpeaker frenchSpeaker = new FrenchSpeaker();

        static Translator()
        {
            EnglishToFrench.Add("how are you?", "comment allez-vous?");
            EnglishToFrench.Add("I am in USA", "Je suis aux Etats-Unis");

            FrenchToEnglish.Add("Je suis trC(s bien", "I am fine");
            FrenchToEnglish.Add("oC9 C*tes-vous?", "where are you?");
        }

        public string TranslateAndTellOtherPerson(string Words, string ConvertToWhichLanguage)
        {
            if (ConvertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string EnglishWords = ConvertToEnglish(Words);
                Console.WriteLine("\nPam Converted \"" + Words + " \" to \"" + EnglishWords + " and send the question to John");

                string EnglishWordsReply = this.englishSpeaker.AnswerForQuestion(EnglishWords);
                Console.WriteLine("Pam Got reply from John in English : " + "\"" + EnglishWordsReply + "\"");

                string FrenchConverted = ConvertToFrench(EnglishWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + EnglishWordsReply + "\"" + " to " + "\"" + FrenchConverted + "\"" + " and send back to David\n");
                return FrenchConverted;
            }
            else if (ConvertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string FrenchWords = ConvertToFrench(Words);
                Console.WriteLine("\nPam Converted \"" + Words + " \" to \"" + FrenchWords + " and send the question to David");
                string FrenchWordsReply = frenchSpeaker.AnswerForQuestion(FrenchWords);
                Console.WriteLine("Pam Got reply from David in French : " + "\"" + FrenchWordsReply + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" + " and send back to John\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }

        public string ConvertToEnglish(string Words)
        {
            return FrenchToEnglish[Words];
        }

        public string ConvertToFrench(string Words)
        {
            return EnglishToFrench[Words];
        }
    }
}
