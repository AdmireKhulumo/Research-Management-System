using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class CArticleController : Controller
    {
        // GET: /<controller>/ -- shows all conference articles in BIUST
        public async Task<IActionResult> Index()
        {
            //authorization check
            if (!Employee.isAdmin())
            {
                //normal user is not allowed to access this page, redirect
                return RedirectToAction("Profile", "Employee");
            }

            //set view bag to contain the conference articles  for use in the UI view
            ViewBag.Message = await new APIRequest().getCArticles();

            return View();
        }

        public async Task<ActionResult> AddCArticle(int pId, string cname, string location, string publisher, int pages, int year, string title="")
        {

            CArticle ca = new CArticle(title,cname,publisher,location,pages, year, pId: pId);
            Console.WriteLine("ca: " + ca.ToString());

            //make sure details arent empty before updating db
            if (title.Length > 0)
            {
                bool success = await new APIRequest().addCArticle(ca);
                Console.WriteLine("success: " + success);
                return RedirectToAction("MyProjects", "Project");
            }

            ViewBag.PId = pId;
            return View();
        }

        //edit carticle
        public async Task<ActionResult> EditCArticle(int pId, string title, string cname, string location, string publisher, int pages, int year, string old_title = "", string old_cname = "")
        {

            CArticle ca = new CArticle(title, cname, publisher, location, pages, year, pId: pId);
            Console.WriteLine("ca: " + ca.ToString());

            //update database only if changes have been made, i.e new form has been submitted consisting of old title
            if (old_title.Length > 0)
            {
                Console.WriteLine($"old title: {old_title}");
                Console.WriteLine($"old cname: {old_cname}");
                //call API to update
                bool success = await new APIRequest().editCArticle(ca,old_title,old_cname);
                Console.WriteLine("success: " + success);
                //since done, just redirect to my projects
                return RedirectToAction("MyProjects", "Project");

            }

            ViewBag.Message = ca;

            return View();
        }

        //delete carticle using title and cname
        public async Task<IActionResult> Delete(string cname, string title)
        {
            Console.WriteLine($"cname: {cname}, title: {title}");
            //call method to delete carticle in api class
            bool success = await new APIRequest().deleteCArticle(cname, title);
            Console.WriteLine(success);

            //reload the page
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
