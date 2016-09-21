using System;
using System.Collections.Generic;

namespace EmployeeCvManager.Models.Employee
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Avatar { get; set; }
        public String Role { get; set; }
        public String Team { get; set; }
        public String Biography { get; set; }
        public IEnumerable<Skill> KeySkills { get; set; }
        public IEnumerable<Project> RecentProjects { get; set; }
    }

    public class Skill
    {
        public String Name { get; set; }
    }

    public class Project
    {
        public String Name { get; set; }
    }
}