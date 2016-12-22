using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christmas_Number_Picker
{
    public partial class Form1 : Form
    {
        private int value;
        private int power;

        ColorPicker[] colorPickers;

        public Form1()
        {
            colorPickers = new ColorPicker[8];
            this.SuspendLayout();
            for (int i = 0; i < 8; i++)
            {
                colorPickers[i] = new ColorPicker();

                colorPickers[i].Location = new Point(12 + 112 * i, 12);
                colorPickers[i].Name = "colorPicker" + (i + 1);
                colorPickers[i].Size = new Size(106, 106);
                colorPickers[i].TabIndex = i;

                colorPickers[i].Click += new EventHandler[] { colorPicker1_Click, colorPicker2_Click,
                    colorPicker3_Click, colorPicker3_Click, colorPicker4_Click, colorPicker5_Click,
                    colorPicker6_Click, colorPicker7_Click, colorPicker8_Click }[i];

                this.Controls.Add(colorPickers[i]);
            }
            InitializeComponent();
            
            value = 0;
            power = 0;
        }

        private void AddDigit(ColorPicker picker)
        {
            value += picker.ColorIndex * (int)Math.Pow(4, power);
            power++;
            Invoke(new Action(() =>
            {
                DisplayValue.Text = ((value % 7) + 1).ToString();
                Refresh();
            }));
        }

        #region Color Picker click handlers
        private void colorPicker1_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[0]);
        }
        private void colorPicker2_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[1]);
        }
        private void colorPicker3_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[2]);
        }
        private void colorPicker4_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[3]);
        }
        private void colorPicker5_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[4]);
        }
        private void colorPicker6_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[5]);
        }
        private void colorPicker7_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[6]);
        }
        private void colorPicker8_Click(object sender, EventArgs e)
        {
            AddDigit(colorPickers[7]);
        }
        #endregion

        private void ResetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                colorPickers[i].Reset();
            }
            value = 0;
            power = 0;
            Invoke(new Action(() =>
            {
                DisplayValue.Text = "?";
                Refresh();
            }));
        }
    }
}
