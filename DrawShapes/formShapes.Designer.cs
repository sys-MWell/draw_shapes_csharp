
namespace Exercise_4
{
    partial class formShapes
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
            this.panel = new System.Windows.Forms.Panel();
            this.addShapeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Control;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(561, 411);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // addShapeBtn
            // 
            this.addShapeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addShapeBtn.Location = new System.Drawing.Point(634, 37);
            this.addShapeBtn.Name = "addShapeBtn";
            this.addShapeBtn.Size = new System.Drawing.Size(110, 37);
            this.addShapeBtn.TabIndex = 1;
            this.addShapeBtn.Text = "Add shape";
            this.addShapeBtn.UseVisualStyleBackColor = true;
            this.addShapeBtn.Click += new System.EventHandler(this.addShapeBtn_Click);
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addShapeBtn);
            this.Controls.Add(this.panel);
            this.Name = "Shapes";
            this.Text = "Shapes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button addShapeBtn;
    }
}

