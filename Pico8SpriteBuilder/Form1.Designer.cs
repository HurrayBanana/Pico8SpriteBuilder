namespace Pico8SpriteBuilder
{
    partial class Form1
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
            this.pbSprites = new System.Windows.Forms.PictureBox();
            this.rtData = new System.Windows.Forms.RichTextBox();
            this.btGetSprite = new System.Windows.Forms.Button();
            this.btCopyClipboard = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tiFlash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSprites)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSprites
            // 
            this.pbSprites.Location = new System.Drawing.Point(16, 32);
            this.pbSprites.Name = "pbSprites";
            this.pbSprites.Size = new System.Drawing.Size(256, 512);
            this.pbSprites.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSprites.TabIndex = 0;
            this.pbSprites.TabStop = false;
            // 
            // rtData
            // 
            this.rtData.Location = new System.Drawing.Point(336, 32);
            this.rtData.Name = "rtData";
            this.rtData.Size = new System.Drawing.Size(760, 502);
            this.rtData.TabIndex = 1;
            this.rtData.Text = "";
            // 
            // btGetSprite
            // 
            this.btGetSprite.Location = new System.Drawing.Point(16, 8);
            this.btGetSprite.Name = "btGetSprite";
            this.btGetSprite.Size = new System.Drawing.Size(290, 23);
            this.btGetSprite.TabIndex = 2;
            this.btGetSprite.Text = "Get Spritesheet";
            this.btGetSprite.UseVisualStyleBackColor = true;
            this.btGetSprite.Click += new System.EventHandler(this.BtGetSprite_Click);
            // 
            // btCopyClipboard
            // 
            this.btCopyClipboard.Enabled = false;
            this.btCopyClipboard.Location = new System.Drawing.Point(336, 8);
            this.btCopyClipboard.Name = "btCopyClipboard";
            this.btCopyClipboard.Size = new System.Drawing.Size(760, 23);
            this.btCopyClipboard.TabIndex = 3;
            this.btCopyClipboard.Text = "Copy to clipboard";
            this.btCopyClipboard.UseVisualStyleBackColor = true;
            this.btCopyClipboard.Click += new System.EventHandler(this.btCopyClipboard_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tiFlash
            // 
            this.tiFlash.Interval = 250;
            this.tiFlash.Tick += new System.EventHandler(this.tiFlash_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 555);
            this.Controls.Add(this.btCopyClipboard);
            this.Controls.Add(this.btGetSprite);
            this.Controls.Add(this.rtData);
            this.Controls.Add(this.pbSprites);
            this.Name = "Form1";
            this.Text = "PICO-8 Sprite sheet convertor";
            ((System.ComponentModel.ISupportInitialize)(this.pbSprites)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSprites;
        private System.Windows.Forms.RichTextBox rtData;
        private System.Windows.Forms.Button btGetSprite;
        private System.Windows.Forms.Button btCopyClipboard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tiFlash;
    }
}

