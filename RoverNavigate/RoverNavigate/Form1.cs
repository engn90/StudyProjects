using RoverNavigate.Common;
using RoverNavigate.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoverNavigate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (CreatePlateau())
                OpenRoverControlForm();
        }
        private bool CreatePlateau()
        {
            try
            {
                if (numericPlateauX.Value == 0)
                {
                    MessageBox.Show("Please enter the X value");
                    return false;
                }

                if (numericPlateauY.Value == 0)
                {
                    MessageBox.Show("Please enter the Y value");
                    return false;
                }

                Plateau.Current = new Plateau(Convert.ToInt32(numericPlateauX.Value), Convert.ToInt32(numericPlateauY.Value));
                
                return true;
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred");
                return false;
            }
        }
        private void OpenRoverControlForm()
        {
            this.Hide();
            FormRoverControl formRoverControl = new FormRoverControl();
            formRoverControl.ShowDialog();
            this.Close();
        }
    }
}
