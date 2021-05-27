using Microsoft.AspNetCore.Components.Forms;

namespace Surveymatic.Model.Questionnaire
{

    public class QuestionBilang
    {
        public QuestionBilang()
        {
            en = new QuestionTranslation { Language = "en" };
            fr = new QuestionTranslation { Language = "fr" };
        }

        public QuestionTranslation en { get; set; }
        public QuestionTranslation fr { get; set; }
    }

}