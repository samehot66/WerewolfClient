﻿namespace WerewolfClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GBChat = new System.Windows.Forms.GroupBox();
            this.TbChatInput = new System.Windows.Forms.TextBox();
            this.TbChatBox = new System.Windows.Forms.TextBox();
            this.GBAction = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnVote = new System.Windows.Forms.Button();
            this.GBStatus = new System.Windows.Forms.GroupBox();
            this.LBTime = new System.Windows.Forms.Label();
            this.LBDay = new System.Windows.Forms.Label();
            this.LBPeriod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPlayer0 = new System.Windows.Forms.Button();
            this.BtnPlayer1 = new System.Windows.Forms.Button();
            this.BtnPlayer2 = new System.Windows.Forms.Button();
            this.BtnPlayer3 = new System.Windows.Forms.Button();
            this.BtnPlayer4 = new System.Windows.Forms.Button();
            this.BtnPlayer5 = new System.Windows.Forms.Button();
            this.BtnPlayer6 = new System.Windows.Forms.Button();
            this.BtnPlayer7 = new System.Windows.Forms.Button();
            this.BtnPlayer8 = new System.Windows.Forms.Button();
            this.BtnPlayer9 = new System.Windows.Forms.Button();
            this.BtnPlayer10 = new System.Windows.Forms.Button();
            this.BtnPlayer11 = new System.Windows.Forms.Button();
            this.BtnPlayer12 = new System.Windows.Forms.Button();
            this.BtnPlayer13 = new System.Windows.Forms.Button();
            this.BtnPlayer14 = new System.Windows.Forms.Button();
            this.BtnPlayer15 = new System.Windows.Forms.Button();
            this.GBPlayers = new System.Windows.Forms.GroupBox();
            this.GBChat.SuspendLayout();
            this.GBAction.SuspendLayout();
            this.GBStatus.SuspendLayout();
            this.GBPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBChat
            // 
            this.GBChat.Controls.Add(this.TbChatInput);
            this.GBChat.Controls.Add(this.TbChatBox);
            this.GBChat.Location = new System.Drawing.Point(16, 436);
            this.GBChat.Margin = new System.Windows.Forms.Padding(4);
            this.GBChat.Name = "GBChat";
            this.GBChat.Padding = new System.Windows.Forms.Padding(4);
            this.GBChat.Size = new System.Drawing.Size(554, 218);
            this.GBChat.TabIndex = 2;
            this.GBChat.TabStop = false;
            this.GBChat.Text = "Chat";
            // 
            // TbChatInput
            // 
            this.TbChatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChatInput.Location = new System.Drawing.Point(20, 166);
            this.TbChatInput.Margin = new System.Windows.Forms.Padding(4);
            this.TbChatInput.Name = "TbChatInput";
            this.TbChatInput.Size = new System.Drawing.Size(514, 30);
            this.TbChatInput.TabIndex = 1;
            this.TbChatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbChatInput_Enter);
            // 
            // TbChatBox
            // 
            this.TbChatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChatBox.Location = new System.Drawing.Point(20, 23);
            this.TbChatBox.Margin = new System.Windows.Forms.Padding(4);
            this.TbChatBox.Multiline = true;
            this.TbChatBox.Name = "TbChatBox";
            this.TbChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbChatBox.Size = new System.Drawing.Size(514, 126);
            this.TbChatBox.TabIndex = 0;
            // 
            // GBAction
            // 
            this.GBAction.Controls.Add(this.button1);
            this.GBAction.Controls.Add(this.BtnJoin);
            this.GBAction.Controls.Add(this.BtnAction);
            this.GBAction.Controls.Add(this.BtnVote);
            this.GBAction.Location = new System.Drawing.Point(436, 25);
            this.GBAction.Margin = new System.Windows.Forms.Padding(4);
            this.GBAction.Name = "GBAction";
            this.GBAction.Padding = new System.Windows.Forms.Padding(4);
            this.GBAction.Size = new System.Drawing.Size(134, 293);
            this.GBAction.TabIndex = 3;
            this.GBAction.TabStop = false;
            this.GBAction.Text = "Action";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 57);
            this.button1.TabIndex = 17;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSignOut_Click);
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(24, 153);
            this.BtnJoin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(90, 57);
            this.BtnJoin.TabIndex = 9;
            this.BtnJoin.Text = "Join Game";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // BtnAction
            // 
            this.BtnAction.Location = new System.Drawing.Point(24, 88);
            this.BtnAction.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(90, 57);
            this.BtnAction.TabIndex = 1;
            this.BtnAction.Text = "Action";
            this.BtnAction.UseVisualStyleBackColor = true;
            this.BtnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // BtnVote
            // 
            this.BtnVote.Location = new System.Drawing.Point(24, 23);
            this.BtnVote.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(90, 57);
            this.BtnVote.TabIndex = 0;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // GBStatus
            // 
            this.GBStatus.Controls.Add(this.LBTime);
            this.GBStatus.Controls.Add(this.LBDay);
            this.GBStatus.Controls.Add(this.LBPeriod);
            this.GBStatus.Controls.Add(this.label2);
            this.GBStatus.Controls.Add(this.label1);
            this.GBStatus.Location = new System.Drawing.Point(436, 327);
            this.GBStatus.Margin = new System.Windows.Forms.Padding(4);
            this.GBStatus.Name = "GBStatus";
            this.GBStatus.Padding = new System.Windows.Forms.Padding(4);
            this.GBStatus.Size = new System.Drawing.Size(134, 101);
            this.GBStatus.TabIndex = 8;
            this.GBStatus.TabStop = false;
            this.GBStatus.Text = "Status";
            // 
            // LBTime
            // 
            this.LBTime.AutoSize = true;
            this.LBTime.Location = new System.Drawing.Point(53, 64);
            this.LBTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBTime.Name = "LBTime";
            this.LBTime.Size = new System.Drawing.Size(16, 17);
            this.LBTime.TabIndex = 12;
            this.LBTime.Text = "0";
            // 
            // LBDay
            // 
            this.LBDay.AutoSize = true;
            this.LBDay.Location = new System.Drawing.Point(53, 43);
            this.LBDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBDay.Name = "LBDay";
            this.LBDay.Size = new System.Drawing.Size(16, 17);
            this.LBDay.TabIndex = 11;
            this.LBDay.Text = "0";
            // 
            // LBPeriod
            // 
            this.LBPeriod.AutoSize = true;
            this.LBPeriod.Location = new System.Drawing.Point(9, 23);
            this.LBPeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBPeriod.Name = "LBPeriod";
            this.LBPeriod.Size = new System.Drawing.Size(57, 17);
            this.LBPeriod.TabIndex = 10;
            this.LBPeriod.Text = "Night of";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day #";
            // 
            // BtnPlayer0
            // 
            this.BtnPlayer0.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlayer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer0.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer0.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer0.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer0.Location = new System.Drawing.Point(19, 23);
            this.BtnPlayer0.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer0.Name = "BtnPlayer0";
            this.BtnPlayer0.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer0.TabIndex = 1;
            this.BtnPlayer0.Tag = "0";
            this.BtnPlayer0.Text = "Player";
            this.BtnPlayer0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer0.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer1
            // 
            this.BtnPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer1.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer1.Location = new System.Drawing.Point(116, 23);
            this.BtnPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer1.Name = "BtnPlayer1";
            this.BtnPlayer1.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer1.TabIndex = 2;
            this.BtnPlayer1.Tag = "1";
            this.BtnPlayer1.Text = "Player";
            this.BtnPlayer1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer1.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer2
            // 
            this.BtnPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer2.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer2.Location = new System.Drawing.Point(212, 23);
            this.BtnPlayer2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer2.Name = "BtnPlayer2";
            this.BtnPlayer2.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer2.TabIndex = 3;
            this.BtnPlayer2.Tag = "2";
            this.BtnPlayer2.Text = "Player";
            this.BtnPlayer2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer2.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer3
            // 
            this.BtnPlayer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer3.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer3.Location = new System.Drawing.Point(308, 23);
            this.BtnPlayer3.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer3.Name = "BtnPlayer3";
            this.BtnPlayer3.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer3.TabIndex = 4;
            this.BtnPlayer3.Tag = "3";
            this.BtnPlayer3.Text = "Player";
            this.BtnPlayer3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer3.UseVisualStyleBackColor = true;
            // 
            // BtnPlayer4
            // 
            this.BtnPlayer4.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer4.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer4.Location = new System.Drawing.Point(20, 119);
            this.BtnPlayer4.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer4.Name = "BtnPlayer4";
            this.BtnPlayer4.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer4.TabIndex = 5;
            this.BtnPlayer4.Tag = "4";
            this.BtnPlayer4.Text = "Player";
            this.BtnPlayer4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer4.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer5
            // 
            this.BtnPlayer5.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer5.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer5.Location = new System.Drawing.Point(116, 119);
            this.BtnPlayer5.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer5.Name = "BtnPlayer5";
            this.BtnPlayer5.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer5.TabIndex = 6;
            this.BtnPlayer5.Tag = "5";
            this.BtnPlayer5.Text = "Player";
            this.BtnPlayer5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer5.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer6
            // 
            this.BtnPlayer6.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer6.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer6.Location = new System.Drawing.Point(212, 119);
            this.BtnPlayer6.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer6.Name = "BtnPlayer6";
            this.BtnPlayer6.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer6.TabIndex = 7;
            this.BtnPlayer6.Tag = "6";
            this.BtnPlayer6.Text = "Player";
            this.BtnPlayer6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer6.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer7
            // 
            this.BtnPlayer7.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer7.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer7.Location = new System.Drawing.Point(308, 119);
            this.BtnPlayer7.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer7.Name = "BtnPlayer7";
            this.BtnPlayer7.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer7.TabIndex = 8;
            this.BtnPlayer7.Tag = "7";
            this.BtnPlayer7.Text = "Player";
            this.BtnPlayer7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer7.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer8
            // 
            this.BtnPlayer8.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer8.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer8.Location = new System.Drawing.Point(20, 215);
            this.BtnPlayer8.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer8.Name = "BtnPlayer8";
            this.BtnPlayer8.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer8.TabIndex = 9;
            this.BtnPlayer8.Tag = "8";
            this.BtnPlayer8.Text = "Player";
            this.BtnPlayer8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer8.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer9
            // 
            this.BtnPlayer9.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer9.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer9.Location = new System.Drawing.Point(116, 215);
            this.BtnPlayer9.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer9.Name = "BtnPlayer9";
            this.BtnPlayer9.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer9.TabIndex = 10;
            this.BtnPlayer9.Tag = "9";
            this.BtnPlayer9.Text = "Player";
            this.BtnPlayer9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer9.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer10
            // 
            this.BtnPlayer10.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer10.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer10.Location = new System.Drawing.Point(212, 215);
            this.BtnPlayer10.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer10.Name = "BtnPlayer10";
            this.BtnPlayer10.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer10.TabIndex = 11;
            this.BtnPlayer10.Tag = "10";
            this.BtnPlayer10.Text = "Player";
            this.BtnPlayer10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer10.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer11
            // 
            this.BtnPlayer11.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer11.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer11.Location = new System.Drawing.Point(308, 215);
            this.BtnPlayer11.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer11.Name = "BtnPlayer11";
            this.BtnPlayer11.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer11.TabIndex = 12;
            this.BtnPlayer11.Tag = "11";
            this.BtnPlayer11.Text = "Player";
            this.BtnPlayer11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer11.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer12
            // 
            this.BtnPlayer12.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer12.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer12.Location = new System.Drawing.Point(20, 311);
            this.BtnPlayer12.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer12.Name = "BtnPlayer12";
            this.BtnPlayer12.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer12.TabIndex = 13;
            this.BtnPlayer12.Tag = "12";
            this.BtnPlayer12.Text = "Player";
            this.BtnPlayer12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer12.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer13
            // 
            this.BtnPlayer13.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer13.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer13.Location = new System.Drawing.Point(116, 311);
            this.BtnPlayer13.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer13.Name = "BtnPlayer13";
            this.BtnPlayer13.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer13.TabIndex = 14;
            this.BtnPlayer13.Tag = "13";
            this.BtnPlayer13.Text = "Player";
            this.BtnPlayer13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer13.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer14
            // 
            this.BtnPlayer14.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer14.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer14.Location = new System.Drawing.Point(212, 311);
            this.BtnPlayer14.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer14.Name = "BtnPlayer14";
            this.BtnPlayer14.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer14.TabIndex = 15;
            this.BtnPlayer14.Tag = "14";
            this.BtnPlayer14.Text = "Player";
            this.BtnPlayer14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer14.UseVisualStyleBackColor = false;
            // 
            // BtnPlayer15
            // 
            this.BtnPlayer15.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayer15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnPlayer15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPlayer15.Image = global::WerewolfClient.Properties.Resources.Icon_villager;
            this.BtnPlayer15.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPlayer15.Location = new System.Drawing.Point(308, 311);
            this.BtnPlayer15.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayer15.Name = "BtnPlayer15";
            this.BtnPlayer15.Size = new System.Drawing.Size(88, 88);
            this.BtnPlayer15.TabIndex = 16;
            this.BtnPlayer15.Tag = "15";
            this.BtnPlayer15.Text = "Player";
            this.BtnPlayer15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPlayer15.UseVisualStyleBackColor = false;
            // 
            // GBPlayers
            // 
            this.GBPlayers.Controls.Add(this.BtnPlayer15);
            this.GBPlayers.Controls.Add(this.BtnPlayer14);
            this.GBPlayers.Controls.Add(this.BtnPlayer13);
            this.GBPlayers.Controls.Add(this.BtnPlayer12);
            this.GBPlayers.Controls.Add(this.BtnPlayer0);
            this.GBPlayers.Controls.Add(this.BtnPlayer11);
            this.GBPlayers.Controls.Add(this.BtnPlayer10);
            this.GBPlayers.Controls.Add(this.BtnPlayer9);
            this.GBPlayers.Controls.Add(this.BtnPlayer8);
            this.GBPlayers.Controls.Add(this.BtnPlayer7);
            this.GBPlayers.Controls.Add(this.BtnPlayer6);
            this.GBPlayers.Controls.Add(this.BtnPlayer5);
            this.GBPlayers.Controls.Add(this.BtnPlayer4);
            this.GBPlayers.Controls.Add(this.BtnPlayer3);
            this.GBPlayers.Controls.Add(this.BtnPlayer2);
            this.GBPlayers.Controls.Add(this.BtnPlayer1);
            this.GBPlayers.Location = new System.Drawing.Point(16, 25);
            this.GBPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.GBPlayers.Name = "GBPlayers";
            this.GBPlayers.Padding = new System.Windows.Forms.Padding(4);
            this.GBPlayers.Size = new System.Drawing.Size(412, 403);
            this.GBPlayers.TabIndex = 0;
            this.GBPlayers.TabStop = false;
            this.GBPlayers.Text = "Players";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 665);
            this.Controls.Add(this.GBStatus);
            this.Controls.Add(this.GBAction);
            this.Controls.Add(this.GBChat);
            this.Controls.Add(this.GBPlayers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Werewolf Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.GBChat.ResumeLayout(false);
            this.GBChat.PerformLayout();
            this.GBAction.ResumeLayout(false);
            this.GBStatus.ResumeLayout(false);
            this.GBStatus.PerformLayout();
            this.GBPlayers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBChat;
        private System.Windows.Forms.TextBox TbChatInput;
        private System.Windows.Forms.TextBox TbChatBox;
        private System.Windows.Forms.GroupBox GBAction;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.GroupBox GBStatus;
        private System.Windows.Forms.Label LBTime;
        private System.Windows.Forms.Label LBDay;
        private System.Windows.Forms.Label LBPeriod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPlayer0;
        private System.Windows.Forms.Button BtnPlayer1;
        private System.Windows.Forms.Button BtnPlayer2;
        private System.Windows.Forms.Button BtnPlayer4;
        private System.Windows.Forms.Button BtnPlayer5;
        private System.Windows.Forms.Button BtnPlayer6;
        private System.Windows.Forms.Button BtnPlayer7;
        private System.Windows.Forms.Button BtnPlayer8;
        private System.Windows.Forms.Button BtnPlayer9;
        private System.Windows.Forms.Button BtnPlayer10;
        private System.Windows.Forms.Button BtnPlayer11;
        private System.Windows.Forms.Button BtnPlayer12;
        private System.Windows.Forms.Button BtnPlayer13;
        private System.Windows.Forms.Button BtnPlayer14;
        private System.Windows.Forms.Button BtnPlayer15;
        private System.Windows.Forms.GroupBox GBPlayers;
        private System.Windows.Forms.Button BtnPlayer3;
    }
}

