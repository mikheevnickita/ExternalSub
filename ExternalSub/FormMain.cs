using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace ExternalSub
{
    public partial class FormMain : Form
    {
        VLCClient rc;
        Subtitles srt = new Subtitles();

        public FormMain()
        {
            InitializeComponent();
        }

        public void SetStatus(Boolean isOn)
        {
            btnConnect.Enabled = !isOn;
            btnDisconnect.Enabled = isOn;
            btnTime.Enabled = isOn;
            timer.Enabled = isOn;

            if (!isOn)
            {
                btnTime.Text = "--:--:--";
                sub0.Clear();
                sub1.Clear();
                sub2.Clear();
                sub3.Clear();
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                rc = new VLCClient("localhost");
                rc.Connect();
                rc.Login("admin");

                String path = rc.get_Path();
                path = path.Substring(0, path.Length - 3) + "srt";
                if (File.Exists(path))
                {
                    srt.ReadFromFile(path);
                } 
                else 
                {
                    var dlg = new OpenFileDialog
                    {
                        DefaultExt = "srt",
                        Multiselect = false,
                        InitialDirectory = Path.GetDirectoryName(path)
                    };
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        srt.ReadFromFile(dlg.FileName);
                    }
                    else
                    {
                        throw new Exception("Subtitles not found");
                    }
                }

                SetStatus(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                rc.Disconnect();
            }
            finally
            {
                SetStatus(false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Time sec = rc.get_Time() + Convert.ToInt32(shiftPicker.Value * 1000);

                btnTime.Text = sec.ToString();

                Int32 indx = srt.IndexOfSubBySeconds(sec.asSeconds) - 1;
                if (indx >= 0)
                    sub0.Fill(srt.Items[indx--]);
                if (indx >= 0)
                    sub1.Fill(srt.Items[indx--]);
                if (indx >= 0)
                    sub2.Fill(srt.Items[indx--]);
                if (indx >= 0)
                    sub3.Fill(srt.Items[indx--]);
            }
            catch 
            {
                Disconnect_Click(sender, e);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Connect_Click(sender, e);
            this.Location = new Point(2000, 110);
            this.WindowState = FormWindowState.Maximized;
        }

        private async void subItem_Click(object sender, EventArgs e)
        {
            translateTextBox.Text = ((ucSubtitleItemViewer) sender).SelectedText;
            var res = await LingvoTranslate.Translate(((ucSubtitleItemViewer) sender).SelectedText);
            translateTextBox.Text = res;
        }
    }
}
