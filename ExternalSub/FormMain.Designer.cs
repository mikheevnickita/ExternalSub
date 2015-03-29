namespace ExternalSub
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftPicker = new System.Windows.Forms.NumericUpDown();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panCenter = new System.Windows.Forms.Panel();
            this.panTranslate = new System.Windows.Forms.Panel();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.panSubtitles = new System.Windows.Forms.Panel();
            this.sub3 = new ExternalSub.ucSubtitleItemViewer();
            this.sub2 = new ExternalSub.ucSubtitleItemViewer();
            this.sub1 = new ExternalSub.ucSubtitleItemViewer();
            this.sub0 = new ExternalSub.ucSubtitleItemViewer();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftPicker)).BeginInit();
            this.panCenter.SuspendLayout();
            this.panTranslate.SuspendLayout();
            this.panSubtitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.shiftPicker);
            this.panTop.Controls.Add(this.btnTime);
            this.panTop.Controls.Add(this.btnDisconnect);
            this.panTop.Controls.Add(this.btnConnect);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(524, 30);
            this.panTop.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Shift";
            // 
            // shiftPicker
            // 
            this.shiftPicker.Location = new System.Drawing.Point(332, 6);
            this.shiftPicker.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.shiftPicker.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.shiftPicker.Name = "shiftPicker";
            this.shiftPicker.Size = new System.Drawing.Size(84, 20);
            this.shiftPicker.TabIndex = 13;
            this.shiftPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTime
            // 
            this.btnTime.Enabled = false;
            this.btnTime.Location = new System.Drawing.Point(84, 3);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(75, 23);
            this.btnTime.TabIndex = 12;
            this.btnTime.Text = "--:--:--";
            this.btnTime.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(165, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.panTranslate);
            this.panCenter.Controls.Add(this.panSubtitles);
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(0, 30);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(524, 956);
            this.panCenter.TabIndex = 111;
            // 
            // panTranslate
            // 
            this.panTranslate.Controls.Add(this.translateTextBox);
            this.panTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTranslate.Location = new System.Drawing.Point(0, 583);
            this.panTranslate.Name = "panTranslate";
            this.panTranslate.Size = new System.Drawing.Size(524, 373);
            this.panTranslate.TabIndex = 1;
            // 
            // translateTextBox
            // 
            this.translateTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.translateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.translateTextBox.Location = new System.Drawing.Point(0, 0);
            this.translateTextBox.Multiline = true;
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translateTextBox.Size = new System.Drawing.Size(524, 373);
            this.translateTextBox.TabIndex = 106;
            // 
            // panSubtitles
            // 
            this.panSubtitles.Controls.Add(this.sub3);
            this.panSubtitles.Controls.Add(this.sub2);
            this.panSubtitles.Controls.Add(this.sub1);
            this.panSubtitles.Controls.Add(this.sub0);
            this.panSubtitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panSubtitles.Location = new System.Drawing.Point(0, 0);
            this.panSubtitles.Name = "panSubtitles";
            this.panSubtitles.Size = new System.Drawing.Size(524, 583);
            this.panSubtitles.TabIndex = 0;
            // 
            // sub3
            // 
            this.sub3.BackColor = System.Drawing.SystemColors.Control;
            this.sub3.Dock = System.Windows.Forms.DockStyle.Top;
            this.sub3.ItemColor = System.Drawing.SystemColors.Control;
            this.sub3.Location = new System.Drawing.Point(0, 435);
            this.sub3.Name = "sub3";
            this.sub3.Size = new System.Drawing.Size(524, 145);
            this.sub3.TabIndex = 103;
            this.sub3.Click += new System.EventHandler(this.subItem_Click);
            // 
            // sub2
            // 
            this.sub2.BackColor = System.Drawing.SystemColors.Control;
            this.sub2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sub2.ItemColor = System.Drawing.SystemColors.Control;
            this.sub2.Location = new System.Drawing.Point(0, 290);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(524, 145);
            this.sub2.TabIndex = 102;
            this.sub2.Click += new System.EventHandler(this.subItem_Click);
            // 
            // sub1
            // 
            this.sub1.BackColor = System.Drawing.SystemColors.Control;
            this.sub1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sub1.ItemColor = System.Drawing.SystemColors.Control;
            this.sub1.Location = new System.Drawing.Point(0, 145);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(524, 145);
            this.sub1.TabIndex = 101;
            this.sub1.Click += new System.EventHandler(this.subItem_Click);
            // 
            // sub0
            // 
            this.sub0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sub0.Dock = System.Windows.Forms.DockStyle.Top;
            this.sub0.ItemColor = System.Drawing.SystemColors.ControlLightLight;
            this.sub0.Location = new System.Drawing.Point(0, 0);
            this.sub0.Name = "sub0";
            this.sub0.Size = new System.Drawing.Size(524, 145);
            this.sub0.TabIndex = 100;
            this.sub0.Click += new System.EventHandler(this.subItem_Click);
            this.sub0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 986);
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "ExternalSub";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftPicker)).EndInit();
            this.panCenter.ResumeLayout(false);
            this.panTranslate.ResumeLayout(false);
            this.panTranslate.PerformLayout();
            this.panSubtitles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shiftPicker;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.Panel panTranslate;
        private System.Windows.Forms.Panel panSubtitles;
        private ucSubtitleItemViewer sub3;
        private ucSubtitleItemViewer sub1;
        private ucSubtitleItemViewer sub2;
        private ucSubtitleItemViewer sub0;
        private System.Windows.Forms.TextBox translateTextBox;
    }
}

