namespace ExternalSub
{
    partial class ucSubtitleItemViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panCenter = new System.Windows.Forms.Panel();
            this.subText = new System.Windows.Forms.TextBox();
            this.panTop = new System.Windows.Forms.Panel();
            this.subTo = new System.Windows.Forms.Button();
            this.subFrom = new System.Windows.Forms.Button();
            this.subN = new System.Windows.Forms.Button();
            this.panCenter.SuspendLayout();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCenter
            // 
            this.panCenter.Controls.Add(this.subText);
            this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCenter.Location = new System.Drawing.Point(0, 25);
            this.panCenter.Name = "panCenter";
            this.panCenter.Size = new System.Drawing.Size(575, 120);
            this.panCenter.TabIndex = 5;
            // 
            // subText
            // 
            this.subText.BackColor = System.Drawing.SystemColors.Control;
            this.subText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subText.Location = new System.Drawing.Point(0, 0);
            this.subText.Multiline = true;
            this.subText.Name = "subText";
            this.subText.Size = new System.Drawing.Size(575, 120);
            this.subText.TabIndex = 0;
            this.subText.Click += new System.EventHandler(this.textBox1_Click);
            this.subText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.subTo);
            this.panTop.Controls.Add(this.subFrom);
            this.panTop.Controls.Add(this.subN);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(575, 25);
            this.panTop.TabIndex = 3;
            // 
            // subTo
            // 
            this.subTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subTo.Location = new System.Drawing.Point(175, 0);
            this.subTo.Name = "subTo";
            this.subTo.Size = new System.Drawing.Size(125, 25);
            this.subTo.TabIndex = 2;
            this.subTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subTo.UseVisualStyleBackColor = true;
            // 
            // subFrom
            // 
            this.subFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subFrom.Location = new System.Drawing.Point(50, 0);
            this.subFrom.Name = "subFrom";
            this.subFrom.Size = new System.Drawing.Size(125, 25);
            this.subFrom.TabIndex = 1;
            this.subFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subFrom.UseVisualStyleBackColor = true;
            // 
            // subN
            // 
            this.subN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subN.Location = new System.Drawing.Point(0, 0);
            this.subN.Name = "subN";
            this.subN.Size = new System.Drawing.Size(50, 25);
            this.subN.TabIndex = 0;
            this.subN.Text = "# ";
            this.subN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subN.UseVisualStyleBackColor = true;
            // 
            // ucSubtitleItemViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panCenter);
            this.Controls.Add(this.panTop);
            this.Name = "ucSubtitleItemViewer";
            this.Size = new System.Drawing.Size(575, 145);
            this.panCenter.ResumeLayout(false);
            this.panCenter.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCenter;
        private System.Windows.Forms.TextBox subText;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Button subTo;
        private System.Windows.Forms.Button subFrom;
        private System.Windows.Forms.Button subN;

    }
}
