using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.DotNetPayroll.Entities
{
    static class TechnologiesBase
    {
        public static List<String> juniorTechnologies = new()
        {
            "Git",
            "LINQ",
            "ASP.NET MVC"
        };

        public static List<String> middleTechnologies = new(juniorTechnologies)
        {
            "SQL",
            "Windows Forms",
            "Web Services",
            "Entity Framework"
        };

        public static List<String> seniorTechnologies = new(middleTechnologies)
        {
            "Entity Framework",
            "WPF",
            "WCF",
            "XML",
            "XSLT",
        };

        public static List<String> teamLeaderTechnologies = new(seniorTechnologies);

        public static List<String> architectTechnologies = new(seniorTechnologies);
    }
}
