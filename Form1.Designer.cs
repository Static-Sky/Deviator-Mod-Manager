
namespace Deviator_Mod_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FilePathLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ModdingSetupTab = new System.Windows.Forms.TabPage();
            this.SetupButtonInfo = new System.Windows.Forms.Label();
            this.SetupModsButton = new System.Windows.Forms.Button();
            this.ActiveModsTab = new System.Windows.Forms.TabPage();
            this.ModListInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadedModsList = new System.Windows.Forms.CheckedListBox();
            this.GameFolderShortcut = new System.Windows.Forms.Button();
            this.PluginsFolderShortcut = new System.Windows.Forms.Button();
            this.BepInExShortcut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TurnAllModsOffButton = new System.Windows.Forms.Button();
            this.TurnAllModsOnButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.ModdingSetupTab.SuspendLayout();
            this.ActiveModsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Get the Deviator game folder.";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.ProgramFilesX86;
            this.folderBrowserDialog1.SelectedPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\DEVIATOR";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // FilePathLable
            // 
            this.FilePathLable.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FilePathLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilePathLable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathLable.ForeColor = System.Drawing.Color.Black;
            this.FilePathLable.Location = new System.Drawing.Point(25, 50);
            this.FilePathLable.Name = "FilePathLable";
            this.FilePathLable.Size = new System.Drawing.Size(550, 23);
            this.FilePathLable.TabIndex = 1;
            this.FilePathLable.Text = "c:\\Program Files (x86)\\Steam\\steamapps\\common\\DEVIATOR";
            this.FilePathLable.Click += new System.EventHandler(this.FilePathLable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game Folder Directory";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(581, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ModdingSetupTab);
            this.tabControl1.Controls.Add(this.ActiveModsTab);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(25, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 359);
            this.tabControl1.TabIndex = 4;
            // 
            // ModdingSetupTab
            // 
            this.ModdingSetupTab.BackColor = System.Drawing.Color.Snow;
            this.ModdingSetupTab.Controls.Add(this.button2);
            this.ModdingSetupTab.Controls.Add(this.SetupButtonInfo);
            this.ModdingSetupTab.Controls.Add(this.SetupModsButton);
            this.ModdingSetupTab.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModdingSetupTab.Location = new System.Drawing.Point(4, 22);
            this.ModdingSetupTab.Name = "ModdingSetupTab";
            this.ModdingSetupTab.Padding = new System.Windows.Forms.Padding(3);
            this.ModdingSetupTab.Size = new System.Drawing.Size(740, 333);
            this.ModdingSetupTab.TabIndex = 0;
            this.ModdingSetupTab.Text = "Modding Setup";
            // 
            // SetupButtonInfo
            // 
            this.SetupButtonInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.SetupButtonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SetupButtonInfo.Location = new System.Drawing.Point(227, 133);
            this.SetupButtonInfo.Name = "SetupButtonInfo";
            this.SetupButtonInfo.Padding = new System.Windows.Forms.Padding(2);
            this.SetupButtonInfo.Size = new System.Drawing.Size(300, 126);
            this.SetupButtonInfo.TabIndex = 2;
            this.SetupButtonInfo.Text = "Clicking the Setup Modding button will edit your game files for modding and mod i" +
    "njection. You can download mods and find modding help in our Discord server!";
            this.SetupButtonInfo.Click += new System.EventHandler(this.SetupButtonInfo_Click);
            // 
            // SetupModsButton
            // 
            this.SetupModsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetupModsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SetupModsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetupModsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetupModsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupModsButton.Location = new System.Drawing.Point(298, 70);
            this.SetupModsButton.Margin = new System.Windows.Forms.Padding(6);
            this.SetupModsButton.Name = "SetupModsButton";
            this.SetupModsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SetupModsButton.Size = new System.Drawing.Size(151, 57);
            this.SetupModsButton.TabIndex = 1;
            this.SetupModsButton.Text = "Setup Modding";
            this.SetupModsButton.UseVisualStyleBackColor = false;
            this.SetupModsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ActiveModsTab
            // 
            this.ActiveModsTab.BackColor = System.Drawing.Color.Snow;
            this.ActiveModsTab.Controls.Add(this.TurnAllModsOnButton);
            this.ActiveModsTab.Controls.Add(this.TurnAllModsOffButton);
            this.ActiveModsTab.Controls.Add(this.BepInExShortcut);
            this.ActiveModsTab.Controls.Add(this.PluginsFolderShortcut);
            this.ActiveModsTab.Controls.Add(this.GameFolderShortcut);
            this.ActiveModsTab.Controls.Add(this.ModListInfo);
            this.ActiveModsTab.Controls.Add(this.label1);
            this.ActiveModsTab.Controls.Add(this.DownloadedModsList);
            this.ActiveModsTab.Location = new System.Drawing.Point(4, 22);
            this.ActiveModsTab.Name = "ActiveModsTab";
            this.ActiveModsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveModsTab.Size = new System.Drawing.Size(740, 333);
            this.ActiveModsTab.TabIndex = 1;
            this.ActiveModsTab.Text = "Active Mods";
            this.ActiveModsTab.Click += new System.EventHandler(this.ActiveModsTab_Click);
            // 
            // ModListInfo
            // 
            this.ModListInfo.BackColor = System.Drawing.SystemColors.Info;
            this.ModListInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModListInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModListInfo.Location = new System.Drawing.Point(284, 72);
            this.ModListInfo.Name = "ModListInfo";
            this.ModListInfo.Size = new System.Drawing.Size(130, 229);
            this.ModListInfo.TabIndex = 2;
            this.ModListInfo.Text = resources.GetString("ModListInfo.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mods List";
            // 
            // DownloadedModsList
            // 
            this.DownloadedModsList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DownloadedModsList.CheckOnClick = true;
            this.DownloadedModsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadedModsList.FormattingEnabled = true;
            this.DownloadedModsList.Items.AddRange(new object[] {
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test",
            "test"});
            this.DownloadedModsList.Location = new System.Drawing.Point(6, 51);
            this.DownloadedModsList.Name = "DownloadedModsList";
            this.DownloadedModsList.Size = new System.Drawing.Size(272, 259);
            this.DownloadedModsList.Sorted = true;
            this.DownloadedModsList.TabIndex = 0;
            this.DownloadedModsList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DownloadedModsList_ItemCheck);
            // 
            // GameFolderShortcut
            // 
            this.GameFolderShortcut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GameFolderShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameFolderShortcut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GameFolderShortcut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameFolderShortcut.Location = new System.Drawing.Point(505, 51);
            this.GameFolderShortcut.Name = "GameFolderShortcut";
            this.GameFolderShortcut.Size = new System.Drawing.Size(183, 50);
            this.GameFolderShortcut.TabIndex = 3;
            this.GameFolderShortcut.Text = "Game Folder Shortcut";
            this.GameFolderShortcut.UseVisualStyleBackColor = false;
            this.GameFolderShortcut.Click += new System.EventHandler(this.GameFolderShortcut_Click);
            // 
            // PluginsFolderShortcut
            // 
            this.PluginsFolderShortcut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PluginsFolderShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PluginsFolderShortcut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PluginsFolderShortcut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PluginsFolderShortcut.Location = new System.Drawing.Point(505, 107);
            this.PluginsFolderShortcut.Name = "PluginsFolderShortcut";
            this.PluginsFolderShortcut.Size = new System.Drawing.Size(183, 50);
            this.PluginsFolderShortcut.TabIndex = 4;
            this.PluginsFolderShortcut.Text = "Plugins Folder Shortcut";
            this.PluginsFolderShortcut.UseVisualStyleBackColor = false;
            this.PluginsFolderShortcut.Click += new System.EventHandler(this.PluginsFolderShortcut_Click);
            // 
            // BepInExShortcut
            // 
            this.BepInExShortcut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BepInExShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BepInExShortcut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BepInExShortcut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BepInExShortcut.Location = new System.Drawing.Point(505, 163);
            this.BepInExShortcut.Name = "BepInExShortcut";
            this.BepInExShortcut.Size = new System.Drawing.Size(183, 50);
            this.BepInExShortcut.TabIndex = 5;
            this.BepInExShortcut.Text = "BepinEx Folder Shortcut";
            this.BepInExShortcut.UseVisualStyleBackColor = false;
            this.BepInExShortcut.Click += new System.EventHandler(this.BepInExShortcut_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Deviator_Mod_Manager.Resource1.discord_logo_blue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(629, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 62);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TurnAllModsOffButton
            // 
            this.TurnAllModsOffButton.Location = new System.Drawing.Point(27, 310);
            this.TurnAllModsOffButton.Name = "TurnAllModsOffButton";
            this.TurnAllModsOffButton.Size = new System.Drawing.Size(108, 23);
            this.TurnAllModsOffButton.TabIndex = 6;
            this.TurnAllModsOffButton.Text = "Disable All Mods";
            this.TurnAllModsOffButton.UseVisualStyleBackColor = true;
            this.TurnAllModsOffButton.Click += new System.EventHandler(this.TurnAllModsOffButton_Click);
            // 
            // TurnAllModsOnButton
            // 
            this.TurnAllModsOnButton.Location = new System.Drawing.Point(141, 310);
            this.TurnAllModsOnButton.Name = "TurnAllModsOnButton";
            this.TurnAllModsOnButton.Size = new System.Drawing.Size(108, 23);
            this.TurnAllModsOnButton.TabIndex = 7;
            this.TurnAllModsOnButton.Text = "Enable All Mods";
            this.TurnAllModsOnButton.UseVisualStyleBackColor = true;
            this.TurnAllModsOnButton.Click += new System.EventHandler(this.TurnAllModsOnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilePathLable);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Deviator Mod Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ModdingSetupTab.ResumeLayout(false);
            this.ActiveModsTab.ResumeLayout(false);
            this.ActiveModsTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FilePathLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage ModdingSetupTab;
        public System.Windows.Forms.TabPage ActiveModsTab;
        private System.Windows.Forms.Button SetupModsButton;
        private System.Windows.Forms.Label SetupButtonInfo;
        public System.Windows.Forms.CheckedListBox DownloadedModsList;
        private System.Windows.Forms.Label ModListInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BepInExShortcut;
        private System.Windows.Forms.Button PluginsFolderShortcut;
        private System.Windows.Forms.Button GameFolderShortcut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TurnAllModsOnButton;
        private System.Windows.Forms.Button TurnAllModsOffButton;
    }
}

