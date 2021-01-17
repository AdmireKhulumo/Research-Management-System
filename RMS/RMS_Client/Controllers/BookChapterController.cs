using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RMS_Client.Controllers
{
    [Authorize]
    public class BookChapterController : Controller
    {

        // GET: /<controller>/ -- shows all book chapters in BIUST
        public async Task<IActionResult> Index()
        {
            //authorization check
            if (!Employee.isAdmin())
            {
                //normal user is not allowed to access this page, redirect
                return RedirectToAction("Profile", "Employee");
            }

            //create API object
            APIRequest api = new APIRequest();

            //call function that gets all book chapters in biust
            List<BookChapter> bookChapters = await api.getBookChapters();

            //set view bag to contain the book chapters for use in the UI view
            ViewBag.Message = bookChapters;

            return View();
        }

        //add book chapter
        public async Task<ActionResult> AddBookChapter(int pId, string bkTitle, string publisher, int pages ,int year, string chTitle="")
        {
            BookChapter bk = new BookChapter(chTitle,bkTitle,publisher, pages, year, pId:pId);
            Console.WriteLine("bk: " + bk.ToString());


            //make sure details arent empty before updating db
            if (chTitle.Length > 0)
            {
                bool success = await new APIRequest().addBookChapter(bk);
                Console.WriteLine("success: " + success);
                return RedirectToAction("MyProjects", "Project");
            }

            ViewBag.PId = pId;

            return View();
        }

        //add book chapter
        public async Task<ActionResult> EditBookChapter(int pId, string chTitle, string bkTitle, string publisher, int pages, int year, string old_ch="", string old_bk="")
        {

            BookChapter bk = new BookChapter(chTitle, bkTitle, publisher, pages, year, pId: pId);
            Console.WriteLine("bk: " + bk.ToString());

            //update database only if changes have been made, i.e new form has been submitted consisting of old chapter/book titles
            if (old_ch.Length > 0)
            {
                Console.WriteLine($"old ch: {old_ch}");
                Console.WriteLine($"old bk: {old_bk}");
                //call API to update
                bool success = await new APIRequest().editBookChapter(bk, old_bkTitle: old_bk, old_chTitle: old_ch);
                Console.WriteLine("success: " + success);
                //since done, just redirect to my projects
                return RedirectToAction("MyProjects", "Project");

            }

            ViewBag.Message = bk;

            return View();
        }

        //delete book chapter using titles
        public async Task<IActionResult> Delete(string bkTitle, string chTitle)
        {
            Console.WriteLine($"bk: {bkTitle}, ch: {chTitle}");

            bool success = await new APIRequest().deleteBookChapter(bkTitle, chTitle);
            Console.WriteLine(success);

            //reload page
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
