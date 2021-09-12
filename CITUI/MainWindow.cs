using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace CITUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (PathList.SelectedIndex != Constants.INDEX_NONE)
            {
                PathList.Items.RemoveAt(PathList.SelectedIndex);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (PathList.SelectedIndex == Constants.INDEX_NONE)
                    {
                        PathList.Items.Add(fbd.SelectedPath);
                    }
                }
            }
        }

        private void AddExtensionBT_Click(object sender, EventArgs e)
        {
            string Extension = ExtensionInput.Text;
            if (Extension.Any(Char.IsWhiteSpace))
            {
                System.Windows.Forms.MessageBox.Show("Incorrect extension specified, remove all whitespaces!");
                return;
            }

            if (!Extension.StartsWith("."))
            {
                Extension = Extension.Insert(0, ".");
            }

            ExtensionBox.Items.Add(Extension);
        }
        private void RemoveExtensionBT_Click(object sender, EventArgs e)
        {
            if (ExtensionBox.SelectedIndex != Constants.INDEX_NONE)
            {
                ExtensionBox.Items.RemoveAt(ExtensionBox.SelectedIndex);
            }
        }

        private string ConstructArguments()
        {
            string bRecursive = RecursiveCB.Checked ? "-r" : " ";
            string bAllExtensions = AllExtensionCB.Checked ? "-a" : " ";

            List<string> Arguments = new List<string>();
            Arguments.Add(bRecursive);
            Arguments.Add(bAllExtensions);
            Arguments.Add("-e"); // explicit flag

            foreach(var Path in PathList.Items)
            {
                Arguments.Add('\"' + Path.ToString() + '\"');
            }

            foreach (var Ext in ExtensionBox.Items)
            {
                Arguments.Add(Ext.ToString());
            }

            string ClearText = TextBox.Text.Replace("\r", "");
            if (ClearText.Length > 0)
            {
                Arguments.Add('\"' + ClearText + '\"');
            }

            return String.Join(' ', Arguments);
        }

        private void InsertBT_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Constants.CIT_NAME))
            {
                System.Windows.Forms.MessageBox.Show(Constants.CIT_NAME + " is not found, please verify that it is in the directory or in system variables!");
                return;
            }

            // Prepare the process to run
            ProcessStartInfo Start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            Start.Arguments = ConstructArguments();
            // Enter the executable to run, including the complete path
            Start.FileName = Constants.CIT_NAME;
            // Hide console window
            Start.WindowStyle = ProcessWindowStyle.Hidden;
            Start.CreateNoWindow = true;
            int ExitCode = -1;


            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(Start))
            {
                proc.WaitForExit();
                // Retrieve the app's exit code
                ExitCode = proc.ExitCode;
                if (ExitCode == (int)ERRORS.OK)
                {
                    System.Windows.Forms.MessageBox.Show("Job Done!");
                    return;
                }

                string ErrorMessage = "";
                if ((ExitCode & (int)ERRORS.MISSING_TXT) != 0)
                {
                    ErrorMessage += Constants.MISSING_TXT_ERROR;
                }
                if ((ExitCode & (int)ERRORS.MISSING_DIR) != 0)
                {
                    ErrorMessage += Constants.MISSING_DIR_ERROR;
                }
                if ((ExitCode & (int)ERRORS.MISSING_EXT) != 0)
                {
                    ErrorMessage += Constants.MISSING_EXT_ERROR;
                }
                System.Windows.Forms.MessageBox.Show(ErrorMessage, "Error!");
            }
        }

        private void OpenTSBT_Click(object sender, EventArgs e)
        {
            using (var FileDialog = new OpenFileDialog())
            {
                FileDialog.Title = "Open config";
                FileDialog.Filter = Constants.FILE_FILTER;
                FileDialog.FilterIndex = 2;
                FileDialog.CheckFileExists = true;
                FileDialog.RestoreDirectory = true;

                if (FileDialog.ShowDialog() == DialogResult.OK && File.Exists(FileDialog.FileName))
                {
                    string JsonString = File.ReadAllText(FileDialog.FileName);
                    Config LoadedConfig = JsonSerializer.Deserialize<Config>(JsonString);

                    TextBox.Text = LoadedConfig.Text;
                    foreach(var Dir in LoadedConfig.Directories)
                    {
                        PathList.Items.Add(Dir);
                    }
                    foreach (var Ext in LoadedConfig.Extensions)
                    {
                        ExtensionBox.Items.Add(Ext);
                    }
                    AllExtensionCB.Checked = LoadedConfig.bAllExtension;
                    RecursiveCB.Checked = LoadedConfig.bRecursive;
                }
            }
        }

        private void SaveTSBT_Click(object sender, EventArgs e)
        {
            SaveFileDialog FileDialog = new SaveFileDialog();

            FileDialog.Title = "Save config";
            FileDialog.Filter = Constants.FILE_FILTER;
            FileDialog.FilterIndex = 2;
            FileDialog.RestoreDirectory = true;

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                Config NewConfig = new Config();

                NewConfig.Text = TextBox.Text;
                foreach (var Dir in PathList.Items)
                {
                    NewConfig.Directories.Add(Dir.ToString());
                }
                foreach (var Ext in ExtensionBox.Items)
                {
                    NewConfig.Extensions.Add(Ext.ToString());
                }
                NewConfig.bAllExtension = AllExtensionCB.Checked;
                NewConfig.bRecursive = RecursiveCB.Checked;

                string JsonOutput = JsonSerializer.Serialize(NewConfig);
                File.WriteAllText(FileDialog.FileName, JsonOutput);
            }
        }
    }

    [Flags]
    public enum ERRORS
    {
        MISSING_TXT = 0b001,
        MISSING_DIR = 0b010,
        MISSING_EXT = 0b100,
        OK = 0b000
    }

    public class Config
    {
        public Config()
        {
            Directories = new List<string>();
            Extensions = new List<string>();
        }

        public string Text { get; set; }
        public List<string> Directories { get; set; }
        public List<string> Extensions { get; set; }
        public bool bRecursive { get; set; }
        public bool bAllExtension { get; set; }
    }

    public static class Constants
    {
        public const int INDEX_NONE = -1;
        public const string FILE_FILTER = "json files (*.json)|*.json";
        public const string CIT_NAME = "CIT.exe";
        public const string MISSING_TXT_ERROR = "No text to insert specified!\n";
        public const string MISSING_EXT_ERROR = "No extensions or all extensions flag specified!\n";
        public const string MISSING_DIR_ERROR = "No directories to work with were specified\n";
    }
}
