using FacialRecognitionSystem.FaceRecognition;
using System;
using System.Windows.Forms;

namespace FacialRecognitionSystem
{
    public partial class Form1 : Form
    {
        FaceId faceRec = new FaceId();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCamara_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBoxCamara, pictureBoxCaptured);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(txtName.Text.ToUpper());
            lblmsg.ForeColor = System.Drawing.Color.Green;
            lblmsg.Text = "Saved";
        }

        private void btnDetectFace_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
            faceRec.getPersonName(lblName);
        }
    }
}
