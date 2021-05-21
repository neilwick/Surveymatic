namespace Surveymatic.Services
{

    public class Session : ISessionService
    {
        private string _lang = "en";
        public string Language
        {
            get => _lang;
            set
            {

                if (value == "fr")
                {
                    _lang = value;
                }
                else
                {
                    _lang = "en";
                }

            }
        }
    }


}