using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace AviutlDesktopCenter
{
    internal class save
    {
        string prop_path = Path.GetFullPath("properties/").ToString();

        public int loadFiles(ref List<profile> profiles)
        {
            DirectoryInfo di = new DirectoryInfo(prop_path);
            if (Directory.Exists(prop_path))
            {
                di.Create();
            }

            string[] propfiles = Directory.GetFiles(prop_path, "*.adc");

            for(int i = 0; i < propfiles.Length; i++)
            {
                profile p = new profile();
                try
                {
                    StreamReader sr = new StreamReader(propfiles[i]);
                    while (0 <= sr.Peek())
                    {
                        string[] line = sr.ReadLine()?.Split(',');
                        if(line is null) continue;

                        switch (line[0])
                        {
                            case "id":
                                p.pID = line[1];
                                break;
                            case "path":
                                p.path = line[1];
                                break;
                            case "name":
                                p.name = line[1];
                                break;
                            case "priority":
                                p.priority = int.Parse(line[1]);
                                break;
                            default:
                                break;
                        }
                        
                    }
                    sr.Close();
                    if (/*File.Exists(p.pID + ".png")*/true)
                    {
                        FileStream fimg = new FileStream(prop_path + p.pID + ".png", FileMode.Open, FileAccess.Read);

                        p.icon = new Bitmap(fimg);
                        fimg.Close();
                    }
                    else p.icon = null;

                    profiles.Add(p);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return propfiles.Length;
        }

        public void saveFiles(profile p)
        {
            try
            {
                StreamWriter sw = new StreamWriter(prop_path + p.pID + ".adc", false, Encoding.UTF8);
                sw.WriteLine(String.Format("id,{0}", p.pID));
                sw.WriteLine(String.Format("path,{0}", p.path));
                sw.WriteLine(String.Format("name,{0}", p.name));
                sw.WriteLine(String.Format("priority,{0}", p.priority));

                p.icon.Save(prop_path+p.pID+".png",System.Drawing.Imaging.ImageFormat.Png);
                sw.Close();
            }
            catch
            {

            }

        }
    }
}
