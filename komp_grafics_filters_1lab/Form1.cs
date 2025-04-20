using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace komp_grafics_filters_1lab
{
    public partial class Form1 : Form
    {
        public Bitmap image;
        Bitmap image2;
        private float _originalWidth;
        private float _originalHeight;
        public Form1()
        {
            InitializeComponent();
        }

        public PictureBox MyPictureBox()
        {
            return pictureBox1;  // pictureBox1 - имя PictureBox, созданного в дизайнере
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp; | All Files (*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK) { 
                image = new Bitmap(dialog.FileName);
                image2 = image;
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilters filter = new InvertFilters();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true) image = newImage;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled) {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlurFilter filters = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void forintI0ISizeIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianFilter filters = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void grayScaleFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayScaleFilter filters = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia filters = new Sepia();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Brightness filters = new Brightness();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobel filters = new Sobel('X');
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sharpness filters = new Sharpness();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embossing filters = new Embossing(128);
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void операторШарраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorSharra filters = new OperatorSharra(false);
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void операторПрюиттаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorPruitta filters = new OperatorPruitta(false);
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void отменаФильтраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image2;
            image = image2;
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void светящиесяКраяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrayaSvet filters = new KrayaSvet();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void sharpness2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sharpness2 filters = new Sharpness2();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void поворотToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Povorot filters = new Povorot();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void переносToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Perenos filters = new Perenos();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void horizontalWavesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HorizontalWaves filters = new HorizontalWaves();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void verticalWavesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerticalWaves filters = new VerticalWaves();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void glassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Glass filters = new Glass();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void максимумToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maximum filters = new Maximum();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void медианаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mediana filters = new Mediana();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void контурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontur filters = new Kontur();
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void motiomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotionBlur filters = new MotionBlur(5);
            backgroundWorker1.RunWorkerAsync(filters);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image files | *.png; *.jpg; *.bmp; | All Files (*.*) | *.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ImageFormat format = ImageFormat.Png; // Значение по умолчанию
                image.Save(filePath, format);
            }
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilation matmorf = new Dilation();
            backgroundWorker1.RunWorkerAsync(matmorf);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion matmorf = new Erosion();
            backgroundWorker1.RunWorkerAsync(matmorf);
        }

        private void grayWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayWorld matmorf = new GrayWorld();
            backgroundWorker1.RunWorkerAsync(matmorf);
        }

        private void autoContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoContrast matmorf = new AutoContrast();
            backgroundWorker1.RunWorkerAsync(matmorf);
        }

        private void proverkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proverka matmorf = new proverka();
            backgroundWorker1.RunWorkerAsync(matmorf);
        }
    }
}
