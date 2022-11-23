using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AviutlDesktopCenter
{
    public partial class Form1 : Form
    {

        private GroupBox[] groupBoxes;
        save save = new save();
        private selectPanel[] selectP;

        private string selectPropID;
        List<profile> profileList = new List<profile>();

        public Form1()
        {
            InitializeComponent();
            this.groupBoxes = null;
            selectPropID = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            profileTitleLabel.Text = "‚ ‚ ";
            savedata_load();
            SelectPanel_load();
            if(profileList.Count > 0) infoPanel_load(profileList[profileList.Count - 1].pID);
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

            try
            {
                p.path = f.filePathBox.Text;
                p.name = f.propertyNameBox.Text;
                p.pID = DateTime.Now.ToString("yyyyMMddHHmmss");

                Icon icnKari = Icon.ExtractAssociatedIcon(p.path);
                p.icon = icnKari.ToBitmap();
                p.priority = 3;

                save.saveFiles(p);

                profileList.Add(p);
                SelectPanel_load();
                infoPanel_load(p.pID);

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            f.Dispose();
            
        }

        private void SelectPanel_load()
        {
            selectP = new selectPanel[profileList.Count];

            this.splitContainer1.Panel1.Controls.Clear();

            profileList.Sort((a,b)=> a.priority - b.priority);

            for (int i = 0; i < profileList.Count; i++)
            {
                selectP[i] = new selectPanel(this);
                this.splitContainer1.Panel1.Controls.Add(selectP[i]);
                selectP[i].make(profileList[i]);
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

        private void savedata_load()
        {
            int i;
            i = save.loadFiles(ref profileList);
            //MessageBox.Show(profileList[0].name);

        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            int view = profileList.FindIndex(item => item.pID == selectPropID);
            settingWindow sW = new settingWindow(profileList[view]);
            sW.frm1=this;
            sW.ShowDialog();
            if(sW.act==1)
            {
                profileList[view] = sW.p;
                SelectPanel_load();
                infoPanel_load(selectPropID);
                save.saveFiles(profileList[view]);
            }

            sW.Dispose();
        }
    }
}