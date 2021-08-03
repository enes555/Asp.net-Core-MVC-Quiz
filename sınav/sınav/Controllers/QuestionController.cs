using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sınav.Repository;

namespace sınav.Controllers
{
    public class QuestionController : Controller
    {

        QuestionRepo questionRepo = new QuestionRepo();
        public IActionResult Index()
        {
            QuestionRepo questionRepo = new QuestionRepo();

            return View(questionRepo.Tlist());
        }


    }
}
