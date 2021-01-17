using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using RMS_API.Models;

namespace RMS_API
{
    public class DB
    {
        private MySqlConnection conn;
        private string sql;
        private MySqlCommand cmd;

        //constructor initialises conection object
        public DB()
        {
            //create connection string
            string conStr = "SERVER = localhost; UID = root; PASSWORD =; database = rms";
            //initialise connection object
            conn = new MySqlConnection(conStr);
        }

    //EMPLOYEES
        //get all employees -- or a single employee if empId is supplied
        public List<Employee> getEmployees(string email="", int empId=0)
        {
            //declare list to hold all returned employees
            List<Employee> employees = new List<Employee>();

            if (email != "")
            {
                //get employee using supplied email
                sql = $"select * from employee where email='{email}'";
            }
            else if (empId != 0)
            {
                //get employee using empId
                sql = $"select * from employee where empId='{empId}'";
            }
            else
            {
                //no email supplied, send all employees
                sql = "select * from employee order by fname";
            }

            //check if connection is open before querying
            if (this.openConn())
            {
                //create a command oject to using the sql string and connection
                cmd = new MySqlCommand(sql, conn);

                //store results of query in a data reader object
                MySqlDataReader dr = cmd.ExecuteReader();

                //loop through data reader
                while (dr.Read())
                {
                    //create a new employee using data returned
                    Employee emp = new Employee((String)dr["fname"], (String)dr["sname"], (String)dr["department"], (String)dr["position"], (String)dr["qualification"], (String)dr["interests"], (String)dr["phone"], (String)dr["email"], (int)dr["empId"], (string)dr["photo"]);

                    //add that employee to the list
                    employees.Add(emp);
                }

                //close data reader object
                dr.Close();

                //close connection, ignore returned boolean
                _ = this.closeConn();
            }

            //return list of employees
            return employees;
        }
        public bool addEmployee(Employee e)
        {
            bool success = false;

            try
            {
                if (this.openConn())
                {
                    sql = $"insert into employee (fname, sname, department, position, qualification, interests, phone, email, photo) values ('{e.Fname}', '{e.Sname}', '{e.Department}', '{e.Position}', '{e.Qualification}', '{e.Interests}', '{e.Phone}', '{e.Email}', '/images/user.png')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public bool editEmployee(Employee e)
        {
            bool success = false;

            try
            {
                if (this.openConn() == true)
                {
                    sql = $"update employee set fname='{e.Fname}', sname='{e.Sname}', department='{e.Department}', position='{e.Position}', qualification='{e.Qualification}', interests='{e.Interests}', phone='{e.Phone}', email='{e.Email}' where empId={e.EmpId}";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();

                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //get authors of a publication
        public List<Employee> getAuthors(string id1, string id2, string type)
        {
            bool success = false;
            List<Employee> employees = new List<Employee>();

            if (type == "bookChapter")
            {
                //id1=bkTitle and id2 = chTitle
                sql = $"select * from employee, employee_bookChapter, bookChapter WHERE employee.empId=employee_bookChapter.empId AND employee_bookChapter.bkTitle=bookChapter.bkTitle AND employee_bookChapter.chTitle=bookChapter.chTitle AND bookChapter.bkTitle='{id1}' AND bookChapter.chTitle='{id2}' ";
            }
            else if (type == "jArticle")
            {
                //id1=jname and id2=title
                sql = $"select * from employee, employee_jArticle, jArticle WHERE employee.empId=employee_jArticle.empId AND employee_jArticle.jname=jArticle.jname AND employee_jArticle.title=jArticle.title AND jArticle.jname='{id1}' AND jArticle.title='{id2}' ";
            }
            else
            {
                //id1=cname and id2=title
                sql = $"select * from employee, employee_cArticle, cArticle WHERE employee.empId=employee_cArticle.empId AND employee_cArticle.cname=cArticle.cname AND employee_cArticle.title=cArticle.title AND cArticle.cname='{id1}' AND cArticle.title='{id2}' ";

            }

            try
            {
                if (this.openConn())
                {

                    cmd = new MySqlCommand(sql, conn);

                    //store results of query in data reader
                    MySqlDataReader dr = cmd.ExecuteReader();

                    //loop through data reader
                    while (dr.Read())
                    {
                        //create a new employee using data returned
                        Employee emp = new Employee((String)dr["fname"], (String)dr["sname"], (String)dr["department"], (String)dr["position"], (String)dr["qualification"], (String)dr["interests"], (String)dr["phone"], (String)dr["email"], (int)dr["empId"]);

                        //add that employee to the list
                        employees.Add(emp);
                    }

                    //close data reader object
                    dr.Close();


                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine(success);
            return employees;
        }
        //add single author by appending employee_publication table accordingly
        public bool addAuthor(int empId, string id1, string id2, string type)
        {
            bool success = false;

            if (type == "bookChapter")
            {
                //add to employee_bookChapter table
                sql = $"insert into employee_bookChapter (empId, bkTitle, chTitle) values ({empId}, '{id1}', '{id2}')";
            }
            else if (type == "jArticle")
            {
                //add to employee_jArticle table
                sql = $"insert into employee_jArticle (empId, jname, title) values ({empId}, '{id1}', '{id2}')";
            }
            else if (type == "cArticle")
            {
                //add to employee_cArticle table
                sql = $"insert into employee_cArticle (empId, cname, title) values ({empId}, '{id1}', '{id2}')";
            }

            try
            {
                if (this.openConn())
                {

                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //get editors/reviewers of an editorial
        public List<Employee> getEditors(string activity, string publication)
        {
            bool success = false;
            List<Employee> employees = new List<Employee>();

            sql = $"select * from employee, editorial, employee_editorial WHERE employee.empId=employee_editorial.empId AND editorial.activity=employee_editorial.activity AND editorial.publication=employee_editorial.publication AND editorial.activity='{activity}' AND editorial.publication='{publication}'";


            try
            {
                if (this.openConn())
                {

                    cmd = new MySqlCommand(sql, conn);

                    //store results of query in data reader
                    MySqlDataReader dr = cmd.ExecuteReader();

                    //loop through data reader
                    while (dr.Read())
                    {
                        //create a new employee using data returned
                        Employee emp = new Employee((String)dr["fname"], (String)dr["sname"], (String)dr["department"], (String)dr["position"], (String)dr["qualification"], (String)dr["interests"], (String)dr["phone"], (String)dr["email"], (int)dr["empId"]);

                        //add that employee to the list
                        employees.Add(emp);
                    }

                    //close data reader object
                    dr.Close();


                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine(success);
            return employees;
        }


        //PROJECTS
        //get all projects -- or a single project if empId is supplied
        public List<Project> getProjects(int empId=0)
        {
            //declare list to hold all returned employees
            List<Project> projects = new List<Project>();

            if (empId == 0)
            {
                //no project Id supplied, send all projects in BIUST
                sql = "select * from project order by pId";
            }
            else
            {
                //get project using supplied project Id -- first join emp and emp_proj using empId, then join emp_proj and proj usng projId, then finally filter using supplied empId in employee table
                sql = $"select * from project, employee, employee_project where employee.empId=employee_project.empId and employee_project.pId=project.pId and employee.empId={empId}";
            }

            //check if connection is open before querying
            if (this.openConn())
            {
                //create a command oject to using the sql string and connection
                cmd = new MySqlCommand(sql, conn);

                //store results of query in a data reader object
                MySqlDataReader dr = cmd.ExecuteReader();

                //loop through data reader
                while (dr.Read())
                {
                    //create a new project using the data returned
                    Project project = new Project((string)dr["title"], (string)dr["fsource"], (double)dr["famount"], pId: (int)dr["pId"], leader: (int)dr["leader"]);
                        
                    //add that employee to the list
                    projects.Add(project);
                }

                //close data reader object
                dr.Close();

                //close connection, ignore returned boolean
                _ = this.closeConn();
            }

            //return list of employees
            return projects;
        }
        //add project to project table, link to employee via employee_project table, and link to funder via project_funder table
        public bool addProject(Project p,  int empId,  int fId)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try{
                    //insert project into project table
                    sql = $"insert into project (title, leader, fsource, famount) values ('{p.Title}', '{p.Leader}', '{p.Fsource}', {p.Famout})";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //get the project Id
                    sql = "SELECT LAST_INSERT_ID()";
                    cmd = new MySqlCommand(sql, conn);
                    //use excute scalar which returns a single value
                    int pId = int.Parse(cmd.ExecuteScalar() + "");

                    //use project Id to associate project with employee
                    sql = $"insert into employee_project (empId, pId) values ({empId}, {pId})";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //use pId to associate project with funder
                    sql = $"insert into project_funder (pId, fId) values ({pId}, {fId})";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }
            return success;
        }
        public bool editProject(Project p)
        {
            bool success = false;

            try
            {
                if (this.openConn() == true)
                {
                    sql = $"update project set title='{p.Title}', leader={p.Leader}, fsource='{p.Fsource}', famount={p.Famout} where pId={p.PId}";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();

                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public bool deleteProject(int pId)
        {
            bool success=false;

            try
            {
                if (this.openConn())
                {
                    //delete employee association
                    sql = $"delete from employee_project where pId={pId}";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //delete project -- leave associated publications, they relate to the authors
                    sql = $"delete from project where pId={pId}";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();
                    success = true;
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


    //JOURNAL ARTICLES
        //get all journal articles -- or a list of them under a specific project
        public List<JArticle> getJArticles(int pId = 0)
        {
            //declare list to hold all returned journal articles
            List<JArticle> jArticles = new List<JArticle>();

            if (pId == 0)
            {
                //no project Id supplied, send all bookchapters in BIUST
                sql = "select * from jArticle";
            }
            else
            {
                //get all book chapters for a given project id
                sql = $"select * from jArticle where pId={pId}";
            }

            //check if connection is open before querying
            if (this.openConn())
            {
                //create a command oject to using the sql string and connection
                cmd = new MySqlCommand(sql, conn);

                //store results of query in a data reader object
                MySqlDataReader dr = cmd.ExecuteReader();

                //loop through data reader
                while (dr.Read())
                {
                    //create a new book chapter object using the data returned
                    JArticle ja = new JArticle((string)dr["title"], (string)dr["jname"], (int)dr["volume"], (int)dr["issue"], (int)dr["pages"], (int)dr["year"], pId: (int)dr["pId"]);

                    //add that book chapter to the list
                    jArticles.Add(ja);

                }

                //close data reader object
                dr.Close();

                //close connection, ignore returned boolean
                _ = this.closeConn();
            }

            //return list of employees
            return jArticles;
        }
        //add journal article to jArticle table
        public bool addJArticle(JArticle ja)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try
                {
                    //insert jArticle details into table
                    sql = $"insert into jArticle (pId, title, jname, volume, issue, pages, year) values ({ja.PId}, '{ja.Title}', '{ja.Jname}', {ja.Volume}, {ja.Issue}, {ja.Pages}, {ja.Year})";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }

            return success;
        }
        //edit journal article information
        public bool editJArticle(JArticle ja, string old_title, string old_jname)
        {
            bool success = false;

            try
            {
                if (this.openConn() == true)
                {
                    //edit on jArticle table
                    sql = $"update jArticle set pId={ja.PId}, title='{ja.Title}', jname='{ja.Jname}', volume={ja.Volume}, issue={ja.Issue}, pages={ja.Pages}, year={ja.Year} WHERE title='{old_title}' AND jname='{old_jname}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //edit on employee_jArticle table
                    sql = $"update employee_jArticle set title='{ja.Title}', jname='{ja.Jname}' WHERE title='{old_title}' AND jname='{old_jname}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();

                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public bool deleteJArticle(string jname, string title)
        {
            bool success = false;

            try
            {
                if (this.openConn())
                {

                    //delete author associations
                    sql = $"delete from employee_jArticle where title='{title}' AND jname='{jname}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //delete from jArticle
                    sql = $"delete from jArticle where title='{title}' AND jname='{jname}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }

        //CONFERENCE ARTICLES
        //get all conference articles -- or a list of them under a specific project
        public List<CArticle> getCArticles(int pId = 0)
        {
            //declare list to hold all returned conference articles
            List<CArticle> cArticles = new List<CArticle>();

            if (pId == 0)
            {
                //no project Id supplied, send all conference articles in BIUST
                sql = "select * from cArticle";
            }
            else
            {
                //get all conference articles for a given project id
                sql = $"select * from cArticle where pId={pId}";
            }

            //check if connection is open before querying
            if (this.openConn())
            {
                //create a command oject to using the sql string and connection
                cmd = new MySqlCommand(sql, conn);

                //store results of query in a data reader object
                MySqlDataReader dr = cmd.ExecuteReader();

                //loop through data reader
                while (dr.Read())
                {
                    //create a new conference article object using the data returned
                    CArticle ca = new CArticle((string)dr["title"], (string)dr["cname"], (string)dr["publisher"], (string)dr["location"], (int)dr["pages"], (int)dr["year"], pId: (int)dr["pId"]);

                    //add that conference article to the list
                    cArticles.Add(ca);

                }

                //close data reader object
                dr.Close();

                //close connection, ignore returned boolean
                _ = this.closeConn();
            }

            //return list of employees
            return cArticles;
        }
        //add conference article
        public bool addCArticle(CArticle ca)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try
                {
                    //insert cArticle details into table
                    sql = $"insert into cArticle (pId, title, cname, publisher, location, pages, year) values ({ca.PId}, '{ca.Title}', '{ca.Cname}', '{ca.Publisher}', '{ca.Location}', {ca.Pages}, {ca.Year})";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }

            return success;
        }
        //edit carticle info
        public bool editCArticle(CArticle ca, string old_title, string old_cname)
        {
            bool success = false;

            try
            {
                if (this.openConn() == true)
                {
                    //edit on cArticle table
                    sql = $"update cArticle set pId={ca.PId}, title='{ca.Title}',publisher='{ca.Publisher}', location='{ca.Location}', cname='{ca.Cname}', pages={ca.Pages}, year={ca.Year} WHERE title='{old_title}' AND cname='{old_cname}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //edit on employee_cArticle
                    sql = $"update employee_cArticle set title='{ca.Title}', cname='{ca.Cname}' WHERE title='{old_title}' AND cname='{old_cname}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();

                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public bool deleteCArticle(string cname, string title)
        {
            bool success = false;

            try
            {
                if (this.openConn())
                {

                    //delete author associations
                    sql = $"delete from employee_cArticle where title='{title}' AND cname='{cname}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //delete from cArticle
                    sql = $"delete from cArticle where title='{title}' AND cname='{cname}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();


                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }

        //BOOK CHAPTERS
        //get all book chapters -- or a list of book chapters under a specific project
        public List<BookChapter> getBookChapters(int pId = 0)
        {
            //declare list to hold all returned book chapters
            List<BookChapter> bookChapters = new List<BookChapter>();

            if (pId == 0)
            {
                //no project Id supplied, send all bookchapters in BIUST
                sql = "select * from bookChapter";
            }
            else
            {
                //get all book chapters for a given project id
                sql = $"select * from bookChapter where pId={pId}";
            }

            //check if connection is open before querying
            if (this.openConn())
            {
                //create a command oject to using the sql string and connection
                cmd = new MySqlCommand(sql, conn);

                //store results of query in a data reader object
                MySqlDataReader dr = cmd.ExecuteReader();

                //loop through data reader
                while (dr.Read())
                {
                    //create a new book chapter object using the data returned
                    BookChapter bc = new BookChapter((string)dr["chTitle"], (string)dr["bkTitle"], (string)dr["publisher"], (int)dr["pages"], (int)dr["year"], pId: (int)dr["pId"]);

                    //add that book chapter to the list
                    bookChapters.Add(bc);

                }

                //close data reader object
                dr.Close();

                //close connection, ignore returned boolean
                _ = this.closeConn();
            }

            //return list of employees
            return bookChapters;
        }
        //add book chapter
        public bool addBookChapter(BookChapter bk)
        {
            bool success = false;

            try
            {
                if (this.openConn() == true)
                {
                    sql = $"insert into bookChapter (pId, chTitle, bkTitle, publisher, pages, year) values ({bk.PId}, '{bk.ChTitle}', '{bk.BkTitle}', '{bk.Publisher}', {bk.Pages}, {bk.Year})";

                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();

                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //edit book chapter information
        public bool editBookChapter(BookChapter bk, string old_chTitle, string old_bkTitle)
        {
            bool success = false;

            try
            {
                if (this.openConn() == true)
                {
                    //edit on the bookChapter table
                    sql = $"update bookChapter set pId={bk.PId}, chTitle='{bk.ChTitle}', bkTitle='{bk.BkTitle}', publisher='{bk.Publisher}', pages={bk.Pages}, year={bk.Year} where chTitle='{old_chTitle}' and bkTitle='{old_bkTitle}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //edit on the employee_authors table -- essential in case titles were edited...it needs to be updated on that table too
                    sql = $"update employee_bookChapter set chTitle='{bk.ChTitle}', bkTitle='{bk.BkTitle}' where chTitle='{old_chTitle}' and bkTitle='{old_bkTitle}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();

                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public bool deletebookChapter(string bkTitile, string chTitle)
        {
            bool success = false;

            try
            {
                if (this.openConn())
                {
                    //delete author associations
                    sql = $"delete from employee_bookChapter where bkTitle='{bkTitile}' AND chTitle='{chTitle}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //delete from bookChapter
                    sql = $"delete from bookChapter where bkTitle='{bkTitile}' AND chTitle='{chTitle}'";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


        //EDITORIAL
        public List<Editorial> getEditorials(int empId = 0)
        {
            //declare list to hold all returned editorials
            List<Editorial> editorials = new List<Editorial>();

            if (empId != 0)
            {
                //get editorials for the specified employee
                sql = $"select * from employee, editorial, employee_editorial WHERE employee.empId=employee_editorial.empId AND editorial.activity=employee_editorial.activity AND editorial.publication=employee_editorial.publication AND employee.empId={empId}";
            }
            else
            {
                //get all editorials in biust
                sql = "select * from editorial order by activity";
            }

            try
            {
                //check if connection is open before querying
                if (this.openConn())
                {
                    //create a command oject to using the sql string and connection
                    cmd = new MySqlCommand(sql, conn);

                    //store results of query in a data reader object
                    MySqlDataReader dr = cmd.ExecuteReader();

                    //loop through data reader
                    while (dr.Read())
                    {
                        //create a new editorial using data returned
                        Editorial ed = new Editorial((string)dr["activity"], (string)dr["publication"], (string)dr["url"], (string)dr["date"]);

                        //add that employee to the list
                        editorials.Add(ed);
                    }

                    //close data reader object
                    dr.Close();

                    //close connection, ignore returned boolean
                    _ = this.closeConn();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            //return list of employees
            return editorials;
        }
        public bool addEditorial(Editorial ed, int empId)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try
                {
                    //insert editorial details into table
                    sql = $"insert into editorial (activity, publication, url, date) values ('{ed.Activity}','{ed.Publication}', '{ed.Url}', '{ed.Date}')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //add employee association
                    sql = $"insert into employee_editorial (empId, activity, publication) values ({empId}, '{ed.Activity}', '{ed.Publication}')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }

            return success;
        }
        public bool editEditorial(Editorial ed, string old_activity, string old_publication)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try
                {

                    //edit on employee_editorial table in case activity and/or publication were changed
                    sql = $"update employee_editorial set activity='{ed.Activity}', publication='{ed.Publication}' WHERE activity='{old_activity}' AND publication='{old_publication}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //edit on editorial table first
                    sql = $"update editorial set activity='{ed.Activity}', publication='{ed.Publication}', url='{ed.Url}', date='{ed.Date}' WHERE activity='{old_activity}' AND publication='{old_publication}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();


                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }

            return success;
        }
        public bool deleteEditorial(string activity, string publication)
        {
            bool success = false;

            try
            {
                if (this.openConn())
                {

                    //delete editor associations
                    sql = $"delete from employee_editorial where activity='{activity}' AND publication='{publication}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //delete from editorial table
                    sql = $"delete from editorial where activity='{activity}' AND publication='{publication}'";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();


                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


        //FUNDERS
        //get all funders for a specific project
        public List<Funder> getFunders(int pId = 0)
        {
            if (pId != 0)
            {
                //get funders matching supplied project ID
                sql = $"SELECT funder.name, funder.organisation, funder.email, funder.fId FROM funder, project, project_funder WHERE project.pId=project_funder.pId AND funder.fId=project_funder.fId AND project.pId={pId}";
            }
            else
            {
                sql = "select * from funder";
            }

            //list of funders
            List<Funder> funders = new List<Funder>();

            //confirm that connection is open
            if (this.openConn())
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                //loop through result
                while (dr.Read())
                {
                    Funder fu = new Funder((string)dr["name"], (string)dr["organisation"], (string)dr["email"], (int)dr["fId"]);
                    funders.Add(fu);
                }

                dr.Close();
                _ = this.closeConn();
            }
            return funders;
        }
        public bool addFunder(Funder fu, int pId=0)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try
                {
                    //insert into funder table
                    sql = $"insert into funder (name, organisation, email) values ('{fu.Name}', '{fu.Organisation}', '{fu.Email}')";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //get fId of last inserted funder since auto_increamented
                    sql = "select LAST_INSERT_ID()";
                    cmd = new MySqlCommand(sql, conn);
                    //use excute scalar which returns a single value
                    int fId = int.Parse(cmd.ExecuteScalar() + "");

                    //associate with project
                    sql = $"insert into project_funder (pId, fId) values ({pId}, {fId})";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }

            return success;
        }
        public bool editFunder(Funder fu)
        {
            bool success = false;

            if (this.openConn() == true)
            {
                try
                {
                    //edit in funder table
                    sql = $"update funder set name='{fu.Name}', organisation='{fu.Organisation}', email='{fu.Email}' where fId={fu.FId}";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //close connection
                    _ = this.closeConn();
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }

            }

            return success;
        }
        public bool deleteFunder(int pId, int fId)
        {
            bool success = false;

            try
            {
                if (this.openConn())
                {

                    //delete project association using fId and pId
                    sql = $"delete from project_funder where fId={fId} AND pId={pId}";
                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    //delete from funder table
                    //sql = $"delete from funder where fId={fId}";
                    //cmd = new MySqlCommand(sql, conn);
                    //cmd.ExecuteNonQuery();


                    _ = this.closeConn();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


    //CONNECTION
        //open connection to the database
        public bool openConn()
        {
            try
            {
                //try to open the connection
                conn.Open();

                //if successful, return true
                return true;
            }
            catch (MySqlException ex)
            {
                //check exception number, output relevant message
                if (ex.Number == 0)
                {
                    Console.WriteLine("Cannot connect to server.");
                }
                else if (ex.Number == 1045)
                {
                    Console.WriteLine("Incorrect credentials.");
                }

                //print stack trace
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        //close connection to the database
        public bool closeConn()
        {
            try
            {
                //try to close the connection
                conn.Close();
                //return true if successfully closed
                return true;
            }
            catch (MySqlException ex)
            {
                //print an exceptions
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}
