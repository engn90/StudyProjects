using RoverNavigate.Common;
using RoverNavigate.Control;
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
    public partial class FormRoverControl : Form
    {
        private PlateauControl plateauControl;
        public FormRoverControl()
        {
            plateauControl = new PlateauControl(this);
            InitializeComponent();
        }

        private void FormRoverControl_Load(object sender, EventArgs e)
        {
            numericRoverX.Maximum = Plateau.Current.TotalX;
            numericRoverY.Maximum = Plateau.Current.TotalY;
            grbBoxMoveRover.Enabled = false;
            SetEnabledMovingButton(false);

            FillDirectionComboBox();
            CreateGrid();
        }
        private void FormRoverControl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FillDirectionComboBox()
        {
            cmbxDirection.Items.Add(new SelectItem("North", (int)EnumDirection.North));
            cmbxDirection.Items.Add(new SelectItem("South", (int)EnumDirection.South));
            cmbxDirection.Items.Add(new SelectItem("East", (int)EnumDirection.East));
            cmbxDirection.Items.Add(new SelectItem("West", (int)EnumDirection.West));
            cmbxDirection.SelectedIndex = 0;
        }
        private void FillRoverComboBox()
        {
            grbBoxMoveRover.Enabled = true;

            cmbxRover.Items.Clear();

            var areaList = Plateau.Current.GetHasRoverAreas();
            if (areaList != null && areaList.Count > 0)
            {
                foreach (var item in areaList)
                {
                    cmbxRover.Items.Add(item.Rover.Name);
                }
                cmbxRover.SelectedIndex = 0;
            }
        }

        private void btnAddRover_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedX = Convert.ToInt32(numericRoverX.Value);
                int selectedY = Convert.ToInt32(numericRoverY.Value);
                SelectItem selectedDirection = (SelectItem)cmbxDirection.SelectedItem;

                var selectedArea = Plateau.Current.GetAreaByCoordinate(selectedX, selectedY);
                if (selectedArea == null)
                {
                    MessageBox.Show("This position is not suitable.");
                    return;
                }

                if (selectedArea.Rover != null)
                {
                    MessageBox.Show("This position is not empty.");
                    return;
                }

                selectedArea.Rover = new Rover()
                {
                    Name = "R" + Plateau.Current.GetRoverCount(),
                    CurrentX = selectedX,
                    CurrentY = selectedY,
                    Direction = (EnumDirection)selectedDirection.Value
                };

                RefreshDefineRover();
                RefreshMoveRover();
                FillRoverComboBox();
                plateauControl.ClearPlateau();
                CreateGrid();
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred");
            }

        }
        private void CreateGrid()
        {
            try
            {
                plateauControl.DrawPlateau();

            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred");
            }
        }
        private void RefreshDefineRover()
        {
            numericRoverX.Value = 0;
            numericRoverY.Value = 0;
            cmbxDirection.SelectedIndex = 0;
        }
        private void RefreshMoveRover()
        {
            txtCommand.Text = String.Empty;
            listViewCommandHistory.Items.Clear();
            //cmbxRover.SelectedIndex = -1;
        }
        private void RefreshGrid()
        {
            var hasRovesAreaList = Plateau.Current.GetHasRoverAreas();
            if (hasRovesAreaList != null && hasRovesAreaList.Count > 0)
            {
                foreach (var item in hasRovesAreaList)
                {
                    item.Rover = null;
                }
            }

            plateauControl.ClearPlateau();
            CreateGrid();
        }
        private void SetEnabledMovingButton(bool enabled)
        {
            btnApply.Enabled = enabled;
            btnDeleteCommand.Enabled = enabled;
            btnBack.Enabled = enabled;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            SetEnabledMovingButton(true);

            if (cmbxRover.SelectedItem == null)
            {
                MessageBox.Show("Rover could not be found");
                return;
            }

            txtCommand.Text += "L";
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            SetEnabledMovingButton(true);

            if (cmbxRover.SelectedItem == null)
            {
                MessageBox.Show("Rover could not be found");
                return;
            }

            txtCommand.Text += "R";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            SetEnabledMovingButton(true);

            if (cmbxRover.SelectedItem == null)
            {
                MessageBox.Show("Rover could not be found");
                return;
            }

            txtCommand.Text += "M";
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCommand.Text))
                return;

            txtCommand.Text = txtCommand.Text.Remove(txtCommand.Text.Length - 1);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCommand.Text))
                {
                    MessageBox.Show("Please enter command before apply.");
                    return;
                }

                string roverName = (string)cmbxRover.SelectedItem;
                var rover = Plateau.Current.GetRoverByName(roverName);
                rover.Go(txtCommand.Text);

                txtCommand.Text = String.Empty;
                FillCommandHistoryListView(rover);
                plateauControl.ClearPlateau();
                CreateGrid();
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                string roverName = (string)cmbxRover.SelectedItem;
                var rover = Plateau.Current.GetRoverByName(roverName);
                rover.Back();

                txtCommand.Text = String.Empty;
                FillCommandHistoryListView(rover);

                plateauControl.ClearPlateau();
                CreateGrid();
            }
            catch (BusinessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred");
            }
        }
        private void cmbxRover_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxRover.SelectedIndex == -1)
                return;

            RefreshMoveRover();
            string roverName = (string)cmbxRover.SelectedItem;
            var rover = Plateau.Current.GetRoverByName(roverName);
            FillCommandHistoryListView(rover);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            RefreshDefineRover();
            RefreshMoveRover();
            cmbxRover.SelectedIndex = -1;
            cmbxRover.Items.Clear();
            grbBoxMoveRover.Enabled = false;
            SetEnabledMovingButton(false);
        }
        private void FillCommandHistoryListView(Rover rover)
        {
            listViewCommandHistory.Items.Clear();
            foreach (var item in rover.CommandHistory)
            {
                listViewCommandHistory.Items.Add(item);
            }
        }


    }
}
