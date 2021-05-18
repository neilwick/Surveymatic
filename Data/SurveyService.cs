using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Surveymatic.Data
{
    public class SurveyService
    {
        private static readonly List<SurveyItem> Survey;

        static SurveyService()
        {
            Survey = new List<SurveyItem> {
                new SurveyItem
                {
                    Question = "Which of the following covid vaccines you used ?",
                    Choices = new List<string> {"Pfizer", "Moderna", "AstraZeneca"},
                    AnswerIndex = 1,
                    Score = 3
                },
                new SurveyItem
                {
                    Question = "Where you tested positive for COVID19",
                    Choices = new List<string> {"Home", "Workplace", "Did not work"},
                    AnswerIndex = 1,
                    Score = 3
                },
                    new SurveyItem
                {
                    Question = "Where did you work during covid lockdown",
                    Choices = new List<string> {"Home", "Workplace", "Did not work"},
                    AnswerIndex = 1,
                    Score = 3
                },
                new SurveyItem
                {
                    Question = "What is your gender identity",
                    Choices = new List<string> {"Male", "Female", "Other"},
                    AnswerIndex = 1,
                    Score = 3
                },
                new SurveyItem
                {
                    Question = "Which Age Group Do You Belong To ?",
                    Choices = new List<string> {"18-29", "30-54", "55+"},
                    AnswerIndex = 1,
                    Score = 3
                },
                new SurveyItem
                {
                    Question = "Where did you receive vaccine?",
                    Choices = new List<string> {"Pharmacy", "Hospital", "Work"},
                    AnswerIndex = 0,
                    Score = 5
                }
            };
        }

        public Task<List<SurveyItem>> GetSurveyAsync()
        {
            return Task.FromResult(Survey);
        }
    }
}