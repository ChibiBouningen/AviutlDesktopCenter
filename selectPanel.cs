using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AviutlDesktopCenter
{
    internal class selectPanel : GroupBox
    {

        private PictureBox iconBox;
        private profile p;
        private Form1 frm1;
        string txt;

        public selectPanel(Form1 form1)
        {
            
            this.frm1 = form1;

            this.Size = new Size(100,100);
            this.Location=new Point(10,300);
            this.Dock = DockStyle.Top;

            this.Click += new EventHandler(ClickEvent);
            this.DoubleClick += new EventHandler(DoubleClickEvent);


            this.iconBox = new PictureBox();
            this.Controls.Add(this.iconBox);
            this.iconBox.SizeMode=PictureBoxSizeMode.StretchImage;
            this.iconBox.Location = new Point(10,25);
            this.iconBox.Dock = DockStyle.None;
            this.iconBox.Size = new Size(60, 60);
            this.iconBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.iconBox.BackColor = Color.Blue;
            this.iconBox.Margin = new Padding(99);

        }

        public void settxt(string a)
        {

            txt = a;
        }



        public void make(profile catchProfile)
        {
            
            p = catchProfile;

            this.iconBox.Image = p.icon;
        }

        public void ClickEvent(object sender, EventArgs e)
        {
            //MessageBox.Show(txt);
            frm1.infoPanel_load(p.pID);

        }

        public void DoubleClickEvent(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(p.path);
            }
            catch
            {
                MessageBox.Show("起動できませんでした。");
            }
            
        }
    }
}
