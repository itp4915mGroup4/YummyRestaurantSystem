﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            txtuser.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtpw.BackColor = SystemColors.Control;
        }

        private void txtpw_Click(object sender, EventArgs e)
        {
            txtpw.BackColor = Color.White;
            panel4.BackColor = Color.White;
            txtuser.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txtpw.PasswordChar = '●';
        }

        private void cbnShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnShowPw.Checked)
            {
                txtpw.PasswordChar = '\0';
            }else
            {
                txtpw.PasswordChar = '●';
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }
    }
}
