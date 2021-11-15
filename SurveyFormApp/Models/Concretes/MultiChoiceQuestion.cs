using SurveyFormApp.Feature;
using SurveyFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    public class MultiChoiceQuestion : Question, IQuestionAddChoice<string>, IQuestionAddAnswer<string>
    {
        public List<string> Choices { get; set; } = new List<string>();
        public List<string> Answers { get; set; } = new List<string>();
        public MultiChoiceQuestion(string questionContent) : base(questionContent)
        {
            QuestionType = QuestionType.MultiChoice;

        }

        public void AddAnswer(string answer)
        {
            if (Answers.Count < 1)
            {
                if (Choices.Count < 2)
                {
                    throw new Exception("Seçenek ekleyin cevap verebilsin anketi çö<ücek kişi");
                }
                bool a = Choices.Any(x => x == answer);
                if (a)
                {
                    Answers.Add(answer);
                }
                else
                {
                    throw new Exception("Seçenekler içerisinde olmayan bir cevap verdiniz!");
                }
            }
            else
            {
                throw new Exception("Cevap yalnızca bir adet olabilir!");
            }
        }

        public void AddChoice(string choice)
        {
            if (Choices.Count < 1)
            {
                Choices.Add(choice);

            }
            else if (Choices.Count > 0 && Choices.Count < 4)
            {
                bool a = Choices.Any(x => x == choice);
                if (a)
                {
                    throw new Exception("Bu seçenekten eklediniz aynısını ekleyemezsiniz");
                }

                Choices.Add(choice);
            }
            else
            {
                throw new Exception("Seçenek 4 den fazla olamaz!");
            }


        }
    }
}
