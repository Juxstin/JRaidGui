namespace JRaidGui
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nordVerticalTabControl1 = new NordVerticalTabControl();
            this.Join = new System.Windows.Forms.TabPage();
            this.JoinGuild = new NordClearButton();
            this.InviteCode = new NordTextbox();
            this.JoinGroup = new System.Windows.Forms.TabPage();
            this.JoinGroupBtn = new NordClearButton();
            this.InviteCodeGroup = new NordTextbox();
            this.Leave = new System.Windows.Forms.TabPage();
            this.LeaveGuild = new NordClearButton();
            this.GuildID = new NordTextbox();
            this.LeaveGroup = new System.Windows.Forms.TabPage();
            this.LeaveGroupBtn = new NordClearButton();
            this.GroupID2 = new NordTextbox();
            this.Friend = new System.Windows.Forms.TabPage();
            this.FloodFriend = new NordClearButton();
            this.Tag = new NordTextbox();
            this.Username = new NordTextbox();
            this.Spam = new System.Windows.Forms.TabPage();
            this.SpamText = new System.Windows.Forms.TextBox();
            this.ChannelId = new NordTextbox();
            this.SpamGuild = new NordClearButton();
            this.SpamDM = new System.Windows.Forms.TabPage();
            this.SpamTextDM = new System.Windows.Forms.TextBox();
            this.UserID = new NordTextbox();
            this.SpamDMButton = new NordClearButton();
            this.SpamGroup = new System.Windows.Forms.TabPage();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.GroupID = new NordTextbox();
            this.SpamGroupBtn = new NordClearButton();
            this.InvSpam = new System.Windows.Forms.TabPage();
            this.FloodInvite = new NordClearButton();
            this.InviteChannel = new NordTextbox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.MusicControl = new NordCheckBox();
            this.Typing = new NordCheckBox();
            this.nordCheckBox2 = new NordCheckBox();
            this.nordCheckBox1 = new NordCheckBox();
            this.Delay = new NordTextbox();
            this.nordVerticalTabControl1.SuspendLayout();
            this.Join.SuspendLayout();
            this.JoinGroup.SuspendLayout();
            this.Leave.SuspendLayout();
            this.LeaveGroup.SuspendLayout();
            this.Friend.SuspendLayout();
            this.Spam.SuspendLayout();
            this.SpamDM.SuspendLayout();
            this.SpamGroup.SuspendLayout();
            this.InvSpam.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // nordVerticalTabControl1
            // 
            this.nordVerticalTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nordVerticalTabControl1.Controls.Add(this.Join);
            this.nordVerticalTabControl1.Controls.Add(this.JoinGroup);
            this.nordVerticalTabControl1.Controls.Add(this.Leave);
            this.nordVerticalTabControl1.Controls.Add(this.LeaveGroup);
            this.nordVerticalTabControl1.Controls.Add(this.Friend);
            this.nordVerticalTabControl1.Controls.Add(this.Spam);
            this.nordVerticalTabControl1.Controls.Add(this.SpamDM);
            this.nordVerticalTabControl1.Controls.Add(this.SpamGroup);
            this.nordVerticalTabControl1.Controls.Add(this.InvSpam);
            this.nordVerticalTabControl1.Controls.Add(this.Settings);
            this.nordVerticalTabControl1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.nordVerticalTabControl1.ItemSize = new System.Drawing.Size(35, 135);
            this.nordVerticalTabControl1.Location = new System.Drawing.Point(-11, 1);
            this.nordVerticalTabControl1.Multiline = true;
            this.nordVerticalTabControl1.Name = "nordVerticalTabControl1";
            this.nordVerticalTabControl1.SelectedIndex = 0;
            this.nordVerticalTabControl1.Size = new System.Drawing.Size(510, 357);
            this.nordVerticalTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nordVerticalTabControl1.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.nordVerticalTabControl1.TabIndex = 0;
            this.nordVerticalTabControl1.TabPageColor = System.Drawing.Color.White;
            this.nordVerticalTabControl1.TabSelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(75)))), ((int)(((byte)(122)))));
            this.nordVerticalTabControl1.TabUnSelectedTextColor = System.Drawing.Color.DarkGray;
            // 
            // Join
            // 
            this.Join.BackColor = System.Drawing.Color.White;
            this.Join.Controls.Add(this.JoinGuild);
            this.Join.Controls.Add(this.InviteCode);
            this.Join.Location = new System.Drawing.Point(139, 4);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(367, 349);
            this.Join.TabIndex = 1;
            this.Join.Text = "Join";
            // 
            // JoinGuild
            // 
            this.JoinGuild.BackColor = System.Drawing.Color.Transparent;
            this.JoinGuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.JoinGuild.IsEnabled = true;
            this.JoinGuild.Location = new System.Drawing.Point(90, 160);
            this.JoinGuild.Name = "JoinGuild";
            this.JoinGuild.RoundRadius = 10;
            this.JoinGuild.Size = new System.Drawing.Size(187, 33);
            this.JoinGuild.TabIndex = 4;
            this.JoinGuild.Text = "Join";
            this.JoinGuild.Click += new System.EventHandler(this.JoinGuild_Click);
            // 
            // InviteCode
            // 
            this.InviteCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.InviteCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.InviteCode.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.InviteCode.Location = new System.Drawing.Point(90, 88);
            this.InviteCode.MaxLength = 32767;
            this.InviteCode.Name = "InviteCode";
            this.InviteCode.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.InviteCode.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.InviteCode.ReadOnly = false;
            this.InviteCode.SideImage = null;
            this.InviteCode.Size = new System.Drawing.Size(187, 30);
            this.InviteCode.TabIndex = 3;
            this.InviteCode.Text = "Invite Code";
            this.InviteCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InviteCode.UseSystemPasswordChar = false;
            this.InviteCode.WatermarkText = "";
            // 
            // JoinGroup
            // 
            this.JoinGroup.BackColor = System.Drawing.Color.White;
            this.JoinGroup.Controls.Add(this.JoinGroupBtn);
            this.JoinGroup.Controls.Add(this.InviteCodeGroup);
            this.JoinGroup.Location = new System.Drawing.Point(139, 4);
            this.JoinGroup.Margin = new System.Windows.Forms.Padding(2);
            this.JoinGroup.Name = "JoinGroup";
            this.JoinGroup.Padding = new System.Windows.Forms.Padding(2);
            this.JoinGroup.Size = new System.Drawing.Size(367, 349);
            this.JoinGroup.TabIndex = 6;
            this.JoinGroup.Text = "JoinGroup";
            // 
            // JoinGroupBtn
            // 
            this.JoinGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.JoinGroupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.JoinGroupBtn.IsEnabled = true;
            this.JoinGroupBtn.Location = new System.Drawing.Point(97, 172);
            this.JoinGroupBtn.Name = "JoinGroupBtn";
            this.JoinGroupBtn.RoundRadius = 10;
            this.JoinGroupBtn.Size = new System.Drawing.Size(187, 33);
            this.JoinGroupBtn.TabIndex = 6;
            this.JoinGroupBtn.Text = "Join";
            this.JoinGroupBtn.Click += new System.EventHandler(this.JoinGroupBtn_Click);
            // 
            // InviteCodeGroup
            // 
            this.InviteCodeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.InviteCodeGroup.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.InviteCodeGroup.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.InviteCodeGroup.Location = new System.Drawing.Point(97, 100);
            this.InviteCodeGroup.MaxLength = 32767;
            this.InviteCodeGroup.Name = "InviteCodeGroup";
            this.InviteCodeGroup.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.InviteCodeGroup.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.InviteCodeGroup.ReadOnly = false;
            this.InviteCodeGroup.SideImage = null;
            this.InviteCodeGroup.Size = new System.Drawing.Size(187, 30);
            this.InviteCodeGroup.TabIndex = 5;
            this.InviteCodeGroup.Text = "Invite Code";
            this.InviteCodeGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InviteCodeGroup.UseSystemPasswordChar = false;
            this.InviteCodeGroup.WatermarkText = "";
            // 
            // Leave
            // 
            this.Leave.BackColor = System.Drawing.Color.White;
            this.Leave.Controls.Add(this.LeaveGuild);
            this.Leave.Controls.Add(this.GuildID);
            this.Leave.Location = new System.Drawing.Point(139, 4);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(367, 349);
            this.Leave.TabIndex = 2;
            this.Leave.Text = "Leave";
            // 
            // LeaveGuild
            // 
            this.LeaveGuild.BackColor = System.Drawing.Color.Transparent;
            this.LeaveGuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LeaveGuild.IsEnabled = true;
            this.LeaveGuild.Location = new System.Drawing.Point(90, 179);
            this.LeaveGuild.Name = "LeaveGuild";
            this.LeaveGuild.RoundRadius = 10;
            this.LeaveGuild.Size = new System.Drawing.Size(187, 33);
            this.LeaveGuild.TabIndex = 6;
            this.LeaveGuild.Text = "Leave";
            this.LeaveGuild.Click += new System.EventHandler(this.LeaveGuild_Click);
            // 
            // GuildID
            // 
            this.GuildID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.GuildID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.GuildID.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.GuildID.Location = new System.Drawing.Point(90, 114);
            this.GuildID.MaxLength = 32767;
            this.GuildID.Name = "GuildID";
            this.GuildID.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.GuildID.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.GuildID.ReadOnly = false;
            this.GuildID.SideImage = null;
            this.GuildID.Size = new System.Drawing.Size(187, 30);
            this.GuildID.TabIndex = 5;
            this.GuildID.Text = "Guild Id";
            this.GuildID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GuildID.UseSystemPasswordChar = false;
            this.GuildID.WatermarkText = "";
            // 
            // LeaveGroup
            // 
            this.LeaveGroup.BackColor = System.Drawing.Color.White;
            this.LeaveGroup.Controls.Add(this.LeaveGroupBtn);
            this.LeaveGroup.Controls.Add(this.GroupID2);
            this.LeaveGroup.Location = new System.Drawing.Point(139, 4);
            this.LeaveGroup.Margin = new System.Windows.Forms.Padding(2);
            this.LeaveGroup.Name = "LeaveGroup";
            this.LeaveGroup.Size = new System.Drawing.Size(367, 349);
            this.LeaveGroup.TabIndex = 8;
            this.LeaveGroup.Text = "Leave Group";
            // 
            // LeaveGroupBtn
            // 
            this.LeaveGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.LeaveGroupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LeaveGroupBtn.IsEnabled = true;
            this.LeaveGroupBtn.Location = new System.Drawing.Point(83, 163);
            this.LeaveGroupBtn.Name = "LeaveGroupBtn";
            this.LeaveGroupBtn.RoundRadius = 10;
            this.LeaveGroupBtn.Size = new System.Drawing.Size(187, 33);
            this.LeaveGroupBtn.TabIndex = 8;
            this.LeaveGroupBtn.Text = "Leave";
            this.LeaveGroupBtn.Click += new System.EventHandler(this.LeaveGroupBtn_Click);
            // 
            // GroupID2
            // 
            this.GroupID2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.GroupID2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.GroupID2.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.GroupID2.Location = new System.Drawing.Point(83, 98);
            this.GroupID2.MaxLength = 32767;
            this.GroupID2.Name = "GroupID2";
            this.GroupID2.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.GroupID2.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.GroupID2.ReadOnly = false;
            this.GroupID2.SideImage = null;
            this.GroupID2.Size = new System.Drawing.Size(187, 30);
            this.GroupID2.TabIndex = 7;
            this.GroupID2.Text = "Group Id";
            this.GroupID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupID2.UseSystemPasswordChar = false;
            this.GroupID2.WatermarkText = "";
            // 
            // Friend
            // 
            this.Friend.BackColor = System.Drawing.Color.White;
            this.Friend.Controls.Add(this.FloodFriend);
            this.Friend.Controls.Add(this.Tag);
            this.Friend.Controls.Add(this.Username);
            this.Friend.Location = new System.Drawing.Point(139, 4);
            this.Friend.Name = "Friend";
            this.Friend.Size = new System.Drawing.Size(367, 349);
            this.Friend.TabIndex = 0;
            this.Friend.Text = "Friend Flood";
            // 
            // FloodFriend
            // 
            this.FloodFriend.BackColor = System.Drawing.Color.Transparent;
            this.FloodFriend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FloodFriend.IsEnabled = true;
            this.FloodFriend.Location = new System.Drawing.Point(93, 194);
            this.FloodFriend.Name = "FloodFriend";
            this.FloodFriend.RoundRadius = 10;
            this.FloodFriend.Size = new System.Drawing.Size(187, 33);
            this.FloodFriend.TabIndex = 2;
            this.FloodFriend.Text = "Flood";
            this.FloodFriend.Click += new System.EventHandler(this.FloodFriend_Click);
            // 
            // Tag
            // 
            this.Tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.Tag.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Tag.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Tag.Location = new System.Drawing.Point(93, 146);
            this.Tag.MaxLength = 32767;
            this.Tag.Name = "Tag";
            this.Tag.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.Tag.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Tag.ReadOnly = false;
            this.Tag.SideImage = null;
            this.Tag.Size = new System.Drawing.Size(187, 30);
            this.Tag.TabIndex = 1;
            this.Tag.Text = "Tag";
            this.Tag.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Tag.UseSystemPasswordChar = false;
            this.Tag.WatermarkText = "";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.Username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Username.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Username.Location = new System.Drawing.Point(93, 97);
            this.Username.MaxLength = 32767;
            this.Username.Name = "Username";
            this.Username.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.Username.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Username.ReadOnly = false;
            this.Username.SideImage = null;
            this.Username.Size = new System.Drawing.Size(187, 30);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.UseSystemPasswordChar = false;
            this.Username.WatermarkText = "";
            // 
            // Spam
            // 
            this.Spam.BackColor = System.Drawing.Color.White;
            this.Spam.Controls.Add(this.SpamText);
            this.Spam.Controls.Add(this.ChannelId);
            this.Spam.Controls.Add(this.SpamGuild);
            this.Spam.Location = new System.Drawing.Point(139, 4);
            this.Spam.Name = "Spam";
            this.Spam.Size = new System.Drawing.Size(367, 349);
            this.Spam.TabIndex = 3;
            this.Spam.Text = "Spam";
            // 
            // SpamText
            // 
            this.SpamText.Location = new System.Drawing.Point(0, 43);
            this.SpamText.Multiline = true;
            this.SpamText.Name = "SpamText";
            this.SpamText.Size = new System.Drawing.Size(364, 256);
            this.SpamText.TabIndex = 9;
            // 
            // ChannelId
            // 
            this.ChannelId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.ChannelId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ChannelId.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ChannelId.Location = new System.Drawing.Point(0, 7);
            this.ChannelId.MaxLength = 32767;
            this.ChannelId.Name = "ChannelId";
            this.ChannelId.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.ChannelId.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ChannelId.ReadOnly = false;
            this.ChannelId.SideImage = null;
            this.ChannelId.Size = new System.Drawing.Size(364, 30);
            this.ChannelId.TabIndex = 7;
            this.ChannelId.Text = "Channel Id";
            this.ChannelId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChannelId.UseSystemPasswordChar = false;
            this.ChannelId.WatermarkText = "";
            // 
            // SpamGuild
            // 
            this.SpamGuild.BackColor = System.Drawing.Color.Transparent;
            this.SpamGuild.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SpamGuild.IsEnabled = true;
            this.SpamGuild.Location = new System.Drawing.Point(3, 305);
            this.SpamGuild.Name = "SpamGuild";
            this.SpamGuild.RoundRadius = 10;
            this.SpamGuild.Size = new System.Drawing.Size(361, 33);
            this.SpamGuild.TabIndex = 8;
            this.SpamGuild.Text = "Spam";
            this.SpamGuild.Click += new System.EventHandler(this.SpamGuild_Click);
            // 
            // SpamDM
            // 
            this.SpamDM.BackColor = System.Drawing.Color.White;
            this.SpamDM.Controls.Add(this.SpamTextDM);
            this.SpamDM.Controls.Add(this.UserID);
            this.SpamDM.Controls.Add(this.SpamDMButton);
            this.SpamDM.Location = new System.Drawing.Point(139, 4);
            this.SpamDM.Name = "SpamDM";
            this.SpamDM.Size = new System.Drawing.Size(367, 349);
            this.SpamDM.TabIndex = 4;
            this.SpamDM.Text = "Spam DM";
            // 
            // SpamTextDM
            // 
            this.SpamTextDM.Location = new System.Drawing.Point(0, 40);
            this.SpamTextDM.Multiline = true;
            this.SpamTextDM.Name = "SpamTextDM";
            this.SpamTextDM.Size = new System.Drawing.Size(364, 259);
            this.SpamTextDM.TabIndex = 12;
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.UserID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.UserID.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.UserID.Location = new System.Drawing.Point(0, 4);
            this.UserID.MaxLength = 32767;
            this.UserID.Name = "UserID";
            this.UserID.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.UserID.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.UserID.ReadOnly = false;
            this.UserID.SideImage = null;
            this.UserID.Size = new System.Drawing.Size(364, 30);
            this.UserID.TabIndex = 10;
            this.UserID.Text = "User Id";
            this.UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserID.UseSystemPasswordChar = false;
            this.UserID.WatermarkText = "";
            // 
            // SpamDMButton
            // 
            this.SpamDMButton.BackColor = System.Drawing.Color.Transparent;
            this.SpamDMButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SpamDMButton.IsEnabled = true;
            this.SpamDMButton.Location = new System.Drawing.Point(3, 305);
            this.SpamDMButton.Name = "SpamDMButton";
            this.SpamDMButton.RoundRadius = 10;
            this.SpamDMButton.Size = new System.Drawing.Size(361, 33);
            this.SpamDMButton.TabIndex = 11;
            this.SpamDMButton.Text = "Spam";
            this.SpamDMButton.Click += new System.EventHandler(this.SpamDMButton_Click);
            // 
            // SpamGroup
            // 
            this.SpamGroup.BackColor = System.Drawing.Color.White;
            this.SpamGroup.Controls.Add(this.GroupText);
            this.SpamGroup.Controls.Add(this.GroupID);
            this.SpamGroup.Controls.Add(this.SpamGroupBtn);
            this.SpamGroup.Location = new System.Drawing.Point(139, 4);
            this.SpamGroup.Margin = new System.Windows.Forms.Padding(2);
            this.SpamGroup.Name = "SpamGroup";
            this.SpamGroup.Padding = new System.Windows.Forms.Padding(2);
            this.SpamGroup.Size = new System.Drawing.Size(367, 349);
            this.SpamGroup.TabIndex = 7;
            this.SpamGroup.Text = "Spam Group";
            // 
            // GroupText
            // 
            this.GroupText.Location = new System.Drawing.Point(1, 44);
            this.GroupText.Multiline = true;
            this.GroupText.Name = "GroupText";
            this.GroupText.Size = new System.Drawing.Size(364, 255);
            this.GroupText.TabIndex = 15;
            // 
            // GroupID
            // 
            this.GroupID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.GroupID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.GroupID.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.GroupID.Location = new System.Drawing.Point(1, 8);
            this.GroupID.MaxLength = 32767;
            this.GroupID.Name = "GroupID";
            this.GroupID.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.GroupID.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.GroupID.ReadOnly = false;
            this.GroupID.SideImage = null;
            this.GroupID.Size = new System.Drawing.Size(364, 30);
            this.GroupID.TabIndex = 13;
            this.GroupID.Text = "Group Id";
            this.GroupID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GroupID.UseSystemPasswordChar = false;
            this.GroupID.WatermarkText = "";
            // 
            // SpamGroupBtn
            // 
            this.SpamGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.SpamGroupBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SpamGroupBtn.IsEnabled = true;
            this.SpamGroupBtn.Location = new System.Drawing.Point(3, 305);
            this.SpamGroupBtn.Name = "SpamGroupBtn";
            this.SpamGroupBtn.RoundRadius = 10;
            this.SpamGroupBtn.Size = new System.Drawing.Size(361, 33);
            this.SpamGroupBtn.TabIndex = 14;
            this.SpamGroupBtn.Text = "Spam";
            this.SpamGroupBtn.Click += new System.EventHandler(this.SpamGroupBtn_Click);
            // 
            // InvSpam
            // 
            this.InvSpam.BackColor = System.Drawing.Color.White;
            this.InvSpam.Controls.Add(this.FloodInvite);
            this.InvSpam.Controls.Add(this.InviteChannel);
            this.InvSpam.Location = new System.Drawing.Point(139, 4);
            this.InvSpam.Name = "InvSpam";
            this.InvSpam.Size = new System.Drawing.Size(367, 349);
            this.InvSpam.TabIndex = 5;
            this.InvSpam.Text = "Inv Spam";
            // 
            // FloodInvite
            // 
            this.FloodInvite.BackColor = System.Drawing.Color.Transparent;
            this.FloodInvite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FloodInvite.IsEnabled = true;
            this.FloodInvite.Location = new System.Drawing.Point(90, 170);
            this.FloodInvite.Name = "FloodInvite";
            this.FloodInvite.RoundRadius = 10;
            this.FloodInvite.Size = new System.Drawing.Size(187, 33);
            this.FloodInvite.TabIndex = 6;
            this.FloodInvite.Text = "Flood";
            this.FloodInvite.Click += new System.EventHandler(this.FloodInvite_Click);
            // 
            // InviteChannel
            // 
            this.InviteChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.InviteChannel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.InviteChannel.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.InviteChannel.Location = new System.Drawing.Point(90, 107);
            this.InviteChannel.MaxLength = 32767;
            this.InviteChannel.Name = "InviteChannel";
            this.InviteChannel.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.InviteChannel.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.InviteChannel.ReadOnly = false;
            this.InviteChannel.SideImage = null;
            this.InviteChannel.Size = new System.Drawing.Size(187, 30);
            this.InviteChannel.TabIndex = 5;
            this.InviteChannel.Text = "Channel ID";
            this.InviteChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InviteChannel.UseSystemPasswordChar = false;
            this.InviteChannel.WatermarkText = "";
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.Controls.Add(this.MusicControl);
            this.Settings.Controls.Add(this.Typing);
            this.Settings.Controls.Add(this.nordCheckBox2);
            this.Settings.Controls.Add(this.nordCheckBox1);
            this.Settings.Controls.Add(this.Delay);
            this.Settings.Location = new System.Drawing.Point(139, 4);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(367, 349);
            this.Settings.TabIndex = 9;
            this.Settings.Text = "Settings";
            // 
            // MusicControl
            // 
            this.MusicControl.BackColor = System.Drawing.Color.Transparent;
            this.MusicControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(114)))));
            this.MusicControl.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.MusicControl.Checked = false;
            this.MusicControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MusicControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MusicControl.Location = new System.Drawing.Point(3, 115);
            this.MusicControl.Name = "MusicControl";
            this.MusicControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MusicControl.Size = new System.Drawing.Size(127, 18);
            this.MusicControl.TabIndex = 10;
            this.MusicControl.Text = "Stop / Play Music";
            this.MusicControl.CheckedChanged += new NordCheckBox.CheckedChangedEventHandler(this.MusicControl_CheckedChanged);
            // 
            // Typing
            // 
            this.Typing.BackColor = System.Drawing.Color.Transparent;
            this.Typing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(114)))));
            this.Typing.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.Typing.Checked = false;
            this.Typing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Typing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Typing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Typing.Location = new System.Drawing.Point(3, 91);
            this.Typing.Name = "Typing";
            this.Typing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Typing.Size = new System.Drawing.Size(196, 18);
            this.Typing.TabIndex = 9;
            this.Typing.Text = "Enable Typing When Spamming";
            // 
            // nordCheckBox2
            // 
            this.nordCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.nordCheckBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(114)))));
            this.nordCheckBox2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.nordCheckBox2.Checked = false;
            this.nordCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nordCheckBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nordCheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nordCheckBox2.Location = new System.Drawing.Point(3, 67);
            this.nordCheckBox2.Name = "nordCheckBox2";
            this.nordCheckBox2.Size = new System.Drawing.Size(222, 18);
            this.nordCheckBox2.TabIndex = 8;
            this.nordCheckBox2.Text = "Remove Dead Tokens (Coming Soon)";
            // 
            // nordCheckBox1
            // 
            this.nordCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.nordCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(114)))));
            this.nordCheckBox1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(181)))), ((int)(((byte)(233)))));
            this.nordCheckBox1.Checked = false;
            this.nordCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nordCheckBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nordCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nordCheckBox1.Location = new System.Drawing.Point(3, 43);
            this.nordCheckBox1.Name = "nordCheckBox1";
            this.nordCheckBox1.Size = new System.Drawing.Size(209, 18);
            this.nordCheckBox1.TabIndex = 7;
            this.nordCheckBox1.Text = "Enable Loop Spam (Coming Soon)";
            // 
            // Delay
            // 
            this.Delay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(210)))), ((int)(((byte)(216)))));
            this.Delay.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Delay.HoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Delay.Location = new System.Drawing.Point(3, 7);
            this.Delay.MaxLength = 32767;
            this.Delay.Name = "Delay";
            this.Delay.NormalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(235)))));
            this.Delay.PushedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.Delay.ReadOnly = false;
            this.Delay.SideImage = null;
            this.Delay.Size = new System.Drawing.Size(113, 30);
            this.Delay.TabIndex = 6;
            this.Delay.Text = "Delay In MS";
            this.Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Delay.UseSystemPasswordChar = false;
            this.Delay.WatermarkText = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 355);
            this.Controls.Add(this.nordVerticalTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "JRaid-GUI";
            this.Load += new System.EventHandler(this.Main_Load);
            this.nordVerticalTabControl1.ResumeLayout(false);
            this.Join.ResumeLayout(false);
            this.JoinGroup.ResumeLayout(false);
            this.Leave.ResumeLayout(false);
            this.LeaveGroup.ResumeLayout(false);
            this.Friend.ResumeLayout(false);
            this.Spam.ResumeLayout(false);
            this.Spam.PerformLayout();
            this.SpamDM.ResumeLayout(false);
            this.SpamDM.PerformLayout();
            this.SpamGroup.ResumeLayout(false);
            this.SpamGroup.PerformLayout();
            this.InvSpam.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private NordVerticalTabControl nordVerticalTabControl1;
        private System.Windows.Forms.TabPage Friend;
        private System.Windows.Forms.TabPage Join;
        private System.Windows.Forms.TabPage Leave;
        private System.Windows.Forms.TabPage Spam;
        private System.Windows.Forms.TabPage SpamDM;
        private System.Windows.Forms.TabPage InvSpam;
        private NordClearButton FloodFriend;
        private NordTextbox Tag;
        private NordTextbox Username;
        private NordClearButton JoinGuild;
        private NordTextbox InviteCode;
        private NordClearButton LeaveGuild;
        private NordTextbox GuildID;
        private System.Windows.Forms.TextBox SpamText;
        private NordClearButton SpamGuild;
        private NordTextbox ChannelId;
        private System.Windows.Forms.TextBox SpamTextDM;
        private NordClearButton FloodInvite;
        private NordTextbox InviteChannel;
        private System.Windows.Forms.TabPage JoinGroup;
        private System.Windows.Forms.TabPage LeaveGroup;
        private System.Windows.Forms.TabPage SpamGroup;
        private NordClearButton JoinGroupBtn;
        private NordTextbox InviteCodeGroup;
        private NordClearButton LeaveGroupBtn;
        private NordTextbox GroupID2;
        private NordTextbox UserID;
        private System.Windows.Forms.TextBox GroupText;
        private NordClearButton SpamGroupBtn;
        private NordTextbox GroupID;
        private System.Windows.Forms.TabPage Settings;
        private NordCheckBox nordCheckBox2;
        private NordCheckBox nordCheckBox1;
        private NordTextbox Delay;
        private NordClearButton SpamDMButton;
        private NordCheckBox Typing;
        private NordCheckBox MusicControl;
    }
}