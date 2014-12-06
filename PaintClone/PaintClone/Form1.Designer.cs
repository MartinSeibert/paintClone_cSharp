namespace PaintClone
{
    partial class Form1
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
            this.controls = new System.Windows.Forms.Panel();
            this.alphaSlider = new System.Windows.Forms.TrackBar();
            this.lineButton = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawColor = new System.Windows.Forms.Panel();
            this.thicknessSlider = new System.Windows.Forms.TrackBar();
            this.greenSlider = new System.Windows.Forms.TrackBar();
            this.redSlider = new System.Windows.Forms.TrackBar();
            this.blueSlider = new System.Windows.Forms.TrackBar();
            this.controls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaSlider)).BeginInit();
            this.drawPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // controls
            // 
            this.controls.BackColor = System.Drawing.SystemColors.Menu;
            this.controls.Controls.Add(this.alphaSlider);
            this.controls.Controls.Add(this.lineButton);
            this.controls.Dock = System.Windows.Forms.DockStyle.Top;
            this.controls.Location = new System.Drawing.Point(0, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(556, 60);
            this.controls.TabIndex = 0;
            this.controls.Paint += new System.Windows.Forms.PaintEventHandler(this.controls_Paint);
            // 
            // alphaSlider
            // 
            this.alphaSlider.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.alphaSlider.Location = new System.Drawing.Point(0, 0);
            this.alphaSlider.Maximum = 255;
            this.alphaSlider.Name = "alphaSlider";
            this.alphaSlider.Size = new System.Drawing.Size(104, 45);
            this.alphaSlider.TabIndex = 1;
            // 
            // lineButton
            // 
            this.lineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineButton.Location = new System.Drawing.Point(121, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(346, 23);
            this.lineButton.TabIndex = 0;
            this.lineButton.Text = "line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.AccessibleDescription = "drawPanel";
            this.drawPanel.AccessibleName = "drawPanel";
            this.drawPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.drawPanel.Controls.Add(this.panel1);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(0, 60);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(556, 262);
            this.drawPanel.TabIndex = 1;
            this.drawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseDown);
            this.drawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.drawColor);
            this.panel1.Controls.Add(this.thicknessSlider);
            this.panel1.Controls.Add(this.greenSlider);
            this.panel1.Controls.Add(this.redSlider);
            this.panel1.Controls.Add(this.blueSlider);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 46);
            this.panel1.TabIndex = 0;
            // 
            // drawColor
            // 
            this.drawColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drawColor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.drawColor.Location = new System.Drawing.Point(0, 0);
            this.drawColor.Margin = new System.Windows.Forms.Padding(0);
            this.drawColor.Name = "drawColor";
            this.drawColor.Size = new System.Drawing.Size(107, 47);
            this.drawColor.TabIndex = 4;
            // 
            // thicknessSlider
            // 
            this.thicknessSlider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.thicknessSlider.BackColor = System.Drawing.SystemColors.Highlight;
            this.thicknessSlider.Location = new System.Drawing.Point(439, 2);
            this.thicknessSlider.Margin = new System.Windows.Forms.Padding(0);
            this.thicknessSlider.Maximum = 100;
            this.thicknessSlider.Name = "thicknessSlider";
            this.thicknessSlider.Size = new System.Drawing.Size(112, 45);
            this.thicknessSlider.TabIndex = 3;
            this.thicknessSlider.Scroll += new System.EventHandler(this.thicknessSlider_Scroll);
            // 
            // greenSlider
            // 
            this.greenSlider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.greenSlider.BackColor = System.Drawing.Color.Green;
            this.greenSlider.Location = new System.Drawing.Point(219, 1);
            this.greenSlider.Margin = new System.Windows.Forms.Padding(0);
            this.greenSlider.Maximum = 255;
            this.greenSlider.Name = "greenSlider";
            this.greenSlider.Size = new System.Drawing.Size(110, 45);
            this.greenSlider.TabIndex = 2;
            this.greenSlider.Scroll += new System.EventHandler(this.greenSlider_Scroll);
            // 
            // redSlider
            // 
            this.redSlider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.redSlider.BackColor = System.Drawing.Color.Red;
            this.redSlider.Location = new System.Drawing.Point(112, 1);
            this.redSlider.Margin = new System.Windows.Forms.Padding(0);
            this.redSlider.Maximum = 255;
            this.redSlider.Name = "redSlider";
            this.redSlider.Size = new System.Drawing.Size(107, 45);
            this.redSlider.TabIndex = 1;
            this.redSlider.Scroll += new System.EventHandler(this.redSlider_Scroll);
            // 
            // blueSlider
            // 
            this.blueSlider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.blueSlider.BackColor = System.Drawing.Color.Blue;
            this.blueSlider.Location = new System.Drawing.Point(329, 0);
            this.blueSlider.Margin = new System.Windows.Forms.Padding(0);
            this.blueSlider.Maximum = 255;
            this.blueSlider.Name = "blueSlider";
            this.blueSlider.Size = new System.Drawing.Size(110, 45);
            this.blueSlider.TabIndex = 0;
            this.blueSlider.Scroll += new System.EventHandler(this.blueSlider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 322);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.controls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.controls.ResumeLayout(false);
            this.controls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaSlider)).EndInit();
            this.drawPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Button lineButton;
        public System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel drawColor;
        private System.Windows.Forms.TrackBar thicknessSlider;
        private System.Windows.Forms.TrackBar greenSlider;
        private System.Windows.Forms.TrackBar redSlider;
        private System.Windows.Forms.TrackBar blueSlider;
        private System.Windows.Forms.TrackBar alphaSlider;
    }
}

