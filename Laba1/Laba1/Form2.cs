using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba1
{
    public partial class PluginForm : Form
    {
        private byte[] _Serialized_Data;
        private string Filename;
        public PluginForm(byte[] stream, string filename)
        {
            InitializeComponent();
            GetPlugins(Directory.GetCurrentDirectory() + "/Plugins");
            _Serialized_Data = stream;
            Filename = filename;
        }
        private void GetPlugins(string Path)
        {
            if (!Directory.Exists(Path))
            {
                return;
            }

            Plugin curr = CMBPlug.SelectedItem as Plugin;
            CMBPlug.BeginUpdate();
            CMBPlug.Items.Clear();

            foreach (string f in Directory.GetFiles(Path))
            {
                FileInfo fi = new FileInfo(f);

                if (fi.Extension.Equals(".dll"))
                {
                    CMBPlug.Items.Add(new Plugin(f));
                }
            }
            CMBPlug.EndUpdate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FMenu._curr_Plugin = CMBPlug.SelectedItem as Plugin;
            if (FMenu._curr_Plugin != null)
            {
                byte[] data = Plugin.ActivatePlugin(FMenu._curr_Plugin, _Serialized_Data, true);
                using (FileStream fs = new FileStream(Filename, FileMode.OpenOrCreate))
                {
                    fs.Write(data, 0, data.Length);
                }
                Plugin.SetCustomFileProperty(Filename, FMenu._curr_Plugin.Filename);
            }
            this.Close();
        }

        private void BDel_Click(object sender, EventArgs e)
        {
            FMenu._curr_Plugin = null;
            using (FileStream fs = new FileStream(Filename, FileMode.OpenOrCreate))
            {
                fs.Write(_Serialized_Data, 0, _Serialized_Data.Length);
            }
            Plugin.SetCustomFileProperty(Filename, "");
            this.Close();
        }
    }
}
