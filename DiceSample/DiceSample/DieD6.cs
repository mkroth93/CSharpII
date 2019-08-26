using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DiceSample
{
    class DieD6 : PictureBox

    {
        private int score;
        private int faceValue;

        public int Score { get => score; set => score = value; }
        public int FaceValue { get => faceValue; set => faceValue = value; }
    }
}
