using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW12.DotNetPayroll.Exeption;

namespace HW12.DotNetPayroll.Entities
{
    static class Company
    {
        const string nameCompany = "Epam";
        const int baseSalary = 500;

        public static List<Developer> ListDevelopers = new();

        public static void RecruitDeveloper(params Developer[] developers)
        {
            ListDevelopers.AddRange(developers);
        }

        public static void ShowDevelopers()
        {
            foreach (var developer in ListDevelopers)
            {
                Console.WriteLine($"Company: {nameCompany}, Full Name: {developer.FirstName} {developer.LastName}, Expirience: {developer.Experience}, Title: {developer.Title},\n" +
                    $"Salary: {developer.Salary}, GitHub: {developer.GitHubAccount}\n");
            }
        }

        public static void GiveSalary()
        {
            foreach (var developer in ListDevelopers)
            {
                developer.Salary = RelationSalaryToTitle(developer.Title);
            }
        }

        public static void DismissDeveloper(Guid idDeveloper)
        {
            bool findDeveloper = false;

            foreach (var developer in ListDevelopers)
            {
                if (developer.Id.Equals(idDeveloper))
                {
                    findDeveloper = true;
                    ListDevelopers.Remove(developer);
                    break;
                }
            }

            try
            {
                if (!findDeveloper)
                {
                    throw new DeveloperNotFoundException("Developer not found");
                }
            }
            catch (DeveloperNotFoundException ex)
            {
                Console.WriteLine(ex);
            }   
        }
       
        private static int RelationSalaryToTitle(DevelopTitles title)
        {
            int salary = title switch
            {
                DevelopTitles i when i.Equals(DevelopTitles.Junior) => baseSalary,
                DevelopTitles i when i.Equals(DevelopTitles.Middle) => baseSalary * 3,
                DevelopTitles i when i.Equals(DevelopTitles.Senior) => baseSalary * 5 + 300,
                DevelopTitles i when i.Equals(DevelopTitles.TeamLeader) => baseSalary * 8 + 500,
                DevelopTitles i when i.Equals(DevelopTitles.Architect) => baseSalary * 12 + 1000,
            };
            return salary;
        }      
    }
}