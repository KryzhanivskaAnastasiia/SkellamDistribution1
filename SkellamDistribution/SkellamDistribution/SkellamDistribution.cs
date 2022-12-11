using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkellamDistribution
{
    public partial class SkellamDistribution : Form
    {
        private CalculationGenerator calculationGenerator;
        private long experiments_number;
        private double M1, M2;

        private double percent;
        private bool stopped;

        private long currentReverse;
        private long currentNeumann;
        private long currentMetropolis;

        private double percentStepCountReverse;
        private double percentStepCountNeumann;
        private double percentStepCountMetropolis;

        private int currentPercentReverse;
        private int currentPercentNeumann;
        private int currentPercentMetropolis;

        private bool completedReverse = false;
        private bool completedNeumann = false;
        private bool completedMetropolis = false;

        private bool pausedReverse = false;
        private bool pausedNeumann = false;
        private bool pausedMetropolis = false;

        private string filename;


        public SkellamDistribution()
        {
            InitializeComponent();
            stopped = false;
            this.buttonPauseResume.Enabled = false;
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (long i = currentReverse; i < experiments_number; i++)
            {
                calculationGenerator.generateRandomReverse();
                percentStepCountReverse += 1;
                if (percentStepCountReverse >= percent)
                {
                    while (percentStepCountReverse >= percent)
                    {
                        worker.ReportProgress(1);
                        percentStepCountReverse = percentStepCountReverse - percent;
                        currentPercentReverse++;
                    }
                    percentStepCountReverse = 0;
                }
                currentReverse++;
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    System.Threading.Thread.Sleep(5);
                    return;
                }
            }
            while (currentPercentReverse < 100)
            {
                System.Threading.Thread.Sleep(5);
                worker.ReportProgress(1);
                currentPercentReverse++;
            }
        }

        public long getNumberOfSteps(Dictionary<int, long> dictionary)
        {

            long NumberOfSteps = 0;
            foreach (KeyValuePair<int, long> i in dictionary)
            {
                NumberOfSteps += i.Value;
            }
            return NumberOfSteps;

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (long i = currentNeumann; i < experiments_number; i++)
            {
                calculationGenerator.generateRandomNeyman();
                percentStepCountNeumann += 1;
                if (percentStepCountNeumann >= percent)
                {
                    while (percentStepCountNeumann >= percent)
                    {
                        worker.ReportProgress(1);
                        percentStepCountNeumann = percentStepCountNeumann - percent;
                        currentPercentNeumann++;
                    }
                    percentStepCountNeumann = 0;
                }
                currentNeumann++;
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
            }
            while (currentPercentNeumann < 100)
            {
                System.Threading.Thread.Sleep(5);
                worker.ReportProgress(1);
                currentPercentNeumann++;
            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (long i = currentMetropolis; i < experiments_number; i++)
            {
                calculationGenerator.generateRandomMetropolys();
                percentStepCountMetropolis += 1;
                if (percentStepCountMetropolis >= percent)
                {
                    while (percentStepCountMetropolis >= percent)
                    {
                        worker.ReportProgress(1);
                        percentStepCountMetropolis = percentStepCountMetropolis - percent;
                        currentPercentMetropolis++;
                    }
                    percentStepCountMetropolis = 0;
                }
                currentMetropolis++;

                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
            }
            while (currentPercentMetropolis < 100)
            {
                System.Threading.Thread.Sleep(5);
                worker.ReportProgress(1);
                currentPercentMetropolis++;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarReverse.PerformStep();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pausedReverse == false)
            {
                completedReverse = true;

                this.buttonTables.Enabled = true;
                checkFinished();
            }
            labelComplReverse.Text = getNumberOfSteps(calculationGenerator.getProcessData().reverseDictionary).ToString();
        }

        private void отСоздателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.Show();

        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creator creator = new Creator();
            creator.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "XML files(*.dat)|*.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            ProcessData processData;
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    try
                    {
                        processData = (ProcessData)formatter.Deserialize(fs);
                        if (calculationGenerator == null)
                        {
                            calculationGenerator = new CalculationGenerator(processData);
                        }
                        else
                        {
                            calculationGenerator.setProcessData(processData);
                        }
                        fs.Close();
                        clear();
                        prepareOpenFileData(processData);
                    }
                    catch (System.InvalidOperationException)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Error;
                        MessageBox.Show("Невозможно открыть файл!", "ERROR", buttons, icon);
                    }
                }
            }

            catch (System.IO.IOException)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Невозможно открыть файл!", "ERROR", buttons, icon);
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename != null)
                saveFile();
            else
            {
                сохранитьКакToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveFile()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, calculationGenerator.getProcessData());
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarNeuman.PerformStep();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (pausedNeumann == false)
            {
                completedNeumann = true;
                checkFinished();
                this.buttonTables.Enabled = true;
            }
            labelComplNeuman.Text = getNumberOfSteps(calculationGenerator.getProcessData().neumannDictionary).ToString();
        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarMetropolis.PerformStep();
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (pausedMetropolis == false)
            {
                completedMetropolis = true;
                checkFinished();
                this.buttonTables.Enabled = true;
            }
            labelComplMetrop.Text = getNumberOfSteps(calculationGenerator.getProcessData().metropolisDictionary).ToString();
        }


        private void buttonTables_Click(object sender, EventArgs e)
        {
            try
            {

                TablesForm tablesForm = new TablesForm(calculationGenerator.getProcessData());
                tablesForm.Show();
            }
            catch (Exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("Нельзя создать таблицы!", "ERROR", buttons, icon);
            }
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (pausedReverse || pausedNeumann || pausedMetropolis)
            {
                pausedReverse = false;
                pausedNeumann = false;
                pausedMetropolis = false;
                stopped = true;
            }
            if (!dataValidation())
                return;
            if (stopped == true)
            {
                progressBarReverse.Value = 0;
                progressBarNeuman.Value = 0;
                progressBarMetropolis.Value = 0;
                stopped = false;
            }
            if (backgroundWorker1.IsBusy != true && backgroundWorker2.IsBusy != true && backgroundWorker3.IsBusy != true)
            {
                enablingChange(false);
                lock (this)
                {
                    prepareStartData();
                    calculationGenerator.addExperiment();
                    buttonClear.Enabled = false;
                    calculationGenerator.makeSomeMetropolysSteps(10000);
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.RunWorkerAsync();
                    backgroundWorker3.RunWorkerAsync();
                }
            }
            else if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                enablingChange(true);
                stopped = true;
                lock (this)
                {
                    backgroundWorker1.CancelAsync();
                    backgroundWorker2.CancelAsync();
                    backgroundWorker3.CancelAsync();
                }
            }
        }

        private void buttonPauseResume_Click(object sender, EventArgs e)
        {
            if (!stopped)
            {
                if ((backgroundWorker1.IsBusy != true) && currentReverse != experiments_number)
                {
                    pausedReverse = false;
                    backgroundWorker1.RunWorkerAsync();
                    checkPauseButtons(true);
                }
                else if (backgroundWorker1.WorkerSupportsCancellation == true || currentReverse == experiments_number)
                {
                    pausedReverse = true;
                    calculationGenerator.getProcessData().percentReverse = currentPercentReverse;
                    backgroundWorker1.CancelAsync();
                    checkPauseButtons(false);
                }
                if (backgroundWorker2.IsBusy != true && currentNeumann != experiments_number)
                {
                    pausedNeumann = false;
                    backgroundWorker2.RunWorkerAsync();
                    checkPauseButtons(true);
                }
                else if (backgroundWorker2.WorkerSupportsCancellation == true || currentNeumann == experiments_number)
                {
                    pausedNeumann = true;
                    calculationGenerator.getProcessData().percentNeumann = currentPercentNeumann;
                    backgroundWorker2.CancelAsync();
                    checkPauseButtons(false);
                }
                if (backgroundWorker3.IsBusy != true && currentMetropolis != experiments_number)
                {
                    pausedMetropolis = false;
                    backgroundWorker3.RunWorkerAsync();
                    checkPauseButtons(true);
                }
                else if (backgroundWorker3.WorkerSupportsCancellation == true || currentMetropolis == experiments_number)
                {
                    pausedMetropolis = true;
                    calculationGenerator.getProcessData().percentMetropolis = currentPercentMetropolis;
                    backgroundWorker3.CancelAsync();
                    checkPauseButtons(false);
                }

                if (pausedReverse && pausedNeumann && pausedMetropolis)
                {
                    System.Threading.Thread.Sleep(5);
                    calculationGenerator.setCurrentNumberOfSteps(currentReverse, currentNeumann, currentMetropolis);
                    createCharts(currentReverse, currentNeumann, currentMetropolis, calculationGenerator.getProcessData());

                    this.buttonTables.Enabled = true;
                }
            }

        }

        private void createCharts(long number1, long number2, long number3, ProcessData stats)
        {

            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.Series.Clear();
            chart1.Series.Add("Метод обратной функции");
            chart1.Series.Add("Метод Неймана");
            chart1.Series.Add("Метод Метрополиса");

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            int x;
            double y;

            foreach (KeyValuePair<int, long> i in stats.reverseDictionary)
            {
                x = i.Key;
                y = (double)i.Value / number1;
                chart1.Series[0].Points.AddXY(x, y);
            }

            foreach (KeyValuePair<int, long> i in stats.neumannDictionary)
            {
                x = i.Key;
                y = (double)i.Value / number2;
                chart1.Series[1].Points.AddXY(x, y);
            }

            foreach (KeyValuePair<int, long> i in stats.metropolisDictionary)
            {
                x = i.Key;
                y = (double)i.Value / number3;
                chart1.Series[2].Points.AddXY(x, y);
            }
        }

        private void checkPauseButtons(bool state)
        {
            if (buttonClear.Enabled == state)
            {
                buttonClear.Enabled = !state;
            }
            if (buttonTables.Enabled == state)
            {
                buttonTables.Enabled = !state;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (!dataValidation())
                return;
            calculationGenerator = new CalculationGenerator(M1, M2, experiments_number);
            this.currentReverse = 0;
            this.currentNeumann = 0;
            this.currentMetropolis = 0;
            clear();
            enablingChange(true);

            numericUpDownExperiments.Value = Decimal.Parse(10000.ToString());
            numericUpDownM1.Value = Decimal.Parse(1.ToString());
            numericUpDownM2.Value = Decimal.Parse(1.ToString());
            this.buttonTables.Enabled = false;

        }
        private void clear()
        {
            currentPercentReverse = 0;
            currentPercentNeumann = 0;
            currentPercentMetropolis = 0;
            currentReverse = 0;
            currentNeumann = 0;
            currentMetropolis = 0;

            progressBarReverse.Value = 0;
            progressBarNeuman.Value = 0;
            progressBarMetropolis.Value = 0;

            completedReverse = false;
            completedNeumann = false;
            completedMetropolis = false;

            labelComplReverse.Text = "";
            labelComplNeuman.Text = "";
            labelComplMetrop.Text = "";

        }

        private void prepareStartData()
        {
            clear();
            progressBarReverse.Minimum = 0;
            progressBarReverse.Maximum = 100;
            progressBarReverse.Step = 1;

            progressBarNeuman.Minimum = 0;
            progressBarNeuman.Maximum = 100;
            progressBarNeuman.Step = 1;

            progressBarMetropolis.Minimum = 0;
            progressBarMetropolis.Maximum = 100;
            progressBarMetropolis.Step = 1;

            this.percentStepCountReverse = 0;
            this.percentStepCountNeumann = 0;
            this.percentStepCountMetropolis = 0;


            labelComplReverse.Text = getNumberOfSteps(calculationGenerator.getProcessData().reverseDictionary).ToString();
            labelComplNeuman.Text = getNumberOfSteps(calculationGenerator.getProcessData().neumannDictionary).ToString();
            labelComplMetrop.Text = getNumberOfSteps(calculationGenerator.getProcessData().metropolisDictionary).ToString();
            percent = experiments_number / 100.00;
        }

        private bool dataValidation()
        {
            bool flag = true;
            string s = "";
            experiments_number = Convert.ToInt64(numericUpDownExperiments.Text);
            if (experiments_number > Int64.MaxValue)
            {
                s = "Слишком много итераций!";
                flag = false;
            }
            M1 = Convert.ToDouble(numericUpDownM1.Text);
            M2 = Convert.ToDouble(numericUpDownM2.Text);
            
            if (!flag)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show(s, "ERROR", buttons, icon);
            }

            if (calculationGenerator == null)
            {
                calculationGenerator = new CalculationGenerator(M1, M2, experiments_number);
            }
            else
            {
                calculationGenerator.setNewData(M1, M2, experiments_number);
            }
            return flag;
        }

        private void enablingChange(bool state)
        {
            numericUpDownExperiments.Enabled = state;
            numericUpDownM1.Enabled = state;
            numericUpDownM2.Enabled = state;
            this.buttonPauseResume.Enabled = !state;
            this.buttonClear.Enabled = state;
        }

        private void checkFinished()
        {
            if (completedReverse == true && completedNeumann == true && completedMetropolis == true)
            {
                stopped = true;
                this.calculationGenerator.setCurrentNumberOfSteps(currentReverse, currentNeumann, currentMetropolis);
                calculationGenerator.getProcessData().percentReverse = currentPercentReverse;
                calculationGenerator.getProcessData().percentNeumann = currentPercentNeumann;
                calculationGenerator.getProcessData().percentMetropolis = currentPercentMetropolis;
                createCharts(currentReverse, currentNeumann, currentMetropolis, calculationGenerator.getProcessData());
                enablingChange(true);
            }
        }

        private void prepareOpenFileData(ProcessData stats)
        {
            M1 = calculationGenerator.getProcessData().a;
            numericUpDownM1.Text = M1.ToString();
            M2 = calculationGenerator.getProcessData().b;
            numericUpDownM2.Text = M2.ToString();
            experiments_number = calculationGenerator.getProcessData().numberOfExperiments;

            currentReverse = stats.currentStepsNumberReverse;
            currentNeumann = stats.currentStepsNumberNeumann;
            currentMetropolis = stats.currentStepsNumberMetropolis;

            percentStepCountReverse = stats.percentStepCountReverse;
            percentStepCountNeumann = stats.percentStepCountNeumann;
            percentStepCountMetropolis = stats.percentStepCountMetropolis;

            currentReverse = stats.percentReverse;
            currentNeumann = stats.percentNeumann;
            currentMetropolis = stats.percentMetropolis;

            progressBarReverse.Value = currentPercentReverse;
            progressBarNeuman.Value = currentPercentNeumann;
            progressBarMetropolis.Value = currentPercentMetropolis;

            progressBarReverse.Minimum = 0;
            progressBarReverse.Maximum = 100;
            progressBarReverse.Step = 1;

            progressBarNeuman.Minimum = 0;
            progressBarNeuman.Maximum = 100;
            progressBarNeuman.Step = 1;

            progressBarMetropolis.Minimum = 0;
            progressBarMetropolis.Maximum = 100;
            progressBarMetropolis.Step = 1;

            if (currentReverse == experiments_number && currentNeumann == experiments_number && currentMetropolis == experiments_number)
                enablingChange(true);
            else
                enablingChange(false);
            buttonClear.Enabled = true;
            buttonTables.Enabled = true;
            pausedReverse = true;
            pausedNeumann = true;
            pausedMetropolis = true;

            if (currentReverse == experiments_number)
            {
                completedReverse = true;
                labelComplReverse.Text = getNumberOfSteps(calculationGenerator.getProcessData().reverseDictionary).ToString();
            }
            if (currentNeumann == experiments_number)
            {
                completedNeumann = true;
                labelComplNeuman.Text = getNumberOfSteps(calculationGenerator.getProcessData().neumannDictionary).ToString();
            }
            if (currentMetropolis == experiments_number)
            {
                completedMetropolis = true;
                labelComplMetrop.Text = getNumberOfSteps(calculationGenerator.getProcessData().metropolisDictionary).ToString();
            }
            percent = experiments_number / 100.0;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (calculationGenerator != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Binary files(*.dat)|*.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = saveFileDialog1.FileName;
                saveFile();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show("File saved", "Success", buttons, icon);
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("No data to save", "Erorr while saving", buttons, icon);
            }
        }
    }
}
