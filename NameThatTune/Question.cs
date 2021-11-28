using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace NameThatTune
{
    class Question
    {

        public string prompt { get; set; }

        List<String> answerBank = new List<string>();
        public string answer { get; set; }

        public Question()
        {
            prompt = "a";
            answerBank[0] = "a"; //getting an error here when creating question member in TriviaRound: index out of range
            answerBank[1] = "a";
            answerBank[2] = "a";
            answerBank[3] = "a";
            answer = "a";

            QuestionBuilder();
        }

        public List<Question> Q_Bank = new List<Question>();
        public void QuestionBuilder()
        {
            try
            {
                StreamReader file = new StreamReader(@"https://github.com/msickinger/NameThatTune/blob/master/TuneBank.txt");
                string line = "line";
                int count = 0;
                Question temp = new Question();
                while (line != null)
                {
                    temp.prompt = file.ReadLine();
                    temp.answerBank[0] = file.ReadLine();
                    temp.answerBank[1] = file.ReadLine();
                    temp.answerBank[2] = file.ReadLine();
                    temp.answerBank[3] = file.ReadLine();
                    temp.answer = file.ReadLine();
                    Q_Bank.Add(temp);
                    count++;
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found...");
            }
            
        }



        



    }
}
