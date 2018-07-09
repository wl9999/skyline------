using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraExplorerX;

namespace skyline二次开发平台1._0
{
    public partial class MainForm : Form
    {
        private SGWorld61 sgworld;
        public MainForm()
        {           
            InitializeComponent();
            asc.controllInitializeSize(this);
            sgworld = new SGWorld61();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sgworld.OnLoadFinished += new
                _ISGWorld61Events_OnLoadFinishedEventHandler(OnProjectLoadFinished);
            string flyFile = "http://www.skylineglobe.com/SkylineGlobe/WebClient/PresentationLayer/WebClient/SkyglobeLB.fly";
            //string flyFile="D:/user/QT/SkyLine/Demo/Demo/bin/Default.FLY";
            sgworld.Project.Open(flyFile, true, null, null);
        }
        void OnProjectLoadFinished()
        {
            //IPosition61 Washington = sgworld.Creator.CreatePosition(-77.036667, 38.895111, 1500, AltitudeTypeCode.ATC_TERRAIN_RELATIVE, 0, 0, 0, 0);
            //sgworld.Navigate.FlyTo(Washington);
        }
        AutoSizeFormClass asc = new AutoSizeFormClass();
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }

        }

}
