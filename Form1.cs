using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AviutlDesktopCenter
{
    public partial class Form1 : Form
    {

        private GroupBox[] groupBoxes;
        private selectPanel[] selectP;
        private string selectPropID;
        List<profile> profileList = new List<profile>();


        int panelcnt = 0;
        public Form1()
        {
            InitializeComponent();
            this.groupBoxes = null;
            selectPropID = null;
            SelectPanel_load(profileList);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            profileTitleLabel.Text = "‚ ‚ ";
        }

        private void newAviutl_button_Click(object sender, EventArgs e)
        {
            addAviUtl();
            
        }

        private void addAviUtl()
        {
            addManage f = new addManage();
            profile p = new profile();
            f.frm1 = this;
            f.ShowDialog();

            p.path = f.filePathBox.Text;
            p.name = f.propertyNameBox.Text;
            p.pID = DateTime.Now.ToString("yyyyMMddHHmmss");

            Icon icnKari = Icon.ExtractAssociatedIcon(p.path);
            p.icon = icnKari.ToBitmap();

            profileList.Add(p);

            f.Dispose();

            SelectPanel_load(profileList);
            infoPanel_load(p.pID);
        }

        private void SelectPanel_load(List<profile> profiles)
        {
            selectP = new selectPanel[profiles.Count];

            this.splitContainer1.Panel1.Controls.Clear();

            for (int i = 0; i < profiles.Count; i++)
            {
                selectP[i] = new selectPanel(this);
                this.splitContainer1.Panel1.Controls.Add(selectP[i]);
                selectP[i].make(profiles[i]);
                //selectP[i].settxt(profiles[i].path);
            }
        }

        public void infoPanel_load(string viewID)
        {
            //int view = profileList.Find(i=>i.pID==viewID);
            int view = profileList.FindIndex(item => item.pID == viewID);
            profileTitleLabel.Text = profileList[view].name;
            selectPropID = viewID;
        }

        
    }
}