using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_API.Models;

namespace RMS_API.Controllers
{
    /// <summary>
    /// Performs CRUD operations on a book chapter
    /// </summary>
    [Route("api/[controller]")]
    public class BookChapterController : Controller
    {
        /// <summary>
        /// Get all book chapter records in the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BookChapter> Get()
        {
            //initialise DB object
            DB db = new DB();

            //call method to get all book articles in BIUST, return results
            return db.getBookChapters();
        }

        /// <summary>
        /// Get all book chapters belonging to a specific project.
        /// </summary>
        /// <remarks>Can be empty if <paramref name="pId"/> supplied has no associated book chapters</remarks>
        /// <param name="pId">Project ID</param>
        /// <returns>List of BookChapter objects</returns>
        [HttpGet("{pId}")]
        public List<BookChapter> Get(int pId)
        {
            //return result of calling method to get book chapters 
            return new DB().getBookChapters(pId);
        }

        /// <summary>
        /// Add a book chapter to a specific project.
        /// </summary>
        /// <param name="bk">Book chapter's details</param>
        [HttpPost("add")]
        public void Post([FromForm] BookChapter bk)
        {
            Console.WriteLine("bk: " + bk.ToString());

            bool success = new DB().addBookChapter(bk);
            Console.WriteLine("success: " + success);
        }

        /// <summary>
        /// Edit a book chapter record.
        /// </summary>
        /// <remarks>Record found using <paramref name="old_bkTitle"/> and <paramref name="old_chTitle"/> which make up the primary key.</remarks>
        /// <param name="bk">Book chapter's new details</param>
        /// <param name="old_chTitle">Current chapter title (might be changed)</param>
        /// <param name="old_bkTitle">Current book title (might be changed)</param>
        [HttpPost("edit")]
        public void Edit([FromForm] BookChapter bk, [FromForm] string old_chTitle, [FromForm] string old_bkTitle)
        {
            Console.WriteLine("bk: " + bk.ToString());
            Console.WriteLine($"old ch: {old_chTitle}, old bk: {old_bkTitle}");

            bool success = new DB().editBookChapter(bk, old_chTitle, old_bkTitle);
            Console.WriteLine("success: " + success);
        }


        /// <summary>
        /// Delete a book chapter record from the database.
        /// </summary>
        /// <remarks><paramref name="bkTitle"/> and <paramref name="chTitle"/> used to uniquely identify the record</remarks>
        /// <param name="bkTitle">Book's title</param>
        /// <param name="chTitle">Chapter's title</param>
        [HttpDelete("{bkTitle}/{chTitle}")]
        public void Delete(string bkTitle, string chTitle)
        {
            Console.WriteLine($"bk: {bkTitle}, ch: {chTitle}");
            bool success = new DB().deletebookChapter(bkTitle, chTitle);
            Console.WriteLine(success);
        }
    }
}
