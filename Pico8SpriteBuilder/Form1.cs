using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pico8SpriteBuilder
{
    public partial class Form1 : Form
    {
        private string currentMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtGetSprite_Click(object sender, EventArgs e)
        {
            rtData.Clear();
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pbSprites.Image = Image.FromFile(o.FileName);
                    GraphicsUnit gu = GraphicsUnit.Pixel;
                    if (pbSprites.Image.GetBounds(ref gu).Width < 128 ||
                        pbSprites.Image.GetBounds(ref gu).Height < 128)
                    {
                        currentMessage = "Image selected needs to be at least 128x128 pixels";
                        btGetSprite.Enabled = false;
                        timer1.Start();
                        tiFlash.Start();
                    }
                    else
                    {
                        currentMessage = "Sprite data copied to clipboard";

                        btGetSprite.Enabled = false;
                        timer1.Start();
                        tiFlash.Start();
                        pico8.GenerateSpriteData(o.FileName, rtData);
                        CopyToClipboard();

                        btCopyClipboard.Enabled = true;
                    }
                }
                catch { }
            }
        }

        private void btCopyClipboard_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void CopyToClipboard()
        {
            rtData.SelectAll();
            Clipboard.SetText(rtData.SelectedText, TextDataFormat.Text);
            btCopyClipboard.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "PICO - 8 Sprite sheet convertor";
            btGetSprite.Enabled = true;
            timer1.Stop();
            tiFlash.Stop();
        }

        private void tiFlash_Tick(object sender, EventArgs e)
        {
            if (this.Text == "")
                this.Text = currentMessage;
            else
                this.Text = "";
        }
    }
}
