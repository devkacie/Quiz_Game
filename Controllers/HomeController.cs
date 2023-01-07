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
                QuestionText="What is the capital of france?",
                PossibleAnswers= new List<string>{"Paris", "London", "Rome", "Madrid"},
                CorrectAnswer=0
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
                if (_quizQuestions[i].CorrectAnswer == UserAnswers[i] ) //counting correct questions
                {
                    numCorrect++;
                }
            }
            ViewBag.NumCorrect = numCorrect;
            return View("Results");
        }
    }
}
