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
        string txt;

        public selectPanel()
        {
            
            this.Size = new Size(100,100);
            this.Location=new Point(10,300);
            this.Dock = DockStyle.Top;

            this.iconBox = new PictureBox();
            this.Controls.Add(this.iconBox);
            this.iconBox.Location = new Point(10,25);
            this.iconBox.Dock = DockStyle.None;
            this.iconBox.Size = new Size(60, 60);
            this.iconBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.iconBox.BackColor = Color.Blue;
            this.iconBox.Margin = new Padding(99);

        }

        public void settxt(int a)
        {
            txt = a.ToString();
        }



        public void eventMake()
        {
            this.Click += new EventHandler(ClickEvent);
        }

        public void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show(txt);
        }
    }
}
