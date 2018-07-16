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


namespace skyline二次开发平台
{
    public partial class AdddrillForm : Form
    {
        private object sgworld = MainForm.sgworld;
        uint nrgb;
        public AdddrillForm()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog ColorForm = new ColorDialog();
            if (ColorForm.ShowDialog() == DialogResult.OK)
            {
                Color GetColor = ColorForm.Color;
                //GetColor就是用户选择的颜色，接下来就可以使用该颜色了
                nrgb = ParseRGB(GetColor);
                label6.BackColor = GetColor;
            }
        }
        uint ParseRGB(Color color)
        {
            return (uint)(((uint)color.B << 16) | (ushort)(((ushort)color.G << 8) | color.R));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = textBox3.Text;
            string s4 = textBox4.Text;
            string mes = String.Empty;
            IPosition61 cpos = null;
            ITerrain3DRegBase61 drill = null;

            try
            {
                double dxcoord = double.Parse(s1);
                double dycoord = double.Parse(s2);
                double altitude = double.Parse(s3);
                AltitudeTypeCode ealit = AltitudeTypeCode.ATC_TERRAIN_RELATIVE;
                cpos = MainForm.sgworld.Creator.CreatePosition(dxcoord, dycoord, altitude, ealit, -90, -30, 180, 1000);
                {
                    drill = MainForm.sgworld.Creator.CreateCone(cpos, 10, 50, nrgb, nrgb, -1, 0, s4);
                    MainForm.sgworld.Navigate.FlyTo(cpos, ActionCode.AC_FLYTO);
                }
            }
            catch (Exception ex)
            {
                mes = String.Format("CreateLabelButton_Click Exception :{0}", ex.Message);
                Log4NetHelper.WriteLog(typeof(AdddrillForm), ex);
                MessageBox.Show(mes);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label6.BackColor=Color.Black;
            nrgb = 00000000;
        }
    }
}
