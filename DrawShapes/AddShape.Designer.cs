
namespace Exercise_4
{
    partial class AddShape
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
            this.triangleRadioButton = new System.Windows.Forms.RadioButton();
            this.colourDialog = new System.Windows.Forms.ColorDialog();
            this.shapeTypePanel = new System.Windows.Forms.Panel();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectColour = new System.Windows.Forms.Button();
            this.colourLabel = new System.Windows.Forms.Label();
            this.widthEntry = new System.Windows.Forms.TextBox();
            this.heightEntry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.yPositionEntry = new System.Windows.Forms.TextBox();
            this.xPositionEntry = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.positionPanel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.shapeTypePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // triangleRadioButton
            // 
            this.triangleRadioButton.AutoSize = true;
            this.triangleRadioButton.Location = new System.Drawing.Point(17, 26);
            this.triangleRadioButton.Name = "triangleRadioButton";
            this.triangleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.triangleRadioButton.TabIndex = 0;
            this.triangleRadioButton.Text = "Triangle";
            this.triangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // shapeTypePanel
            // 
            this.shapeTypePanel.Controls.Add(this.circleRadioButton);
            this.shapeTypePanel.Controls.Add(this.triangleRadioButton);
            this.shapeTypePanel.Controls.Add(this.squareRadioButton);
            this.shapeTypePanel.Location = new System.Drawing.Point(29, 24);
            this.shapeTypePanel.Name = "shapeTypePanel";
            this.shapeTypePanel.Size = new System.Drawing.Size(170, 103);
            this.shapeTypePanel.TabIndex = 1;
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Location = new System.Drawing.Point(17, 72);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.circleRadioButton.TabIndex = 2;
            this.circleRadioButton.Text = "Circle";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(17, 49);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(59, 17);
            this.squareRadioButton.TabIndex = 1;
            this.squareRadioButton.Text = "Square";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shape Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectColour);
            this.panel1.Controls.Add(this.colourLabel);
            this.panel1.Controls.Add(this.widthEntry);
            this.panel1.Controls.Add(this.heightEntry);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.heightLabel);
            this.panel1.Controls.Add(this.yPositionEntry);
            this.panel1.Controls.Add(this.xPositionEntry);
            this.panel1.Controls.Add(this.yLabel);
            this.panel1.Controls.Add(this.xLabel);
            this.panel1.Controls.Add(this.positionPanel);
            this.panel1.Location = new System.Drawing.Point(278, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 155);
            this.panel1.TabIndex = 2;
            // 
            // selectColour
            // 
            this.selectColour.Location = new System.Drawing.Point(69, 126);
            this.selectColour.Name = "selectColour";
            this.selectColour.Size = new System.Drawing.Size(56, 22);
            this.selectColour.TabIndex = 13;
            this.selectColour.Text = "Colour";
            this.selectColour.UseVisualStyleBackColor = true;
            this.selectColour.Click += new System.EventHandler(this.selectColour_Click);
            // 
            // colourLabel
            // 
            this.colourLabel.AutoSize = true;
            this.colourLabel.Location = new System.Drawing.Point(5, 131);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(58, 13);
            this.colourLabel.TabIndex = 12;
            this.colourLabel.Text = "Customise:";
            // 
            // widthEntry
            // 
            this.widthEntry.Location = new System.Drawing.Point(69, 101);
            this.widthEntry.Name = "widthEntry";
            this.widthEntry.Size = new System.Drawing.Size(56, 20);
            this.widthEntry.TabIndex = 11;
            // 
            // heightEntry
            // 
            this.heightEntry.Location = new System.Drawing.Point(69, 75);
            this.heightEntry.Name = "heightEntry";
            this.heightEntry.Size = new System.Drawing.Size(56, 20);
            this.heightEntry.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(20, 76);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height:";
            // 
            // yPositionEntry
            // 
            this.yPositionEntry.Location = new System.Drawing.Point(69, 46);
            this.yPositionEntry.Name = "yPositionEntry";
            this.yPositionEntry.Size = new System.Drawing.Size(56, 20);
            this.yPositionEntry.TabIndex = 7;
            // 
            // xPositionEntry
            // 
            this.xPositionEntry.Location = new System.Drawing.Point(69, 19);
            this.xPositionEntry.Name = "xPositionEntry";
            this.xPositionEntry.Size = new System.Drawing.Size(56, 20);
            this.xPositionEntry.TabIndex = 6;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(46, 53);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 13);
            this.yLabel.TabIndex = 5;
            this.yLabel.Text = "Y:";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(46, 22);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 13);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "X:";
            // 
            // positionPanel
            // 
            this.positionPanel.AutoSize = true;
            this.positionPanel.Location = new System.Drawing.Point(17, 0);
            this.positionPanel.Name = "positionPanel";
            this.positionPanel.Size = new System.Drawing.Size(85, 13);
            this.positionPanel.TabIndex = 3;
            this.positionPanel.Text = "Shape Attributes";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addBtn.Location = new System.Drawing.Point(131, 197);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(87, 35);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelBtn.Location = new System.Drawing.Point(278, 197);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 35);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 266);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeTypePanel);
            this.Name = "AddShape";
            this.Text = "Add Shape";
            this.shapeTypePanel.ResumeLayout(false);
            this.shapeTypePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton triangleRadioButton;
        private System.Windows.Forms.ColorDialog colourDialog;
        private System.Windows.Forms.Panel shapeTypePanel;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label positionPanel;
        private System.Windows.Forms.TextBox yPositionEntry;
        private System.Windows.Forms.TextBox xPositionEntry;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox widthEntry;
        private System.Windows.Forms.TextBox heightEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.Button selectColour;
    }
}