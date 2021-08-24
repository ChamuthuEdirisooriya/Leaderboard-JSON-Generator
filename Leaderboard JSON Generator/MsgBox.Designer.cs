
namespace Leaderboard_JSON_Generator
{
    partial class MsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.okButton = new Guna.UI2.WinForms.Guna2Button();
            this.outputButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.okErrorButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton.DisabledState.Parent = this.closeButton;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.closeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.closeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(476, 10);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.BorderRadius = 0;
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(47, 43);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.Font = new System.Drawing.Font("Titillium Web", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel1.Location = new System.Drawing.Point(161, 49);
            this.errorLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(199, 36);
            this.errorLabel1.TabIndex = 100;
            this.errorLabel1.Text = "An Error Occurred";
            this.errorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Titillium Web", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.Location = new System.Drawing.Point(80, 76);
            this.errorLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(346, 36);
            this.errorLabel2.TabIndex = 20;
            this.errorLabel2.Text = "Please Recheck the Spreadsheet";
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Titillium Web", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.Location = new System.Drawing.Point(92, 60);
            this.successLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(328, 36);
            this.successLabel.TabIndex = 99;
            this.successLabel.Text = "JSON File Created Successfully";
            // 
            // okButton
            // 
            this.okButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.okButton.BorderRadius = 6;
            this.okButton.BorderThickness = 2;
            this.okButton.CheckedState.Parent = this.okButton;
            this.okButton.CustomImages.Parent = this.okButton;
            this.okButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okButton.DisabledState.Parent = this.okButton;
            this.okButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.okButton.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.okButton.HoverState.Parent = this.okButton;
            this.okButton.Location = new System.Drawing.Point(79, 128);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.ShadowDecoration.Parent = this.okButton;
            this.okButton.Size = new System.Drawing.Size(100, 43);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // outputButton
            // 
            this.outputButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.outputButton.BorderRadius = 6;
            this.outputButton.BorderThickness = 2;
            this.outputButton.CheckedState.Parent = this.outputButton;
            this.outputButton.CustomImages.Parent = this.outputButton;
            this.outputButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.outputButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.outputButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.outputButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.outputButton.DisabledState.Parent = this.outputButton;
            this.outputButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.outputButton.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.outputButton.HoverState.Parent = this.outputButton;
            this.outputButton.Location = new System.Drawing.Point(205, 128);
            this.outputButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputButton.Name = "outputButton";
            this.outputButton.ShadowDecoration.Parent = this.outputButton;
            this.outputButton.Size = new System.Drawing.Size(251, 43);
            this.outputButton.TabIndex = 1;
            this.outputButton.Text = "OPEN OUTPUT FOLDER";
            this.outputButton.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2ShadowPanel1.Controls.Add(this.okErrorButton);
            this.guna2ShadowPanel1.Controls.Add(this.successLabel);
            this.guna2ShadowPanel1.Controls.Add(this.closeButton);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(533, 215);
            this.guna2ShadowPanel1.TabIndex = 101;
            // 
            // okErrorButton
            // 
            this.okErrorButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.okErrorButton.BorderRadius = 6;
            this.okErrorButton.BorderThickness = 2;
            this.okErrorButton.CheckedState.Parent = this.okErrorButton;
            this.okErrorButton.CustomImages.Parent = this.okErrorButton;
            this.okErrorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okErrorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okErrorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okErrorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okErrorButton.DisabledState.Parent = this.okErrorButton;
            this.okErrorButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.okErrorButton.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okErrorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.okErrorButton.HoverState.Parent = this.okErrorButton;
            this.okErrorButton.Location = new System.Drawing.Point(217, 128);
            this.okErrorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okErrorButton.Name = "okErrorButton";
            this.okErrorButton.ShadowDecoration.Parent = this.okErrorButton;
            this.okErrorButton.Size = new System.Drawing.Size(100, 43);
            this.okErrorButton.TabIndex = 100;
            this.okErrorButton.Text = "OK";
            this.okErrorButton.Click += new System.EventHandler(this.okErrorButton_Click);
            // 
            // MsgBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(533, 215);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MsgBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            this.Load += new System.EventHandler(this.MsgBox_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MsgBox_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MsgBox_MouseDown);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        public Guna.UI2.WinForms.Guna2Button okErrorButton;
        public System.Windows.Forms.Label errorLabel2;
        public System.Windows.Forms.Label errorLabel1;
        public Guna.UI2.WinForms.Guna2Button outputButton;
        public Guna.UI2.WinForms.Guna2Button okButton;
        public System.Windows.Forms.Label successLabel;
        public Guna.UI2.WinForms.Guna2Button closeButton;
    }
}