using SurveyFormApp.Feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    public class YesOrNoQuestion : Question, IQuestionAddAnswer<bool>, IQuestionAddChoice<bool>
    {
        public bool Yes { get; set; } = true;
        public bool No { get; set; } = false;
        public List<bool> Answers { get; set; } = new List<bool>();
        public List<bool> Choices { get; set; } = new List<bool>();

        public YesOrNoQuestion(string questionContent) : base(questionContent)
        {
            QuestionType = QuestionType.YesOrNo;
        }

        public void AddAnswer(bool answer)
        {
          
            if (Answers.Count < 1 && Choices.Count == 2)
            {
                if (answer == Yes || answer == No)
                {
                    Answers.Add(answer);
                }
                else
                {
                    throw new Exception("Hatalı bir cevap verdiniz");
                }
            }
            
        }

        public void AddChoice(bool choice)
        {
            if (Choices.Count < 2)
            {
                if (choice == Yes)
                {
                    Choices.Add(Yes);
                }
                else if (choice == No)
                {
                    Choices.Add(No);
                }
                else
                {
                    throw new Exception("Yanlış ekleme yaptınız");
                }
            }
            else
            {
                throw new Exception("Fazladan seçenek giremezsiniz!");
            }
            
        }
    }
}
