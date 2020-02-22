namespace assignment
{
    partial class Multiplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplication));
            this.firsnumberLabel = new Guna.UI.WinForms.GunaLabel();
            this.secondnumberLabel = new Guna.UI.WinForms.GunaLabel();
            this.firstnumberTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.secondnumberTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.answerLabel = new Guna.UI.WinForms.GunaLabel();
            this.calcuButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // firsnumberLabel
            // 
            this.firsnumberLabel.AutoSize = true;
            this.firsnumberLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firsnumberLabel.ForeColor = System.Drawing.Color.White;
            this.firsnumberLabel.Location = new System.Drawing.Point(30, 59);
            this.firsnumberLabel.Name = "firsnumberLabel";
            this.firsnumberLabel.Size = new System.Drawing.Size(137, 23);
            this.firsnumberLabel.TabIndex = 1;
            this.firsnumberLabel.Text = "First Number";
            // 
            // secondnumberLabel
            // 
            this.secondnumberLabel.AutoSize = true;
            this.secondnumberLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondnumberLabel.ForeColor = System.Drawing.Color.White;
            this.secondnumberLabel.Location = new System.Drawing.Point(30, 118);
            this.secondnumberLabel.Name = "secondnumberLabel";
            this.secondnumberLabel.Size = new System.Drawing.Size(165, 23);
            this.secondnumberLabel.TabIndex = 2;
            this.secondnumberLabel.Text = "Second Number";
            // 
            // firstnumberTextbox
            // 
            this.firstnumberTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.firstnumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstnumberTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.firstnumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstnumberTextbox.ForeColor = System.Drawing.Color.White;
            this.firstnumberTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.firstnumberTextbox.Location = new System.Drawing.Point(229, 56);
            this.firstnumberTextbox.Name = "firstnumberTextbox";
            this.firstnumberTextbox.PasswordChar = '\0';
            this.firstnumberTextbox.Size = new System.Drawing.Size(160, 26);
            this.firstnumberTextbox.TabIndex = 3;
            // 
            // secondnumberTextbox
            // 
            this.secondnumberTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.secondnumberTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secondnumberTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.secondnumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.secondnumberTextbox.ForeColor = System.Drawing.Color.White;
            this.secondnumberTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.secondnumberTextbox.Location = new System.Drawing.Point(229, 115);
            this.secondnumberTextbox.Name = "secondnumberTextbox";
            this.secondnumberTextbox.PasswordChar = '\0';
            this.secondnumberTextbox.Size = new System.Drawing.Size(160, 26);
            this.secondnumberTextbox.TabIndex = 4;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(151, 194);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(31, 23);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.Text = "---";
            // 
            // calcuButton
            // 
            this.calcuButton.AnimationHoverSpeed = 0.07F;
            this.calcuButton.AnimationSpeed = 0.03F;
            this.calcuButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.calcuButton.BorderColor = System.Drawing.Color.Black;
            this.calcuButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.calcuButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.calcuButton.CheckedForeColor = System.Drawing.Color.White;
            this.calcuButton.CheckedImage = ((System.Drawing.Image)(resources.GetObject("calcuButton.CheckedImage")));
            this.calcuButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.calcuButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.calcuButton.FocusedColor = System.Drawing.Color.Empty;
            this.calcuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calcuButton.ForeColor = System.Drawing.Color.White;
            this.calcuButton.Image = ((System.Drawing.Image)(resources.GetObject("calcuButton.Image")));
            this.calcuButton.ImageSize = new System.Drawing.Size(20, 20);
            this.calcuButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.calcuButton.Location = new System.Drawing.Point(229, 234);
            this.calcuButton.Name = "calcuButton";
            this.calcuButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.calcuButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.calcuButton.OnHoverForeColor = System.Drawing.Color.White;
            this.calcuButton.OnHoverImage = null;
            this.calcuButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.calcuButton.OnPressedColor = System.Drawing.Color.Black;
            this.calcuButton.Size = new System.Drawing.Size(180, 42);
            this.calcuButton.TabIndex = 6;
            this.calcuButton.Text = "gunaAdvenceButton1";
            this.calcuButton.Click += new System.EventHandler(this.calcuButton_Click);
            // 
            // Multiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.Controls.Add(this.calcuButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.secondnumberTextbox);
            this.Controls.Add(this.firstnumberTextbox);
            this.Controls.Add(this.secondnumberLabel);
            this.Controls.Add(this.firsnumberLabel);
            this.Name = "Multiplication";
            this.Size = new System.Drawing.Size(428, 292);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel firsnumberLabel;
        private Guna.UI.WinForms.GunaLabel secondnumberLabel;
        private Guna.UI.WinForms.GunaLineTextBox firstnumberTextbox;
        private Guna.UI.WinForms.GunaLineTextBox secondnumberTextbox;
        private Guna.UI.WinForms.GunaLabel answerLabel;
        private Guna.UI.WinForms.GunaAdvenceButton calcuButton;
    }
}
