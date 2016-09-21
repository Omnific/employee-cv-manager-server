using System.Collections.Generic;

namespace EmployeeCvManager.Models.Employee
{
    public class ScriptBundle {
        public string Name {get;set;}
        public string DefinitionFileUrl {get;set;}
        public IList<ScriptDefinition> Scripts {get;set;}
    }

    public class ScriptDefinition
    {
        public string FileName {get;set;}
        public string Priority {get;set;}
        public string Url {get;set;}
    }

}