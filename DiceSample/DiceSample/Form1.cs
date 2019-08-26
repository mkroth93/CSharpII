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
            DieD6[] dice = new DieD6[5];


            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new DieD6();

                dice[i].Score = 7;
                dice[i].Image = global::DiceSample.Properties.Resources.dice_six_faces_1;
                dice[i].Location = new System.Drawing.Point(133 + i * 100, 90);
                dice[i].Name = "Die" + i;
                dice[i].Size = new System.Drawing.Size(100, 77);
                dice[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                dice[i].TabIndex = 0;
                dice[i].TabStop = false;

                this.Controls.Add(dice[i]);
            }
        }
    }
}
