using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARPReply
{
    public partial class ArpReplyForm : Form
    {
        BackgroundWorker _runner;
        string _startButtonText = "Start";

        public ArpReplyForm()
        {
            InitializeComponent();
        }

        private void arpInjectButton_Click(object sender, EventArgs e)
        {
            arpInjectButton.Enabled = false;
            arpInjectButton.Text = "Sending ARP replies..";
            _runner.RunWorkerAsync(new string[] { myMacCombo.Text, myIPCombo.Text, nextHopMacCombo.Text, sendersIPCombo.Text, packetsCountCombo.Text });
        }

        private void ArpReplyForm_Load(object sender, EventArgs e)
        {
            _runner = new BackgroundWorker();
            _runner.DoWork +=_runner_DoWork;
            _runner.RunWorkerCompleted +=_runner_RunWorkerCompleted;
        }

        void _runner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            arpInjectButton.Enabled = true;
            arpInjectButton.Text = _startButtonText;
        }

        void _runner_DoWork(object sender, DoWorkEventArgs e)
        {
 	        Program.Start((string[])e.Argument);
        }
    }
}
