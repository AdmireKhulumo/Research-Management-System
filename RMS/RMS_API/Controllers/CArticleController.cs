using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_API.Models;


namespace RMS_API.Controllers
{
    /// <summary>
    /// Performs CRUD operations on a conference article.
    /// </summary>
    [Route("api/[controller]")]
    public class CArticleController : Controller
    {
        /// <summary>
        /// Get all conference articles in the database.
        /// </summary>
        /// <returns>List of conference articles</returns>
        [HttpGet]
        public List<CArticle> Get()
        {

            //initialise db object and call method to get all conference articles, return results
            return new DB().getCArticles();
        }

        /// <summary>
        /// Get conference articles belonging to a specifc project ID.
        /// </summary>
        /// <remarks>Can be empty if project has no conference articles</remarks>
        /// <param name="pId">Project ID</param>
        /// <returns>List of conference articles</returns>
        [HttpGet("{pId}")]
        public List<CArticle> Get(int pId)
        {
            return new DB().getCArticles(pId);
        }

        /// <summary>
        /// Add conference article to a specific project.
        /// </summary>
        /// <param name="ca">Conference article's details</param>
        [HttpPost("add")]
        public void Post([FromForm] CArticle ca)
        {
            Console.WriteLine("ca:" + ca.ToString());
            bool success = new DB().addCArticle(ca);
            Console.WriteLine("Success: {0}", success);
        }

        /// <summary>
        /// Edit a conference article's details.
        /// </summary>
        ///<remarks><paramref name="old_cname"/> and <paramref name="old_title"/> are used to uniquely identify the record.</remarks>
        /// <param name="ca">Conference article's new details</param>
        /// <param name="old_title">Current conference article title (could be changed)</param>
        /// <param name="old_cname">Current conference name (could be changed)</param>
        [HttpPost("edit")]
        public void Edit([FromForm] CArticle ca, [FromForm] string old_title, [FromForm] string old_cname)
        {
            Console.WriteLine("ca: " + ca.ToString());
            Console.WriteLine($"old title: {old_title}, old cname: {old_cname}");

            bool success = new DB().editCArticle(ca, old_title, old_cname);
            Console.WriteLine("success: " + success);
        }

        /// <summary>
        /// Delete a conference article record from the database.
        /// </summary>
        /// <remarks><paramref name="cname"/> and <paramref name="title"/> are used to uniquely identify the record.</remarks>
        /// <param name="cname">Conference name</param>
        /// <param name="title">Article's title</param>
        [HttpDelete("{cname}/{title}")]
        public void Delete(string cname, string title)
        {
            Console.WriteLine($"cname: {cname}, title: {title}");
            bool success = new DB().deleteCArticle(cname,title);
            Console.WriteLine(success);
        }
    }
}
