﻿namespace ChatCliente
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
            this.gbRegistar = new System.Windows.Forms.GroupBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtRPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbHome = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnHomeRegistar = new System.Windows.Forms.Button();
            this.btnHomeLogin = new System.Windows.Forms.Button();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLastAccess = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbRegistar.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.gbChat.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbHome.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistar
            // 
            this.gbRegistar.Controls.Add(this.btnRegistar);
            this.gbRegistar.Controls.Add(this.txtRPass);
            this.gbRegistar.Controls.Add(this.label2);
            this.gbRegistar.Controls.Add(this.txtRUser);
            this.gbRegistar.Controls.Add(this.label1);
            this.gbRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistar.Location = new System.Drawing.Point(368, 105);
            this.gbRegistar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRegistar.Name = "gbRegistar";
            this.gbRegistar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRegistar.Size = new System.Drawing.Size(194, 155);
            this.gbRegistar.TabIndex = 0;
            this.gbRegistar.TabStop = false;
            this.gbRegistar.Text = "Registar";
            this.gbRegistar.Visible = false;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(62, 119);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(75, 27);
            this.btnRegistar.TabIndex = 4;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtRPass
            // 
            this.txtRPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRPass.Location = new System.Drawing.Point(9, 94);
            this.txtRPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRPass.Name = "txtRPass";
            this.txtRPass.Size = new System.Drawing.Size(174, 21);
            this.txtRPass.TabIndex = 3;
            this.txtRPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palavra-Passe";
            // 
            // txtRUser
            // 
            this.txtRUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUser.Location = new System.Drawing.Point(9, 48);
            this.txtRUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRUser.Name = "txtRUser";
            this.txtRUser.Size = new System.Drawing.Size(174, 21);
            this.txtRUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de Utilizador";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtLPass);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.txtLUser);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(362, 105);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLogin.Size = new System.Drawing.Size(194, 155);
            this.gbLogin.TabIndex = 5;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Iniciar Sessão";
            this.gbLogin.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(52, 119);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(107, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sessão";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLPass
            // 
            this.txtLPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLPass.Location = new System.Drawing.Point(9, 94);
            this.txtLPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLPass.Name = "txtLPass";
            this.txtLPass.Size = new System.Drawing.Size(174, 21);
            this.txtLPass.TabIndex = 3;
            this.txtLPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Palavra-Passe";
            // 
            // txtLUser
            // 
            this.txtLUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLUser.Location = new System.Drawing.Point(9, 48);
            this.txtLUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLUser.Name = "txtLUser";
            this.txtLUser.Size = new System.Drawing.Size(174, 21);
            this.txtLUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome de Utilizador";
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.btnSend);
            this.gbChat.Controls.Add(this.txtMessage);
            this.gbChat.Controls.Add(this.lbChat);
            this.gbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChat.Location = new System.Drawing.Point(268, 10);
            this.gbChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbChat.Name = "gbChat";
            this.gbChat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbChat.Size = new System.Drawing.Size(310, 356);
            this.gbChat.TabIndex = 6;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            this.gbChat.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(219, 286);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 27);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMessage.Location = new System.Drawing.Point(14, 252);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(281, 21);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.WordWrap = false;
            // 
            // lbChat
            // 
            this.lbChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 15;
            this.lbChat.Location = new System.Drawing.Point(14, 31);
            this.lbChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(281, 199);
            this.lbChat.TabIndex = 0;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.label15);
            this.gbInfo.Controls.Add(this.label16);
            this.gbInfo.Controls.Add(this.label14);
            this.gbInfo.Controls.Add(this.label13);
            this.gbInfo.Controls.Add(this.label12);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.lblServer);
            this.gbInfo.Controls.Add(this.lblPort);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbInfo.Location = new System.Drawing.Point(25, 10);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbInfo.Size = new System.Drawing.Size(208, 356);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informações da Aplicação";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 306);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "Professor";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label16.Location = new System.Drawing.Point(5, 321);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Nuno Simões";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.Location = new System.Drawing.Point(5, 271);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 9;
            this.label14.Text = "Rúben Soares";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label13.Location = new System.Drawing.Point(5, 243);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Hugo Gomes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Estudantes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(5, 214);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "David Domingues";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblServer.Location = new System.Drawing.Point(57, 98);
            this.lblServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(58, 15);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPort.Location = new System.Drawing.Point(57, 116);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(42, 15);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "50001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(20, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Porta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(5, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Servidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tópicos de Segurança";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Projeto de";
            // 
            // gbHome
            // 
            this.gbHome.Controls.Add(this.label18);
            this.gbHome.Controls.Add(this.label17);
            this.gbHome.Controls.Add(this.btnHomeRegistar);
            this.gbHome.Controls.Add(this.btnHomeLogin);
            this.gbHome.Location = new System.Drawing.Point(323, 115);
            this.gbHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbHome.Name = "gbHome";
            this.gbHome.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbHome.Size = new System.Drawing.Size(259, 134);
            this.gbHome.TabIndex = 8;
            this.gbHome.TabStop = false;
            this.gbHome.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(66, 36);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Escolha uma das opções";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(66, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Bem vindo ao Chat DGS.";
            // 
            // btnHomeRegistar
            // 
            this.btnHomeRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeRegistar.Location = new System.Drawing.Point(32, 58);
            this.btnHomeRegistar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHomeRegistar.Name = "btnHomeRegistar";
            this.btnHomeRegistar.Size = new System.Drawing.Size(75, 27);
            this.btnHomeRegistar.TabIndex = 6;
            this.btnHomeRegistar.Text = "Registar";
            this.btnHomeRegistar.UseVisualStyleBackColor = true;
            this.btnHomeRegistar.Click += new System.EventHandler(this.btnHomeRegistar_Click);
            // 
            // btnHomeLogin
            // 
            this.btnHomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeLogin.Location = new System.Drawing.Point(132, 58);
            this.btnHomeLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHomeLogin.Name = "btnHomeLogin";
            this.btnHomeLogin.Size = new System.Drawing.Size(107, 27);
            this.btnHomeLogin.TabIndex = 5;
            this.btnHomeLogin.Text = "Iniciar Sessão";
            this.btnHomeLogin.UseVisualStyleBackColor = true;
            this.btnHomeLogin.Click += new System.EventHandler(this.btnHomeLogin_Click);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.btnQuit);
            this.gbUserInfo.Controls.Add(this.btnLogOut);
            this.gbUserInfo.Controls.Add(this.label10);
            this.gbUserInfo.Controls.Add(this.lblLastAccess);
            this.gbUserInfo.Controls.Add(this.label9);
            this.gbUserInfo.Controls.Add(this.lblUsername);
            this.gbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbUserInfo.Location = new System.Drawing.Point(612, 10);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUserInfo.Size = new System.Drawing.Size(164, 356);
            this.gbUserInfo.TabIndex = 9;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "Dados e Ações do Utilizador";
            this.gbUserInfo.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(7, 240);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(152, 27);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Sair";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(7, 192);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(152, 27);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Terminar Sessão";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Último Acesso";
            // 
            // lblLastAccess
            // 
            this.lblLastAccess.AutoSize = true;
            this.lblLastAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLastAccess.Location = new System.Drawing.Point(4, 116);
            this.lblLastAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastAccess.Name = "lblLastAccess";
            this.lblLastAccess.Size = new System.Drawing.Size(0, 15);
            this.lblLastAccess.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nome de Utilizador";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblUsername.Location = new System.Drawing.Point(4, 64);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 15);
            this.lblUsername.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 386);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.gbHome);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbRegistar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Chap App";
            this.gbRegistar.ResumeLayout(false);
            this.gbRegistar.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbHome.ResumeLayout(false);
            this.gbHome.PerformLayout();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistar;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtRPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbHome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnHomeRegistar;
        private System.Windows.Forms.Button btnHomeLogin;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLastAccess;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnLogOut;
    }

}

