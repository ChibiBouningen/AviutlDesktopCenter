namespace AviutlDesktopCenter
{
    partial class addManage
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
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.commentlabel1 = new System.Windows.Forms.Label();
            this.propertyNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(109, 88);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(421, 23);
            this.filePathBox.TabIndex = 0;
            // 
            // openFolderButton
            // 
            this.openFolderButton.Location = new System.Drawing.Point(570, 88);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(108, 23);
            this.openFolderButton.TabIndex = 1;
            this.openFolderButton.Text = "aviutl.exeを開く";
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.openFolderButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(372, 394);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(75, 23);
            this.CompleteButton.TabIndex = 2;
            this.CompleteButton.Text = "完了";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // commentlabel1
            // 
            this.commentlabel1.AutoSize = true;
            this.commentlabel1.Location = new System.Drawing.Point(110, 48);
            this.commentlabel1.Name = "commentlabel1";
            this.commentlabel1.Size = new System.Drawing.Size(141, 15);
            this.commentlabel1.TabIndex = 3;
            this.commentlabel1.Text = "aviutl.exeを指定してください";
            // 
            // propertyNameBox
            // 
            this.propertyNameBox.Location = new System.Drawing.Point(109, 207);
            this.propertyNameBox.Name = "propertyNameBox";
            this.propertyNameBox.Size = new System.Drawing.Size(421, 23);
            this.propertyNameBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "設定の名前を入力してください";
            // 
            // addManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyNameBox);
            this.Controls.Add(this.commentlabel1);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.openFolderButton);
            this.Controls.Add(this.filePathBox);
            this.Name = "addManage";
            this.Text = "Add AviUtl Wizard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button openFolderButton;
        private Button CompleteButton;
        public TextBox filePathBox;
        private Label commentlabel1;
        private Label label1;
        public TextBox propertyNameBox;
    }
}