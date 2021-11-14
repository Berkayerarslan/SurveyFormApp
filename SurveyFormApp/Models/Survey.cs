using SurveyFormApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Models
{
    class Survey
    {
        public string Title { get; private set; }
        public string UserName { get; private set; }
        public string UserSurname { get; private set; }
        public DateTime SurveyTime { get; private set; }
        public string Description { get; private set; }
        public int QuestionCount { get; private set; }

        public IReadOnlySet<Question> Questions => questions;
        private HashSet<Question> questions = new HashSet<Question>();

        public Survey(string title, string name, string surname, int questionCount)
        {
            Title = title;
            UserName = name;
            UserSurname = surname;
            QuestionCount = questionCount;
        }


        public void AddQuestion(Question question)
        {
            if (questions.Count < QuestionCount)
            {
                questions.Add(question);
            }
            else
            {
                throw new Exception("Girilen soru adedindeb fazla giremezsiniz");
            }
            
        }
        public void AddSurveyTime(DateTime surveyTime)
        {
            if (DateTime.Now < surveyTime)
            {
                this.SurveyTime = surveyTime;
            }
        }
    }
}
