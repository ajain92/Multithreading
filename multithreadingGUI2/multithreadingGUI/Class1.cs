using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
namespace multithreadingGUI
{
    public class RandomLetters
    {
        private static Random generator = new Random();
        private bool suspend = false;
        private Label output;
        private string threadName;
        public RandomLetters(Label label)
        {
            output = label;
        }

        private delegate void DisplayDelegate(int [] a);

        private void DisplayCharacter(int [] a)
        {int sum=0;
        if (threadName == "Thread 1 ")
        {
            sum = a[0] + a[1];
            output.Text = threadName + " " + a[0] + " + " + a[1] + " = " + sum;
        }
        if (threadName == "Thread 2 ")
        {
            sum = a[0] * a[1];
            output.Text = threadName + " " + a[0] + " * " + a[1] + " = " + sum;
        }
        if (threadName == "Thread 3 ")
        {
            sum = a[0] - a[1];
            output.Text = threadName + " " + a[0] + " - " + a[1] + " = " + sum;
        }

        }

        public void GeneratorRandomCharacter()
        {
            threadName = Thread.CurrentThread.Name;
            while (true)
            {
                Thread.Sleep(generator.Next(1000));
                lock (this)
                {
                    while (suspend)
                    {
                        Monitor.Wait(this);
                    }
                }
                int []num=new int[2] ;
                num[0]= generator.Next(28);
                num[1] = generator.Next(28);
                
                output.Invoke(new DisplayDelegate(DisplayCharacter), new object[] { num });

            }


        }
        public void Toggle()
        {
            suspend = !suspend;
            output.BackColor = suspend ? Color.Red : Color.Green;
            lock (this)
                if (!suspend)
                    Monitor.Pulse(this);
        }
    }
}