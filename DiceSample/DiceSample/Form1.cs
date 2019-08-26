using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DieD6 pictureBox2 = new DieD6();

            // 
            // pictureBox2
            // 
            pictureBox2.Score = 7;
            pictureBox2.Image = global::DiceSample.Properties.Resources.dice_six_faces_two;
            pictureBox2.Location = new System.Drawing.Point(133, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(260, 77);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;

            this.Controls.Add(pictureBox2);
        }
    }
}
