using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Litography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPX_Click(object sender, EventArgs e)
        {  
            updateTrackBarX(1);
        }

        private void TrackBarX_Scroll(object sender, EventArgs e)
        {
            updateTrackBarX();
        }

        private void ButtonNX_Click(object sender, EventArgs e)
        {
            
            updateTrackBarX(-1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTrackBarX();
            updateTrackBarY();
            updateTrackBarZ();

            var Clock = new Timer();
            Clock.Interval = 200;
            Clock.Start();
            Clock.Tick += new EventHandler(OnTimer_Tick);
        }
        bool LED = false;
        private void OnTimer_Tick(object sender, EventArgs e)
        {
            
            if (LED)
            {
                pictureBoxBUSYLED.Image = govnosoft1.Properties.Resources.RedLedOff1;
            }
            else
            {
                pictureBoxBUSYLED.Image = govnosoft1.Properties.Resources.RedLedOn1;
            }
            LED = !LED;
        }

        private void updateTrackBarX(int value=0)
        {
            value *= Convert.ToInt32(textBoxButtnMult.Text);
            if (trackBarX.Minimum <= trackBarX.Value + value && trackBarX.Maximum >= trackBarX.Value + value)
            {
                trackBarX.Value += value;
            }
            
            textBoxCurrX.Text = trackBarX.Value.ToString();
            

        }

        private void updateTrackBarY(int value = 0)
        {
            value *= Convert.ToInt32(textBoxButtnMult.Text);
            if (trackBarY.Minimum <= trackBarY.Value + value && trackBarY.Maximum >= trackBarY.Value + value)
            {
                trackBarY.Value += value;
            }

            textBoxCurrY.Text = trackBarY.Value.ToString();


        }

        private void updateTrackBarZ(int value = 0)
        {
            value *= Convert.ToInt32(textBoxButtnMult.Text);
            if (trackBarZ.Minimum <= trackBarZ.Value + value && trackBarZ.Maximum >= trackBarZ.Value + value)
            {
                trackBarZ.Value += value;
            }

            textBoxCurrZ.Text = trackBarZ.Value.ToString();


        }

        private void ButtonPMult_Click(object sender, EventArgs e)
        {
            int ЖораЧиниВидак = Convert.ToInt32(textBoxButtnMult.Text)*10;
            if (1000 >= ЖораЧиниВидак)
            {
                textBoxButtnMult.Text = (ЖораЧиниВидак).ToString(); //GOVNOKOD INTERFAIZIS
            }

        }

        private void ButtonNMult_Click(object sender, EventArgs e)
        {
            int КТКогдаДид = Convert.ToInt32(textBoxButtnMult.Text) / 10;
            if (0 < КТКогдаДид)
            {
                textBoxButtnMult.Text = (КТКогдаДид).ToString(); //GOVNOKOD INTERFAIZIS
            }
        }

        private void TrackBarY_Scroll(object sender, EventArgs e)
        {
            updateTrackBarY();
        }

        private void ButtonNY_Click(object sender, EventArgs e)
        {
            updateTrackBarY(-1);
        }

        private void ButtonPY_Click(object sender, EventArgs e)
        {
            updateTrackBarY(1);
        }

        private void TrackBarZ_Scroll(object sender, EventArgs e)
        {
            updateTrackBarZ();
        }

        private void ButtonNZ_Click(object sender, EventArgs e)
        {
            updateTrackBarZ(-1);
        }

        private void ButtonPZ_Click(object sender, EventArgs e)
        {
            updateTrackBarZ(1);
        }
    }
}



