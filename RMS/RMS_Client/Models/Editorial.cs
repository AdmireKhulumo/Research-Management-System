using System;
using System.Collections.Generic;

namespace RMS_Client.Models
{
    public class Editorial
    {
        private string activity, publication, url, date;
        //stores list of doers of an editorial...aka editors
        private List<Employee> doers;

        public Editorial()
        {
            activity = "";
            publication = "";
            url = "";
            date = "";
            doers = new List<Employee>();
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
        public List<Employee> Doers { get => doers; set => doers = value; }

        public override string ToString()
        {
            return $"activity: {activity}, publication: {publication}, url: {url}, date: {date}";
        }
    }
}
