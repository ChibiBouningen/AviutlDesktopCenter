namespace AviutlDesktopCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newAviutl_button = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.profileTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer.Panel1MinSize = 250;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.settingButton);
            this.splitContainer.Panel2.Controls.Add(this.profileTitleLabel);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.newAviutl_button);
            this.splitContainer1.Size = new System.Drawing.Size(250, 450);
            this.splitContainer1.SplitterDistance = 424;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // newAviutl_button
            // 
            this.newAviutl_button.AutoSize = true;
            this.newAviutl_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newAviutl_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newAviutl_button.FlatAppearance.BorderSize = 0;
            this.newAviutl_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAviutl_button.Location = new System.Drawing.Point(0, 0);
            this.newAviutl_button.Margin = new System.Windows.Forms.Padding(0);
            this.newAviutl_button.Name = "newAviutl_button";
            this.newAviutl_button.Size = new System.Drawing.Size(250, 25);
            this.newAviutl_button.TabIndex = 0;
            this.newAviutl_button.Text = "+";
            this.newAviutl_button.UseVisualStyleBackColor = false;
            this.newAviutl_button.Click += new System.EventHandler(this.newAviutl_button_Click);
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingButton.Location = new System.Drawing.Point(418, 48);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(75, 23);
            this.settingButton.TabIndex = 1;
            this.settingButton.Text = "設定";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // profileTitleLabel
            // 
            this.profileTitleLabel.AutoSize = true;
            this.profileTitleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileTitleLabel.Location = new System.Drawing.Point(123, 44);
            this.profileTitleLabel.Name = "profileTitleLabel";
            this.profileTitleLabel.Size = new System.Drawing.Size(63, 25);
            this.profileTitleLabel.TabIndex = 0;
            this.profileTitleLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private SplitContainer splitContainer1;
        private Button newAviutl_button;
        private Panel panel1;
        private PictureBox pictureBox1;
        public Label profileTitleLabel;
        private Button settingButton;
    }
}