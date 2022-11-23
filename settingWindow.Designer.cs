namespace AviutlDesktopCenter
{
    partial class settingWindow
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.propertySet = new System.Windows.Forms.TabPage();
            this.profNameBox = new System.Windows.Forms.TextBox();
            this.profIconBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.OverallSet = new System.Windows.Forms.TabPage();
            this.propPriorityBox = new System.Windows.Forms.ComboBox();
            this.tabPage.SuspendLayout();
            this.propertySet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.propertySet);
            this.tabPage.Controls.Add(this.OverallSet);
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.Location = new System.Drawing.Point(0, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(390, 292);
            this.tabPage.TabIndex = 0;
            // 
            // propertySet
            // 
            this.propertySet.BackColor = System.Drawing.Color.White;
            this.propertySet.Controls.Add(this.propPriorityBox);
            this.propertySet.Controls.Add(this.profNameBox);
            this.propertySet.Controls.Add(this.profIconBox);
            this.propertySet.Controls.Add(this.saveButton);
            this.propertySet.Location = new System.Drawing.Point(4, 24);
            this.propertySet.Name = "propertySet";
            this.propertySet.Padding = new System.Windows.Forms.Padding(3);
            this.propertySet.Size = new System.Drawing.Size(382, 264);
            this.propertySet.TabIndex = 0;
            this.propertySet.Text = "プロパティ";
            // 
            // profNameBox
            // 
            this.profNameBox.Location = new System.Drawing.Point(84, 15);
            this.profNameBox.Name = "profNameBox";
            this.profNameBox.Size = new System.Drawing.Size(290, 23);
            this.profNameBox.TabIndex = 2;
            this.profNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // profIconBox
            // 
            this.profIconBox.Location = new System.Drawing.Point(8, 6);
            this.profIconBox.Name = "profIconBox";
            this.profIconBox.Size = new System.Drawing.Size(70, 70);
            this.profIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profIconBox.TabIndex = 1;
            this.profIconBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 222);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(370, 36);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "設定を保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OverallSet
            // 
            this.OverallSet.Location = new System.Drawing.Point(4, 24);
            this.OverallSet.Name = "OverallSet";
            this.OverallSet.Padding = new System.Windows.Forms.Padding(3);
            this.OverallSet.Size = new System.Drawing.Size(382, 264);
            this.OverallSet.TabIndex = 1;
            this.OverallSet.Text = "全体";
            this.OverallSet.UseVisualStyleBackColor = true;
            // 
            // propPriorityBox
            // 
            this.propPriorityBox.FormattingEnabled = true;
            this.propPriorityBox.Location = new System.Drawing.Point(253, 89);
            this.propPriorityBox.Name = "propPriorityBox";
            this.propPriorityBox.Size = new System.Drawing.Size(121, 23);
            this.propPriorityBox.TabIndex = 3;
            // 
            // settingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 292);
            this.Controls.Add(this.tabPage);
            this.Name = "settingWindow";
            this.Text = "設定";
            this.tabPage.ResumeLayout(false);
            this.propertySet.ResumeLayout(false);
            this.propertySet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabPage;
        private TabPage propertySet;
        private TabPage OverallSet;
        private TextBox profNameBox;
        private PictureBox profIconBox;
        private Button saveButton;
        private ComboBox propPriorityBox;
    }
}