using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TheRaceBetweenTortoiseAndRabbit
{
    public partial class Form1 : Form
    {
        bool isFinished = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isFinished = false;
            Thread threadRabbit = new Thread(rabbitRun);
            Thread threadTortoise = new Thread(tortoiseRun);
            threadRabbit.Start();
            threadTortoise.Start();
            label1.Text = "The race is begin!";

        }

        public void rabbitRun()
        {
            Random random = new Random();
            int numRandom = random.Next(100, 500);
            for (int i = 1; i <= 700; i++)
            {

                pbRabbit.Location = new Point(38 + i, 12);
                Thread.Sleep(10);
                if (i == numRandom)
                {
                    label1.Text = "Rabbit is sleeping...zZZ";
                    Thread.Sleep(new Random().Next(600, 2000));
                    label1.Text = "Rabbit is going on...";
                }
            }
            if (!isFinished)
            {
                showResult(1);
                isFinished = true;
            }

            //if (InvokeRequired)
            //{
            //    Action actionRabbit = delegate
            //    {
            //        for (int i = 1; i <= 600; i++)
            //        {
            //            pbRabbit.Location = new Point(38 + i, 12);
            //            Thread.Sleep(10);
            //        }
            //    };
            //}

        }

        public void tortoiseRun()
        {

            for (int i = 1; i <= 700; i++)
            {

                pbTortoise.Location = new Point(38 + i, 183);
                Thread.Sleep(12);

            }
            if (!isFinished)
            {
                showResult(2);
                isFinished = true;
            }

            //if (InvokeRequired)
            //{
            //    Action actionTortoise = delegate
            //    {
            //        for (int i = 1; i <= 600; i++)
            //        {
            //            pbTortoise.Location = new Point(38 + i, 183);
            //            Thread.Sleep(12);
            //        }
            //    };
            //}

        }
        public void showResult(int result)
        {
            switch (result)
            {
                case 1:
                    label1.Text = "The rabbit win the game";
                    break;
                case 2:
                    label1.Text = "The tortoise win the game";
                    break;
                default:
                    break;
            }
        }
    }
}
