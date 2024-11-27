using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using Emgu.CV;
namespace FaceLogin
{
    public partial class Form1 : Form
    {
        FaceRec faceRec = new FaceRec(); 

        public Form1()
        {
            InitializeComponent();
        }
        private void btnCamera_Click_1(object sender, EventArgs e)
        {
            faceRec.openCamera(pbCamera, pbCaptures);
        }

        private void btnSaveImage_Click_1(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(tbName.Text.ToUpper());
            MessageBox.Show("You successfully save your identity");
        }

        private void btnDetectFace_Click_1(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }
    }
}
