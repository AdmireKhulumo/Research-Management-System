using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_API.Models;

namespace RMS_API.Controllers
{
    /// <summary>
    /// Performs CRUD operations on an employee.
    /// </summary>
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        /// <summary>
        /// Get all employees in the database.
        /// </summary>
        /// <returns>List of employees.</returns>
        [HttpGet]
        public List<Employee> Get()
        {
            //get all employees
            return new DB().getEmployees();
        }

        /// <summary>
        /// Get a specific employee record.
        /// </summary>
        /// <remarks>Employee identified using their unique email address or employee ID.</remarks>
        /// <param name="email">Email Address</param>
        /// <param name="empId">Employee ID</param>
        /// <returns>List with one or zero Employee objects</returns>
        [HttpGet("{email}/{empId}")]
        public List<Employee> Get(string email="", int empId=0)
        {
            if (empId != 0)
            {
                //get using ID
                return new DB().getEmployees(empId: empId);
            }
            else if (email != "")
            {
                //get using email
                return new DB().getEmployees(email: email);
            }
            else
            {
                //get all in db
                return new DB().getEmployees();
            }

            //get list of employees, pick out first employee object in the list
            
        }

        /// <summary>
        /// Add an employee to the database.
        /// </summary>
        /// <param name="e">Employee's details</param>
        [HttpPost("add")]
        public void AddEmployee([FromForm] Employee e)
        {
            bool success = new DB().addEmployee(e);
        }

        /// <summary>
        /// Edit an employee record.
        /// </summary>
        /// <remarks>Employee identified using their empId</remarks>
        /// <param name="e">Employee's details</param>
        [HttpPost("edit")]
        public void EditEmployee([FromForm] Employee e)
        {
            bool success = new DB().editEmployee(e);
        }

        /// <summary>
        /// Get authors of a publication. Used by all publication types.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>An author is an employee.</item>
        ///     <item><paramref name="type"/> identifies the type of publication</item>
        ///     <item><paramref name="id1"/> and <paramref name="id2"/> uniquely identify the record.</item>
        /// </list>
        /// </remarks>
        /// <param name="id1">journal name, conferance name, or book title</param>
        /// <param name="id2">article title or chapter title</param>
        /// <param name="type">Type of publication: jArticle, cArticle, or bookChapter</param>
        /// <returns>List of Employee objects.</returns>
        [HttpPost("author")]
        public List<Employee> GetAuthors([FromForm] string id1, [FromForm] string id2, [FromForm] string type)
        {
            return new DB().getAuthors(id1, id2, type);
        }

        /// <summary>
        /// Associate an author with a publication they wrote.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>An author is an employee.</item>
        ///     <item><paramref name="type"/> identifies the type of publication</item>
        ///     <item><paramref name="id1"/> and <paramref name="id2"/> uniquely identify the record.</item>
        /// </list>
        /// </remarks>
        /// <param name="empId">Employee ID</param>
        /// <param name="id1">journal name, conferance name, or book title</param>
        /// <param name="id2">article title or chapter title</param>
        /// <param name="type">Type of publication: jArticle, cArticle, or bookChapter</param>
        [HttpPost("author/add")]
        public void AddAuthor([FromForm] int empId, [FromForm] string id1, [FromForm] string id2, [FromForm] string type)
        {
            Console.WriteLine($"empId: {empId}, id1: {id1}, id2: {id2}, type{type}");
            bool success = new DB().addAuthor(empId, id1, id2, type);
            Console.WriteLine(success);
        }

        /// <summary>
        /// Get editors/reviewers of an editorial
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>An editor is an employee. </item>
        ///     <item><paramref name="activity"/> and <paramref name="publication"/> are used to uniquely identify the record.</item>
        /// </list>
        /// </remarks>
        /// <param name="activity"></param>
        /// <param name="publication"></param>
        /// <returns>List of Employee objects.</returns>
        [HttpPost("editor")]
        public List<Employee> GetEditors([FromForm] string activity, [FromForm] string publication)
        {
            return new DB().getEditors(activity, publication);
        }

    }
}
