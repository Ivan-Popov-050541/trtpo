using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace trtpo_fractal_lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        int getMandelbrod(int x, int y)
        {
            Complex z = new Complex(0, 0);
            Complex c = new Complex(x * 4.0 / FractalPictureBox.Width - 2.0, y * 4.0 / FractalPictureBox.Height - 2.0);
            int i = 0;
            while (i < 255 && z.getAbs() < 4.0)
            {
                z = z * z + c;
                ++i;
            }
            return i;
        }

        int getJulia(int x, int y)
        {
            Complex z = new Complex(x * 4.0 / FractalPictureBox.Width - 2.0, y * 4.0 / FractalPictureBox.Height - 2.0);
            Complex c = new Complex(Convert.ToDouble(RealTextBox.Text), Convert.ToDouble(ImaginaryTextBox.Text));
            int i = 0;
            while (i < 255 && z.getAbs() < 4.0)
            {
                z = z * z + c;
                ++i;
            }
            return i;
        }

        void GenerateFractal()
        {
            Bitmap btmImage = new Bitmap(FractalPictureBox.Width, FractalPictureBox.Height);
            FractalPictureBox.BackgroundImage = btmImage;
            for (int y = 0; y < FractalPictureBox.Height; ++y)
                for (int x = 0; x < FractalPictureBox.Width; ++x)
                {
                    int i = 0;
                    if (MandelCheckBox.Checked)
                        i = getMandelbrod(x, y);
                    if (JuliaCheckBox.Checked)
                        i = getJulia(x, y);
                    btmImage.SetPixel(x, y, Color.FromArgb(i * RedTrackBar.Value % 256,
                       i * GreenTrackBar.Value % 256, i * BlueTrackBar.Value % 256));
                }
            FractalPictureBox.Refresh();
        }

        private void MandelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MandelCheckBox.Checked)
                JuliaCheckBox.Checked = false;
            else
                JuliaCheckBox.Checked = true;
        }

        private void JuliaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JuliaCheckBox.Checked)
                MandelCheckBox.Checked = false;
            else
                MandelCheckBox.Checked = true;
        }

        private void GenerateFractalButton_Click(object sender, EventArgs e) => GenerateFractal();
        private void RealTextBox_Leave(object sender, EventArgs e) => RealTextBox.Text = RealTextBox.Text.Replace('.', ',');
        private void ImaginaryTextBox_Leave(object sender, EventArgs e) => ImaginaryTextBox.Text = ImaginaryTextBox.Text.Replace('.', ',');
        private void RedTrackBar_ValueChanged(object sender, EventArgs e) => RedNumericUpDown.Value = RedTrackBar.Value;
        private void GreenTrackBar_ValueChanged(object sender, EventArgs e) => GreenNumericUpDown.Value = GreenTrackBar.Value;
        private void BlueTrackBar_ValueChanged(object sender, EventArgs e) => BlueNumericUpDown.Value = BlueTrackBar.Value;
        private void RedNumericUpDown_ValueChanged(object sender, EventArgs e) => RedTrackBar.Value = Convert.ToInt32(RedNumericUpDown.Value);
        private void GreenNumericUpDown_ValueChanged(object sender, EventArgs e) => GreenTrackBar.Value = Convert.ToInt32(GreenNumericUpDown.Value);
        private void BlueNumericUpDown_ValueChanged(object sender, EventArgs e) => BlueTrackBar.Value = Convert.ToInt32(BlueNumericUpDown.Value);

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}