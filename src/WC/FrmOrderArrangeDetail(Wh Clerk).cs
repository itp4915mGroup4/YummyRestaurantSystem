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
    public partial class FrmOrderArrangeDetail_Wh_Clerk_ : Form
    {
        public FrmOrderArrangeDetail_Wh_Clerk_()
        {
            InitializeComponent();
        }

        private void lblRestaurant_Click(object sender, EventArgs e)
        {

        }

        private void FrmOrderArrangeDetail_Load(object sender, EventArgs e)
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