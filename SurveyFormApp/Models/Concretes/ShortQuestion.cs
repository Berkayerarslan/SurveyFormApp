using SurveyFormApp.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    class ShortQuestion : Question, IQuestionAddAnswer<string>
    {
        public List<string> Answers { get;  set; } = new List<string>();
        public ShortQuestion(string questionContent) : base(questionContent)
        {
            QuestionType = QuestionType.Short;
        }

        public void AddAnswer(string answer)
        {
            if (Answers.Count < 1)
            {
                if (answer.Length < 31)
                {
                    Answers.Add(answer);
                }
            }
            else
            {
                throw new Exception("Birden fazla cevap girdiniz");
            }
  
        }

    }
}
