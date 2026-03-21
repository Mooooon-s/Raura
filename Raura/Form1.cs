using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;

namespace Raura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = $"이미지 찾기";
            ofd.Filter = $"이미지 파일|*.jpg;*.jepg;*.png";
            ofd.Multiselect = false ;

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            Mat img = Cv2.ImRead(ofd.FileName);

            if (img.Empty())
            {
                MessageBox.Show("이미지를 로드하지 못했습니다.");
            }

            MessageBox.Show($"가로:{img.Width}, 세로 {img.Height}");

            Bitmap bit = BitmapConverter.ToBitmap(img);

            pictureBox1.Image = bit;
        }
    }
}
