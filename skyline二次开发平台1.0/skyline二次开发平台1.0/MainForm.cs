using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraExplorerX;

namespace skyline二次开发平台1._0
{
    public partial class MainForm : Form
    {
        public static SGWorld61 sgworld;
        private TerraExplorer CoTE;
        private ITerraExplorer5 ITE;
        private IInformationTree5 IInfoTree;
        private IRender5 IRender;
        private IObjectManager5 IObjectManager;
        private ITerraExplorerObject5 ITeObj5;
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public MainForm()
        {           
            InitializeComponent();
            asc.controllInitializeSize(this);
            sgworld = new SGWorld61();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            sgworld.OnLoadFinished += new
                _ISGWorld61Events_OnLoadFinishedEventHandler(OnProjectLoadFinished);
            string flyFile = "http://www.skylineglobe.com/SkylineGlobe/WebClient/PresentationLayer/WebClient/SkyglobeLB.fly";
            //string flyFile="D:/user/QT/SkyLine/Demo/Demo/bin/Default.FLY";
            sgworld.Project.Open(flyFile, true, null, null);

            CoTE = new TerraExplorerClass();
            ITE = (TerraExplorerX.ITerraExplorer5)CoTE;
            IInfoTree = (TerraExplorerX.IInformationTree5)CoTE;
            IRender = (IRender5)CoTE;
            IObjectManager = (IObjectManager5)CoTE;
            this.CoTE.OnLButtonDown += new _ITerraExplorerEvents5_OnLButtonDownEventHandler(OnLButtonDown);
        
        }
        void OnProjectLoadFinished()
        {
            //IPosition61 Washington = sgworld.Creator.CreatePosition(-77.036667, 38.895111, 1500, AltitudeTypeCode.ATC_TERRAIN_RELATIVE, 0, 0, 0, 0);
            //sgworld.Navigate.FlyTo(Washington);
        }
        
        
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            ofd.Title = "打开文件";
            ofd.Filter = "TerraExplorer Header文件|*.fly";
            string path = ofd.FileName;
            //sgworld.Project.Open(path, true, null, null);
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.ValidateNames = true;     //文件有效性验证ValidateNames，验证用户输入是否是一个有效的Windows文件名
            ofd.CheckFileExists = true;  //验证文件有效性
            ofd.CheckPathExists = true; //验证路径有效性
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sgworld.Project.Open(path, true, null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }


        private void OnLButtonDown(int Flags, int X, int Y, ref object pbHandled)
        {
            object objType,DX,DY,DH,OID;
            objType= 63;
            IRender.ScreenToWorld(X, Y, ref objType, out DX, out DH, out DY, out OID);
            label2.Text = "经度："+Convert.ToString(DX)+ "纬度："+Convert.ToString(DY);//获取x,y坐标



        }

        private void 文字标签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LabelForm labelform = new LabelForm();
            labelform.Show();
        }
    }

}
