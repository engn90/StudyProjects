using RoverNavigate.Common;
using RoverNavigate.Model;
using RoverNavigate.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace RoverNavigate.Control
{
    public class PlateauControl
    {
        private FormRoverControl _form;
        private List<Panel> _panelList;
        private Panel _basePanel;
        public PlateauControl(FormRoverControl form)
        {
            _form = form;
        }
        public void DrawPlateau()
        {
            _panelList = new List<Panel>();

            _basePanel = new Panel();
            _basePanel.Location = new System.Drawing.Point(44, 100);
            _basePanel.Size = new System.Drawing.Size(750, 720);
            _basePanel.AutoScroll = true;
            _form.Controls.Add(_basePanel);

            int panelX = 0;
            int panelY = 0;

            for (int y = Plateau.Current.TotalY; y > -1; y--)
            {
                for (int x = 0; x < Plateau.Current.TotalX + 1; x++)
                {
                    var currentArea = Plateau.Current.GetAreaByCoordinate(x, y);
                    DrawArea(currentArea, panelX, panelY);
                    panelX += 65;
                }
                panelX = 0;
                panelY += 65;
            }
        }
        public void ClearPlateau()
        {
            foreach (var item in _panelList)
            {
                _form.Controls.Remove(item);
            }

            _form.Controls.Remove(_basePanel);
        }

        private void DrawArea(Area area, int panelX, int panelY)
        {
           Panel panel = new Panel();
           panel.Location = new Point(panelX, panelY);
           panel.Size = new Size(60, 60);
           panel.BorderStyle = BorderStyle.FixedSingle;

            Label lblCordinate = new Label();
            lblCordinate.Location = new Point(2, 40);
            lblCordinate.Size = new Size(35, 13);
            lblCordinate.Text = area.X + "," + area.Y;
            panel.Controls.Add(lblCordinate);

            if (area.Rover != null)
            {
                Label lblName = new Label();
                lblName.Location = new Point(35, 40);
                lblName.Size = new Size(26, 12);
                lblName.Text = area.Rover.Name;
                lblName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                panel.Controls.Add(lblName);

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (area.Rover.Direction.Equals(EnumDirection.North) || area.Rover.Direction.Equals(EnumDirection.South))
                {
                    pictureBox.Location = new Point(25, 3);
                    pictureBox.Size = new Size(17, 38);
                    pictureBox.Image = area.Rover.Direction.Equals(EnumDirection.North) ? Resources.arrowUp : Resources.arrowDown;
                }
                else
                {
                    pictureBox.Location = new Point(12, 15);
                    pictureBox.Size = new Size(41, 17);
                    pictureBox.Image = area.Rover.Direction.Equals(EnumDirection.East) ? Resources.arrowRight : Resources.arrowLeft;
                }

                panel.Controls.Add(pictureBox);
            }

            _panelList.Add(panel);
            _basePanel.Controls.Add(panel);
        }

    }
}
