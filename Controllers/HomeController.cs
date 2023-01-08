using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quiz_Game.Models;

namespace Quiz_Game.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private List<QuizQuestionModel> _quizQuestions = new List<QuizQuestionModel>
        {
            new QuizQuestionModel
            {
                QuestionText="1. What is the capital of france?",
                PossibleAnswers= new List<string>{"Paris", "London", "Rome", "Madrid"},
                CorrectAnswer=0
            },
             new QuizQuestionModel
            {
                QuestionText="2. Which big cat is the largest?",
                PossibleAnswers= new List<string>{"Lion", "Leapord", "Tiger", "Jaguar"},
                CorrectAnswer=2
            },
              new QuizQuestionModel
            {
                QuestionText="3. Which is the worlds largest ocean?",
                PossibleAnswers= new List<string>{"Alantic", "Artic", "Indian", "Pacific"},
                CorrectAnswer=3
            },
               new QuizQuestionModel
            {
                QuestionText="4. How many earths can fit inside of the sun?",
                PossibleAnswers= new List<string>{"1037", "1.3 Million", "20.7 Million", "20,567"},
                CorrectAnswer=1
            },
                  new QuizQuestionModel
            {
                QuestionText="5. Which is the largest internal organ in the human body",
                PossibleAnswers= new List<string>{"heart", "liver", "stomach", "lungs"},
                CorrectAnswer=1
            },
                     new QuizQuestionModel
            {
                QuestionText="6. Which Country was the first to use paper money?",
                PossibleAnswers= new List<string>{"China", "England", "Russia", "Mexico"},
                CorrectAnswer=0
            },
                        new QuizQuestionModel
            {
                QuestionText="7. Which country was Pablo Picasso born in?",
                PossibleAnswers= new List<string>{"Italy", "France", "Spain", "England"},
                CorrectAnswer=2
            },
                           new QuizQuestionModel
            {
                QuestionText="8. Which was the first indina jones movie?",
                PossibleAnswers= new List<string>{"Temple of Doom", "Kingdom of Crystal Skull",
                    "The Last Crusade", "Raiders off the Lost Ark"},
                CorrectAnswer=3
            },
                              new QuizQuestionModel
            {
                QuestionText="9. Which state is the Sunshine State?",
                PossibleAnswers= new List<string>{"California", "Flordia", "Alabama", "Texas"},
                CorrectAnswer=1
            },
                                 new QuizQuestionModel
            {
                QuestionText="10. Steve Jobs is the CEO and co-founder of which company?",
                PossibleAnswers= new List<string>{"FaceBook", "Intel", "TikTok", "Apple"},
                CorrectAnswer=3
            }
        };
        public IActionResult Index()
        {
            return View(_quizQuestions);
        }
        [HttpPost]
        public IActionResult SubmitAnswers(List<int> UserAnswers)
        {
            int numCorrect = 0;
            for (int i =0; i < _quizQuestions.Count; i++) //counting number of questions
            {
                try
                {
                    if (_quizQuestions[i].CorrectAnswer == UserAnswers[i]) //counting correct questions
                    {
                        numCorrect++;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Did not answer all the questions");
                }
            }
            ViewBag.NumCorrect = numCorrect;
            return View("Results");
        }
    }
}
