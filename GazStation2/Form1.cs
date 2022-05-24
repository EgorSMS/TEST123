using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazStation2
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void enternumberBTN_Click(object sender, EventArgs e)
        {
            PictureAndNumber pictureAndNumber = new PictureAndNumber(pictureBox1.Image);
            pictureAndNumber.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void enterPicktureBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл!");

                }
            }
            if (openFileDialog.FileName.Contains("не"))
            {
                label1.Text = "Номер не распознан";
            }
            else
            {
                label1.Text = openFileDialog.SafeFileName.Split('.')[0];
            }
        }

        private void checkBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
