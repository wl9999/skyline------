using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraExplorerX;

namespace skyline二次开发平台
{
    public partial class MainForm : Form
    {
        public static SGWorld61 sgworld;
        private ITerrain5 Ita;
        private TerraExplorer CoTE;
        private ITerraExplorer5 ITE;
        private IInformationTree5 IInfoTree;
        private IRender5 IRender;
        private IObjectManager5 IObjectManager;
        private ITerraExplorerObject5 ITeObj5;
        private IPlane5 IPlane;
        private ILayer5 iLyr,iLyr2, iLyr3, iLyr4, iLyr5;
        private ITENavigationMap5 map;
        private object[] objArray;
        private double[] sx;
        private double[] sy;
        private double[] xx;
        private double[] yy;
        private int numObjs;
        private int currObj;
        private Random RandomClass = new Random();
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public MainForm()
        {           
            InitializeComponent();
            asc.controllInitializeSize(this);
            this.CoTE = new TerraExplorerClass();
            this.ITE = (ITerraExplorer51)CoTE;
            this.IInfoTree = (IInformationTree5)CoTE;
            this.IPlane = (IPlane5)CoTE;
            this.Ita = (ITerrain5)CoTE;
            sgworld = new SGWorld61();
            CoTE.OnFrame += new _ITerraExplorerEvents5_OnFrameEventHandler(TE_OnFrame);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            sgworld.OnLoadFinished += new
                _ISGWorld61Events_OnLoadFinishedEventHandler(OnProjectLoadFinished);
            //string flyFile = "http://www.skylineglobe.com/SkylineGlobe/WebClient/PresentationLayer/WebClient/SkyglobeLB.fly";
            string flyFile= Application.StartupPath + "\\elta.fly";
            //ITE.LoadEx(Application.StartupPath + @"\elta.fly", "", "", 0);
            sgworld.Project.Open(flyFile, true, null, null);
            CoTE = new TerraExplorerClass();
            ITE = (TerraExplorerX.ITerraExplorer5)CoTE;
            IInfoTree = (TerraExplorerX.IInformationTree5)CoTE;
            IRender = (IRender5)CoTE;
            IObjectManager = (IObjectManager5)CoTE;
            this.CoTE.OnLButtonDown += new _ITerraExplorerEvents5_OnLButtonDownEventHandler(OnLButtonDown);

            numObjs = 0;
            currObj = 0;
            objArray = new object[2000];
            sx = new double[2000];
            sy = new double[2000];
            xx = new double[2000];
            yy = new double[2000];
            InitArray();

        }

        private void InitArray()
        {
        int MyGroup;
        int ItemID;
        double a;
        double b;
        MyGroup = IInfoTree.FindItem("group1");
            ItemID = (int)IInfoTree.GetNextItem(MyGroup, TerraExplorerX.ItemCode.CHILD);
            while (ItemID > 0)
            {
                objArray[numObjs] = (object)IInfoTree.GetObjectEx(ItemID, "ITerraExplorerObject5");
                a = RandomClass.Next(0,1000);
                b = RandomClass.Next(0, 1000);
                xx[numObjs] = -80.2178 + a / 10000;
                yy[numObjs] = 25.7718 + b / 10000;
                a = RandomClass.Next(0,1000);
                b = RandomClass.Next(0, 1000);
                sx[numObjs] = (a - 500) / 1000000;
                sy[numObjs] = (b - 500) / 1000000;
                numObjs = numObjs + 1;
                ItemID = IInfoTree.GetNextItem(ItemID, TerraExplorerX.ItemCode.NEXT);
            }
}

        void TE_OnFrame()
        {
            int counter;
            double a;
            double b;
            ITerrainLocation5 ObjID;
            counter = 0;
            while (counter <= 1000)
            {
                ObjID = (ITerrainLocation5)objArray[currObj];
                ObjID.SetPosition(xx[currObj], yy[currObj], 0, 0, 0, 0, 56);              
                xx[currObj] += sx[currObj];
                yy[currObj] += sy[currObj];
                currObj = currObj + 1;
                if (currObj >= numObjs - 1)
                    currObj = 0;
                counter = counter + 1;
            }           
        }

        void OnProjectLoadFinished()
        {
            IPosition61 beijing = sgworld.Creator.CreatePosition(116.216667, 39.775111, 15000, AltitudeTypeCode.ATC_TERRAIN_RELATIVE, -60, -60, 0, 0);            
            sgworld.Navigate.JumpTo(beijing);
            //不加载天地图
            IInfoTree.SetVisibility(0,0);
       
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

        private void 钻孔模型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdddrillForm adddrillform = new AdddrillForm();
            adddrillform.Show();
        }

    

