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
    /// Performs CRUD operations on a journal article.
    /// </summary>
    [Route("api/[controller]")]
    public class JArticleController : Controller
    {
        /// <summary>
        /// Get all journal articles in the database.
        /// </summary>
        /// <returns>List of journal articles</returns>
        [HttpGet]
        public List<JArticle> Get()
        {

            //initialise db object and call method to get all journal articles, return results
            return new DB().getJArticles();
        }

        /// <summary>
        /// Get journal articles belonging to a specifc project ID.
        /// </summary>
        /// <remarks>Can be empty if project has no journal articles.</remarks>
        /// <param name="pId">Project ID</param>
        /// <returns>List of journal articles</returns>
        [HttpGet("{pId}")]
        public List<JArticle> Get(int pId)
        {
            return new DB().getJArticles(pId);
        }

        /// <summary>
        /// Add journal article to a specific project.
        /// </summary>
        /// <param name="ja">Journal article's details</param>
        [HttpPost("add")]
        public void Post([FromForm] JArticle ja)
        {
            Console.WriteLine("ja: " + ja.ToString());
            new DB().addJArticle(ja);
        }

        /// <summary>
        /// Edit a journal article's details.
        /// </summary>
        /// <remarks><paramref name="old_jname"/> and <paramref name="old_title"/> are used to uniquely identify the record.</remarks>
        /// <param name="ja">Journal article's new details</param>
        /// <param name="old_title">Current journal article title (could be changed)</param>
        /// <param name="old_jname">Current journal name (could be changed)</param>
        [HttpPost("edit")]
        public void Edit([FromForm] JArticle ja, [FromForm] string old_title, [FromForm] string old_jname)
        {
            Console.WriteLine("ja: " + ja.ToString());
            Console.WriteLine($"old title: {old_title}, old jname: {old_jname}");

            bool success = new DB().editJArticle(ja, old_title, old_jname);
            Console.WriteLine("success: " + success);
        }


        /// <summary>
        /// Delete a journal article record from the database.
        /// </summary>
        /// <remarks><paramref name="jname"/> and <paramref name="title"/> are used to uniquely identify the record.</remarks>
        /// <param name="jname">Journal name</param>
        /// <param name="title">Article's title</param>
        [HttpDelete("{jname}/{title}")]
        public void Delete(string jname, string title)
        {
            Console.WriteLine($"jname: {jname}, title: {title}");
            bool success = new DB().deleteJArticle(jname, title);
            Console.WriteLine(success);
        }
    }
}
