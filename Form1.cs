using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;

namespace Deviator_Mod_Manager
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fileExists = Directory.Exists(FilePathLable.Text);

            if (!fileExists)
            {
                FilePathLable.Text = "Please Select Game File Path";
            }
            if (Directory.Exists(folderBrowserDialog1.SelectedPath + "\\BepInEx"))
            {
                PopulateDownloadedModsList();
                DownloadedModsList.ItemCheck += DownloadedModsList_ItemCheck;
            }

        }

        private List<string> GetModsInDir()
        {
            string pluginStorePath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", "pluginStore");
            string pluginsPath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", "plugins");
            List<string> pluginFiles = new List<string>();

            try
            {
                if (Directory.Exists(pluginStorePath))
                {
                    string[] dllFiles = Directory.GetFiles(pluginStorePath, "*.dll", SearchOption.TopDirectoryOnly);
                    pluginFiles.AddRange(dllFiles);
                }
                else
                {
                    MessageBox.Show("Warning: The pluginStore directory does not exist.");
                }
                if (Directory.Exists(pluginsPath))
                {
                    string[] dllFilesInPlugins = Directory.GetFiles(pluginsPath, "*.dll", SearchOption.TopDirectoryOnly);
                    pluginFiles.AddRange(dllFilesInPlugins);
                }
                else
                {
                    MessageBox.Show("The plugins directory does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the mods: {ex.Message}");
            }

            return pluginFiles;
        }

        private void PopulateDownloadedModsList()
        {
            DownloadedModsList.Items.Clear();
            List<string> mods = GetModsInDir();

            // Add each file name to the CheckedListBox
            foreach (string mod in mods)
            {
                // Extract the file name from the full path
                string fileName = Path.GetFileName(mod);

                // Determine if the mod is in the pluginStore or plugins directory
                string directory = Path.GetDirectoryName(mod);
                bool isInPlugins = directory.EndsWith("plugins");

                // Add the file name to the CheckedListBox and check it if in the plugins directory
                DownloadedModsList.Items.Add(fileName, isInPlugins);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(folderBrowserDialog1.SelectedPath) && folderBrowserDialog1.SelectedPath.EndsWith("DEVIATOR"))
                {
                    FilePathLable.Text = folderBrowserDialog1.SelectedPath;
                    FilePathLable.ForeColor = Color.Black;
                }
                else
                {
                    FilePathLable.Text = "Error: Invalid Game File Path";
                    FilePathLable.ForeColor = Color.Red;
                }

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderBrowserDialog1.SelectedPath) && folderBrowserDialog1.SelectedPath.EndsWith("DEVIATOR"))
            {
                if (Directory.Exists(folderBrowserDialog1.SelectedPath + "\\BepInEx") && !File.Exists(folderBrowserDialog1.SelectedPath + "\\winhttp.dll"))
                {
                    SetupButtonInfo.Text = "Run the game to setup files";
                    SetupButtonInfo.ForeColor = Color.Orange;
                }
                else if (Directory.Exists(folderBrowserDialog1.SelectedPath + "\\BepInEx") && !File.Exists(folderBrowserDialog1.SelectedPath + "\\winhttp.dll"))
                {
                    SetupButtonInfo.Text = "Mods are already setup";
                    SetupButtonInfo.ForeColor = Color.Orange;
                }
                else
                {
                    FilePathLable.Text = folderBrowserDialog1.SelectedPath;
                    FilePathLable.ForeColor = Color.Black;
                    SetupModsButton.Enabled = false;
                    SetupModsButton.Text = "Setting Up Mods";
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                    Uri BepInExURL = new Uri("https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip");
                    wc.DownloadFileAsync(BepInExURL, folderBrowserDialog1.SelectedPath + "\\BepinEx_To_Extract_Folder.zip");
                    SetupButtonInfo.Text = "Downloading Modding Files";
                    SetupButtonInfo.ForeColor = Color.Black;
                }
            }
            else
            {
                FilePathLable.Text = "Error: Invalid Game File Path";
                FilePathLable.ForeColor = Color.Red;
                SetupButtonInfo.Text = "Please select a valid game file path";
            }
        }


        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            SetupButtonInfo.Text = "Download Complete\nSetting up BepInEx files";
            SetupModsButton.ForeColor = Color.Black;
            ZipFile.ExtractToDirectory(folderBrowserDialog1.SelectedPath + "\\BepinEx_To_Extract_Folder.zip", folderBrowserDialog1.SelectedPath);
            SetupButtonInfo.Text = "Warning Opening Game\nPlease close game once loaded to progress setup";
            System.Threading.Thread.Sleep(3000);


            string exePath = System.IO.Path.Combine(folderBrowserDialog1.SelectedPath, "Deviator.exe");

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = false, // Set true to use the operating system shell to start the process
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = false // Set true for no window to appear
                };

                // Start the process
                Process process = Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur when trying to start the process
                MessageBox.Show($"Failed to start Deviator.exe: {ex.Message}");
            }

            Directory.CreateDirectory(folderBrowserDialog1.SelectedPath + "\\BepInEx\\pluginStore");



            SetupButtonInfo.Text = "Close the game once loaded. \nModding setup is complete! \nCheck out Active Mods tab or the discord server for mods and help.";
            SetupModsButton.Text = "Modding already setup";
        }

        // Useless events that I accidentally created below
        private void SetupButtonInfo_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void FilePathLable_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ActiveModsTab_Click(object sender, EventArgs e)
        {

        }

        private void DownloadedModsList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Determine the file name of the mod being checked/unchecked
            string fileName = DownloadedModsList.Items[e.Index].ToString();

            // Determine the source and destination paths based on the intended new value (checked or unchecked)
            string sourcePath;
            string destinationPath;

            if (e.NewValue == CheckState.Checked)
            {
                // The item is being checked, so move it to the plugins folder
                sourcePath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", "pluginStore", fileName);
                destinationPath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", "plugins", fileName);
            }
            else
            {
                // The item is being unchecked, so move it to the pluginStore folder
                sourcePath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", "plugins", fileName);
                destinationPath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", "pluginStore", fileName);
            }

            try
            {
                // Ensure the source file exists before attempting to move
                if (File.Exists(sourcePath))
                {
                    // Move the file
                    File.Move(sourcePath, destinationPath);
                }
                else
                {
                    Console.WriteLine($"File '{fileName}' does not exist at '{sourcePath}' and will not be moved.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions during the file move operation
                MessageBox.Show($"An error occurred while moving the file: {ex.Message}");
            }
        }

        private void GameFolderShortcut_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderBrowserDialog1.SelectedPath) && folderBrowserDialog1.SelectedPath.EndsWith("DEVIATOR"))
            {
                Process.Start("explorer.exe", folderBrowserDialog1.SelectedPath);
            }
        }

        private void PluginsFolderShortcut_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderBrowserDialog1.SelectedPath) && folderBrowserDialog1.SelectedPath.EndsWith("DEVIATOR"))
            {
                Process.Start("explorer.exe", folderBrowserDialog1.SelectedPath + "\\BepInEx\\plugins");
            }
        }

        private void BepInExShortcut_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(folderBrowserDialog1.SelectedPath) && folderBrowserDialog1.SelectedPath.EndsWith("DEVIATOR"))
            {
                Process.Start("explorer.exe", folderBrowserDialog1.SelectedPath + "\\BepInEx");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string discordInviteUrl = "https://discord.gg/jcpnptZJp4";

            Process.Start(new ProcessStartInfo
            {
                FileName = discordInviteUrl,
                UseShellExecute = true
            });
        }

        private void TurnAllModsOffButton_Click(object sender, EventArgs e)
        {
            MoveAllMods("plugins", "pluginStore");
        }
        private void TurnAllModsOnButton_Click(object sender, EventArgs e)
        {
            MoveAllMods("pluginStore", "plugins");
        }
        private void MoveAllMods(string sourceFolder, string destinationFolder)
        {
            string sourcePath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", sourceFolder);
            string destinationPath = Path.Combine(folderBrowserDialog1.SelectedPath, "BepInEx", destinationFolder);

            try
            {
                if (Directory.Exists(sourcePath))
                {
                    string[] modFiles = Directory.GetFiles(sourcePath, "*.dll", SearchOption.TopDirectoryOnly);

                    foreach (string modFile in modFiles)
                    {
                        string fileName = Path.GetFileName(modFile);
                        string destFilePath = Path.Combine(destinationPath, fileName);

                        if (File.Exists(modFile))
                        {
                            // Move the file to the destination folder
                            File.Move(modFile, destFilePath);
                        }
                    }

                    // Refresh the mod list and update the checked state in the UI
                    PopulateDownloadedModsList();
                }
                else
                {
                    MessageBox.Show($"The source folder '{sourceFolder}' does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while moving the mods: {ex.Message}");
            }
        }


    }
}