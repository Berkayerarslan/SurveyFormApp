using SurveyFormApp.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    public class ParagraphQuestion : Question, IQuestionAddAnswer<string>
    {
        public List<string> Answers { get; set; } = new List<string>();
        public ParagraphQuestion(string questionContent) : base(questionContent)
        {
            QuestionType = QuestionType.Paragraph;
        }
        public void AddAnswer(string answer)
        {
            if (Answers.Count < 1)
            {
                if (answer.Length < 201)
                {
                    Answers.Add(answer);
                }
            }
            else
            {
                throw new Exception("Birden fazla cevap verdiniz!");
            }
        }
    }
}
