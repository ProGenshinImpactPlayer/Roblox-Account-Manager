using BrightIdeasSoftware;
using Microsoft.Scripting.Hosting;
using Python.Runtime;
using RBX_Alt_Manager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBX_Alt_Manager.Forms
{
    public partial class RAMScriptExecutorForm : Form
    {
        public RAMScript SelectedScript;
        public List<RAMScript> SelectedScripts;

        public decimal ScriptExecutionDelay;

        public RAMScriptExecutorForm()
        {
            InitializeComponent();
        }

        private readonly static string ScriptFolderPath = Path.Combine(Environment.CurrentDirectory, "scripts");
        private void RAMScriptExecutorForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Beaware of scripts that someone sent you, it can be dangerous. We are not responsible for any damage that was made by any scripts.", "Roblox Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("This feature is very vulnerable, I wouldn't recommend anyone from using it without valid reason and caution.", "Roblox Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Check does the scripts folder exists, if not then create it.
            bool ScriptFolderExists = Directory.Exists(ScriptFolderPath);
            if (!ScriptFolderExists)
            {
                Directory.CreateDirectory(ScriptFolderPath);
            }

            // If the Python dll path is already in settings, then initialize Python engine
            if (AccountManager.ScriptSettings.Get("PythonDLL") != "None")
            {
                try
                {
                    Runtime.PythonDLL = AccountManager.ScriptSettings.Get("PythonDLL");
                    PythonEngine.Initialize();
                    PythonEngine.BeginAllowThreads();
                    updateScriptsList();
                }
                catch
                {
                    MessageBox.Show("Failed to Initialize Python Engine. You can try resetting Python dll.", "Roblox Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("If Python engine is not initialized, the script list won't show.", "Roblox Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void updateScriptsList()
        {
            // Get all files in the script folder
            string[] ScriptFolderFiles = Directory.GetFiles(ScriptFolderPath);

            List<RAMScript> RAMScripts = new List<RAMScript>();

            // Loop through all files in the script folder
            foreach (string File in ScriptFolderFiles)
            {
                // If the file name ends with .py, add it to the RAM scripts list
                if (File.EndsWith(".py"))
                {
                    RAMScript script = new RAMScript(File);

                    script.setInformations();

                    RAMScripts.Add(script);
                }
            }

            ScriptsListView.SetObjects(RAMScripts);
        }
        
        
        private void RAMScriptExecutorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        public void ShowForm() => Show();
        public void HideForm() => this.InvokeIfRequired(() => Hide());

        private void SetPythonDLL()
        {
            DialogResult dr = PythonDLLOpenFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                try
                {
                    Runtime.PythonDLL = PythonDLLOpenFileDialog.FileName;

                    AccountManager.ScriptSettings.Set("PythonDLL", Runtime.PythonDLL);
                    AccountManager.IniSettings.Save("RAMSettings.ini");

                    PythonEngine.Initialize();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("You need to select the Python DLL.", "Roblox Account Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExecuteScriptButton_Click(object sender, EventArgs e)
        {
            if (AccountManager.ScriptSettings.Get("PythonDLL") == "None")
            {
                DialogResult dr = MessageBox.Show("You need to set Python DLL before executing any scripts. Do you want to set it now?", "Roblox Account Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if ( dr == DialogResult.Yes )
                {
                    SetPythonDLL();
                }
                return;
            }

            if (SelectedScripts.Count == 0) return;
            Task.Run(() =>
            {
                foreach (Account account in AccountManager.SelectedAccounts)
                {
                    foreach (RAMScript script in SelectedScripts)
                    {

                        Task.Run(() =>
                        {
                            MessageBox.Show($"Executing script {script.ScriptFile}");
                            script.Execute(account);
                        });
                    }
                    Thread.Sleep(((int)ScriptExecutionDelay));
                }
            });
        }

        private void SetPythonDLLButton_Click(object sender, EventArgs e)
        {
            SetPythonDLL();
        }

        private void ScriptsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedScript = null;
            if (ScriptsListView.SelectedItems.Count > 0)
            {
                SelectedScripts = ScriptsListView.SelectedObjects.Cast<RAMScript>().ToList();
                if (ScriptsListView.SelectedItems.Count == 1) SelectedScript = ScriptsListView.SelectedObject as RAMScript;
                return;
            }
        }

        private void DelayExecuteNumeric_ValueChanged(object sender, EventArgs e)
        {
            ScriptExecutionDelay = DelayExecuteNumeric.Value;
        }

        private void RefreshScriptsButton_Click(object sender, EventArgs e)
        {
            updateScriptsList();
        }
    }
}
