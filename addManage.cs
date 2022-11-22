using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviutlDesktopCenter
{
    public partial class addManage : Form
    {
        public Form1 frm1;
        public addManage()
        {
            InitializeComponent();
        }

        private void openFolderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "aviutl.exe|*.exe";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathBox.Text = openFileDialog.FileName;
            }
        }

        private void CompleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
