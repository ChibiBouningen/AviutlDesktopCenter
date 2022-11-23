using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AviutlDesktopCenter
{
    internal class selectPanel : Panel
    {

        private PictureBox iconBox;
        private Label title;
        private profile p;
        private Form1 frm1;

        public selectPanel(Form1 form1)
        {
            
            this.frm1 = form1;

            this.Size = new Size(100,100);
            this.Location=new Point(10,300);
            this.Dock = DockStyle.Top;
            this.BackColor=Color.WhiteSmoke;
            
            this.Click += new EventHandler(ClickEvent);
            this.DoubleClick += new EventHandler(DoubleClickEvent);
            this.MouseEnter += new EventHandler(MouseEnterEvent);
            this.MouseLeave += new EventHandler(MouseLeaveEvent);


            this.iconBox = new PictureBox();
            this.Controls.Add(this.iconBox);
            this.iconBox.SizeMode=PictureBoxSizeMode.StretchImage;
            this.iconBox.Location = new Point(10,25);
            this.iconBox.Dock = DockStyle.None;
            this.iconBox.Size = new Size(60, 60);
            this.iconBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.iconBox.BackColor = Color.Blue;
            this.iconBox.Margin = new Padding(99);
            this.iconBox.Click += new EventHandler(ClickEvent);
            this.iconBox.DoubleClick+= new EventHandler(DoubleClickEvent);
            this.iconBox.MouseEnter += new EventHandler(MouseEnterEvent);
            this.iconBox.MouseLeave += new EventHandler(MouseLeaveEvent);

            this.title = new Label();
            this.Controls.Add(this.title);
            this.title.Location = new Point(90,40);
            this.title.Size = new Size(150, 30);
            this.title.AutoSize = false;
            //this.title.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.title.Font = new Font(title.Font.Name, 15, title.Font.Style);
            this.title.Click+=new EventHandler(ClickEvent);
            this.title.DoubleClick+=new EventHandler(DoubleClickEvent);
            this.title.MouseEnter += new EventHandler(MouseEnterEvent);
            this.title.MouseLeave += new EventHandler(MouseLeaveEvent);
        }



        public void make(profile catchProfile)
        { 
            p = catchProfile;

            this.iconBox.Image = p.icon;
            this.title.Text = p.name;
        }

        private void MouseEnterEvent(object sender, EventArgs e)
        {
            this.BackColor=Color.Gainsboro;
        }
        private void MouseLeaveEvent(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void ClickEvent(object sender, EventArgs e)
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
