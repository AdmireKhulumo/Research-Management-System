using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ReportController : Controller
    {

        // GET: /<controller>/ -- shows all projects in BIUST
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

            //get all employees
            List<Employee> employees = await api.getEmployees();

            //call function that gets all projects in biust
            List<Project> projects = await api.getProjects();

            //loop through projects, get leader's details
            foreach (Project project in projects)
            {
                // get leader (employee) information by filtering list of employees using project leader's empId
                project.LeadDetails = employees.Find(emp => emp.EmpId == project.Leader);

                //get list of funders and their info
                project.Funders = await api.getFunders(pId: project.PId);

                //get list of book chapters
                project.BookChapters = await api.getBookChapters(project.PId);
                //get list of carticles
                project.CArticles = await api.getCArticles(project.PId);
                //get list of jarticles
                project.JArticles = await api.getJArticles(project.PId);
            }

            //call to get all editorials
            List<Editorial> editorials = await api.getEditorials();

            //loop through editorials and get doers' details, could be one or many
            foreach (Editorial ed in editorials)
            {
                ed.Doers = await api.getEditors(ed.Activity, ed.Publication);
                Console.WriteLine(ed.ToString());
                Console.WriteLine(ed.Doers[0].Sname);
            }

            //set view bag to contain info
            ViewBag.Employees = employees;
            ViewBag.Projects = projects;
            ViewBag.Editorials = editorials;


            return View();
        }

    }
}
