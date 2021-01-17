using System;
namespace RMS_API.Models
{
    public class JArticle
    {
        private int pId, pages, year, volume, issue;
        private string title, jname;

        public JArticle()
        {
            this.pId = 0;
            this.title = "";
            this.jname = "";
            this.pages = 0;
            this.year = 0;
            this.volume = 0;
            this.issue = 0;
        }

        public JArticle(string title, string jname, int volume, int issue, int pages, int year, int pId=0 )
        {
            this.pId = pId;
            this.title = title;
            this.jname = jname;
            this.pages = pages;
            this.year = year;
            this.issue = issue;
            this.volume = volume;
        }

        //properties
        public int PId { get => pId; set => pId = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Year { get => year; set => year = value; }
        public string Jname { get => jname; set => jname = value; }
        public string Title { get => title; set => title = value; }
        public int Volume { get => volume; set => volume = value; }
        public int Issue { get => issue; set => issue = value; }

        public override string ToString()
        {
            return $"pId: {pId}, title: {title}, jname: {jname}, volume: {volume}, issue: {issue}, pages: {pages}, year: {year}";
        }

    }
}
