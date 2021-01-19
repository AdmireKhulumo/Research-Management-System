using System;
namespace RMS_Client.Models
{
    public class Employee
    {
        string fname, sname, department, position, qualification, interests, phone, email, photo;
        int empId;

        //stores currently logged in employee user...details added when he/she logs in via navbar
        public static Employee user = new Employee();
         
        //default constructor 
        public Employee()
        {
            this.fname = "";
            this.sname = "";
            this.department = "";
            this.position = "";
            this.qualification = "";
            this.interests = "";
            this.phone = "";
            this.email = "";
            this.empId = 0;
            this.photo = "/images/user.png";

        }

        //paramterised constructor
        public Employee(string fname, string sname, string department, string position, string qualification, string interests, string phone, string email, int empId = 0, string photo = "/images/user.png")
        {
            this.fname = fname;
            this.sname = sname;
            this.department = department;
            this.position = position;
            this.qualification = qualification;
            this.interests = interests;
            this.phone = phone;
            this.email = email;
            this.empId = empId;
            this.photo = photo;

        }

        //properties
        public string Fname { get => fname; set => fname = value; }
        public string Sname { get => sname; set => sname = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Interests { get => interests; set => interests = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Photo { get => photo; set => photo = value; }
        public int EmpId { get => empId; set => empId = value; }

        //to string method for employees
        public override string ToString()
        {
            return $"{empId} {fname} {sname} {department} {position} {qualification} {interests} {phone} {email}";
        }

        //static method to check if logged in user is admin
        public static bool isAdmin()
        {
            if (user.Email == "admin@admin.com")
            {
                //user is admin, return true
                return true;
            }
            else
            {
                //user is not admin, user is normal employee
                return false;
            }
        }

    }
}
