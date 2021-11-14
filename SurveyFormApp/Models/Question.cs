using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Abstracts
{
    public enum QuestionType
    {
        Short,
        Paragraph,
        YesOrNo,
        MultiChoice,
        CheckBox,
        Time
    }
    public abstract class Question
    {
        public string QuestionContent { get; protected set; }
        public QuestionType QuestionType { get; protected set; }

        //public string Choice { get;protected set; }

        //public IReadOnlyList<string> Choices => choices;

        //protected List<string> choices = new List<string>();

        //public IReadOnlyList<string> Anwers => answers;

        protected List<string> answers = new List<string>();
        public Question(string questionContent)
        {
            QuestionContent = questionContent;
            
        }


    }
}
