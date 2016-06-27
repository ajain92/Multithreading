using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace multithreadingGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private RandomLetters letter1, letter2, letter3;
        private void Form1_Load(object sender, EventArgs e)
        {
            letter1 = new RandomLetters(thread1label);
            letter2 = new RandomLetters(thread2label);
            letter3 = new RandomLetters(thread3label);
            Thread firstThread = new Thread(new ThreadStart(letter1.GeneratorRandomCharacter));
            firstThread.Name = "Thread 1 ";
            firstThread.Start();
            Thread secondthread = new Thread(new ThreadStart(letter2.GeneratorRandomCharacter));
            secondthread.Name = "Thread 2 ";
            secondthread.Start();
            Thread thirdThread = new Thread(new ThreadStart(letter3.GeneratorRandomCharacter));
            thirdThread.Name = "Thread 3 ";
            thirdThread.Start();

        }

        private void thread1checkbox_CheckedChanged(object sender, EventArgs e)
        {
            letter1.Toggle();
        }

        private void thread2checkbox_CheckedChanged(object sender, EventArgs e)
        {
            letter2.Toggle();
        }

        private void thread3checkbox_CheckedChanged(object sender, EventArgs e)
        {
            letter3.Toggle();
        }

    }
}
