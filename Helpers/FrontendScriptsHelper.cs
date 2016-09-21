using System.Linq;
using EmployeeCvManager.Models.Employee;
using Newtonsoft.Json;

namespace EmployeeCvManager.Helpers
{
    public class FrontendScriptsHelper {
        private readonly string _scriptBundleString;
        private readonly bool _isDevelopment;
        public FrontendScriptsHelper (string scriptBundleString, bool isDevelopment = false) {
            _scriptBundleString = scriptBundleString;
            _isDevelopment = isDevelopment;
        }

        public string GetScriptTagString(){
            if(_isDevelopment) {
                return "<script type=\"text/javascript\" src=\"http://localhost:3000/vendor.js\"></script><script type=\"text/javascript\" src=\"http://localhost:3000/app.js\"></script>";
            }
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