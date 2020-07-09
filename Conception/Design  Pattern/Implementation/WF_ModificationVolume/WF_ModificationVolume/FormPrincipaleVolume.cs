using CLibrary_ModificationVolume;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ModificationVolume
{
    public partial class FormPrincipaleVolume : Form
    {
        VolumeModel volumeModel = new VolumeModel(0);

        public FormPrincipaleVolume()
        {
            InitializeComponent();
        }

        private void FormPrincipaleVolume_Load(object sender, EventArgs e)
        {
            //tbChangerVolume.Text += Convert.ToString(volumeModel.Volume);
            MajIHM();
        }

        public void MajIHM()
        {
            volumeModel.NotificationListener();
            
            ProgressBarVolume.Value = volumeModel.Volume;
        }
    }
}
