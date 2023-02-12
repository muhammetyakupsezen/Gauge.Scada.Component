using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gauge.Scada.Component
{
    public partial class GaugeScada : UserControl
    {

        int Count = 0;

        private int FHeat;

        public int Heat
        {
            get { return GetHeat(); }
            set { SetHeat(value); }
        }

        private void SetHeat(int value)
        {
            FHeat = value;
            trackBar1.Value = FHeat;

            if (FHeat >= FMaxHeat)
            {
                if (FAlarmActive)
                {
                    timer1.Enabled = true;
                }
            }


        }

        private int GetHeat()
        {
            return FHeat;
        }


        private string FDeviceName;

        public string Device
        {
            get { return GetDeviceName(); }
            set { SetDeviceName(value); }
        }

        private void SetDeviceName(string value)
        {
            FDeviceName = value;
            LblName.Text = FDeviceName;

        }

        private string GetDeviceName()
        {
            return FDeviceName;
        }




        private int FMaxHeat;

        public int MaxHeat
        {
            get { return GetFMaxHeat(); }
            set { SetFMaxHeat(value); }
        }

        private void SetFMaxHeat(int value)
        {
            FMaxHeat = value;

        }

        private int GetFMaxHeat()
        {
            return FMaxHeat;
        }



        private bool FAlarmActive;

        public bool AlarmActive
        {
            get { return GetAlarmActive(); }
            set { SetAlarmActive(value); }
        }

        private void SetAlarmActive(bool value)
        {
            FAlarmActive = value;
        }

        private bool GetAlarmActive()
        {
            return FAlarmActive;
        }




        public GaugeScada()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Count > 25)
                timer1.Enabled = false;


            if (LblName.BackColor == Color.PowderBlue)
                LblName.BackColor = Color.Red;

            else
                LblName.BackColor = Color.PowderBlue;



            Count++;



        }
    }
}
