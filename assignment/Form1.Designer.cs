namespace assignment
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.sideMenu = new Guna.UI.WinForms.GunaPanel();
            this.MathSubPanel = new Guna.UI.WinForms.GunaPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MathButton = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.mainPan = new Guna.UI.WinForms.GunaPanel();
            this.BtnExit = new Guna.UI.WinForms.GunaImageButton();
            this.CLEARbtn = new Guna.UI.WinForms.GunaGradientButton();
            this.nested1 = new assignment.Nested();
            this.multiplication1 = new assignment.Multiplication();
            this.comparison1 = new assignment.Comparison();
            this.calculator1 = new assignment.Calculator();
            this.sideMenu.SuspendLayout();
            this.MathSubPanel.SuspendLayout();
            this.mainPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.sideMenu.Controls.Add(this.MathSubPanel);
            this.sideMenu.Controls.Add(this.MathButton);
            this.sideMenu.Controls.Add(this.gunaPanel1);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(161, 446);
            this.sideMenu.TabIndex = 0;
            // 
            // MathSubPanel
            // 
            this.MathSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.MathSubPanel.Controls.Add(this.button4);
            this.MathSubPanel.Controls.Add(this.button3);
            this.MathSubPanel.Controls.Add(this.button2);
            this.MathSubPanel.Controls.Add(this.button1);
            this.MathSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MathSubPanel.Location = new System.Drawing.Point(0, 128);
            this.MathSubPanel.Name = "MathSubPanel";
            this.MathSubPanel.Size = new System.Drawing.Size(161, 187);
            this.MathSubPanel.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Location = new System.Drawing.Point(0, 138);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(161, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nested";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(0, 92);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(161, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Multiplication";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Location = new System.Drawing.Point(0, 46);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(161, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Comparison";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(161, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MathButton
            // 
            this.MathButton.AnimationHoverSpeed = 0.07F;
            this.MathButton.AnimationSpeed = 0.03F;
            this.MathButton.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.MathButton.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.MathButton.BorderColor = System.Drawing.Color.Black;
            this.MathButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MathButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MathButton.FocusedColor = System.Drawing.Color.Empty;
            this.MathButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MathButton.ForeColor = System.Drawing.Color.White;
            this.MathButton.Image = null;
            this.MathButton.ImageSize = new System.Drawing.Size(20, 20);
            this.MathButton.Location = new System.Drawing.Point(0, 76);
            this.MathButton.Name = "MathButton";
            this.MathButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.MathButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.MathButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.MathButton.OnHoverForeColor = System.Drawing.Color.White;
            this.MathButton.OnHoverImage = null;
            this.MathButton.OnPressedColor = System.Drawing.Color.Black;
            this.MathButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MathButton.Size = new System.Drawing.Size(161, 52);
            this.MathButton.TabIndex = 2;
            this.MathButton.Text = "Math";
            this.MathButton.Click += new System.EventHandler(this.MathButton_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(161, 76);
            this.gunaPanel1.TabIndex = 1;
            // 
            // mainPan
            // 
            this.mainPan.Controls.Add(this.nested1);
            this.mainPan.Controls.Add(this.multiplication1);
            this.mainPan.Controls.Add(this.comparison1);
            this.mainPan.Controls.Add(this.calculator1);
            this.mainPan.Location = new System.Drawing.Point(210, 76);
            this.mainPan.Name = "mainPan";
            this.mainPan.Size = new System.Drawing.Size(428, 292);
            this.mainPan.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnExit.Image = null;
            this.BtnExit.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnExit.Location = new System.Drawing.Point(657, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.OnHoverImage = null;
            this.BtnExit.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.BtnExit.Size = new System.Drawing.Size(30, 27);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CLEARbtn
            // 
            this.CLEARbtn.AnimationHoverSpeed = 0.07F;
            this.CLEARbtn.AnimationSpeed = 0.03F;
            this.CLEARbtn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.CLEARbtn.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.CLEARbtn.BorderColor = System.Drawing.Color.Black;
            this.CLEARbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CLEARbtn.FocusedColor = System.Drawing.Color.Empty;
            this.CLEARbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CLEARbtn.ForeColor = System.Drawing.Color.White;
            this.CLEARbtn.Image = null;
            this.CLEARbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.CLEARbtn.Location = new System.Drawing.Point(601, 392);
            this.CLEARbtn.Name = "CLEARbtn";
            this.CLEARbtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.CLEARbtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.CLEARbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CLEARbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CLEARbtn.OnHoverImage = null;
            this.CLEARbtn.OnPressedColor = System.Drawing.Color.Black;
            this.CLEARbtn.Size = new System.Drawing.Size(86, 42);
            this.CLEARbtn.TabIndex = 5;
            this.CLEARbtn.Text = "CLEAR";
            this.CLEARbtn.Click += new System.EventHandler(this.CLEARbtn_Click);
            // 
            // nested1
            // 
            this.nested1.BackColor = System.Drawing.Color.Black;
            this.nested1.ForeColor = System.Drawing.Color.White;
            this.nested1.Location = new System.Drawing.Point(0, 0);
            this.nested1.Name = "nested1";
            this.nested1.Size = new System.Drawing.Size(428, 292);
            this.nested1.TabIndex = 3;
            // 
            // multiplication1
            // 
            this.multiplication1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.multiplication1.Location = new System.Drawing.Point(0, 0);
            this.multiplication1.Name = "multiplication1";
            this.multiplication1.Size = new System.Drawing.Size(428, 292);
            this.multiplication1.TabIndex = 2;
            // 
            // comparison1
            // 
            this.comparison1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.comparison1.Location = new System.Drawing.Point(0, 0);
            this.comparison1.Name = "comparison1";
            this.comparison1.Size = new System.Drawing.Size(428, 292);
            this.comparison1.TabIndex = 1;
            // 
            // calculator1
            // 
            this.calculator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.calculator1.Location = new System.Drawing.Point(0, 0);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(428, 292);
            this.calculator1.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(699, 446);
            this.Controls.Add(this.CLEARbtn);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.mainPan);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.sideMenu.ResumeLayout(false);
            this.MathSubPanel.ResumeLayout(false);
            this.mainPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel sideMenu;
        private Guna.UI.WinForms.GunaPanel MathSubPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaGradientButton MathButton;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel mainPan;
        private Guna.UI.WinForms.GunaImageButton BtnExit;
        private Guna.UI.WinForms.GunaGradientButton CLEARbtn;
        private Calculator calculator1;
        private Comparison comparison1;
        private Multiplication multiplication1;
        private Nested nested1;
    }
}

