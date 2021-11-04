using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class AddShape : Form
    {
        Shape _shape = null;
        Color _penColour = Color.Blue;

        public AddShape()
        {
            InitializeComponent();
        }

        public Shape Shape
        {
            get
            {
                return _shape;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int xCoord;
            int yCoord;
            int height;
            int width;
            bool validationFailed = false;

            if (!int.TryParse(xPositionEntry.Text, out xCoord) || xCoord < 0)
            {
                validationFailed = true;
            }

            if (!int.TryParse(yPositionEntry.Text, out yCoord) || yCoord < 0)
            {
                validationFailed = true;
            }

            if (!int.TryParse(heightEntry.Text, out height) || height < 0)
            {
                validationFailed = true;
            }

            if (!int.TryParse(widthEntry.Text, out width) || width < 0)
            {
                validationFailed = true;
            }

            if (!triangleRadioButton.Checked && !circleRadioButton.Checked && !squareRadioButton.Checked)
            {
                validationFailed = true;
            }

            if (!validationFailed)
            {
                if (triangleRadioButton.Checked)
                {
                    _shape = new Triangle(xCoord, yCoord, height, width, _penColour);
                }
                else if (circleRadioButton.Checked)
                {
                    _shape = new Circle(xCoord, yCoord, height, width, _penColour);
                }
                else if (squareRadioButton.Checked)
                {
                    _shape = new Square(xCoord, yCoord, height, width, _penColour);
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void selectColour_Click(object sender, EventArgs e)
        {
            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                _penColour = colourDialog.Color;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
