using System;
namespace RMS_API.Models
{
    public class Editorial
    {
        private string activity, publication, url, date;

        public Editorial()
        {
            activity = "";
            publication = "";
            url = "";
            date = "";
        }

        public Editorial(string activity, string publication, string url, string date)
        {
            this.activity = activity;
            this.publication = publication;
            this.url = url;
            this.date = date;
        }

        public string Activity { get => activity; set => activity = value; }
        public string Publication { get => publication; set => publication = value; }
        public string Url { get => url; set => url = value; }
        public string Date { get => date; set => date = value; }

        public override string ToString()
        {
            return $"activity: {activity}, publication: {publication}, url: {url}, date: {date}";
        }
    }
}
