using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class FunderController : Controller
    {
        
        public async Task<ActionResult> AddFunder(string name, string organisation, string email, int pId, string save="false")
        {

            Funder fu = new Funder(name, organisation, email);

            if (save == "true")
            {
                //details exist, add to database
                bool success = await new APIRequest().addFunder(fu, pId);
                Console.WriteLine(success);
                //return to my projects page
                return RedirectToAction("MyProjects", "Project");
            }

            ViewBag.Message = pId;

            return View();
        }

        //edit project
        public async Task<ActionResult> EditFunder(string name, string organisation, string email, int fId, string save = "false")
        {
            Funder fu = new Funder(name, organisation, email, fId:fId);

            //save to db if i.e save button has been pressed
            if (save == "true")
            {
                //edit on database
                bool success = await new APIRequest().editFunder(fu);
                Console.WriteLine(success);
                //return to my projects page
                return RedirectToAction("MyProjects", "Project");
            }

            ViewBag.Message = fu;

            return View();
        }

        //delete an editorials
        public async Task<IActionResult> Delete(int pId,int fId)
        {
            Console.WriteLine($"fId: {fId}, pId: {pId}");

            bool success = await new APIRequest().deleteFunder(pId, fId);
            Console.WriteLine(success);

            //reload page
            return Redirect(Request.Headers["Referer"].ToString());
        }

    }
}