        private void 地质体模型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 添加建筑物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddbuildingForm addbuildingForm = new AddbuildingForm();
            addbuildingForm.Show();
        }

        private void 地下场景显示ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //启用地下模式
            sgworld.Command.Execute(1027, 0);
            //获取中心坐标
            IPosition61 center = sgworld.Window.CenterPixelToWorld().Position;
            //设置视角
            sgworld.Navigate.SetPosition(center);
            
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sgworld.Command.Execute(1004, 0);
        }

        private void 天地图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sgworld.Command.Execute(1014, 21);
            //string strFindUrl = "http://t0.tianditu.com/img_c/wmts";
            //string strJSONTxt;
            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(strFindUrl);
            //HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            //Stream s = res.GetResponseStream();
            //StreamReader r = new StreamReader(s);
            //strJSONTxt = r.ReadToEnd();
            //strJSONTxt = "[" + strJSONTxt.Trim() + "]";
            //sgworld.Creator.CreatePosition()

            //设置天地图图层显示
            IInfoTree.SetVisibility(0, 1);
        }

        private void 钻孔显示ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var itemId = sgworld.ProjectTree.FindItem("新建圆锥");
            MessageBox.Show("" + itemId);
            var layer = sgworld.ProjectTree.GetLayer(itemId);

            
            
        
        }

        private void 地上地下一体化显示ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Ita.Opacity == 0) { Ita.Opacity = 1; }
            else { Ita.Opacity = 0; }
            
           
        }

        private void 加载shp数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\data\\国界\\bou1_4l.shp";
            string XMLLayerInfo = "<PlugData><LayerName>" + path + "</LayerName><PlugType>shape</PlugType><AttributesToLoad>AREA,STATE_NAME,POP1990,POP2000</AttributesToLoad><StreamedLayer>0</StreamedLayer></PlugData>";
            iLyr = IInfoTree.CreateLayer("国界", XMLLayerInfo, 0);//在根目录下装载shp数据
            string path2 = Application.StartupPath + "\\data\\国界与省界\\bou2_4l.shp";
            string XMLLayerInfo2 = "<PlugData><LayerName>" + path2 + "</LayerName><PlugType>shape</PlugType><AttributesToLoad>AREA,STATE_NAME,POP1990,POP2000</AttributesToLoad><StreamedLayer>0</StreamedLayer></PlugData>";
            iLyr2 = IInfoTree.CreateLayer("国界与省界", XMLLayerInfo2, 0);//在根目录下装载shp数据
            string path3 = Application.StartupPath + "\\data\\首都和省级行政中心\\res1_4m.shp";
            string XMLLayerInfo3 = "<PlugData><LayerName>" + path3 + "</LayerName><PlugType>shape</PlugType><AttributesToLoad>AREA,STATE_NAME,POP1990,POP2000</AttributesToLoad><StreamedLayer>0</StreamedLayer></PlugData>";
            iLyr3 = IInfoTree.CreateLayer("首都和省级行政中心", XMLLayerInfo3, 0);//在根目录下装载shp数据
            string path4 = Application.StartupPath + "\\data\\主要公路\\roa_4m.shp";
            string XMLLayerInfo4 = "<PlugData><LayerName>" + path4 + "</LayerName><PlugType>shape</PlugType><AttributesToLoad>AREA,STATE_NAME,POP1990,POP2000</AttributesToLoad><StreamedLayer>0</StreamedLayer></PlugData>";
            iLyr4 = IInfoTree.CreateLayer("主要公路", XMLLayerInfo4, 0);//在根目录下装载shp数据
            string path5 = Application.StartupPath + "\\data\\主要铁路\\rai_4m.shp";
            string XMLLayerInfo5 = "<PlugData><LayerName>" + path5 + "</LayerName><PlugType>shape</PlugType><AttributesToLoad>AREA,STATE_NAME,POP1990,POP2000</AttributesToLoad><StreamedLayer>0</StreamedLayer></PlugData>";
            iLyr5 = IInfoTree.CreateLayer("主要铁路", XMLLayerInfo5, 0);//在根目录下装载shp数据
            iLyr.Load();
            iLyr2.Load();
            iLyr3.Load();
            iLyr4.Load();
            iLyr5.Load();
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

        private void 百度地图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sgworld.Command.Execute(1014, 21);
        }

    }

}
