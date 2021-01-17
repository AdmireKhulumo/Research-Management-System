using System;
namespace RMS_Client.Models
{
    public class CArticle
    {
        private int pId, pages, year;
        private string title, cname, publisher, location;

        public CArticle()
        {
            this.pId = 0;
            this.title = "";
            this.cname = "";
            this.publisher = "";
            this.pages = 0;
            this.year = 0;
            this.location = "";
        }

        public CArticle(string title, string cname, string publisher,string location, int pages, int year, int pId=0 )
        {
            this.pId = pId;
            this.title = title;
            this.cname = cname;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
            this.location = location;
        }

        //properties
        public int PId { get => pId; set => pId = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Year { get => year; set => year = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Title { get => title; set => title = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Location { get => location; set => location = value; }

        public override string ToString()
        {
            return $"pId: {pId}, title: {title}, cname: {cname}, publisher: {publisher}, location: {location}, pages: {pages}, year: {year}";
        }
    }
}
