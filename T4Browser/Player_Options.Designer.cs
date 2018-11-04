namespace T4Browser
{
    partial class Player_Options
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
            this.character_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.character_select = new System.Windows.Forms.ComboBox();
            this.player_name_label = new System.Windows.Forms.Label();
            this.player_name = new System.Windows.Forms.TextBox();
            this.ControlsGroup = new System.Windows.Forms.GroupBox();
            this.VertSens = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HorzSens = new System.Windows.Forms.ComboBox();
            this.InvertedCheck = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GamePathText = new System.Windows.Forms.TextBox();
            this.SetGamePathBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character_picture)).BeginInit();
            this.ControlsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.character_picture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.character_select);
            this.groupBox1.Controls.Add(this.player_name_label);
            this.groupBox1.Controls.Add(this.player_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Options";
            // 
            // character_picture
            // 
            this.character_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.character_picture.Location = new System.Drawing.Point(94, 78);
            this.character_picture.Name = "character_picture";
            this.character_picture.Size = new System.Drawing.Size(128, 128);
            this.character_picture.TabIndex = 4;
            this.character_picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Character:";
            // 
            // character_select
            // 
            this.character_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.character_select.Enabled = false;
            this.character_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.character_select.FormattingEnabled = true;
            this.character_select.Items.AddRange(new object[] {
            "Tal\'Set",
            "Djunn",
            "Bruckner",
            "Wisefather",
            "Genn",
            "Ny Gulkuk",
            "Xon",
            "Zrannis",
            "Metalhead",
            "Retsnom",
            "Crust",
            "Silvac",
            "Lang",
            "Jrog",
            "Balrock",
            "Venom",
            "Brok",
            "Lizzar",
            "Gerbur",
            "Jaz",
            "Duncun",
            "Yoran",
            "Meakrous",
            "Anep",
            "Malk"});
            this.character_select.Location = new System.Drawing.Point(83, 46);
            this.character_select.Name = "character_select";
            this.character_select.Size = new System.Drawing.Size(149, 21);
            this.character_select.TabIndex = 2;
            this.character_select.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // player_name_label
            // 
            this.player_name_label.AutoSize = true;
            this.player_name_label.Location = new System.Drawing.Point(7, 23);
            this.player_name_label.Name = "player_name_label";
            this.player_name_label.Size = new System.Drawing.Size(70, 13);
            this.player_name_label.TabIndex = 1;
            this.player_name_label.Text = "Player Name:";
            // 
            // player_name
            // 
            this.player_name.Location = new System.Drawing.Point(83, 20);
            this.player_name.MaxLength = 16;
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(149, 20);
            this.player_name.TabIndex = 0;
            this.player_name.Text = "Player";
            // 
            // ControlsGroup
            // 
            this.ControlsGroup.Controls.Add(this.VertSens);
            this.ControlsGroup.Controls.Add(this.label3);
            this.ControlsGroup.Controls.Add(this.label2);
            this.ControlsGroup.Controls.Add(this.HorzSens);
            this.ControlsGroup.Controls.Add(this.InvertedCheck);
            this.ControlsGroup.Enabled = false;
            this.ControlsGroup.Location = new System.Drawing.Point(290, 12);
            this.ControlsGroup.Name = "ControlsGroup";
            this.ControlsGroup.Size = new System.Drawing.Size(199, 104);
            this.ControlsGroup.TabIndex = 1;
            this.ControlsGroup.TabStop = false;
            this.ControlsGroup.Text = "Controls";
            // 
            // VertSens
            // 
            this.VertSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VertSens.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.VertSens.FormattingEnabled = true;
            this.VertSens.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.VertSens.Location = new System.Drawing.Point(120, 51);
            this.VertSens.Name = "VertSens";
            this.VertSens.Size = new System.Drawing.Size(65, 21);
            this.VertSens.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vertical Sensitivity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horziontal Sensitivity:";
            // 
            // HorzSens
            // 
            this.HorzSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorzSens.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HorzSens.FormattingEnabled = true;
            this.HorzSens.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.HorzSens.Location = new System.Drawing.Point(120, 24);
            this.HorzSens.Name = "HorzSens";
            this.HorzSens.Size = new System.Drawing.Size(65, 21);
            this.HorzSens.TabIndex = 1;
            // 
            // InvertedCheck
            // 
            this.InvertedCheck.AutoSize = true;
            this.InvertedCheck.Checked = true;
            this.InvertedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.InvertedCheck.Location = new System.Drawing.Point(120, 78);
            this.InvertedCheck.Name = "InvertedCheck";
            this.InvertedCheck.Size = new System.Drawing.Size(65, 17);
            this.InvertedCheck.TabIndex = 0;
            this.InvertedCheck.Text = "Inverted";
            this.InvertedCheck.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(300, 195);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(189, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Game Path:";
            // 
            // GamePathText
            // 
            this.GamePathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePathText.Cursor = System.Windows.Forms.Cursors.No;
            this.GamePathText.Enabled = false;
            this.GamePathText.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GamePathText.Location = new System.Drawing.Point(303, 140);
            this.GamePathText.Name = "GamePathText";
            this.GamePathText.ReadOnly = true;
            this.GamePathText.Size = new System.Drawing.Size(186, 20);
            this.GamePathText.TabIndex = 4;
            this.GamePathText.WordWrap = false;
            // 
            // SetGamePathBtn
            // 
            this.SetGamePathBtn.Location = new System.Drawing.Point(300, 166);
            this.SetGamePathBtn.Name = "SetGamePathBtn";
            this.SetGamePathBtn.Size = new System.Drawing.Size(189, 23);
            this.SetGamePathBtn.TabIndex = 5;
            this.SetGamePathBtn.Text = "Set Game Path";
            this.SetGamePathBtn.UseVisualStyleBackColor = true;
            this.SetGamePathBtn.Click += new System.EventHandler(this.SetGamePathBtn_Click);
            // 
            // Player_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 238);
            this.Controls.Add(this.SetGamePathBtn);
            this.Controls.Add(this.GamePathText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ControlsGroup);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player_Options";
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player_Options_FormClosed);
            this.Load += new System.EventHandler(this.Player_Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character_picture)).EndInit();
            this.ControlsGroup.ResumeLayout(false);
            this.ControlsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox character_select;
        private System.Windows.Forms.Label player_name_label;
        private System.Windows.Forms.TextBox player_name;
        private System.Windows.Forms.PictureBox character_picture;
        private System.Windows.Forms.GroupBox ControlsGroup;
        private System.Windows.Forms.ComboBox VertSens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HorzSens;
        private System.Windows.Forms.CheckBox InvertedCheck;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GamePathText;
        private System.Windows.Forms.Button SetGamePathBtn;
    }
}