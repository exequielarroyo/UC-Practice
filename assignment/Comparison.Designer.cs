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
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.ForeColor = System.Drawing.Color.Silver;
            this.Width.Location = new System.Drawing.Point(14, 90);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(137, 23);
            this.Width.TabIndex = 0;
            this.Width.Text = "First Number";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.Height.ForeColor = System.Drawing.Color.Silver;
            this.Height.Location = new System.Drawing.Point(14, 133);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(165, 23);
            this.Height.TabIndex = 1;
            this.Height.Text = "Second Number";
            // 
            // firstNumberTextbox
            // 
            this.firstNumberTextbox.BackColor = System.Drawing.Color.White;
            this.firstNumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNumberTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.firstNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNumberTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.firstNumberTextbox.Location = new System.Drawing.Point(226, 87);
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
            this.secondNumberTextbox.Location = new System.Drawing.Point(226, 130);
            this.secondNumberTextbox.Name = "secondNumberTextbox";
            this.secondNumberTextbox.PasswordChar = '\0';
            this.secondNumberTextbox.Size = new System.Drawing.Size(160, 26);
            this.secondNumberTextbox.TabIndex = 3;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.resultLabel.ForeColor = System.Drawing.Color.Silver;
            this.resultLabel.Location = new System.Drawing.Point(179, 187);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(45, 23);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "-----";
            // 
            // compareButton
            // 
            this.compareButton.AnimationHoverSpeed = 0.07F;
            this.compareButton.AnimationSpeed = 0.03F;
            this.compareButton.BackColor = System.Drawing.Color.Transparent;
            this.compareButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.compareButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.compareButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.compareButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.compareButton.CheckedForeColor = System.Drawing.Color.Silver;
            this.compareButton.CheckedImage = null;
            this.compareButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.compareButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.compareButton.FocusedColor = System.Drawing.Color.Empty;
            this.compareButton.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.ForeColor = System.Drawing.Color.White;
            this.compareButton.Image = null;
            this.compareButton.ImageSize = new System.Drawing.Size(20, 20);
            this.compareButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.compareButton.Location = new System.Drawing.Point(302, 234);
            this.compareButton.Name = "compareButton";
            this.compareButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.compareButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.compareButton.OnHoverForeColor = System.Drawing.Color.White;
            this.compareButton.OnHoverImage = null;
            this.compareButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.compareButton.OnPressedColor = System.Drawing.Color.Black;
            this.compareButton.Radius = 10;
            this.compareButton.Size = new System.Drawing.Size(108, 42);
            this.compareButton.TabIndex = 6;
            this.compareButton.Text = "Show Result";
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(428, 53);
            this.gunaGradientPanel1.TabIndex = 7;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(142, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(151, 23);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "COMPARISON";
            // 
            // Comparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondNumberTextbox);
            this.Controls.Add(this.firstNumberTextbox);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Name = "Comparison";
            this.Size = new System.Drawing.Size(428, 292);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
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
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}
