using Microsoft.AspNetCore.Mvc;
using CommunityPolling.Models;
using System.Collections.Generic;

namespace CommunityPolling.Controllers
{
    public class PollsController : Controller
    {
        
        private static readonly List<Poll> _samplePolls = new List<Poll>
        {
            new Poll { Id = 1, Question = "What community event would you like next?", Options = new List<string>{"Clean-up day","Block party","Skills workshop"}, Votes = new List<int>{5,3,2} },
            new Poll { Id = 2, Question = "Which day is best for meetings?", Options = new List<string>{"Weekday evening","Saturday morning","Sunday afternoon"}, Votes = new List<int>{1,4,7} }
        };

        public IActionResult Index()
        {
            return View(_samplePolls);
        }

        
    }
}