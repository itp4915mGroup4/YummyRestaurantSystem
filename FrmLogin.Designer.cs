﻿
namespace YummyRestaurantSystem
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblcompanyName3 = new System.Windows.Forms.Label();
            this.lblcompanyName2 = new System.Windows.Forms.Label();
            this.lblcompanyName1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbnShowPw = new System.Windows.Forms.CheckBox();
            this.btnforgot = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.picpw = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.lblLoginmsg = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpw)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblcompanyName3);
            this.panel1.Controls.Add(this.lblcompanyName2);
            this.panel1.Controls.Add(this.lblcompanyName1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 579);
            this.panel1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(17, 524);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            // 
            // lblcompanyName3
            // 
            this.lblcompanyName3.AutoSize = true;
            this.lblcompanyName3.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyName3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcompanyName3.Location = new System.Drawing.Point(12, 350);
            this.lblcompanyName3.Name = "lblcompanyName3";
            this.lblcompanyName3.Size = new System.Drawing.Size(82, 27);
            this.lblcompanyName3.TabIndex = 3;
            this.lblcompanyName3.Text = "System";
            // 
            // lblcompanyName2
            // 
            this.lblcompanyName2.AutoSize = true;
            this.lblcompanyName2.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcompanyName2.Location = new System.Drawing.Point(12, 305);
            this.lblcompanyName2.Name = "lblcompanyName2";
            this.lblcompanyName2.Size = new System.Drawing.Size(210, 27);
            this.lblcompanyName2.TabIndex = 2;
            this.lblcompanyName2.Text = "Yummy Restaurant ";
            // 
            // lblcompanyName1
            // 
            this.lblcompanyName1.AutoSize = true;
            this.lblcompanyName1.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyName1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcompanyName1.Location = new System.Drawing.Point(12, 261);
            this.lblcompanyName1.Name = "lblcompanyName1";
            this.lblcompanyName1.Size = new System.Drawing.Size(179, 27);
            this.lblcompanyName1.TabIndex = 1;
            this.lblcompanyName1.Text = "Weclocme to the";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbnShowPw);
            this.panel2.Controls.Add(this.btnforgot);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblLoginmsg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 579);
            this.panel2.TabIndex = 2;
            // 
            // cbnShowPw
            // 
            this.cbnShowPw.AutoSize = true;
            this.cbnShowPw.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbnShowPw.Location = new System.Drawing.Point(357, 400);
            this.cbnShowPw.Name = "cbnShowPw";
            this.cbnShowPw.Size = new System.Drawing.Size(99, 17);
            this.cbnShowPw.TabIndex = 7;
            this.cbnShowPw.Text = "ShowPassword";
            this.cbnShowPw.UseVisualStyleBackColor = true;
            this.cbnShowPw.CheckedChanged += new System.EventHandler(this.cbnShowPw_CheckedChanged);
            // 
            // btnforgot
            // 
            this.btnforgot.BackColor = System.Drawing.SystemColors.Control;
            this.btnforgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforgot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnforgot.Location = new System.Drawing.Point(59, 460);
            this.btnforgot.Name = "btnforgot";
            this.btnforgot.Size = new System.Drawing.Size(146, 38);
            this.btnforgot.TabIndex = 6;
            this.btnforgot.Text = "Forgot password";
            this.btnforgot.UseVisualStyleBackColor = false;
            this.btnforgot.Click += new System.EventHandler(this.btnforgot_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(309, 460);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtpw);
            this.panel4.Controls.Add(this.picpw);
            this.panel4.Location = new System.Drawing.Point(47, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 49);
            this.panel4.TabIndex = 4;
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(59, 14);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(305, 20);
            this.txtpw.TabIndex = 2;
            this.txtpw.Click += new System.EventHandler(this.txtpw_Click);
            // 
            // picpw
            // 
            this.picpw.Image = ((System.Drawing.Image)(resources.GetObject("picpw.Image")));
            this.picpw.Location = new System.Drawing.Point(6, 3);
            this.picpw.Name = "picpw";
            this.picpw.Size = new System.Drawing.Size(28, 35);
            this.picpw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picpw.TabIndex = 1;
            this.picpw.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtuser);
            this.panel3.Controls.Add(this.picuser);
            this.panel3.Location = new System.Drawing.Point(47, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 49);
            this.panel3.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(59, 14);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(305, 20);
            this.txtuser.TabIndex = 1;
            this.txtuser.Click += new System.EventHandler(this.txtuser_Click);
            // 
            // picuser
            // 
            this.picuser.Image = ((System.Drawing.Image)(resources.GetObject("picuser.Image")));
            this.picuser.Location = new System.Drawing.Point(6, 3);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(28, 35);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picuser.TabIndex = 0;
            this.picuser.TabStop = false;
            // 
            // lblLoginmsg
            // 
            this.lblLoginmsg.AutoSize = true;
            this.lblLoginmsg.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginmsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoginmsg.Location = new System.Drawing.Point(43, 114);
            this.lblLoginmsg.Name = "lblLoginmsg";
            this.lblLoginmsg.Size = new System.Drawing.Size(229, 27);
            this.lblLoginmsg.TabIndex = 2;
            this.lblLoginmsg.Text = "Login to your account";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picpw)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcompanyName3;
        private System.Windows.Forms.Label lblcompanyName2;
        private System.Windows.Forms.Label lblcompanyName1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnforgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.PictureBox picpw;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.Label lblLoginmsg;
        private System.Windows.Forms.CheckBox cbnShowPw;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}