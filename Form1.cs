namespace Budzik
{
    partial class frmBudzik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBudzik));
            this.cmdSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.IkonaTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuIkonaTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWylacz = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIkonaTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSet
            // 
            this.cmdSet.Location = new System.Drawing.Point(135, 1);
            this.cmdSet.Name = "cmdSet";
            this.cmdSet.Size = new System.Drawing.Size(58, 23);
            this.cmdSet.TabIndex = 0;
            this.cmdSet.Text = "Set";
            this.cmdSet.UseVisualStyleBackColor = true;
            this.cmdSet.Click += new System.EventHandler(this.cmdSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alarm";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(51, 6);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(72, 13);
            this.lblAlarm.TabIndex = 2;
            this.lblAlarm.Text = "not set";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.licznik_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(51, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Time";
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(51, 3);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(62, 20);
            this.txtAlarm.TabIndex = 5;
            this.txtAlarm.Visible = false;
            // 
            // IkonaTray
            // 
            this.IkonaTray.ContextMenuStrip = this.mnuIkonaTray;
            this.IkonaTray.Icon = ((System.Drawing.Icon)(resources.GetObject("IkonaTray.Icon")));
            this.IkonaTray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IkonaTray_MouseMove);
            this.IkonaTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IkonaTray_MouseClick);
            // 
            // mnuIkonaTray
            // 
            this.mnuIkonaTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShow,
            this.mnuSet,
            this.mnuWylacz});
            this.mnuIkonaTray.Name = "mnuIkonaTray";
            this.mnuIkonaTray.Size = new System.Drawing.Size(121, 70);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(120, 22);
            this.mnuShow.Text = "Poka¿";
            this.mnuShow.Click += new System.EventHandler(this.mnuPokaz_Click);
            // 
            // mnuSet
            // 
            this.mnuSet.Name = "mnuSet";
            this.mnuSet.Size = new System.Drawing.Size(120, 22);
            this.mnuSet.Text = "Set";
            this.mnuSet.Click += new System.EventHandler(this.mnuUstaw_Click);
            // 
            // mnuWylacz
            // 
            this.mnuWylacz.Name = "mnuWylacz";
            this.mnuWylacz.Size = new System.Drawing.Size(120, 22);
            this.mnuWylacz.Text = "Wy³¹cz";
            this.mnuWylacz.Click += new System.EventHandler(this.mnuWylacz_Click);
            // 
            // frmBudzik
            // 
            this.AcceptButton = this.cmdSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(205, 50);
            this.Controls.Add(this.txtAlarm);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSet);
            this.MaximizeBox = false;
            this.Name = "frmBudzik";
            this.Text = "Budzik";
            this.Resize += new System.EventHandler(this.frmBudzik_Resize);
            this.mnuIkonaTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlarm;
        private System.Windows.Forms.NotifyIcon IkonaTray;
        private System.Windows.Forms.ContextMenuStrip mnuIkonaTray;
        private System.Windows.Forms.ToolStripMenuItem mnuShow;
        private System.Windows.Forms.ToolStripMenuItem mnuSet;
        private System.Windows.Forms.ToolStripMenuItem mnuWylacz;
    }
}

