using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ErmitanoJF.DataAccess;
using ErmitanoJF.BusinessLogic;

namespace WindowsFormsApplication1
{
    public partial class Phones : Form
    {
        public Phones()
        {
            InitializeComponent();
        }
        #region txtboxBehavior
        private void txtID_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "Phone I.D.")
            {
                txtID.Text = "";
            }
            else
            {
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Phone I.D.";
            }
            else
            {
            }
        }

        private void txtPN_Click(object sender, EventArgs e)
        {
            if (txtPN.Text == "Phone Name")
            {
                txtPN.Text = "";
            }
            else
            {
            }
        }

        private void txtPN_Leave(object sender, EventArgs e)
        {
            if (txtPN.Text == "")
            {
                txtPN.Text = "Phone Name";
            }
            else
            {
            }
        }

        private void txtM_Click(object sender, EventArgs e)
        {
            if (txtM.Text == "Manufacturer")
            {
                txtM.Text = "";
            }
            else
            {
            }
        }

        private void txtM_Leave(object sender, EventArgs e)
        {
            if (txtM.Text == "")
            {
                txtM.Text = "Manufacturer";
            }
            else
            {
            }
        }

        private void txtP_Click(object sender, EventArgs e)
        {
            if (txtP.Text == "Price")
            {
                txtP.Text = "";
            }
            else
            {
            }
        }

        private void txtP_Leave(object sender, EventArgs e)
        {
            if (txtP.Text == "")
            {
                txtP.Text = "Price";
            }
            else
            {
            }
        }

        private void txtSC_Click(object sender, EventArgs e)
        {
            if (txtSC.Text == "Storage Capacity")
            {
                txtSC.Text = "";
            }
            else
            {
            }
        }

        private void txtSC_Leave(object sender, EventArgs e)
        {
            if (txtSC.Text == "")
            {
                txtSC.Text = "Storage Capacity";
            }
            else
            {
            }
        }

        private void txtOS_Click(object sender, EventArgs e)
        {
            if (txtOS.Text == "Operating System")
            {
                txtOS.Text = "";
            }
            else
            {
            }
        }

        private void txtOS_Leave(object sender, EventArgs e)
        {
            if (txtOS.Text == "")
            {
                txtOS.Text = "Operating System";
            }
            else
            {
            }
        }

        private void txtYR_Click(object sender, EventArgs e)
        {
            if (txtYR.Text == "Year Released")
            {
                txtYR.Text = "";
            }
            else
            {
            }
        }

        private void txtYR_Leave(object sender, EventArgs e)
        {
            if (txtYR.Text == "")
            {
                txtYR.Text = "Year Released";
            }
            else
            {
            }
        }
        #endregion
        #region VADU
        BLL Phone = new BLL();
        private void Phones_Load(object sender, EventArgs e)
        {
            dgv.DataSource = Phone.View();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            try
            {
                Phone.PhoneID = txtID.Text;
                Phone.PhoneName = txtPN.Text;
                Phone.Manufacturer = txtM.Text;
                Phone.Price = txtP.Text;
                Phone.StorageCapacity = txtSC.Text;
                Phone.OperatingSystem = txtOS.Text;
                Phone.YearReleased = int.Parse(txtYR.Text);
                Phone.Add();
                Phones_Load(sender, e);
                txtID.Text = "Phone I.D.";
                txtPN.Text = "Phone Name";
                txtM.Text = "Manufacturer";
                txtP.Text = "Price";
                txtSC.Text = "Storage Capacity";
                txtOS.Text = "Operating System";
                txtYR.Text = "Year Released";
                MessageBox.Show("Phone successfully added.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "-" + ex.Message);
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                Phone.PhoneID = txtID.Text;
                Phone.PhoneName = txtPN.Text;
                Phone.Manufacturer = txtM.Text;
                Phone.Price = txtP.Text;
                Phone.StorageCapacity = txtSC.Text;
                Phone.OperatingSystem = txtOS.Text;
                Phone.YearReleased = int.Parse(txtYR.Text);
                Phone.Update();
                Phones_Load(sender, e);
                txtID.Text = "Phone I.D.";
                txtPN.Text = "Phone Name";
                txtM.Text = "Manufacturer";
                txtP.Text = "Price";
                txtSC.Text = "Storage Capacity";
                txtOS.Text = "Operating System";
                txtYR.Text = "Year Released";
                MessageBox.Show("Phone successfully updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "-" + ex.Message);
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            try
            {
                Phone.PhoneID = txtID.Text;
                Phone.Delete();
                Phones_Load(sender, e);
                txtID.Text = "Phone I.D.";
                txtPN.Text = "Phone Name";
                txtM.Text = "Manufacturer";
                txtP.Text = "Price";
                txtSC.Text = "Storage Capacity";
                txtOS.Text = "Operating System";
                txtYR.Text = "Year Released";
                MessageBox.Show("Phone successfully deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "-" + ex.Message);
            }
#endregion
        }
    }
}
