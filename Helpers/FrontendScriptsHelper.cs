using System.Linq;
using EmployeeCvManager.Models.Employee;
using Newtonsoft.Json;

namespace EmployeeCvManager.Helpers
{
    public class FrontendScriptsHelper {
        private readonly string _scriptBundleString;
        public FrontendScriptsHelper (string scriptBundleString) {
            _scriptBundleString = scriptBundleString;
        }

        public string GetScriptTagString(){
            var scriptTagString = "";
            var bundleDefinition = JsonConvert.DeserializeObject<ScriptBundle>(_scriptBundleString);
            var orderedScripts = bundleDefinition.Scripts.OrderBy(s => s.Priority);
            foreach(ScriptDefinition scriptDefinition in orderedScripts){
                scriptTagString += $"<script type=\"text/javascript\" src=\"{scriptDefinition.Url}\"></script>";
            }
            return scriptTagString;
        }
    }
}