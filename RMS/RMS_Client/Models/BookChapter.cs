using System;
namespace RMS_Client.Models
{
    public class BookChapter
    {
        private int pId, pages, year;
        private string chTitle, bkTitle, publisher;

        public BookChapter()
        {
            this.pId = 0;
            this.chTitle = "";
            this.bkTitle = "";
            this.publisher = "";
            this.pages = 0;
            this.year = 0;
        }

        public BookChapter(string chTitle, string bkTitle, string publisher, int pages, int year, int pId=0 )
        {
            this.pId = pId;
            this.chTitle = chTitle;
            this.bkTitle = bkTitle;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        //properties
        public int PId { get => pId; set => pId = value; }
        public int Pages { get => pages; set => pages = value; }
        public int Year { get => year; set => year = value; }
        public string BkTitle { get => bkTitle; set => bkTitle = value; }
        public string ChTitle { get => chTitle; set => chTitle = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public override string ToString()
        {
            return $"pId: {pId}, bkTitle: {bkTitle}, chTitle: {chTitle}, publisher: {publisher}, pages: {pages}, year: {year}";
        }
    }
}
