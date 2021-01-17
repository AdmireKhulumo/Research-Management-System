using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class JArticleController : Controller
    {
        // GET: /<controller>/ -- shows all journal articles in BIUST
        public async Task<IActionResult> Index()
        {
            //authorization check
            if (!Employee.isAdmin())
            {
                //normal user is not allowed to access this page, redirect
                return RedirectToAction("Profile", "Employee");
            }

            //set view bag to contain the conference articles  for use in the UI view
            ViewBag.Message = await new APIRequest().getJArticles();

            return View();
        }

        public async Task<ActionResult> AddJArticle(int pId, string jname, int volume, int issue, int pages, int year, string title="")
        {
            JArticle ja = new JArticle(title, jname, volume, issue, pages, year, pId: pId);
            Console.WriteLine(ja.ToString());

            //make sure details arent empty before updating db
            if (title.Length> 0)
            {
                bool success = await new APIRequest().addJArticle(ja);
                Console.WriteLine("successful: {0}", success);
                return RedirectToAction("MyProjects", "Project");
            }

            ViewBag.PId = pId;

            return View();
        }

        //add jarticle
        public async Task<IActionResult> EditJArticle(int pId, string title, string jname, int volume, int issue, int pages, int year, string old_title = "", string old_jname = "")
        {

            JArticle ja = new JArticle(title, jname, volume, issue, pages, year, pId:pId);
            Console.WriteLine("ja: " + ja.ToString());

            //update database only if changes have been made, i.e new form has been submitted consisting of old title
            if (old_title.Length > 0)
            {
                Console.WriteLine($"old title: {old_title}");
                Console.WriteLine($"old jname: {old_jname}");
                //call API to update
                bool success = await new APIRequest().editJArticle(ja, old_title, old_jname);
                Console.WriteLine("success: " + success);
                //since done, just redirect to my projects
                return RedirectToAction("MyProjects","Project");
            }

            ViewBag.Message = ja;

            return View();
            
        }

        //delete jarticle using title and jname
        public async Task<IActionResult> Delete(string jname, string title)
        {
            Console.WriteLine($"jname: {jname}, title: {title}");
            //call method to delete jarticle in api class, return the boolean result to the caller
            
            bool success = await new APIRequest().deleteJArticle(jname, title);
            Console.WriteLine(success);

            return Redirect(Request.Headers["Referer"].ToString());
        }

    }
}
