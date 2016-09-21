
using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeCvManager.Models;
using Microsoft.Extensions.Caching.Memory;

namespace EmployeeCvManager.Helpers
{
    public static class EmployeeHelper
    {
        public static IList<EmployeeModel> GetEmployees(IMemoryCache memoryCache)
        {
            IList<EmployeeModel> employees = null;
            if(memoryCache.TryGetValue("employee-list", out employees))
            {
                return employees;
            }
            else
            {
                employees = GetInitialEmployees();
                return memoryCache.Set("employee-list", employees);
            }
        }

        public static EmployeeModel GetEmployee(IMemoryCache memoryCache, Guid id)
        {
            var employees = GetEmployees(memoryCache);
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public static bool CreateEmployee(IMemoryCache memoryCache, EmployeeModel employee)
        {
            var employees = GetEmployees(memoryCache);
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            memoryCache.Set("employee-list", employees);
            return true;
        }

        public static bool UpdateEmployee(IMemoryCache memoryCache, Guid id, EmployeeModel employee)
        {
            var employees = GetEmployees(memoryCache);
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee != null)
            {
                existingEmployee = employee;
                memoryCache.Set("employee-list", employees);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteEmployee(IMemoryCache memoryCache, Guid id)
        {
            var employees = GetEmployees(memoryCache);
            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee != null)
            {
                employees.Remove(existingEmployee);
                memoryCache.Set("employee-list", employees);
                return true;
            }
            else
            {
                return false;
            }
        }

#region Set initial database

        public static IList<EmployeeModel> GetInitialEmployees()
        {
            var employees = new List<EmployeeModel>
            {
                new EmployeeModel
                {
                    Id = new Guid("2813a9b5-d5d0-4b3a-a7bb-a7f275516b1d"),
                    FirstName = "Gabriella",
                    LastName = "Boon",
                    Avatar = "/images/gabriella-boon.png",
                    Role = ".NET Developer",
                    Team = "Modern Apps",
                    Biography = "Gabriella Boon has been a .NET developer since 2011 having build various solutions using ASPNET as well as mobile development using Xamarin. With background mostly in server side development Gabriella is in her element when developing decoupled services and designing SQL database solutions.",
                    KeySkills = new List<Skill>
                    {
                        new Skill { Name = "ASP.NET MVC / WEBAPI" },
                        new Skill { Name = "SQL" },
                        new Skill { Name = "Epi Server" },
                        new Skill { Name = "Azure Configuration" },
                        new Skill { Name = "ASP.NET Web Forms" },
                        new Skill { Name = "Xamarin" }
                    },
                    RecentProjects = new List<Project>
                    {
                        new Project { Name = "City Council - Mobility solution" },
                        new Project { Name = "Mircosoft - Showcase project" },
                        new Project { Name = "Azure SQL database migration - On premise to cloud" },
                        new Project { Name = "Craig and Smiths - Farming supplies web site" }
                    }
                },
                new EmployeeModel
                {
                    Id = new Guid("8c5b25d5-64bb-411b-a1af-4fe1394e50a4"),
                    FirstName = "Rowanne",
                    LastName = "Everett",
                    Avatar = "/images/rowanne-everett.png",
                    Role = "CRM consultant",
                    Team = "Dynamics",
                    Biography = "Rowanne has 10 years’ experience designing, building and delivering high quality CRM solutions for companies in New Zealand and the United Kingdom. Her passion lies in finding the underlying business needs of each client she works with and immersing herself in the business.",
                    KeySkills = new List<Skill>
                    {
                        new Skill { Name = "CRM On-Prmise" },
                        new Skill { Name = "CRM Online" },
                        new Skill { Name = "Agile Methodologies" },
                        new Skill { Name = "Consultancy" }
                    },
                    RecentProjects = new List<Project>
                    {
                        new Project { Name = "John Jones Advertising - CRM Online Implementation" },
                        new Project { Name = "Argudenture - CRM Upgrade" },
                        new Project { Name = "Ministry of Health - Migration from on premise to CRM Online" }
                    }
                },
                new EmployeeModel
                {
                    Id = new Guid("1191fdcd-0641-44f5-9380-792b1a92a44b"),
                    FirstName = "Heath",
                    LastName = "Kendrick",
                    Avatar = "/images/heath-kendrick.png",
                    Role = "Front-End developer",
                    Team = "Modern Apps",
                    Biography = "Heath started his career as a graphic designer but after learning basic HTML and JavaScript he quickly began to shift focus on his career. With a strong emphasis on usability and aesthetics Health has delivered slick mobile and web interfaces for over 4 years.",
                    KeySkills = new List<Skill>
                    {
                        new Skill { Name = "HTML5" },
                        new Skill { Name = "JavaScript" },
                        new Skill { Name = "Angular 1.x" },
                        new Skill { Name = "Bootstrap" }
                    },
                    RecentProjects = new List<Project>
                    {
                        new Project { Name = "Erics Astroturf - Rostering system" },
                        new Project { Name = "Gardeneers - Public website" },
                        new Project { Name = "Crafty Crafts - Event mobile app" }
                    }
                },
                new EmployeeModel
                {
                    Id = new Guid("af0034a0-19a4-4aed-9c2c-52d9d599d1ac"),
                    FirstName = "Kathlyn",
                    LastName = "Marley",
                    Avatar = "/images/kathlyn-marley.png",
                    Role = "UX Designer",
                    Team = "Digital",
                    Biography = "Kathleen is an expert in both user experience and design thinking. Embedding herself in clients for weeks or months to fully understand the needs of the end users, as well as spotting areas where business could be improved or optimised.",
                    KeySkills = new List<Skill>
                    {
                        new Skill { Name = "Graphic Design" },
                        new Skill { Name = "User testing" },
                        new Skill { Name = "Story Boarding" },
                        new Skill { Name = "Consulting" }
                    },
                    RecentProjects = new List<Project>
                    {
                        new Project { Name = "Farmiculture - Mobility solution" },
                        new Project { Name = "Police - Crisis alert system" },
                        new Project { Name = "Grand central society - Public website" }
                    }
                },
                new EmployeeModel
                {
                    Id = new Guid("cde5028a-0106-46d2-a616-09f39694c6eb"),
                    FirstName = "Pete",
                    LastName = "Elliot",
                    Avatar = "/images/pete-elliot.png",
                    Role = "IOS Developer",
                    Team = "Digital",
                    Biography = "",
                    KeySkills = new List<Skill>
                    {
                        new Skill { Name = "Swift" },
                        new Skill { Name = "Objective C" },
                        new Skill { Name = "X Code" }
                    },
                    RecentProjects = new List<Project>
                    {
                        new Project { Name = "City Council - Mobility solution" },
                        new Project { Name = "Fake Construction - Inventory App" }
                    }
                },
                new EmployeeModel
                {
                    Id = new Guid("88fe44f8-a01b-4ed0-a0da-793be90b3c25"),
                    FirstName = "Andy",
                    LastName = "Dawson",
                    Avatar = "/images/andy-dawson.png",
                    Role = "Senior .NET Developer",
                    Team = "Modern Apps",
                    Biography = "Andy has been developing software since the late 90s using a variety of technologies until he learned .NET back on version 2 and has never looked back. With a hand in both front-end and back-end development Andry has also become very familiar with the fast paced JavaScript world and continues to push himself to learn new technologies.",
                    KeySkills = new List<Skill>
                    {
                        new Skill { Name = "ASP.NET MVC / WEBAPI" },
                        new Skill { Name = "React Native" },
                        new Skill { Name = "React" },
                        new Skill { Name = "ASP.NET Web Forms" }
                    },
                    RecentProjects = new List<Project>
                    {
                        new Project { Name = "Spectappular - Back end integration system" },
                        new Project { Name = "Rotecom Healthcare - Windows 10 Tablet Application" },
                        new Project { Name = "Steel and Frame - Rostering system" }
                    }
                }
            };

            return employees;
        }

#endregion
    }
}