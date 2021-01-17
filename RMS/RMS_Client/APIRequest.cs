using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using RMS_Client.Models;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace RMS_Client
{
    public class APIRequest
    {
        private string baseUrl = "https://localhost:24167/api";
        private string url;

        public APIRequest(){}

    //EMPLOYEE
        //api call to get all employees 
        public async Task<List<Employee>> getEmployees(string email="", int empId=0)
        {
            string url = baseUrl + "/employee";

            if (email != "")
            {
                //email/empID supplied, get employee matching email or empID -- neither should ever both be non-default
                url += $"/{email}/0";
            }
            else if ((empId != 0))
            {
                // employee/""/5 for empId = 5
                url += $"/\"\"/{empId}";
            }


            List<Employee> employees = new List<Employee>();
            var httpClient = HttpClientFactory.Create();


            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                employees = await content.ReadAsAsync<List<Employee>>();

            }

            return employees;
        }
        public async Task<bool> addEmployee(Employee e)
        {
            bool success = false;
            url = baseUrl + "/employee/add";

            var values = new Dictionary<string, string>
            {
                {"fname", e.Fname},
                {"sname", e.Sname},
                {"position", e.Position},
                {"department", e.Department},
                {"qualification", e.Qualification},
                {"interests", e.Interests},
                {"phone", e.Phone},
                {"email", e.Email},
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> editEmployee(Employee e)
        {
            bool success = false;
            url = baseUrl + "/employee/edit";

            var values = new Dictionary<string, string>
            {
                {"empId", $"{e.EmpId}"},
                {"fname", e.Fname},
                {"sname", e.Sname},
                {"position", e.Position},
                {"department", e.Department},
                {"qualification", e.Qualification},
                {"interests", e.Interests},
                {"phone", e.Phone},
                {"email", e.Email}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }

        //get authors of a publication
        public async Task<List<Employee>> getAuthors(string id1, string id2, string type)
        {
            bool success = false;
            List<Employee> employees = new List<Employee>();

            url = baseUrl + "/employee/author";

            var values = new Dictionary<string, string>
            {
                {"id1", id1},
                {"id2", id2},
                {"type", type}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                //var responseString = await response.Content.ReadAsStringAsync();

                //check if request was successful
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //employees stored in the 
                    employees = await response.Content.ReadAsAsync<List<Employee>>();
                }

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine(success);
            return employees;
        }
        //add  authors to a publication
        public async Task<bool> addAuthor(int empId, string id1, string id2, string type)
        {
            bool success = false;

            url = baseUrl + "/employee/author/add";

            var values = new Dictionary<string, string>
            {
                {"empId", $"{empId}"},
                {"id1", id1},
                {"id2", id2},
                {"type", type}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //get editors of an editorial piece
        public async Task<List<Employee>> getEditors(string activity, string publication)
        {
            bool success = false;
            List<Employee> employees = new List<Employee>();

            url = baseUrl + "/employee/editor";

            var values = new Dictionary<string, string>
            {
                {"activity", activity},
                {"publication", publication}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                //var responseString = await response.Content.ReadAsStringAsync();

                //check if request was successful
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //employees stored in the 
                    employees = await response.Content.ReadAsAsync<List<Employee>>();
                }

                success = true;
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
        //api call to get all projects in BIUST -- or projects by a single employee given their empId 
        public async Task<List<Project>> getProjects(int empId=0)
        {
            //url to be used
            string url = baseUrl + "/project";

            if (empId != 0)
            {
                //employee ID supplied, get projects for that employee
                url += $"/{empId}";
            }

            //create empty list of Project objects
            List<Project> projects = new List<Project>();

            //create http client to handle call
            var httpClient = HttpClientFactory.Create();

            //capture response from API call in a variable
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                //successful, store contents of response message
                var content = httpResponseMessage.Content;
                //iterate through contents and read into a project object, adding that into the projects list
                projects = await content.ReadAsAsync<List<Project>>();

            }

            //list size could be 0 if employee is not associated with any projects
            return projects;
        }
        //add a new project
        public async Task<bool> addProject(int empId, string title, int leader, string fsource, double famount, int fId)
        {
            bool success = false;

            var values = new Dictionary<string, string>
            {
                {"empId", $"{empId}"},
                {"title", title},
                {"leader", $"{leader}"},
                {"fsource", fsource},
                {"famount", $"{famount}"},
                {"fId", $"{fId}"}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync($"{baseUrl}/project/add",content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //edit project
        public async Task<bool> editProject(Project p)
        {
            bool success = false;

            url = baseUrl + "/project/edit";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{p.PId}"},
                {"title", p.Title},
                {"leader", $"{p.Leader}"},
                {"fsource", p.Fsource},
                {"famount", $"{p.Famout}"}
            };

            foreach (KeyValuePair<string, string> kvp in values)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> deleteProject(int pId)
        {
            bool success = false;

            url = baseUrl + $"/project/{pId}";


            try { 
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.DeleteAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }

        //BOOK CHAPTERS
        //api call to get all book chapters in BIUST -- or book chapters belonging to a single project
        public async Task<List<BookChapter>> getBookChapters(int pId = 0)
        {
            //url to be used
            string url = baseUrl + "/BookChapter";

            if (pId != 0)
            {
                //project ID supplied, get projects for that employee
                url += $"/{pId}";
            }

            //create empty list of Book Chapter objects
            List<BookChapter> bookChapters = new List<BookChapter>();

            //create http client to handle call
            var httpClient = HttpClientFactory.Create();

            //capture response from API call in a variable
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);


            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                //successful, store contents of response message
                var content = httpResponseMessage.Content;
                //iterate through contents and read into a book chapter object, then add to list
                bookChapters = await content.ReadAsAsync<List<BookChapter>>();

            }

            //list size could be 0 if project has no book chapters under it
            return bookChapters;
        }
        //add book chapter to db via api
        public async Task<bool> addBookChapter(BookChapter bk)
        {
            bool success = false;

            url = baseUrl + "/BookChapter/add";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{bk.PId}"},
                {"chTitle", bk.ChTitle},
                {"bkTitle", bk.BkTitle},
                {"pages", $"{bk.Pages}"},
                {"year", $"{bk.Year}"},
                {"publisher", bk.Publisher}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //edit book chapter -- use old chTitle and bkTitle as primary key...via API call
        public async Task<bool> editBookChapter(BookChapter bk, string old_chTitle, string old_bkTitle)
        {
            bool success = false;

            url = baseUrl + "/BookChapter/edit";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{bk.PId}"},
                {"chTitle", bk.ChTitle},
                {"bkTitle", bk.BkTitle},
                {"pages", $"{bk.Pages}"},
                {"year", $"{bk.Year}"},
                {"publisher", bk.Publisher},
                {"old_chTitle", old_chTitle},
                {"old_bkTitle", old_bkTitle}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> deleteBookChapter(string bkTitle, string chTitle)
        {
            bool success = false;

            url = baseUrl + $"/BookChapter/{bkTitle}/{chTitle}";

            try
            {
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.DeleteAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


        //CONFERENCE ARTICLES
        //get conference articles -- all or belonging to a specific project
        public async Task<List<CArticle>> getCArticles(int pId = 0)
        {
            //url to be used
            string url = baseUrl + "/CArticle";

            if (pId != 0)
            {
                //project ID supplied, get cpnference articles for that project
                url += $"/{pId}";
            }

            List<CArticle> cArticles = new List<CArticle>();

            //create http client to handle call
            var httpClient = HttpClientFactory.Create();

            //capture response from API call in a variable
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);


            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                //successful, store contents of response message
                var content = httpResponseMessage.Content;
                //iterate through contents and read into a book chapter object, then add to list
                cArticles = await content.ReadAsAsync<List<CArticle>>();

            }

            //list size could be 0 if project has no conference articles under it
            return cArticles;
        }
        //add conference article
        public async Task<bool> addCArticle(CArticle ca)
        {
            bool success = false;

            url = baseUrl + "/CArticle/add";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{ca.PId}"},
                {"title", ca.Title},
                {"cname", ca.Cname},
                {"pages", $"{ca.Pages}"},
                {"year", $"{ca.Year}"},
                {"location", ca.Location},
                {"publisher", ca.Publisher}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //edit carticle
        public async Task<bool> editCArticle(CArticle ca, string old_title, string old_cname)
        {
            bool success = false;

            url = baseUrl + "/CArticle/edit";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{ca.PId}"},
                {"title", ca.Title},
                {"cname", ca.Cname},
                {"pages", $"{ca.Pages}"},
                {"year", $"{ca.Year}"},
                {"location", ca.Location},
                {"publisher", ca.Publisher},
                {"old_title", $"{old_title}"},
                {"old_cname", $"{old_cname}"}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> deleteCArticle(string cname, string title)
        {
            bool success = false;

            url = baseUrl + $"/CArticle/{cname}/{title}";

            try
            {
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.DeleteAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


        //JOURNAL ARTICLES
        //get journal articles -- all or belonging to a specific project
        public async Task<List<JArticle>> getJArticles(int pId = 0)
        {
            //url to be used
            string url = baseUrl + "/JArticle";

            if (pId != 0)
            {
                //project ID supplied, get cpnference articles for that project
                url += $"/{pId}";
            }

            List<JArticle> jArticles = new List<JArticle>();

            //create http client to handle call
            var httpClient = HttpClientFactory.Create();

            //capture response from API call in a variable
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);


            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                //successful, store contents of response message
                var content = httpResponseMessage.Content;
                //iterate through contents and read into a book chapter object, then add to list
                jArticles = await content.ReadAsAsync<List<JArticle>>();

            }

            //list size could be 0 if project has no conference articles under it
            return jArticles;
        }
        //add journal article to db via API
        public async Task<bool> addJArticle(JArticle ja)
        {
            bool success = false;

            url = baseUrl + "/JArticle/add";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{ja.PId}"},
                {"title", ja.Title},
                {"jname", ja.Jname},
                {"pages", $"{ja.Pages}"},
                {"year", $"{ja.Year}"},
                {"volume", $"{ja.Volume}"},
                {"issue", $"{ja.Issue}"}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        //edit journal article
        public async Task<bool> editJArticle(JArticle ja, string old_title, string old_jname)
        {
            bool success = false;

            url = baseUrl + "/JArticle/edit";

            var values = new Dictionary<string, string>
            {
                {"pId", $"{ja.PId}"},
                {"title", ja.Title},
                {"jname", ja.Jname},
                {"pages", $"{ja.Pages}"},
                {"year", $"{ja.Year}"},
                {"volume", $"{ja.Volume}"},
                {"issue", $"{ja.Issue}"},
                {"old_title", $"{old_title}"},
                {"old_jname", $"{old_jname}"}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> deleteJArticle(string jname, string title)
        {
            bool success = false;

            url = baseUrl + $"/JArticle/{jname}/{title}";

            try
            {
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.DeleteAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }

        //EDITORIALS
        //get editorials, either all or by employee ID
        public async Task<List<Editorial>> getEditorials(int empId = 0)
        {
            //url to be used
            string url = baseUrl + "/editorial";

            if (empId != 0)
            {
                //employee ID supplied, get  editorials for that employee
                url += $"/{empId}";
            }

            List<Editorial> editorials = new List<Editorial>();

            //create http client to handle call
            var httpClient = HttpClientFactory.Create();

            //capture response from API call in a variable
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);


            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                //successful, store contents of response message
                var content = httpResponseMessage.Content;
                //iterate through contents and read into a book chapter object, then add to list
                editorials = await content.ReadAsAsync<List<Editorial>>();

            }

            //list size could be 0 if project has no conference articles under it
            return editorials;
        }
        public async Task<bool> addEditorial(Editorial ed, int empId)
        {
            bool success = false;

            url = baseUrl + "/editorial/add";

            var values = new Dictionary<string, string>
            {
                {"empId", $"{empId}"},
                {"activity", ed.Activity},
                {"publication", ed.Publication},
                {"url", ed.Url},
                {"date", ed.Date}

            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> editEditorial(Editorial ed, string old_activity, string old_publication)
        {
            bool success = false;

            url = baseUrl + "/editorial/edit";

            var values = new Dictionary<string, string>
            {
                {"activity", ed.Activity},
                {"publication", ed.Publication},
                {"url", ed.Url},
                {"date", ed.Date},
                {"old_publication", old_publication},
                {"old_activity", old_activity}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> deleteEditorial(string activity, string publication)
        {
            bool success = false;

            url = baseUrl + $"/editorial/{activity}/{publication}";

            try
            {
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.DeleteAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }



        //FUNDERS
        //get all of funders associated with a project Id
        public async Task<List<Funder>> getFunders(int pId=0)
        {
            url = baseUrl + "/funder";

            //check if pId was supplied
            if(pId != 0)
            {
                //include pId in url to get funders for a specific project
                url += $"/{pId}";
            }

            List<Funder> funders = new List<Funder>();

            var httpClient = HttpClientFactory.Create();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                var content = httpResponseMessage.Content;
                funders = await content.ReadAsAsync<List<Funder>>();
            }

            return funders;
        }
        //add funder to a certain project
        public async Task<bool> addFunder(Funder fu, int pId)
        {
            bool success = false;
            url = baseUrl + "/funder/add";
            Console.WriteLine(url);

            var values = new Dictionary<string, string>
            {
                {"pId", $"{pId}"},
                {"name", fu.Name},
                {"organisation", fu.Organisation},
                {"email", fu.Email}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> editFunder(Funder fu)
        {
            bool success = false;
            url = baseUrl + "/funder/edit";

            var values = new Dictionary<string, string>
            {
                {"fId", $"{fu.FId}"},
                {"name", fu.Name},
                {"organisation", fu.Organisation},
                {"email", fu.Email}
            };

            try
            {
                var content = new FormUrlEncodedContent(values);

                HttpClient httpClient = new HttpClient();

                var response = await httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }
        public async Task<bool> deleteFunder(int pId, int fId)
        {
            bool success = false;

            url = baseUrl + $"/funder/{pId}/{fId}";

            try
            {
                HttpClient httpClient = new HttpClient();

                var response = await httpClient.DeleteAsync(url);
                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseString);

                success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return success;
        }


    }
}
