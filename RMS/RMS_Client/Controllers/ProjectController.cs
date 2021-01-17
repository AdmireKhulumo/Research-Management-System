using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class ProjectController : Controller
    {

        //currently logged in user
        private static Employee user = Employee.user;

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

            //call function that gets all projects in biust
            List<Project> projects = await api.getProjects();

            //loop through projects, get leader's details
            foreach (Project project in projects)
            {

                // get leader (employee) information
                List<Employee> list = await api.getEmployees(empId: project.Leader);
                project.LeadDetails = list[0];

            }

            //set view bag to contain the projects fpr use in the UI view
            ViewBag.Message = projects;

            return View();
        }

        //show projects belonging to a specific employee -- i.e currently logged in user
        public async Task<IActionResult> MyProjects()
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
            List<Project> projects = await api.getProjects(Employee.user.EmpId);


            //loop through projects, get project details
            foreach (Project project in projects)
            {

                // get leader (employee) information
                List<Employee> list = await api.getEmployees(empId: project.Leader);
                project.LeadDetails = list[0];

            }

            //set view bag to contain the projects fpr use in the UI view
            ViewBag.Message = projects;

            return View();
        }

        public async Task<IActionResult> Details(int pId, string title, int leader, string fsource, int famount)
        {
            APIRequest api = new APIRequest();

            Project project = new Project(title, fsource, famount, pId: pId, leader: leader);


            //get list of book chapters
            project.BookChapters = await api.getBookChapters(project.PId);
            //get list of carticles
            project.CArticles = await api.getCArticles(project.PId);
            //get list of jarticles
            project.JArticles = await api.getJArticles(project.PId);

            //get leader(employee) information
            List<Employee> list = await api.getEmployees(empId: project.Leader);
            project.LeadDetails = list[0];

            //get list of funders and their info
            project.Funders = await api.getFunders(pId: project.PId);

            ViewBag.Message = project;

            return View();
        }

        
        public async Task<ActionResult> AddProject( int leader, string fsource, double famount, int fId, string title="")
        {
            int empId = Employee.user.EmpId;
            Console.WriteLine($"{empId}, {title}, {leader}, {fsource}, {famount}, {fId}");

            //ensure details arent empty before updating db
            if (title.Length > 0)
            {
                bool success = await new APIRequest().addProject(empId, title, leader, fsource, famount, fId);
                Console.WriteLine(success);
                return RedirectToAction("MyProjects");
            }

            return View();
        }

        //edit project
        public async Task<ActionResult> EditProject(int pId,string title, int leader, string fsource, double famount, string save="false")
        {

            Project p = new Project(title, fsource, famount, pId:pId, leader: leader);
            Console.WriteLine("p: " + p.ToString());

            //save value is only passed as true when save changes button is clicked on the editing interface
            if (save.Equals("true"))
            {
                //call API to update
                bool success = await new APIRequest().editProject(p);
                Console.WriteLine("success: " + success);
                //since done, just redirect to my projects
                return RedirectToAction("MyProjects");

            }

            ViewBag.Message = p;

            return View();
        }

        public async Task<IActionResult> Delete(int pId)
        {
            Console.WriteLine($"pIf: {pId}");

            bool success = await new APIRequest().deleteProject(pId);
            Console.WriteLine(success);

            //reload page
            return RedirectToAction("MyProjects");
        }

        //add author
        public async Task<IActionResult> AddAuthor(int empId, string id1, string id2, string type)
        {
            Console.WriteLine(empId);
            Console.WriteLine(id1);
            Console.WriteLine(id2);
            Console.WriteLine(type);

            bool success = await new APIRequest().addAuthor(empId, id1, id2, type);

            Console.WriteLine(success);
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
