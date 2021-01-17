using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class EditorialController : Controller
    {

        //currently logged in user
        private static Employee user = Employee.user;

        // GET: /<controller>/ -- shows all editorials in BIUST
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

            //call function that gets all editorials in biust
            List<Editorial> editorials = await api.getEditorials();

            //loop through editorials and get doers' details, could be one or many
            foreach (Editorial ed in editorials)
            {
                ed.Doers = await api.getEditors(ed.Activity, ed.Publication);
            }

            //set view bag to contain the projects fpr use in the UI view
            ViewBag.Message = editorials;

            return View();
        }

        //show editorials done by a specific employee -- i.e currently logged in user
        public async Task<IActionResult> MyEditorials()
        {
            //authorization check
            if (Employee.isAdmin())
            {
                //admin user is not allowed to access this page, redirect
                return RedirectToAction("Index", "Employee");
            }

            //create API object
            APIRequest api = new APIRequest();

            //call function that gets projects by a certain employee -- logged in user
            List<Editorial> editorials = await api.getEditorials(Employee.user.EmpId);

            //set view bag to contain the projects fpr use in the UI view
            ViewBag.Message = editorials;

            return View();
        }

        
        public async Task<ActionResult> AddEditorial(string activity, string publication, string url, string date, string save="false")
        {
            int empId = Employee.user.EmpId;

            Editorial ed = new Editorial(activity, publication, url, date);

            if (save == "true")
            {
                //details exist, add to database
                bool success = await new APIRequest().addEditorial(ed, empId);
                Console.WriteLine(success);
                //return to my editorials page
                return RedirectToAction("MyEditorials");
            }

            return View();
        }

        //edit project
        public async Task<ActionResult> EditEditorial(string activity, string publication, string url, string date, string old_activity="", string old_publication="")
        {
            Editorial ed = new Editorial(activity, publication, url, date);
            Console.WriteLine("ed: " + ed.ToString());
            Console.WriteLine($"old act: {old_activity}, old pub: {old_publication}");

            //save to db if old_act or old_pub are supplied, i.e save button has been pressed
            if (old_activity.Length > 0 )
            {
                //call API to update
                bool success = await new APIRequest().editEditorial(ed, old_activity, old_publication);
                Console.WriteLine("success: " + success);
                //since done, just redirect to my editorials
                return RedirectToAction("MyEditorials");

            }

            ViewBag.Message = ed;

            return View();
        }

        //delete an editorials
        public async Task<IActionResult> Delete(string activity, string publication)
        {
            Console.WriteLine($"act: {activity}, pub: {publication}");

            bool success = await new APIRequest().deleteEditorial(activity, publication);
            Console.WriteLine(success);

            //reload page
            return RedirectToAction("MyEditorials");
        }

    }
}
