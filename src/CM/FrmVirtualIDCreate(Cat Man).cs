﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YummyRestaurantSystem
{
    public partial class FrmVirtualIDCreate : Form
    {
        private bool validItemID = false;

        public bool logout = false;
        public bool created = false;

        public FrmVirtualIDCreate()
        {
            InitializeComponent();
            DataTable typeTable = SQLHandler.GetAllRestaurantType();
            foreach (DataRow row in typeTable.Rows)
            {
                string typeID = (string)row["TypeID"];
                cboTypeID.Items.Add(typeID);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            string itemName = SQLHandler.GetItemNameByItemID(txtItemID.Text);
            if (itemName != null)
            {
                txtItemName.Text = itemName;
                validItemID = true;
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeID = cboTypeID.SelectedItem.ToString();
            string typeName = SQLHandler.GetTypeNameByTypeID(typeID);
            if (typeName != null)
            {
                txtTypeName.Text = typeName;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTypeName.Text.Length == 0 || !validItemID) return;

            Match match = Regex.Match(txtVID.Text, @"V\d{9}");
            if (!match.Success)
            {
                MessageBox.Show("Incorrect VID format.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool success = SQLHandler.CreateVIDMapping(txtVID.Text, cboTypeID.SelectedItem.ToString(), txtItemID.Text);
            if (!success)
            {
                MessageBox.Show("Constraint violation.", "Fail to create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("New Virtual ID mapping have inserted into database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            created = true;
        }

        private void FrmVirtualIDCreate_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCM_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmCategoryManage form = new FrmCategoryManage();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
        }

        private void btnVID_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            FrmItemManage form = new FrmItemManage();
            form.ShowDialog();
            if (form.logout)
            {
                Close();
            }
            else
            {
                Visible = true;
            }
        }
    }
}
