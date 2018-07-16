using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TerraExplorerX;
using System.IO;

namespace skyline二次开发平台
{
    public partial class AddbuildingForm : Form
    {
        private object sgworld = MainForm.sgworld;
        private ITerraExplorer5 ITerraExplorer;
        private TerraExplorer TECoClass;
        private ITerrainDynamicObject5 tempDynamicObject;
        private IInformationTree5 IInfoTree;
        private IObjectManager5 IObjectManager;
        public AddbuildingForm()
        {
            InitializeComponent();
            TECoClass = new TerraExplorerClass();
            ITerraExplorer = (ITerraExplorer5)TECoClass;
            IInfoTree = (IInformationTree5)TECoClass;
            IObjectManager = (IObjectManager5)TECoClass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\GPS.txt");
            object DX, DH, DY, mSpeed;
            int ItemID = IInfoTree.FindItem("car");
            if (ItemID == 0)
            {
                //tempDynamicObject = IObjectManager.CreateDynamicObject(DynamicMotionStyle.MOTION_GROUND_VEHICLE, DynamicObjectType.DYNAMIC_3D_MODEL, Application.StartupPath + "\\car.xpc", 3, HeightStyleCode.HS_ON_TERRAIN, 0, this.textBox4.Text);
                tempDynamicObject = IObjectManager.CreateDynamicObject(DynamicMotionStyle.MOTION_GROUND_VEHICLE, DynamicObjectType.DYNAMIC_3D_MODEL, Application.StartupPath + "\\car.xpc", 1, HeightStyleCode.HS_ON_TERRAIN, 0, this.textBox4.Text);
                tempDynamicObject.SetPosition(Convert.ToDouble(this.textBox1.Text), Convert.ToDouble(this.textBox2.Text), -30, -30, 0, 0);

            }
            for (int i = 0; i < tempDynamicObject.NumberOfWaypoints; i++)
            {
                tempDynamicObject.GetWaypoint(i, out DX, out DH, out DY, out mSpeed);
                if (tempDynamicObject.CurrentWaypoint != 1)
                {
                    tempDynamicObject.ModifyWaypoint(i, Convert.ToDouble(this.textBox1.Text), 0, Convert.ToDouble(this.textBox2.Text), Convert.ToDouble(this.textBox3.Text));
                    sw.WriteLine(i.ToString() + "\t" + DX.ToString() + "\t" + DH.ToString() + "\t" + DY.ToString() + "\t" + mSpeed.ToString());

                }
                sw.Close();

            }
        }
            //读取并文件保存
            //for (int j = 0; j < tempDynamicObject.NumberOfWaypoints; j++)
            //    {
            //        tempDynamicObject.GetWaypoint(j, out DX, out DH, out DY, out mSpeed);

            //        sw.WriteLine(j.ToString() + "\t" + DX.ToString() + "\t" + DH.ToString() + "\t" + DY.ToString() + "\t" + mSpeed.ToString());
            //    }
            //    //tempDynamicObject.RestartRoute(tempDynamicObject.CurrentWaypoint);
            //    sw.Close();
            //}
        

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";         
        }
    }
}
