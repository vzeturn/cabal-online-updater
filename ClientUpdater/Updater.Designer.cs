namespace ClientUpdater
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.StatusLable = new System.Windows.Forms.Label();
            this.percentLable = new System.Windows.Forms.Label();
            this.updaterWorker = new System.ComponentModel.BackgroundWorker();
            this.StopButton = new System.Windows.Forms.Button();
            this.FullCheckButton = new System.Windows.Forms.Button();
            this.CurrentProgBar = new System.Windows.Forms.PictureBox();
            this.SpeedLable = new System.Windows.Forms.Label();
            this.TotalProgBar = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.TotalLable = new System.Windows.Forms.Label();
            this.startGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLable
            // 
            this.StatusLable.AutoSize = true;
            this.StatusLable.BackColor = System.Drawing.Color.Transparent;
            this.StatusLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusLable.Location = new System.Drawing.Point(200, 443);
            this.StatusLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLable.Name = "StatusLable";
            this.StatusLable.Size = new System.Drawing.Size(0, 24);
            this.StatusLable.TabIndex = 3;
            this.StatusLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentLable
            // 
            this.percentLable.AutoSize = true;
            this.percentLable.BackColor = System.Drawing.Color.Transparent;
            this.percentLable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLable.ForeColor = System.Drawing.Color.Gold;
            this.percentLable.Location = new System.Drawing.Point(736, 480);
            this.percentLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.percentLable.Name = "percentLable";
            this.percentLable.Size = new System.Drawing.Size(0, 23);
            this.percentLable.TabIndex = 5;
            this.percentLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // updaterWorker
            // 
            this.updaterWorker.WorkerSupportsCancellation = true;
            this.updaterWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updaterWorker_DoWork);
            this.updaterWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.updaterWorker_ProgressChanged);
            this.updaterWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updaterWorker_RunWorkerCompleted);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.BackgroundImage = global::ClientUpdater.Properties.Resources.stop_enabled;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.No;
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(632, 583);
            this.StopButton.Margin = new System.Windows.Forms.Padding(0);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(69, 41);
            this.StopButton.TabIndex = 6;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FullCheckButton
            // 
            this.FullCheckButton.BackColor = System.Drawing.Color.Transparent;
            this.FullCheckButton.BackgroundImage = global::ClientUpdater.Properties.Resources.full_check_enabled;
            this.FullCheckButton.Cursor = System.Windows.Forms.Cursors.No;
            this.FullCheckButton.Enabled = false;
            this.FullCheckButton.Location = new System.Drawing.Point(717, 583);
            this.FullCheckButton.Margin = new System.Windows.Forms.Padding(0);
            this.FullCheckButton.Name = "FullCheckButton";
            this.FullCheckButton.Size = new System.Drawing.Size(115, 41);
            this.FullCheckButton.TabIndex = 7;
            this.FullCheckButton.UseVisualStyleBackColor = false;
            this.FullCheckButton.Click += new System.EventHandler(this.FullCheckButton_Click);
            // 
            // CurrentProgBar
            // 
            this.CurrentProgBar.BackColor = System.Drawing.Color.Transparent;
            this.CurrentProgBar.Image = global::ClientUpdater.Properties.Resources.File;
            this.CurrentProgBar.Location = new System.Drawing.Point(105, 573);
            this.CurrentProgBar.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentProgBar.Name = "CurrentProgBar";
            this.CurrentProgBar.Size = new System.Drawing.Size(499, 25);
            this.CurrentProgBar.TabIndex = 9;
            this.CurrentProgBar.TabStop = false;
            // 
            // SpeedLable
            // 
            this.SpeedLable.AutoSize = true;
            this.SpeedLable.BackColor = System.Drawing.Color.Transparent;
            this.SpeedLable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpeedLable.Location = new System.Drawing.Point(667, 449);
            this.SpeedLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeedLable.Name = "SpeedLable";
            this.SpeedLable.Size = new System.Drawing.Size(0, 17);
            this.SpeedLable.TabIndex = 10;
            this.SpeedLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalProgBar
            // 
            this.TotalProgBar.BackColor = System.Drawing.Color.Transparent;
            this.TotalProgBar.Image = global::ClientUpdater.Properties.Resources.Total;
            this.TotalProgBar.Location = new System.Drawing.Point(105, 606);
            this.TotalProgBar.Margin = new System.Windows.Forms.Padding(4);
            this.TotalProgBar.Name = "TotalProgBar";
            this.TotalProgBar.Size = new System.Drawing.Size(499, 25);
            this.TotalProgBar.TabIndex = 11;
            this.TotalProgBar.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(49, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 24);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(150, 9);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 24);
            this.linkLabel2.TabIndex = 16;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(266, 9);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(77, 24);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Activate";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(385, 9);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(56, 24);
            this.linkLabel4.TabIndex = 18;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Reset";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(562, 9);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(95, 24);
            this.linkLabel5.TabIndex = 19;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Web Shop";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.White;
            this.linkLabel6.Location = new System.Drawing.Point(682, 9);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(54, 24);
            this.linkLabel6.TabIndex = 20;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Login";
            this.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.White;
            this.linkLabel7.Location = new System.Drawing.Point(795, 9);
            this.linkLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(103, 24);
            this.linkLabel7.TabIndex = 21;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Downloads";
            this.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.White;
            this.linkLabel8.Location = new System.Drawing.Point(941, 9);
            this.linkLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(55, 24);
            this.linkLabel8.TabIndex = 22;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "News";
            this.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // TotalLable
            // 
            this.TotalLable.AutoSize = true;
            this.TotalLable.BackColor = System.Drawing.Color.Transparent;
            this.TotalLable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLable.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalLable.Location = new System.Drawing.Point(736, 527);
            this.TotalLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(0, 23);
            this.TotalLable.TabIndex = 23;
            this.TotalLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startGameBtn
            // 
            this.startGameBtn.BackgroundImage = global::ClientUpdater.Properties.Resources.startEnabled;
            this.startGameBtn.Cursor = System.Windows.Forms.Cursors.No;
            this.startGameBtn.Enabled = false;
            this.startGameBtn.Location = new System.Drawing.Point(869, 583);
            this.startGameBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(170, 41);
            this.startGameBtn.TabIndex = 24;
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ClientUpdater.Properties.Resources.IT_solutions_smarter_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1067, 633);
            this.Controls.Add(this.startGameBtn);
            this.Controls.Add(this.TotalLable);
            this.Controls.Add(this.percentLable);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TotalProgBar);
            this.Controls.Add(this.SpeedLable);
            this.Controls.Add(this.CurrentProgBar);
            this.Controls.Add(this.StatusLable);
            this.Controls.Add(this.FullCheckButton);
            this.Controls.Add(this.StopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SR Updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Updater_FormClosing);
            this.Load += new System.EventHandler(this.Updater_Load);
            this.Shown += new System.EventHandler(this.Updater_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Updater_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentProgBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalProgBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLable;
        private System.Windows.Forms.Label percentLable;
        private System.ComponentModel.BackgroundWorker updaterWorker;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FullCheckButton;
        private System.Windows.Forms.PictureBox CurrentProgBar;
        private System.Windows.Forms.Label SpeedLable;
        private System.Windows.Forms.PictureBox TotalProgBar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.Button startGameBtn;
    }
}

