using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Threading;
namespace ThreadExample
{
    public partial class Form1 : Form
    {

        private delegate void RenewTextBox(String msg);
        private RenewTextBox RTB1, RTB2;

        public Form1()
        {
            //Form1.CheckForIllegalCrossThreadCalls = false; //////  UNSAFE;
            InitializeComponent();

        }


        Thread Thread1;
        private void button_Thread1_Click(object sender, EventArgs e)
        {
            RTB1 = new RenewTextBox(RenewTextBox1);
            Thread1 = new Thread(Thread1Inside);
            Thread1.Start();
        }
        private void Thread1Inside()
        {
            int i = 0;
            while (i < 500)
            {
                textBox_Thread1.Invoke(RTB1, i.ToString());
                i++;
                Thread.Sleep(100);
            }
        }
        private void RenewTextBox1(String s)
        {
            textBox_Thread1.Text = s;
        }


        Thread Thread2;
        private void button_Thread2_Click(object sender, EventArgs e)
        {
            int i;
            bool result = int.TryParse(textBox_InputInt.Text, out i);
            if (result)
            {
                RTB2 = new RenewTextBox(RenewTextBox2);
                ParameterizedThreadStart pts = new ParameterizedThreadStart(RenewTextBox2_obj);
                Thread2 = new Thread(pts);
                Thread2.Start(i.ToString());
            }
            else
                textBox_Thread2.Text = "Not Integer !";
        }
        private void RenewTextBox2_obj(Object objs)
        {
            int inti = Convert.ToInt32(objs);
            int intia = (inti + 500);
            for (; inti <= intia; inti++)
            {
                textBox_Thread1.Invoke(RTB2, inti.ToString());
                Thread.Sleep(200);
            }
        }
        private void RenewTextBox2(String s)
        {
            textBox_Thread2.Text = s;
        }


        private BackgroundWorker bw = new BackgroundWorker();
        private void button_BackgroundWorker_Click(object sender, EventArgs e)
        {
            InitBackGround();
            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }
        private void InitBackGround()
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 1; (i <= 10); i++)
            {
                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress((i * 10));
                }
            }
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.textBox_BackgroundWorker.Text = "Canceled!";
            }
            else if (!(e.Error == null))
            {
                this.textBox_BackgroundWorker.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.textBox_BackgroundWorker.Text = "Done!";
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.textBox_BackgroundWorker.Text = (e.ProgressPercentage.ToString() + "%");
        }
    }
}
