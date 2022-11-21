using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AviutlDesktopCenter
{
    public partial class Form1 : Form
    {

        private GroupBox[] groupBoxes;
        private selectPanel[] selectP;


        int panelcnt = 0;
        public Form1()
        {
            InitializeComponent();
            this.groupBoxes = null;
            loadSelectPanel(panelcnt);
        }

        private void newAviutl_button_Click(object sender, EventArgs e)
        {
            /*this.groupBoxes=new GroupBox[3];
            this.groupBoxes[0] = new GroupBox();
            this.groupBoxes[0].Location=new Point(10,300);
            this.groupBoxes[0].Size = new Size(244, 45);
            this.groupBoxes[0].Dock = DockStyle.Top;

            this.splitContainer1.Panel1.Controls.Add(this.groupBoxes[0]);*/

            //selectPanel selectP = new selectPanel();
            loadSelectPanel(++panelcnt);
        }

        private void loadSelectPanel(int n)
        {
            selectP = new selectPanel[n];

            this.splitContainer1.Panel1.Controls.Clear();

            for (int i = 0; i < n; i++)
            {
                selectP[i] = new selectPanel();
                this.splitContainer1.Panel1.Controls.Add(selectP[i]);
                selectP[i].eventMake();
                selectP[i].settxt(i);
            }
        }
    }
}