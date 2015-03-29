using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExternalSub
{
    public partial class ucSubtitleItemViewer : UserControl
    {
        String Selected;
        String basetext;
        public String SelectedText { get { return Selected; } }
        public Color ItemColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor     = value;
                subText.BackColor = value;
                subN.BackColor     = value;
                subFrom.BackColor  = value;
                subTo.BackColor    = value;
            }
        }

        public void Clear()
        {
            this.subN.Text     = "";
            this.subFrom.Text  = "";
            this.subTo.Text    = "";
            basetext           = "";
            this.subText.Text = "";
        }


        public ucSubtitleItemViewer()
        {
            InitializeComponent();
        }

         public void Fill(SubTitleItem itm)
        {
            this.subN.Text     = "# " + itm.ID;
            this.subFrom.Text  = itm.From.asTimeString;
            this.subTo.Text    = itm.To  .asTimeString;
            basetext           = itm.Text;
            this.subText.Text = basetext;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            subText.Text = basetext;
        }

        String Dict = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            Int32 lenght = subText.Text.Length;
            Int32 pos = subText.SelectionStart;

            if ((pos - 1 >= 0) && (Dict.IndexOf(subText.Text[pos-1]) >= 0))
            {
                Int32 i = pos;
                while ((i < lenght) && (Dict.IndexOf(subText.Text[i]) >= 0))
                    i++;
                Int32 end = i - 1;

                i = pos;
                while ((i >= 0) && (Dict.IndexOf(subText.Text[i]) >= 0))
                    i--;

                Int32 start = i + 1;
                if (end - start > 0)
                {
                    Selected = subText.Text.Substring(start, end - start + 1);
                    this.OnClick(e);
                }
                else
                {
                    Selected = null;
                }
            }
            
        }
    }
}
