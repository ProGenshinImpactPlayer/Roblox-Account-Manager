using CefSharp.DevTools.Database;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBX_Alt_Manager.Classes
{
    public class RAMScript
    {
        public string NAME {  get ; set; }
        public string DESCRIPTION { get; set; }
        public string TAG { get; set; }

        public string ScriptFile;
        
        public RAMScript(string file)
        {
            ScriptFile = file;
        }

        private string getScriptContent()
        {
            return File.ReadAllText(ScriptFile);
        }
        public void setInformations()
        {
            string script = getScriptContent();

            using (Py.GIL())
            {
                PyDict globals = new PyDict();
                PythonEngine.Exec(script, globals);

                NAME = globals.GetItem("name").ToString();
                DESCRIPTION = globals.GetItem("description").ToString();
                TAG = globals.GetItem("tag").ToString();
            }
        }
        
        public bool Execute(Account account)
        {
            string script = getScriptContent();

            using (Py.GIL())
            {
                dynamic traceback = Py.Import("traceback");

                PyDict globals = new PyDict();
                PythonEngine.Exec(script, globals);

                PyObject method = globals.GetItem("run");

                PyObject[] args = { account.ToPython() };

                try
                {
                    method.Invoke(args);
                }
                catch (PythonException e)
                {
                    PyString[] traceback_messages = traceback.format_tb(e.Traceback);

                    dynamic traceback_message = String.Join<PyString>("", traceback_messages);
                    MessageBox.Show($"Script Error\n{traceback_message}\n{e.Message}", "Roblox Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}
