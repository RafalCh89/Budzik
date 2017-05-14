using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace Budzik
{
    public partial class frmBudzik : Form
    {
        private DateTime alarm = new DateTime();
        private DateTime current;
        private bool gra = false;
        private bool ustawiony = false;
        private SoundPlayer dzwonek = new System.Media.SoundPlayer("whistle.wav");
        private DateTime koniecalarmu;
        private TimeSpan czastrwania = new TimeSpan(0, 1, 0);

        public frmBudzik()
        {
            InitializeComponent();
            timer.Start();
        }

        private void licznik_Tick(object sender, EventArgs e)
        {
            current = DateTime.Now;
            lblTime.Text = current.ToString("T");
            if (ustawiony &&
                current.Hour == alarm.Hour &&
                current.Minute == alarm.Minute &&
                current.Second == alarm.Second && !gra)
            {
                gra = true;
                mnuSet.Text = "Stop";
                cmdSet.Text = "Stop";
                koniecalarmu = DateTime.Now.Add(czastrwania);
                dzwonek.PlayLooping();
            }
            if (gra)
            {
                if (koniecalarmu.Hour == current.Hour &&
                    koniecalarmu.Minute == current.Minute &&
                    koniecalarmu.Second == current.Second)
                {
                    mnuSet.Text = "Set";
                    cmdSet.Text = "Set";
                    gra = false;
                    dzwonek.Stop();
                }
            }
        }

        private void cmdSet_Click(object sender, EventArgs e)
        {
            if (cmdSet.Text == "Set")
            {
                cmdSet.Text = "OK";
                lblAlarm.Visible = false;
                txtAlarm.Visible = true;
                txtAlarm.Focus();
            }
            else if (cmdSet.Text == "OK")
            {
                DateTime tmp = new DateTime();
                try
                {
                    tmp = DateTime.Parse(txtAlarm.Text);
                }
                catch
                {
                    lblAlarm.Text = "not set";
                    ustawiony = false;
                    txtAlarm.Visible = false;
                    lblAlarm.Visible = true;
                    cmdSet.Text = "Set";
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                alarm = tmp;
                lblAlarm.Text = alarm.ToString("T");
                txtAlarm.Visible = false;
                lblAlarm.Visible = true;
                ustawiony = true;
                cmdSet.Text = "Set";
            }
            else if (cmdSet.Text == "Stop")
            {
                gra = false;
                dzwonek.Stop();
                cmdSet.Text = "Set";
                mnuSet.Text = "Set";
            }
        }

        private void frmBudzik_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                IkonaTray.Visible = true;
            }
        }

        private void mnuPokaz_Click(object sender, EventArgs e)
        {
            this.Show();
            IkonaTray.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuUstaw_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            IkonaTray.Visible = false;
            cmdSet_Click(sender, e);
        }

        private void mnuWylacz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IkonaTray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mnuPokaz_Click(sender, e);
        }

        private void IkonaTray_MouseMove(object sender, MouseEventArgs e)
        {
            IkonaTray.Text = "Time: " + lblTime.Text +
                "\nAlarm: " + lblAlarm.Text;
        }
    }
}