using SurveyFormApp.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    public class CheckBoxQuestion : Question, IQuestionAddChoice<string>, IQuestionAddAnswer<string>
    {
        public List<string> Answers { get; set; } = new List<string>();
        public List<string> Choices { get; set; } = new List<string>();
        public CheckBoxQuestion(string questionContent) : base(questionContent)
        {
            QuestionType = QuestionType.CheckBox;
        }


        public void AddAnswer(string answer)
        {
            if (Answers.Count < Choices.Count && Choices.Count < 2)
            {
                bool a = Choices.Any(x => x == answer);
                if (a)
                {
                    Answers.Add(answer);
                }
                else
                {
                    throw new Exception("Seçenekler içerisinde olmayan bir cevap verdiniz!");
                }
                if (answer == "Hiçbiri")
                {
                    Answers.Clear();
                    Answers.Add("Hiçbiri");
                }

            }
            else
            {
                throw new Exception("Seçenekten fazla cevap olamaz veya 2 den az seçenek olmaz kontrol et!");
            }
        }

        public void AddChoice(string choice)
        {
            if (Choices.Count < 1)
            {
                Choices.Add(choice);

            }
            else if (Choices.Count > 0 && Choices.Count < 5)
            {
                foreach (var choiceItem in Choices)
                {
                    bool a = Choices.Any(x => x == choice);
                    if (a)
                    {
                        throw new Exception("Bu seçenekten eklediniz aynısını ekleyemezsiniz");
                    }

                }
                Choices.Add(choice);
            }
            else
            {
                throw new Exception("Seçenek 5 den fazla olamaz!");
            }
        }

    }
}
