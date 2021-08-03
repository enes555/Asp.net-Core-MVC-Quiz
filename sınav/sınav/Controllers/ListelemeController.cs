using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sınav.Data.Model;
using Microsoft.AspNetCore.Mvc;
using sınav.Models;
using sınav.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace sınav.Controllers
{
    public class ListelemeController : Controller
    {

        Context c = new Context();        
        QuestionRepo questionRepo = new QuestionRepo();
        public IActionResult Index()
        {
            
            return View(questionRepo.Tlist());
        }
        public IActionResult DeleteQuestion(int id)
        {
            questionRepo.TDelete(new Question { QuestionID = id });

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddQuestion()
        {

            List<SelectListItem> values = (from x in c.Questions.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.QuestionDesc,
                                               Value = x.QuestionID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;

            List<SelectListItem> values2 = (from x in c.Questions.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.QuestionDesc,
                                               Value = x.QuestionID.ToString()
                                           }).ToList();
            ViewBag.v2 = values2;

            List<SelectListItem> values3 = (from x in c.Questions.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.QuestionDesc,
                                               Value = x.QuestionID.ToString()
                                           }).ToList();
            ViewBag.v3 = values3;

            List<SelectListItem> values4 = (from x in c.Questions.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.QuestionDesc,
                                               Value = x.QuestionID.ToString()
                                           }).ToList();
            ViewBag.v4 = values4;
            return View();
          
        }
        [HttpPost]
        public IActionResult AddQuestion(Question q)
        {
            questionRepo.TAdd(q);
            return RedirectToAction("Index");
        }


        public IActionResult GetQuestion(int id)
        {
            var x= questionRepo.GetT(id);
            Question q = new Question()
            {
                QuestionDesc = x.QuestionDesc,

                Question1 = x.Question1,
                Question2 = x.Question2,
                Question3 = x.Question3,
                Question4 = x.Question4,
                Question11 = x.Question11,
                Question12 = x.Question12,
                Question13 = x.Question13,
                Question14 = x.Question14,
                Question21 = x.Question21,
                Question22 = x.Question22,
                Question23 = x.Question23,
                Question24 = x.Question24,
                Question31 = x.Question31,
                Question32 = x.Question32,
                Question33 = x.Question33,
                Question34 = x.Question34,
                Question41 = x.Question41,
                Question42 = x.Question42,
                Question43 = x.Question43,
                Question44 = x.Question44,


            };

            return View(q);
        }

        public IActionResult StartQuiz()
        {

            return View(questionRepo.Tlist());
        }


       // public JsonResult CheckAnswer(string QueIdAndAnswer, int questionID)
   //     {
          //  Manager check = new Manager();
          
           // return Json(JsonConvert.SerializeObject(check.CheckAnswer(QueIdAndAnswer, questionID), Formatting.Indented), JsonRequestBehavior.AllowGet);
       // }

    }
}