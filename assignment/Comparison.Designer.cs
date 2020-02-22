namespace assignment
{
    partial class Comparison
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparison));
            this.Width = new Guna.UI.WinForms.GunaLabel();
            this.Height = new Guna.UI.WinForms.GunaLabel();
            this.firstNumberTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.secondNumberTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.resultLabel = new Guna.UI.WinForms.GunaLabel();
            this.compareButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(4)))), ((int)(((byte)(2)))));
            this.Width.Location = new System.Drawing.Point(14, 62);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(146, 23);
            this.Width.TabIndex = 0;
            this.Width.Text = "Enter Number";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.Height.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(4)))), ((int)(((byte)(2)))));
            this.Height.Location = new System.Drawing.Point(14, 103);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(187, 23);
            this.Height.TabIndex = 1;
            this.Height.Text = "Enter 2nd Number";
            // 
            // firstNumberTextbox
            // 
            this.firstNumberTextbox.BackColor = System.Drawing.Color.White;
            this.firstNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNumberTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.firstNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNumberTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.firstNumberTextbox.Location = new System.Drawing.Point(226, 59);
            this.firstNumberTextbox.Name = "firstNumberTextbox";
            this.firstNumberTextbox.PasswordChar = '\0';
            this.firstNumberTextbox.Size = new System.Drawing.Size(160, 26);
            this.firstNumberTextbox.TabIndex = 2;
            // 
            // secondNumberTextbox
            // 
            this.secondNumberTextbox.BackColor = System.Drawing.Color.White;
            this.secondNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondNumberTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.secondNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.secondNumberTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.secondNumberTextbox.Location = new System.Drawing.Point(226, 100);
            this.secondNumberTextbox.Name = "secondNumberTextbox";
            this.secondNumberTextbox.PasswordChar = '\0';
            this.secondNumberTextbox.Size = new System.Drawing.Size(160, 26);
            this.secondNumberTextbox.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(203, 176);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(68, 15);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "gunaLabel1";
            // 
            // compareButton
            // 
            this.compareButton.AnimationHoverSpeed = 0.07F;
            this.compareButton.AnimationSpeed = 0.03F;
            this.compareButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.compareButton.BorderColor = System.Drawing.Color.Black;
            this.compareButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.compareButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.compareButton.CheckedForeColor = System.Drawing.Color.White;
            this.compareButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("compareButton.CheckedImage")));
            this.compareButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.compareButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.compareButton.FocusedColor = System.Drawing.Color.Empty;
            this.compareButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.compareButton.ForeColor = System.Drawing.Color.White;
            this.compareButton.Image = ((System.Drawing.Image)(resources.GetObject("compareButton.Image")));
            this.compareButton.ImageSize = new System.Drawing.Size(20, 20);
            this.compareButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.compareButton.Location = new System.Drawing.Point(206, 228);
            this.compareButton.Name = "compareButton";
            this.compareButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.compareButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.compareButton.OnHoverForeColor = System.Drawing.Color.White;
            this.compareButton.OnHoverImage = null;
            this.compareButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.compareButton.OnPressedColor = System.Drawing.Color.Black;
            this.compareButton.Size = new System.Drawing.Size(180, 42);
            this.compareButton.TabIndex = 6;
            this.compareButton.Text = "gunaAdvenceButton1";
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondNumberTextbox);
            this.Controls.Add(this.firstNumberTextbox);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Name = "Comparison";
            this.Size = new System.Drawing.Size(428, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel Width;
        private Guna.UI.WinForms.GunaLabel Height;
        private Guna.UI.WinForms.GunaLineTextBox firstNumberTextbox;
        private Guna.UI.WinForms.GunaLineTextBox secondNumberTextbox;
        private Guna.UI.WinForms.GunaLabel resultLabel;
        private Guna.UI.WinForms.GunaAdvenceButton compareButton;
    }
}
