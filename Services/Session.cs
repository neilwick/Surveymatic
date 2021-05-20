namespace Surveymatic.Services
{

    public class Session : ISessionService
    {
        private string _lang = "en";
        public string Language { get => _lang; set => _lang = value; }
    }


}