
namespace SkellamDistribution
{
    partial class SkellamDistribution
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отСоздателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownM1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM2 = new System.Windows.Forms.NumericUpDown();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonPauseResume = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTables = new System.Windows.Forms.Button();
            this.progressBarReverse = new System.Windows.Forms.ProgressBar();
            this.progressBarNeuman = new System.Windows.Forms.ProgressBar();
            this.progressBarMetropolis = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelComplReverse = new System.Windows.Forms.Label();
            this.labelComplNeuman = new System.Windows.Forms.Label();
            this.labelComplMetrop = new System.Windows.Forms.Label();
            this.numericUpDownExperiments = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiments)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файдToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.отСоздателейToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1356, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файдToolStripMenuItem
            // 
            this.файдToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файдToolStripMenuItem.Name = "файдToolStripMenuItem";
            this.файдToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файдToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(249, 34);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как ...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // отСоздателейToolStripMenuItem
            // 
            this.отСоздателейToolStripMenuItem.Name = "отСоздателейToolStripMenuItem";
            this.отСоздателейToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.отСоздателейToolStripMenuItem.Text = "От создателей";
            this.отСоздателейToolStripMenuItem.Click += new System.EventHandler(this.отСоздателейToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "К-во экспериментов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "μ1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "μ2:";
            // 
            // numericUpDownM1
            // 
            this.numericUpDownM1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownM1.Location = new System.Drawing.Point(380, 60);
            this.numericUpDownM1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownM1.Name = "numericUpDownM1";
            this.numericUpDownM1.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownM1.TabIndex = 6;
            this.numericUpDownM1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownM2
            // 
            this.numericUpDownM2.Location = new System.Drawing.Point(580, 60);
            this.numericUpDownM2.Name = "numericUpDownM2";
            this.numericUpDownM2.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownM2.TabIndex = 7;
            this.numericUpDownM2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(30, 109);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(150, 35);
            this.buttonStartStop.TabIndex = 8;
            this.buttonStartStop.Text = "Старт | Стоп";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // buttonPauseResume
            // 
            this.buttonPauseResume.Location = new System.Drawing.Point(210, 109);
            this.buttonPauseResume.Name = "buttonPauseResume";
            this.buttonPauseResume.Size = new System.Drawing.Size(200, 35);
            this.buttonPauseResume.TabIndex = 9;
            this.buttonPauseResume.Text = "Пауза | Продолжить";
            this.buttonPauseResume.UseVisualStyleBackColor = true;
            this.buttonPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(440, 109);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 35);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTables
            // 
            this.buttonTables.Enabled = false;
            this.buttonTables.Location = new System.Drawing.Point(570, 109);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(110, 35);
            this.buttonTables.TabIndex = 11;
            this.buttonTables.Text = "Таблицы";
            this.buttonTables.UseVisualStyleBackColor = true;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // progressBarReverse
            // 
            this.progressBarReverse.Location = new System.Drawing.Point(30, 220);
            this.progressBarReverse.Name = "progressBarReverse";
            this.progressBarReverse.Size = new System.Drawing.Size(650, 25);
            this.progressBarReverse.TabIndex = 12;
            // 
            // progressBarNeuman
            // 
            this.progressBarNeuman.Location = new System.Drawing.Point(30, 300);
            this.progressBarNeuman.Name = "progressBarNeuman";
            this.progressBarNeuman.Size = new System.Drawing.Size(650, 25);
            this.progressBarNeuman.TabIndex = 13;
            // 
            // progressBarMetropolis
            // 
            this.progressBarMetropolis.Location = new System.Drawing.Point(30, 380);
            this.progressBarMetropolis.Name = "progressBarMetropolis";
            this.progressBarMetropolis.Size = new System.Drawing.Size(650, 25);
            this.progressBarMetropolis.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Метод обратных функций";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Метод Неймана";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Метод Метрополиса";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.WorkerSupportsCancellation = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(30, 434);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1287, 617);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Выполнено экспериментов:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Выполнено экспериментов:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Выполнено экспериментов:";
            // 
            // labelComplReverse
            // 
            this.labelComplReverse.AutoSize = true;
            this.labelComplReverse.Location = new System.Drawing.Point(530, 189);
            this.labelComplReverse.Name = "labelComplReverse";
            this.labelComplReverse.Size = new System.Drawing.Size(0, 20);
            this.labelComplReverse.TabIndex = 22;
            // 
            // labelComplNeuman
            // 
            this.labelComplNeuman.AutoSize = true;
            this.labelComplNeuman.Location = new System.Drawing.Point(530, 269);
            this.labelComplNeuman.Name = "labelComplNeuman";
            this.labelComplNeuman.Size = new System.Drawing.Size(0, 20);
            this.labelComplNeuman.TabIndex = 23;
            // 
            // labelComplMetrop
            // 
            this.labelComplMetrop.AutoSize = true;
            this.labelComplMetrop.Location = new System.Drawing.Point(530, 349);
            this.labelComplMetrop.Name = "labelComplMetrop";
            this.labelComplMetrop.Size = new System.Drawing.Size(0, 20);
            this.labelComplMetrop.TabIndex = 24;
            // 
            // numericUpDownExperiments
            // 
            this.numericUpDownExperiments.Location = new System.Drawing.Point(210, 60);
            this.numericUpDownExperiments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownExperiments.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownExperiments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExperiments.Name = "numericUpDownExperiments";
            this.numericUpDownExperiments.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownExperiments.TabIndex = 25;
            this.numericUpDownExperiments.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // SkellamDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 1050);
            this.Controls.Add(this.numericUpDownExperiments);
            this.Controls.Add(this.labelComplMetrop);
            this.Controls.Add(this.labelComplNeuman);
            this.Controls.Add(this.labelComplReverse);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBarMetropolis);
            this.Controls.Add(this.progressBarNeuman);
            this.Controls.Add(this.progressBarReverse);
            this.Controls.Add(this.buttonTables);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPauseResume);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.numericUpDownM2);
            this.Controls.Add(this.numericUpDownM1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SkellamDistribution";
            this.Text = "SkellamDistribution";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отСоздателейToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownM1;
        private System.Windows.Forms.NumericUpDown numericUpDownM2;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonPauseResume;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.ProgressBar progressBarReverse;
        private System.Windows.Forms.ProgressBar progressBarNeuman;
        private System.Windows.Forms.ProgressBar progressBarMetropolis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelComplReverse;
        private System.Windows.Forms.Label labelComplNeuman;
        private System.Windows.Forms.Label labelComplMetrop;
        private System.Windows.Forms.NumericUpDown numericUpDownExperiments;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    }
}

