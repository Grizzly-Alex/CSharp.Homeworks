using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HW12.DotNetPayroll.Entities
{
    enum DevelopTitles
    {
        Junior,
        Middle,
        Senior,
        Architect,
        TeamLeader,
    }

    abstract class Developer
    {
        public int Experience { get; set; }
        public int Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GitHubAccount { get; set; }
        public DevelopTitles Title { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public Guid Id { get; }
        public List<String> Responsibilities { get; set; }
        public List<String> Technologies { get; set; }

        public Developer(string firstName, string lastName, string gitLink, int expirience, string dayOfBirthday)
        {         
            FirstName = firstName;
            LastName = lastName;
            Experience = expirience;
            GitHubAccount = gitLink;
            DayOfBirth = DateTime.ParseExact(dayOfBirthday, new string[]{"d/M/yyyy", "d.M.yyyy", "d:M:yyyy"}, CultureInfo.InvariantCulture); 
            Id = Guid.NewGuid();
            Technologies = new List<String>();
            Responsibilities = new List<String>() { "Знание английского языка" };
        }
    }
}