using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercise_4
{
    public partial class formShapes : Form
    {
        //Defined variable that contrains a list
        private List<Shape> _lstShapes = new List<Shape>();

        public formShapes()
        {
            InitializeComponent();
        }

        // Set initial font and colours
        Color panelBackgroundColour = Color.White;

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            int panelWidth = panel.ClientRectangle.Width;
            int panelHeight = panel.ClientRectangle.Height;
            g.FillRectangle(new SolidBrush(panelBackgroundColour), 0, 0, panelWidth, panelHeight);

            foreach (Shape shp in _lstShapes)
            {
                shp.Draw(g);
            }
        }

        private void addShapeBtn_Click(object sender, EventArgs e)
        {
            AddShape addShape = new AddShape();

            if (addShape.ShowDialog() == DialogResult.OK)
            {
                _lstShapes.Add(addShape.Shape);
                //Refreshes panel
                panel.Invalidate();
            }
            addShape.Dispose();
        }
    }
}
