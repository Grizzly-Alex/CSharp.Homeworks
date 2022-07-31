using HW12.DotNetPayroll.DeveloperTypes;
using HW12.DotNetPayroll.Entities;


JuniorDeveloper jun = new("Alexander", "Medved", "https://github.com/Grizzly-pride", 1, "28/04/1991");
MiddleDeveloper mid = new("Victor", "Chepikov", "https://github.com/Grizzly-pride", 3, "20.05.1987");
SeniorDeveloper senior = new("Pavel", "Milinkevich", "https://github.com/Grizzly-pride", 5, "15.12.1986");
ArchitectDeveloper architect = new("Alexander", "Stelmah", "https://github.com/Grizzly-pride", 8, "02.11.1985");
TeamLeader leader = new("Valeria", "Vlaschik", "https://github.com/Grizzly-pride", 7, "12/05/1994");


Company.RecruitDeveloper(jun, mid, senior, architect, leader);

Company.DismissDeveloper(Guid.NewGuid());

Company.GiveSalary();

Company.ShowDevelopers();

Company.DismissDeveloper(leader.Id);