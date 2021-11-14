using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyFormApp.Feature
{
    public interface IQuestionAddAnswer<T> 
    {
        public List<T> Answers { get; set; }
        void AddAnswer(T answer);
    }
}
