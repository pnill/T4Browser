namespace T4Browser
{
    partial class Host_Server
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WeaponSpawn = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WeaponSet = new System.Windows.Forms.CheckedListBox();
            this.GameTypeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.player_limit = new System.Windows.Forms.ComboBox();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartLobby = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mapimage = new System.Windows.Forms.PictureBox();
            this.map_select = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.time_limit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.frag_limit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gameTypeOptions = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapimage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WeaponSpawn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.WeaponSet);
            this.groupBox1.Controls.Add(this.GameTypeCombo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Options";
            // 
            // WeaponSpawn
            // 
            this.WeaponSpawn.CheckOnClick = true;
            this.WeaponSpawn.FormattingEnabled = true;
            this.WeaponSpawn.Items.AddRange(new object[] {
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
            this.WeaponSpawn.Location = new System.Drawing.Point(9, 206);
            this.WeaponSpawn.Name = "WeaponSpawn";
            this.WeaponSpawn.Size = new System.Drawing.Size(264, 109);
            this.WeaponSpawn.TabIndex = 5;
            this.WeaponSpawn.SelectedIndexChanged += new System.EventHandler(this.WeaponSpawn_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weapon Spawns:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Weapon Available List:";
            // 
            // WeaponSet
            // 
            this.WeaponSet.CheckOnClick = true;
            this.WeaponSet.FormattingEnabled = true;
            this.WeaponSet.Items.AddRange(new object[] {
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
            this.WeaponSet.Location = new System.Drawing.Point(9, 68);
            this.WeaponSet.Name = "WeaponSet";
            this.WeaponSet.Size = new System.Drawing.Size(264, 109);
            this.WeaponSet.TabIndex = 2;
            this.WeaponSet.SelectedIndexChanged += new System.EventHandler(this.WeaponSet_SelectedIndexChanged);
            // 
            // GameTypeCombo
            // 
            this.GameTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameTypeCombo.FormattingEnabled = true;
            this.GameTypeCombo.Items.AddRange(new object[] {
            "Death Match"});
            this.GameTypeCombo.Location = new System.Drawing.Point(77, 17);
            this.GameTypeCombo.Name = "GameTypeCombo";
            this.GameTypeCombo.Size = new System.Drawing.Size(196, 21);
            this.GameTypeCombo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Game Type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.player_limit);
            this.groupBox2.Controls.Add(this.ServerPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ServerName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player Limit:";
            // 
            // player_limit
            // 
            this.player_limit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.player_limit.FormattingEnabled = true;
            this.player_limit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.player_limit.Location = new System.Drawing.Point(75, 84);
            this.player_limit.MaxDropDownItems = 16;
            this.player_limit.Name = "player_limit";
            this.player_limit.Size = new System.Drawing.Size(51, 21);
            this.player_limit.TabIndex = 4;
            // 
            // ServerPort
            // 
            this.ServerPort.Location = new System.Drawing.Point(52, 57);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(51, 20);
            this.ServerPort.TabIndex = 3;
            this.ServerPort.Text = "9001";
            this.ServerPort.TextChanged += new System.EventHandler(this.ServerPort_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(52, 31);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(100, 20);
            this.ServerName.TabIndex = 1;
            this.ServerName.Text = "My Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // StartLobby
            // 
            this.StartLobby.Location = new System.Drawing.Point(12, 468);
            this.StartLobby.Name = "StartLobby";
            this.StartLobby.Size = new System.Drawing.Size(285, 23);
            this.StartLobby.TabIndex = 2;
            this.StartLobby.Text = "Start Lobby";
            this.StartLobby.UseVisualStyleBackColor = true;
            this.StartLobby.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mapimage);
            this.groupBox3.Controls.Add(this.map_select);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.time_limit);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.frag_limit);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.gameTypeOptions);
            this.groupBox3.Location = new System.Drawing.Point(304, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 475);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Game Options";
            // 
            // mapimage
            // 
            this.mapimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mapimage.Location = new System.Drawing.Point(10, 228);
            this.mapimage.Name = "mapimage";
            this.mapimage.Size = new System.Drawing.Size(346, 241);
            this.mapimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapimage.TabIndex = 11;
            this.mapimage.TabStop = false;
            // 
            // map_select
            // 
            this.map_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.map_select.FormattingEnabled = true;
            this.map_select.Items.AddRange(new object[] {
            "Place Of Lamia",
            "Tears Of Horatio",
            "Tristess Temple",
            "Selkirk Complex",
            "Swampy Abodes",
            "Sands of Hueyon",
            "Regnereb Arena",
            "Oasis",
            "Dark Jungle",
            "Withering Heights",
            "Slag Base",
            "Nehpets Towers",
            "Dino Depot"});
            this.map_select.Location = new System.Drawing.Point(43, 188);
            this.map_select.Name = "map_select";
            this.map_select.Size = new System.Drawing.Size(307, 21);
            this.map_select.TabIndex = 6;
            this.map_select.SelectedIndexChanged += new System.EventHandler(this.map_select_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Map:";
            // 
            // time_limit
            // 
            this.time_limit.Location = new System.Drawing.Point(96, 162);
            this.time_limit.Name = "time_limit";
            this.time_limit.Size = new System.Drawing.Size(43, 20);
            this.time_limit.TabIndex = 9;
            this.time_limit.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time Limit (mins):";
            // 
            // frag_limit
            // 
            this.frag_limit.Location = new System.Drawing.Point(96, 136);
            this.frag_limit.Name = "frag_limit";
            this.frag_limit.Size = new System.Drawing.Size(43, 20);
            this.frag_limit.TabIndex = 7;
            this.frag_limit.Text = "15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Frag Limit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Game Type Options:";
            // 
            // gameTypeOptions
            // 
            this.gameTypeOptions.CheckOnClick = true;
            this.gameTypeOptions.FormattingEnabled = true;
            this.gameTypeOptions.Items.AddRange(new object[] {
            "Auto Balance",
            "Radar",
            "Head Shots Only",
            "Weapons Stay",
            "No Health",
            "No Powerups",
            "One Shot Kill",
            "Unlimited Ammo"});
            this.gameTypeOptions.Location = new System.Drawing.Point(9, 46);
            this.gameTypeOptions.Name = "gameTypeOptions";
            this.gameTypeOptions.Size = new System.Drawing.Size(341, 79);
            this.gameTypeOptions.TabIndex = 0;
            this.gameTypeOptions.SelectedIndexChanged += new System.EventHandler(this.gameTypeOptions_SelectedIndexChanged);
            // 
            // Host_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.StartLobby);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Host_Server";
            this.Text = "Create a Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Host_Server_FormClosing);
            this.Load += new System.EventHandler(this.Host_Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox player_limit;
        private System.Windows.Forms.ComboBox GameTypeCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartLobby;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox WeaponSet;
        private System.Windows.Forms.CheckedListBox WeaponSpawn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox time_limit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox frag_limit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox gameTypeOptions;
        private System.Windows.Forms.ComboBox map_select;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox mapimage;
    }
}