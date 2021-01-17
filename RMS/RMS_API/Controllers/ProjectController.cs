using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_API.Models;

namespace RMS_API.Controllers
{
    /// <summary>
    /// Performs CRUD operations on projects in the database.
    /// </summary>
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        /// <summary>
        /// Get All Projects in BIUST.
        /// </summary>
        /// <returns>
        /// List of Projects
        /// </returns>
        [HttpGet]
        public List<Project> Get()
        {
            //initialise DB object
            DB db = new DB();

            //call method to get all projects in BIUST, return results
            return db.getProjects();
        }


        /// <summary>
        /// Get All Projects done by a certain employee.
        /// </summary>
        /// <remarks> Could be an empty list if <paramref name="empId"/> is not found. </remarks>
        /// <returns>
        /// List of Projects
        /// </returns>
        /// <param name="empId">Employee ID Number</param>
        [HttpGet("{empId}")]
        public List<Project> Get(int empId)
        {
            //initialise DB object
            DB db = new DB();

            //call method to get all projects in BIUST, return results
            return db.getProjects(empId);
        }

        /// <summary>
        /// Add a project done by a certain employee.
        /// </summary>
        /// <param name="title">Title of the project</param>
        /// <param name="leader">Project leader's employee ID</param>
        /// <param name="famount">Funding amount</param>
        /// <param name="fsource">Source of funding</param>
        /// <param name="empId">Employee ID</param>
        /// <param name="fId">Funder's ID</param>
        [HttpPost("add")]
        public void Post([FromForm] string title, [FromForm]  int leader, [FromForm] int famount, [FromForm] string fsource, [FromForm] int empId, [FromForm] int fId)
        {
            //create a new project object to store details -- project ID does  not exist yet.
            Project p = new Project(title, fsource, famount, leader: leader);
            Console.WriteLine(p.ToString());
            Console.WriteLine(empId);
            Console.WriteLine(fId);

            //call method to add the project to the database
            _ = new DB().addProject(p, empId, fId);
        }

        /// <summary>
        /// Edit an existing project's details.
        /// </summary>
        /// <param name="title">Title of the project</param>
        /// <param name="leader">Project leader's employee ID</param>
        /// <param name="famount">Funding amount</param>
        /// <param name="fsource">Source of funding</param>
        /// <param name="pId">Project ID</param>
        [HttpPost("edit")]
        public void Edit([FromForm] string title, [FromForm] int leader, [FromForm] int famount, [FromForm] string fsource, [FromForm] int pId)
        {
            //create a Project object to store details
            Project p = new Project(title, fsource, famount, pId:pId, leader: leader);
            Console.WriteLine("p: " + p.ToString());

            //call method to edit that project
            bool success = new DB().editProject(p);
            Console.WriteLine("success: " + success);
        }


        /// <summary>
        /// Delete a project from the database.
        /// </summary>
        /// <remarks>Finds project using the <paramref name="pId"/> supplied.</remarks>
        /// <param name="pId"></param>
        [HttpDelete("{pId}")]
        public void Delete(int pId)
        {
            Console.WriteLine($"pId: {pId}");
            //call method to delete that project
            bool success = new DB().deleteProject(pId);
            Console.WriteLine(success);
        }
    }
}
