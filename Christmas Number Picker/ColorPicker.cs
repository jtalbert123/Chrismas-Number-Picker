using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christmas_Number_Picker
{
    public partial class ColorPicker : UserControl
    {
        public static readonly Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Gray };

        private static Timer IntervalTimer;
        public int ColorIndex { get; private set; }

        public bool Picked { get; private set; }


        static ColorPicker()
        {
            IntervalTimer = new Timer();
            IntervalTimer.Interval = 300;
        }

        public ColorPicker()
        {
            InitializeComponent();
            IntervalTimer.Tick += IntervalTimer_Tick;
            ColorIndex = 0;
            Picked = false;
        }

        private void ColorPicker_Load(object sender, EventArgs e)
        {
            IntervalTimer.Enabled = true;
        }

        private void IntervalTimer_Tick(object sender, EventArgs e)
        {
            if (!Picked && Enabled)
            {
                ColorIndex = (ColorIndex + 1) % colors.Length;
                Invoke(new Action(() =>
                {
                    ColorPanel.BackColor = colors[ColorIndex];
                    Refresh();
                }));
            }
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            Picked = true;
            Invoke(new Action(() =>
            {
                BackColor = Color.DarkGray;
                Refresh();
            }));
            OnClick(new EventArgs());
        }

        public void Reset()
        {
            ColorIndex = 0;
            Picked = false;
            BackColor = SystemColors.Control;
        }
    }
}
