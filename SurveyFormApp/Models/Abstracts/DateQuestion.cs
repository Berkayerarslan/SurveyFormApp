using SurveyFormApp.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    public class DateQuestion : Question, IQuestionAddAnswer<string> 
    {
        public List<string> Answers { get; set; } = new List<string>();

        public DateQuestion(string questionContent) : base(questionContent)
        {
            QuestionType = QuestionType.Time;
        }

        public void AddAnswer(string answer)
        {   
            DateTime dDate;
            if (Answers.Count == 0)
            {
                if (DateTime.TryParse(answer, out dDate))
                {
                    String.Format("{0:d/MM/yyyy}", dDate);
                    Answers.Add(answer);
                }
                else
                {
                    throw new Exception("Hatalı tarih giriş lütfen Gün/Ay/Yıl formatında giriş yapın");
                }
            }
            else
            {
                throw new Exception("Birden fazla cevap olamaz");
            }

            
        }

    }
}
