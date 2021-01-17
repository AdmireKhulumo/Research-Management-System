using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_API.Models;

namespace RMS_API.Controllers
{
    /// <summary>
    /// Performs CRUD operations on editorials.
    /// </summary>
    [Route("api/[controller]")]
    public class EditorialController : Controller
    {
        /// <summary>
        /// Get all editorials in the database.
        /// </summary>
        /// <returns>List of editorials</returns>
        [HttpGet]
        public List<Editorial> Get()
        {

            //initialise db object and call method to get all editorials
            return new DB().getEditorials();
        }

        /// <summary>
        /// Get all editorials done by a certain employee.
        /// </summary>
        /// <param name="empId">Employee ID</param>
        /// <returns>List of editorials</returns>
        [HttpGet("{empId}")]
        public List<Editorial> Get(int empId)
        {
            return new DB().getEditorials(empId: empId);
        }

        /// <summary>
        /// Add editorial done by a specific employee.
        /// </summary>
        /// <param name="ed">Editorial's details</param>
        /// <param name="empId">Employee ID</param>
        [HttpPost("add")]
        public void Post([FromForm] Editorial ed, int empId)
        {
            Console.WriteLine("ed: " + ed.ToString());
            Console.WriteLine($"empId: {empId}");

            new DB().addEditorial(ed, empId);
        }

        /// <summary>
        /// Edit an editorial's details.
        /// </summary>
        /// <remarks><paramref name="old_activity"/> and <paramref name="old_publication"/> are used to uniquly identify the existing record in the database.</remarks>
        /// <param name="ed"></param>
        /// <param name="old_activity">Current activity details (could be changed)</param>
        /// <param name="old_publication">Current publication details (could be changed)</param>
        [HttpPost("edit")]
        public void Edit([FromForm] Editorial ed, [FromForm] string old_activity, [FromForm] string old_publication)
        {
            Console.WriteLine("ed: " + ed.ToString());
            Console.WriteLine($"old activity: {old_activity}, old pub: {old_publication}");

            bool success = new DB().editEditorial(ed, old_activity, old_publication);
            Console.WriteLine("success: " + success);
        }


        /// <summary>
        /// Delete an editorial record from the database.
        /// </summary>
        /// <remarks><paramref name="activity"/> and <paramref name="publication"/> are used to uniquely identify the record.</remarks>
        /// <param name="activity"></param>
        /// <param name="publication"></param>
        [HttpDelete("{activity}/{publication}")]
        public void Delete(string activity, string publication)
        {
            Console.WriteLine($"act: {activity}, pub: {publication}");
            bool success = new DB().deleteEditorial(activity, publication);
            Console.WriteLine(success);
        }
    }
}
