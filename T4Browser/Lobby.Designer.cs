namespace T4Browser
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.playerlist = new System.Windows.Forms.ListBox();
            this.chat_text = new System.Windows.Forms.TextBox();
            this.send_text = new System.Windows.Forms.Button();
            this.player_count = new System.Windows.Forms.Label();
            this.chat_label = new System.Windows.Forms.Label();
            this.chat_box = new System.Windows.Forms.RichTextBox();
            this.game_options_group = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeaponSpawn_List = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeaponAllowed_List = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GameOptions_List = new System.Windows.Forms.CheckedListBox();
            this.time_limit_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.map_text = new System.Windows.Forms.TextBox();
            this.type_text = new System.Windows.Forms.TextBox();
            this.frag_text = new System.Windows.Forms.TextBox();
            this.Frag_Label = new System.Windows.Forms.Label();
            this.GameType_label = new System.Windows.Forms.Label();
            this.map_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hostOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.game_options_group.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerlist
            // 
            this.playerlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerlist.FormattingEnabled = true;
            this.playerlist.Location = new System.Drawing.Point(670, 160);
            this.playerlist.Name = "playerlist";
            this.playerlist.Size = new System.Drawing.Size(167, 340);
            this.playerlist.TabIndex = 1;
            // 
            // chat_text
            // 
            this.chat_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chat_text.Location = new System.Drawing.Point(16, 516);
            this.chat_text.Name = "chat_text";
            this.chat_text.Size = new System.Drawing.Size(640, 20);
            this.chat_text.TabIndex = 3;
            // 
            // send_text
            // 
            this.send_text.Location = new System.Drawing.Point(670, 511);
            this.send_text.Name = "send_text";
            this.send_text.Size = new System.Drawing.Size(167, 28);
            this.send_text.TabIndex = 4;
            this.send_text.Text = "Send";
            this.send_text.UseVisualStyleBackColor = true;
            this.send_text.Click += new System.EventHandler(this.send_text_Click);
            // 
            // player_count
            // 
            this.player_count.AutoSize = true;
            this.player_count.Location = new System.Drawing.Point(667, 144);
            this.player_count.Name = "player_count";
            this.player_count.Size = new System.Drawing.Size(76, 13);
            this.player_count.TabIndex = 6;
            this.player_count.Text = "Players: 0 / 16";
            // 
            // chat_label
            // 
            this.chat_label.AutoSize = true;
            this.chat_label.Location = new System.Drawing.Point(13, 144);
            this.chat_label.Name = "chat_label";
            this.chat_label.Size = new System.Drawing.Size(53, 13);
            this.chat_label.TabIndex = 7;
            this.chat_label.Text = "Chat Box:";
            // 
            // chat_box
            // 
            this.chat_box.BackColor = System.Drawing.SystemColors.Control;
            this.chat_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chat_box.Location = new System.Drawing.Point(16, 160);
            this.chat_box.Name = "chat_box";
            this.chat_box.ReadOnly = true;
            this.chat_box.ShortcutsEnabled = false;
            this.chat_box.Size = new System.Drawing.Size(640, 342);
            this.chat_box.TabIndex = 9;
            this.chat_box.Text = "";
            this.chat_box.TextChanged += new System.EventHandler(this.chat_box_TextChanged);
            // 
            // game_options_group
            // 
            this.game_options_group.Controls.Add(this.label4);
            this.game_options_group.Controls.Add(this.WeaponSpawn_List);
            this.game_options_group.Controls.Add(this.label3);
            this.game_options_group.Controls.Add(this.WeaponAllowed_List);
            this.game_options_group.Controls.Add(this.label2);
            this.game_options_group.Controls.Add(this.GameOptions_List);
            this.game_options_group.Controls.Add(this.time_limit_text);
            this.game_options_group.Controls.Add(this.label1);
            this.game_options_group.Controls.Add(this.map_text);
            this.game_options_group.Controls.Add(this.type_text);
            this.game_options_group.Controls.Add(this.frag_text);
            this.game_options_group.Controls.Add(this.Frag_Label);
            this.game_options_group.Controls.Add(this.GameType_label);
            this.game_options_group.Controls.Add(this.map_label);
            this.game_options_group.Location = new System.Drawing.Point(16, 33);
            this.game_options_group.Name = "game_options_group";
            this.game_options_group.Size = new System.Drawing.Size(821, 108);
            this.game_options_group.TabIndex = 10;
            this.game_options_group.TabStop = false;
            this.game_options_group.Text = "Game Options";
            this.game_options_group.Enter += new System.EventHandler(this.game_options_group_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Weapons Spawn:";
            // 
            // WeaponSpawn_List
            // 
            this.WeaponSpawn_List.FormattingEnabled = true;
            this.WeaponSpawn_List.Items.AddRange(new object[] {
            "Crossbow",
            "Spike mine",
            "Spider Mine",
            "Pistol",
            "Shotgun",
            "Minigun",
            "Rocket Launcher",
            "Tek Weapon",
            "Flamethrower",
            "Gravity Distruptor",
            "Dark Matter Cube"});
            this.WeaponSpawn_List.Location = new System.Drawing.Point(286, 38);
            this.WeaponSpawn_List.Name = "WeaponSpawn_List";
            this.WeaponSpawn_List.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.WeaponSpawn_List.Size = new System.Drawing.Size(174, 64);
            this.WeaponSpawn_List.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Weapons Allowed:";
            // 
            // WeaponAllowed_List
            // 
            this.WeaponAllowed_List.FormattingEnabled = true;
            this.WeaponAllowed_List.Items.AddRange(new object[] {
            "Crossbow",
            "Spike mine",
            "Spider Mine",
            "Pistol",
            "Shotgun",
            "Minigun",
            "Rocket Launcher",
            "Tek Weapon",
            "Flamethrower",
            "Gravity Distruptor",
            "Dark Matter Cube"});
            this.WeaponAllowed_List.Location = new System.Drawing.Point(466, 38);
            this.WeaponAllowed_List.Name = "WeaponAllowed_List";
            this.WeaponAllowed_List.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.WeaponAllowed_List.Size = new System.Drawing.Size(174, 64);
            this.WeaponAllowed_List.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Additional Options:";
            // 
            // GameOptions_List
            // 
            this.GameOptions_List.FormattingEnabled = true;
            this.GameOptions_List.Items.AddRange(new object[] {
            "Auto Balance",
            "Radar",
            "Head Shots Only",
            "Weapons Stay",
            "No Health",
            "No Powerups",
            "One Shot Kill",
            "Unlimited Ammo"});
            this.GameOptions_List.Location = new System.Drawing.Point(646, 38);
            this.GameOptions_List.Name = "GameOptions_List";
            this.GameOptions_List.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.GameOptions_List.Size = new System.Drawing.Size(169, 64);
            this.GameOptions_List.TabIndex = 10;
            // 
            // time_limit_text
            // 
            this.time_limit_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_limit_text.CausesValidation = false;
            this.time_limit_text.Enabled = false;
            this.time_limit_text.HideSelection = false;
            this.time_limit_text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.time_limit_text.Location = new System.Drawing.Point(216, 70);
            this.time_limit_text.Name = "time_limit_text";
            this.time_limit_text.ReadOnly = true;
            this.time_limit_text.ShortcutsEnabled = false;
            this.time_limit_text.Size = new System.Drawing.Size(39, 20);
            this.time_limit_text.TabIndex = 9;
            this.time_limit_text.Text = "0";
            this.time_limit_text.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time Limit (mins):";
            // 
            // map_text
            // 
            this.map_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_text.CausesValidation = false;
            this.map_text.Enabled = false;
            this.map_text.HideSelection = false;
            this.map_text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.map_text.Location = new System.Drawing.Point(78, 18);
            this.map_text.Name = "map_text";
            this.map_text.ReadOnly = true;
            this.map_text.ShortcutsEnabled = false;
            this.map_text.Size = new System.Drawing.Size(128, 20);
            this.map_text.TabIndex = 7;
            this.map_text.Text = "Loading...";
            this.map_text.WordWrap = false;
            // 
            // type_text
            // 
            this.type_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.type_text.CausesValidation = false;
            this.type_text.Enabled = false;
            this.type_text.HideSelection = false;
            this.type_text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.type_text.Location = new System.Drawing.Point(78, 44);
            this.type_text.Name = "type_text";
            this.type_text.ReadOnly = true;
            this.type_text.ShortcutsEnabled = false;
            this.type_text.Size = new System.Drawing.Size(128, 20);
            this.type_text.TabIndex = 6;
            this.type_text.Text = "Loading..";
            this.type_text.WordWrap = false;
            // 
            // frag_text
            // 
            this.frag_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frag_text.CausesValidation = false;
            this.frag_text.Enabled = false;
            this.frag_text.HideSelection = false;
            this.frag_text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.frag_text.Location = new System.Drawing.Point(78, 70);
            this.frag_text.Name = "frag_text";
            this.frag_text.ReadOnly = true;
            this.frag_text.ShortcutsEnabled = false;
            this.frag_text.Size = new System.Drawing.Size(39, 20);
            this.frag_text.TabIndex = 5;
            this.frag_text.Text = "0";
            this.frag_text.WordWrap = false;
            // 
            // Frag_Label
            // 
            this.Frag_Label.AutoSize = true;
            this.Frag_Label.Location = new System.Drawing.Point(6, 72);
            this.Frag_Label.Name = "Frag_Label";
            this.Frag_Label.Size = new System.Drawing.Size(55, 13);
            this.Frag_Label.TabIndex = 4;
            this.Frag_Label.Text = "Frag Limit:";
            // 
            // GameType_label
            // 
            this.GameType_label.AutoSize = true;
            this.GameType_label.Location = new System.Drawing.Point(7, 46);
            this.GameType_label.Name = "GameType_label";
            this.GameType_label.Size = new System.Drawing.Size(65, 13);
            this.GameType_label.TabIndex = 2;
            this.GameType_label.Text = "Game Type:";
            // 
            // map_label
            // 
            this.map_label.AutoSize = true;
            this.map_label.Location = new System.Drawing.Point(7, 20);
            this.map_label.Name = "map_label";
            this.map_label.Size = new System.Drawing.Size(31, 13);
            this.map_label.TabIndex = 0;
            this.map_label.Text = "Map:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hostOptionsToolStripMenuItem
            // 
            this.hostOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGameSettingsToolStripMenuItem,
            this.startGameToolStripMenuItem});
            this.hostOptionsToolStripMenuItem.Name = "hostOptionsToolStripMenuItem";
            this.hostOptionsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.hostOptionsToolStripMenuItem.Text = "Host Options";
            // 
            // editGameSettingsToolStripMenuItem
            // 
            this.editGameSettingsToolStripMenuItem.Name = "editGameSettingsToolStripMenuItem";
            this.editGameSettingsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.editGameSettingsToolStripMenuItem.Text = "Edit Game Options";
            this.editGameSettingsToolStripMenuItem.Click += new System.EventHandler(this.editGameSettingsToolStripMenuItem_Click);
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // Lobby
            // 
            this.AcceptButton = this.send_text;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 544);
            this.Controls.Add(this.game_options_group);
            this.Controls.Add(this.chat_box);
            this.Controls.Add(this.chat_label);
            this.Controls.Add(this.player_count);
            this.Controls.Add(this.send_text);
            this.Controls.Add(this.chat_text);
            this.Controls.Add(this.playerlist);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lobby";
            this.Text = "Server Lobby - ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lobby_FormClosed);
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.game_options_group.ResumeLayout(false);
            this.game_options_group.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playerlist;
        private System.Windows.Forms.TextBox chat_text;
        private System.Windows.Forms.Button send_text;
        private System.Windows.Forms.Label player_count;
        private System.Windows.Forms.Label chat_label;
        private System.Windows.Forms.RichTextBox chat_box;
        private System.Windows.Forms.GroupBox game_options_group;
        private System.Windows.Forms.Label GameType_label;
        private System.Windows.Forms.Label map_label;
        private System.Windows.Forms.TextBox frag_text;
        private System.Windows.Forms.Label Frag_Label;
        private System.Windows.Forms.TextBox map_text;
        private System.Windows.Forms.TextBox type_text;
        private System.Windows.Forms.TextBox time_limit_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox GameOptions_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox WeaponAllowed_List;
        private System.Windows.Forms.CheckedListBox WeaponSpawn_List;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hostOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGameSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
    }
}