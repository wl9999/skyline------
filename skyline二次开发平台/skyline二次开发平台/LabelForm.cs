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
using CCWin;
namespace skyline二次开发平台
{
    public partial class LabelForm : Form
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        private object sgworld = MainForm.sgworld;
        //uint nrgb = 0xFFFF00;
        uint nrgb;
        public LabelForm()
        {
            InitializeComponent();
            
        }

        private void LabelForm_Load(object sender, EventArgs e)
        {
            asc.controllInitializeSize(this);
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = textBox3.Text;
            string s4 = textBox4.Text;
            string s5 = textBox4.Text+"\r\n"+textBox5.Text;
            string mes = String.Empty;
            IPosition61 cpos = null;
            ILabelStyle61 clabelstyle = null;
            ITerrainLabel61 ctextlabel = null;
            try
            {
                double dxcoord = double.Parse(s1);
                double dycoord = double.Parse(s2);
                double altitude = double.Parse(s3);
                AltitudeTypeCode ealit = AltitudeTypeCode.ATC_TERRAIN_RELATIVE;
                cpos = MainForm.sgworld.Creator.CreatePosition(dxcoord, dycoord, altitude, ealit,-30, -30, 0.0, 10000);                
                {
                    SGLabelStyle elabelstyle = SGLabelStyle.LS_DEFAULT;
                    clabelstyle = MainForm.sgworld.Creator.CreateLabelStyle(elabelstyle);
                    {                        
                        double alpha = 0.5;
                        IColor61 cbackground = clabelstyle.BackgroundColor;
                        cbackground.FromBGRColor(nrgb);
                        cbackground.SetAlpha(alpha);
                        clabelstyle.FontName = "Arial";
                        clabelstyle.FontSize = 50;
                        clabelstyle.TextColor.FromABGRColor(nrgb);
                        clabelstyle.Italic = true;
                        clabelstyle.Scale = 3;
                        ctextlabel = MainForm.sgworld.Creator.CreateTextLabel(cpos, s5, clabelstyle, 0,s4);
                        IPosition61 cflypos = cpos.Copy();
                        cflypos.Pitch = -30.0;
                        MainForm.sgworld.Navigate.FlyTo(cflypos, ActionCode.AC_FLYTO);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                mes = String.Format("CreateLabelButton_Click Exception :{0}", ex.Message);
                Log4NetHelper.WriteLog(typeof(LabelForm), ex);
                MessageBox.Show(mes);
            }
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
        uint ParseRGB(Color color){
         return (uint)(((uint)color.B << 16) | (ushort)(((ushort)color.G << 8) | color.R));}

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label6.BackColor = Color.Black;
            nrgb = 00000000;


        }

      
    }
}
