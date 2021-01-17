using System;
using System.Collections.Generic;
using RMS_Client.Models;

namespace RMS_Client.Models
{
    public class Project
    {
        private int pId, leader;
        private double famount;
        private string title, fsource;

        //making it super!
        private Employee leadDetails;
        private List<BookChapter> bookChapters;
        private List<CArticle> cArticles;
        private List<JArticle> jArticles;
        private List<Funder> funders;

        //add funder

        //default constructor
        public Project()
        {
            pId = 0;
            leader = 0;
            famount = 0.0;
            title = "";
            fsource = "";
            leadDetails = new Employee();
            bookChapters = new List<BookChapter>();
            cArticles = new List<CArticle>();
            jArticles = new List<JArticle>();
            funders = new List<Funder>();

        }

        //parameterised constructor
        public Project(string title, string fsource, double famount, int pId = 0, int leader = 0)
        {
            this.pId = pId;
            this.title = title;
            this.leader = leader;
            this.famount = famount;
            this.fsource = fsource;
        }

        //properties
        public int PId { get => pId; set => pId = value; }
        public string Title { get => title; set => title = value; }
        public int Leader { get => leader; set => leader = value; }
        public string Fsource { get => fsource; set => fsource = value; }
        public double Famout { get => famount; set => famount = value; }
        public Employee LeadDetails { get => leadDetails; set => leadDetails = value; }
        public List<BookChapter> BookChapters { get => bookChapters; set => bookChapters = value; }
        public List<CArticle> CArticles { get => cArticles; set => cArticles = value; }
        public List<JArticle> JArticles { get => jArticles; set => jArticles = value; }
        public List<Funder> Funders { get => funders; set => funders = value; }

        //override to string method
        public override string ToString()
        {
            return $"pId: {pId}, title: {title}, leader: {leader}, fsource: {fsource}, famount: {famount} ";
        }
    }
}
