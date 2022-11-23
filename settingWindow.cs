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
    public partial class settingWindow : Form
    {
        public Form1 frm1;
        public profile p;
        public int act;
        public settingWindow(profile catchProfile)
        {
            InitializeComponent();
            p = catchProfile;
            act = 0;
            profNameBox.Text = p.name;
            profIconBox.Image = p.icon;

            propPriorityBox.Items.AddRange(new string[] {"1","2","3","4","5"});
            propPriorityBox.SelectedIndex = p.priority - 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            p.name=profNameBox.Text;
            p.priority = int.Parse(propPriorityBox.Text);
            act = 1;
            this.Close();
        }
    }
}
