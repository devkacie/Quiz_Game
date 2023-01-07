using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_Game.Models
{
    public class QuizQuestionModel
    {
        public string QuestionText { get; set; }
        public List<string> PossibleAnswers { get; set; }
        public int CorrectAnswer { get; set; }
    }        
}
