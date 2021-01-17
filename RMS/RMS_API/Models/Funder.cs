using System;
namespace RMS_API.Models
{
    public class Funder
    {
        string name, organisation, email;
        int fId;

        //default constructor
        public Funder()
        {
            name = "";
            organisation = "";
            email = "";
            fId = 0;
        }

        public Funder(string name, string organisation, string email, int fId=0)
        {
            this.name = name;
            this.organisation = organisation;
            this.email = email;
            this.fId = fId;
        }

        public int FId { get => fId; set => fId = value; }
        public string Name { get => name; set => name = value; }
        public string Organisation { get => organisation; set => organisation = value; }
        public string Email { get => email; set => email = value; }

        public override string ToString()
        {
            return $"fId: {fId}, name: {name}, organisation: {organisation}, email: {email}";
        }
    }
}
