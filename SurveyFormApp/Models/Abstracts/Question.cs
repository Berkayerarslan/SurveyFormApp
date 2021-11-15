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

        public Question(string questionContent)
        {
            QuestionContent = questionContent;

        }


    }
}
