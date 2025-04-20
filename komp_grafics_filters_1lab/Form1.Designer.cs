namespace komp_grafics_filters_1lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.переносToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalWavesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalWavesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.glassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forintI0ISizeIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторШарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светящиесяКраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpness2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motiomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаФильтраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матморфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.proverkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1348, 840);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PeachPuff;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.отменаФильтраToolStripMenuItem,
            this.матморфологияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.grayScaleFilterToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.поворотToolStripMenuItem1,
            this.переносToolStripMenuItem1,
            this.horizontalWavesToolStripMenuItem1,
            this.verticalWavesToolStripMenuItem1,
            this.glassToolStripMenuItem1,
            this.proverkaToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // grayScaleFilterToolStripMenuItem
            // 
            this.grayScaleFilterToolStripMenuItem.Name = "grayScaleFilterToolStripMenuItem";
            this.grayScaleFilterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.grayScaleFilterToolStripMenuItem.Text = "GrayScaleFilter";
            this.grayScaleFilterToolStripMenuItem.Click += new System.EventHandler(this.grayScaleFilterToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem1
            // 
            this.поворотToolStripMenuItem1.Name = "поворотToolStripMenuItem1";
            this.поворотToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.поворотToolStripMenuItem1.Text = "Поворот";
            this.поворотToolStripMenuItem1.Click += new System.EventHandler(this.поворотToolStripMenuItem1_Click);
            // 
            // переносToolStripMenuItem1
            // 
            this.переносToolStripMenuItem1.Name = "переносToolStripMenuItem1";
            this.переносToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.переносToolStripMenuItem1.Text = "Перенос";
            this.переносToolStripMenuItem1.Click += new System.EventHandler(this.переносToolStripMenuItem1_Click);
            // 
            // horizontalWavesToolStripMenuItem1
            // 
            this.horizontalWavesToolStripMenuItem1.Name = "horizontalWavesToolStripMenuItem1";
            this.horizontalWavesToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.horizontalWavesToolStripMenuItem1.Text = "HorizontalWaves";
            this.horizontalWavesToolStripMenuItem1.Click += new System.EventHandler(this.horizontalWavesToolStripMenuItem1_Click);
            // 
            // verticalWavesToolStripMenuItem1
            // 
            this.verticalWavesToolStripMenuItem1.Name = "verticalWavesToolStripMenuItem1";
            this.verticalWavesToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.verticalWavesToolStripMenuItem1.Text = "VerticalWaves";
            this.verticalWavesToolStripMenuItem1.Click += new System.EventHandler(this.verticalWavesToolStripMenuItem1_Click);
            // 
            // glassToolStripMenuItem1
            // 
            this.glassToolStripMenuItem1.Name = "glassToolStripMenuItem1";
            this.glassToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.glassToolStripMenuItem1.Text = "Glass";
            this.glassToolStripMenuItem1.Click += new System.EventHandler(this.glassToolStripMenuItem1_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.forintI0ISizeIToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.sharpnessToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.операторШарраToolStripMenuItem,
            this.операторПрюиттаToolStripMenuItem,
            this.светящиесяКраяToolStripMenuItem,
            this.sharpness2ToolStripMenuItem,
            this.максимумToolStripMenuItem,
            this.медианаToolStripMenuItem,
            this.контурToolStripMenuItem,
            this.motiomToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // forintI0ISizeIToolStripMenuItem
            // 
            this.forintI0ISizeIToolStripMenuItem.Name = "forintI0ISizeIToolStripMenuItem";
            this.forintI0ISizeIToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.forintI0ISizeIToolStripMenuItem.Text = "GaussianFilter";
            this.forintI0ISizeIToolStripMenuItem.Click += new System.EventHandler(this.forintI0ISizeIToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // sharpnessToolStripMenuItem
            // 
            this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
            this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.sharpnessToolStripMenuItem.Text = "Sharpness";
            this.sharpnessToolStripMenuItem.Click += new System.EventHandler(this.sharpnessToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // операторШарраToolStripMenuItem
            // 
            this.операторШарраToolStripMenuItem.Name = "операторШарраToolStripMenuItem";
            this.операторШарраToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.операторШарраToolStripMenuItem.Text = "Оператор Шарра";
            this.операторШарраToolStripMenuItem.Click += new System.EventHandler(this.операторШарраToolStripMenuItem_Click);
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            this.операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            this.операторПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            this.операторПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.операторПрюиттаToolStripMenuItem_Click);
            // 
            // светящиесяКраяToolStripMenuItem
            // 
            this.светящиесяКраяToolStripMenuItem.Name = "светящиесяКраяToolStripMenuItem";
            this.светящиесяКраяToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.светящиесяКраяToolStripMenuItem.Text = "Светящиеся края";
            this.светящиесяКраяToolStripMenuItem.Click += new System.EventHandler(this.светящиесяКраяToolStripMenuItem_Click);
            // 
            // sharpness2ToolStripMenuItem
            // 
            this.sharpness2ToolStripMenuItem.Name = "sharpness2ToolStripMenuItem";
            this.sharpness2ToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.sharpness2ToolStripMenuItem.Text = "Sharpness2";
            this.sharpness2ToolStripMenuItem.Click += new System.EventHandler(this.sharpness2ToolStripMenuItem_Click);
            // 
            // максимумToolStripMenuItem
            // 
            this.максимумToolStripMenuItem.Name = "максимумToolStripMenuItem";
            this.максимумToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.максимумToolStripMenuItem.Text = "Максимум";
            this.максимумToolStripMenuItem.Click += new System.EventHandler(this.максимумToolStripMenuItem_Click);
            // 
            // медианаToolStripMenuItem
            // 
            this.медианаToolStripMenuItem.Name = "медианаToolStripMenuItem";
            this.медианаToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.медианаToolStripMenuItem.Text = "Медиана";
            this.медианаToolStripMenuItem.Click += new System.EventHandler(this.медианаToolStripMenuItem_Click);
            // 
            // контурToolStripMenuItem
            // 
            this.контурToolStripMenuItem.Name = "контурToolStripMenuItem";
            this.контурToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.контурToolStripMenuItem.Text = "Контур";
            this.контурToolStripMenuItem.Click += new System.EventHandler(this.контурToolStripMenuItem_Click);
            // 
            // motiomToolStripMenuItem
            // 
            this.motiomToolStripMenuItem.Name = "motiomToolStripMenuItem";
            this.motiomToolStripMenuItem.Size = new System.Drawing.Size(273, 34);
            this.motiomToolStripMenuItem.Text = "MotionBlur";
            this.motiomToolStripMenuItem.Click += new System.EventHandler(this.motiomToolStripMenuItem_Click);
            // 
            // отменаФильтраToolStripMenuItem
            // 
            this.отменаФильтраToolStripMenuItem.Name = "отменаФильтраToolStripMenuItem";
            this.отменаФильтраToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.отменаФильтраToolStripMenuItem.Text = "Откат фильтра";
            this.отменаФильтраToolStripMenuItem.Click += new System.EventHandler(this.отменаФильтраToolStripMenuItem_Click);
            // 
            // матморфологияToolStripMenuItem
            // 
            this.матморфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.grayWorldToolStripMenuItem,
            this.autoContrastToolStripMenuItem});
            this.матморфологияToolStripMenuItem.Name = "матморфологияToolStripMenuItem";
            this.матморфологияToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.матморфологияToolStripMenuItem.Text = "Матморфология";
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // grayWorldToolStripMenuItem
            // 
            this.grayWorldToolStripMenuItem.Name = "grayWorldToolStripMenuItem";
            this.grayWorldToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.grayWorldToolStripMenuItem.Text = "Gray World";
            this.grayWorldToolStripMenuItem.Click += new System.EventHandler(this.grayWorldToolStripMenuItem_Click);
            // 
            // autoContrastToolStripMenuItem
            // 
            this.autoContrastToolStripMenuItem.Name = "autoContrastToolStripMenuItem";
            this.autoContrastToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.autoContrastToolStripMenuItem.Text = "AutoContrast";
            this.autoContrastToolStripMenuItem.Click += new System.EventHandler(this.autoContrastToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(1148, 886);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 886);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(998, 47);
            this.progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GreenYellow;
            this.button2.Location = new System.Drawing.Point(1016, 887);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // proverkaToolStripMenuItem
            // 
            this.proverkaToolStripMenuItem.Name = "proverkaToolStripMenuItem";
            this.proverkaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.proverkaToolStripMenuItem.Text = "proverka";
            this.proverkaToolStripMenuItem.Click += new System.EventHandler(this.proverkaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1347, 965);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forintI0ISizeIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторШарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаФильтраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светящиесяКраяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpness2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переносToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horizontalWavesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verticalWavesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem glassToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem максимумToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motiomToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem матморфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proverkaToolStripMenuItem;
    }
}

