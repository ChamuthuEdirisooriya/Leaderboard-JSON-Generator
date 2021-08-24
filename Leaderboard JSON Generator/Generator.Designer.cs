
namespace Leaderboard_JSON_Generator
{
    partial class Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.jsonSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pathTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.browseButton = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2Button();
            this.browseDialog = new System.Windows.Forms.OpenFileDialog();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(389, 53);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 186);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // jsonSaveLocation
            // 
            this.jsonSaveLocation.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.BorderThickness = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2Button1.Font = new System.Drawing.Font("Titillium Web", 14.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(407, 390);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(233, 62);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "GENERATE JSON";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pathTextbox
            // 
            this.pathTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.pathTextbox.BorderRadius = 6;
            this.pathTextbox.BorderThickness = 5;
            this.pathTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pathTextbox.DefaultText = "";
            this.pathTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.pathTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.pathTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.pathTextbox.DisabledState.Parent = this.pathTextbox;
            this.pathTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.pathTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.pathTextbox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.pathTextbox.FocusedState.Parent = this.pathTextbox;
            this.pathTextbox.Font = new System.Drawing.Font("Titillium Web", 14.25F, System.Drawing.FontStyle.Bold);
            this.pathTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.pathTextbox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.pathTextbox.HoverState.Parent = this.pathTextbox;
            this.pathTextbox.Location = new System.Drawing.Point(163, 300);
            this.pathTextbox.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.PasswordChar = '\0';
            this.pathTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.pathTextbox.PlaceholderText = "Select the Leaderboard Spreadsheet";
            this.pathTextbox.SelectedText = "";
            this.pathTextbox.ShadowDecoration.Parent = this.pathTextbox;
            this.pathTextbox.ShortcutsEnabled = false;
            this.pathTextbox.Size = new System.Drawing.Size(549, 62);
            this.pathTextbox.TabIndex = 0;
            this.pathTextbox.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // browseButton
            // 
            this.browseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.browseButton.BorderRadius = 6;
            this.browseButton.BorderThickness = 5;
            this.browseButton.CheckedState.Parent = this.browseButton;
            this.browseButton.CustomImages.Parent = this.browseButton;
            this.browseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.browseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.browseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.browseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.browseButton.DisabledState.Parent = this.browseButton;
            this.browseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.browseButton.Font = new System.Drawing.Font("Titillium Web", 12F, System.Drawing.FontStyle.Bold);
            this.browseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.browseButton.HoverState.Parent = this.browseButton;
            this.browseButton.Location = new System.Drawing.Point(753, 300);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.ShadowDecoration.Parent = this.browseButton;
            this.browseButton.Size = new System.Drawing.Size(131, 62);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "BROWSE";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click_1);
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
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.closeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.closeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.closeButton.HoverState.Parent = this.closeButton;
            this.closeButton.Location = new System.Drawing.Point(980, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(67, 62);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // browseDialog
            // 
            this.browseDialog.DefaultExt = "xlsx";
            this.browseDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
            this.browseDialog.ReadOnlyChecked = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.HasFormShadow = false;
            // 
            // Generator
            // 
            this.AcceptButton = this.guna2Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1047, 523);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(209)))), ((int)(((byte)(184)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BITS \'21 Leaderboard JSON Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FolderBrowserDialog jsonSaveLocation;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox pathTextbox;
        private Guna.UI2.WinForms.Guna2Button browseButton;
        private Guna.UI2.WinForms.Guna2Button closeButton;
        private System.Windows.Forms.OpenFileDialog browseDialog;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}

