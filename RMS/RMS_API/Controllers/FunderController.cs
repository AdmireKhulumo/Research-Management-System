using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RMS_API.Controllers
{
    /// <summary>
    /// Performs CRUD operations on a project funder
    /// </summary>
    [Route("api/[controller]")]
    public class FunderController : Controller
    {
        /// <summary>
        /// Get all project funders in the database.
        /// </summary>
        /// <returns>List of funders</returns>
        [HttpGet]
        public List<Funder> Get()
        {
            return new DB().getFunders();
        }

        /// <summary>
        /// Get funders of a specific project
        /// </summary>
        /// <remarks>Cannot be empty because each project has at least one funder.</remarks>
        /// <param name="pId"></param>
        /// <returns>List of project funders</returns>
        [HttpGet("{pId}")]
        public List<Funder> Get(int pId)
        {
            return new DB().getFunders(pId: pId);
        }

        /// <summary>
        /// Add a funder to a certain project.
        /// </summary>
        /// <remarks><paramref name="pId"/> is used to associate a funder to a project.</remarks>
        /// <param name="fu">Funder's details</param>
        /// <param name="pId">Project ID</param>
        [HttpPost("add")]
        public void Add([FromForm] Funder fu, [FromForm] int pId)
        {
            Console.WriteLine(fu.ToString());
            Console.WriteLine("pId: " + pId);

            bool success = new DB().addFunder(fu, pId: pId);
            Console.WriteLine(success);

        }

        /// <summary>
        /// Edit a funder's details.
        /// </summary>
        /// <remarks>Funder identified using the fId supplied</remarks>
        /// <param name="fu">Funder's details.</param>
        [HttpPost("edit")]
        public void Add([FromForm] Funder fu)
        {
            Console.WriteLine(fu.ToString());

            bool success = new DB().editFunder(fu);
            Console.WriteLine(success);

        }

        /// <summary>
        /// Delete a funder from a specified project.
        /// </summary>
        /// <remarks><paramref name="pId"/> identifies the project from which to remove the funder.</remarks>
        /// <param name="pId">Project ID</param>
        /// <param name="fId">Funder's ID</param>
        [HttpDelete("{pId}/{fId}")]
        public void Delete(int pId, int fId)
        {
            Console.WriteLine("pId: " + pId);
            Console.WriteLine("fId: " + fId);
            bool success = new DB().deleteFunder(pId, fId);
            Console.WriteLine(success);
        }
    }
}
