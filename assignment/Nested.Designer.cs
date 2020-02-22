namespace assignment
{
    partial class Nested
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nested));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.widthTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.lengthTextbox = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.simbolCombobox = new Guna.UI.WinForms.GunaComboBox();
            this.resultLabel = new Guna.UI.WinForms.GunaLabel();
            this.displayButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(26, 66);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(43, 16);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Width";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(26, 98);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(46, 16);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Height";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.gunaLabel3.Location = new System.Drawing.Point(26, 136);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 16);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Select Symbol";
            // 
            // widthTextbox
            // 
            this.widthTextbox.BackColor = System.Drawing.Color.White;
            this.widthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.widthTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.widthTextbox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthTextbox.ForeColor = System.Drawing.Color.Black;
            this.widthTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.widthTextbox.Location = new System.Drawing.Point(200, 66);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.PasswordChar = '\0';
            this.widthTextbox.Size = new System.Drawing.Size(160, 26);
            this.widthTextbox.TabIndex = 3;
            // 
            // lengthTextbox
            // 
            this.lengthTextbox.BackColor = System.Drawing.Color.White;
            this.lengthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lengthTextbox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lengthTextbox.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTextbox.ForeColor = System.Drawing.Color.Black;
            this.lengthTextbox.LineColor = System.Drawing.Color.Gainsboro;
            this.lengthTextbox.Location = new System.Drawing.Point(200, 99);
            this.lengthTextbox.Name = "lengthTextbox";
            this.lengthTextbox.PasswordChar = '\0';
            this.lengthTextbox.Size = new System.Drawing.Size(160, 26);
            this.lengthTextbox.TabIndex = 4;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // simbolCombobox
            // 
            this.simbolCombobox.BackColor = System.Drawing.Color.Transparent;
            this.simbolCombobox.BaseColor = System.Drawing.Color.White;
            this.simbolCombobox.BorderColor = System.Drawing.Color.Silver;
            this.simbolCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.simbolCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.simbolCombobox.FocusedColor = System.Drawing.Color.Empty;
            this.simbolCombobox.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simbolCombobox.ForeColor = System.Drawing.Color.Black;
            this.simbolCombobox.FormattingEnabled = true;
            this.simbolCombobox.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*",
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "_",
            "=",
            "{",
            "}",
            "[",
            "]",
            "\\",
            "|",
            ":",
            ";",
            "\"",
            "\'",
            "<",
            ">",
            ",",
            ".",
            "?",
            "/"});
            this.simbolCombobox.Location = new System.Drawing.Point(200, 131);
            this.simbolCombobox.Name = "simbolCombobox";
            this.simbolCombobox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.simbolCombobox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.simbolCombobox.Size = new System.Drawing.Size(160, 24);
            this.simbolCombobox.StartIndex = 0;
            this.simbolCombobox.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resultLabel.Location = new System.Drawing.Point(26, 161);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 6;
            // 
            // displayButton
            // 
            this.displayButton.AnimationHoverSpeed = 0.07F;
            this.displayButton.AnimationSpeed = 0.03F;
            this.displayButton.BackColor = System.Drawing.Color.Transparent;
            this.displayButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.displayButton.BorderColor = System.Drawing.Color.Black;
            this.displayButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.displayButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.displayButton.CheckedForeColor = System.Drawing.Color.White;
            this.displayButton.CheckedImage = null;
            this.displayButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.displayButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.displayButton.FocusedColor = System.Drawing.Color.Empty;
            this.displayButton.Font = new System.Drawing.Font("Rockwell", 11.25F);
            this.displayButton.ForeColor = System.Drawing.Color.White;
            this.displayButton.Image = null;
            this.displayButton.ImageSize = new System.Drawing.Size(20, 20);
            this.displayButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.displayButton.Location = new System.Drawing.Point(304, 233);
            this.displayButton.Name = "displayButton";
            this.displayButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.displayButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.displayButton.OnHoverForeColor = System.Drawing.Color.White;
            this.displayButton.OnHoverImage = null;
            this.displayButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.displayButton.OnPressedColor = System.Drawing.Color.Black;
            this.displayButton.Radius = 10;
            this.displayButton.Size = new System.Drawing.Size(108, 42);
            this.displayButton.TabIndex = 7;
            this.displayButton.Text = "Show Result";
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel4);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(428, 53);
            this.gunaGradientPanel1.TabIndex = 9;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(132, 18);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(184, 23);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "MULTIPLICATION";
            // 
            // Nested
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.simbolCombobox);
            this.Controls.Add(this.lengthTextbox);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Nested";
            this.Size = new System.Drawing.Size(428, 292);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox widthTextbox;
        private Guna.UI.WinForms.GunaLineTextBox lengthTextbox;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaComboBox simbolCombobox;
        private Guna.UI.WinForms.GunaLabel resultLabel;
        private Guna.UI.WinForms.GunaAdvenceButton displayButton;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}
