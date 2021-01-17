using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RMS_Client.Models;

namespace RMS_Client.Controllers
{
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class EmployeeController : Controller
    {
        private static Employee user = Employee.user;

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            //authorization check
            if (Employee.isAdmin() == false)
            {
                //normal user is not allowed to access this page, redirect
                return RedirectToAction("Profile");
            }

            //create list to store employees from API -- request via function in APIRequest class
            List<Employee>  employees = await new APIRequest().getEmployees();

            //send employees to view
            ViewBag.Message = employees;

            return View();
        }

        //For employee profile page
        public IActionResult Profile()
        {
            //authorization check
            if (Employee.isAdmin())
            {
                //admin user is not allowed to access this page, redirect
                return RedirectToAction("Index");
            }

            //send logged in user details to the view
            ViewBag.User = user;

            return View();
        }

        //add an employee
        public async Task<IActionResult> AddEmployee(string fname, string sname, string position, string department, string qualification, string interests, string phone, string email, string save = "false" )
        {
            //authorization check
            if (!Employee.isAdmin())
            {
                //normal user is not allowed to access this page, redirect
                return RedirectToAction("Profile");
            }

            if (save == "true")
            {
                Employee e = new Employee(fname, sname, department, position, qualification, interests, phone, email);

                bool success = await new APIRequest().addEmployee(e);
                Console.WriteLine(success);
                return RedirectToAction("Index");
            }

            return View();
        }

        //edit en employee's details
        public async Task<IActionResult> EditEmployee(string fname, string sname, string position, string department, string qualification, string interests, string phone, string email, int empId, string save = "false")
        {

            Employee emp = new Employee(fname, sname, department, position, qualification, interests, phone, email, empId: empId);

            if (save == "true")
            {
                bool success = await new APIRequest().editEmployee(emp);
                Console.WriteLine(success);
                //redirect to home page, if admin --> employees index, if not admin --> my profile
                if (Employee.isAdmin())
                {
                    return RedirectToAction("Index","Employee");
                }
                else
                {
                    return RedirectToAction("Profile", "Employee");
                }    
            }

            ViewBag.Message = emp;

            return View();
        }


    }
}
