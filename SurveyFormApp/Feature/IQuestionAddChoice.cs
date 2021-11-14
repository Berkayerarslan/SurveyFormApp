using SurveyFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp
{
    public interface IQuestionAddChoice<T>
    {
        public List<T> Choices { get; set; }
        void AddChoice(T choice);
    }
}
