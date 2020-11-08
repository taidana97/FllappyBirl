namespace Fllappy
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
            this.tmrCot = new System.Windows.Forms.Timer(this.components);
            this.tmrDat = new System.Windows.Forms.Timer(this.components);
            this.tmrThua = new System.Windows.Forms.Timer(this.components);
            this.tmrXuatCot = new System.Windows.Forms.Timer(this.components);
            this.tmrChayHinhBird = new System.Windows.Forms.Timer(this.components);
            this.tmrRoi = new System.Windows.Forms.Timer(this.components);
            this.tmrXoaCot = new System.Windows.Forms.Timer(this.components);
            this.tmrDiem = new System.Windows.Forms.Timer(this.components);
            this.tmrChimRoiKhiThua = new System.Windows.Forms.Timer(this.components);
            this.plMain = new System.Windows.Forms.Panel();
            this.plScore = new System.Windows.Forms.Panel();
            this.lbBest = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.picHuongDan = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.ptbChim = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.plMain.SuspendLayout();
            this.plScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHuongDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrCot
            // 
            this.tmrCot.Interval = 49;
            this.tmrCot.Tick += new System.EventHandler(this.tmrCot_Tick);
            // 
            // tmrDat
            // 
            this.tmrDat.Enabled = true;
            this.tmrDat.Tick += new System.EventHandler(this.tmrDat_Tick);
            // 
            // tmrThua
            // 
            this.tmrThua.Enabled = true;
            this.tmrThua.Tick += new System.EventHandler(this.tmrThua_Tick);
            // 
            // tmrXuatCot
            // 
            this.tmrXuatCot.Interval = 6;
            this.tmrXuatCot.Tick += new System.EventHandler(this.tmrXuatCot_Tick);
            // 
            // tmrChayHinhBird
            // 
            this.tmrChayHinhBird.Enabled = true;
            this.tmrChayHinhBird.Tick += new System.EventHandler(this.tmrChay_Tick);
            // 
            // tmrRoi
            // 
            this.tmrRoi.Tick += new System.EventHandler(this.tmrRoi_Tick);
            // 
            // tmrXoaCot
            // 
            this.tmrXoaCot.Tick += new System.EventHandler(this.tmrXoaCot_Tick);
            // 
            // tmrDiem
            // 
            this.tmrDiem.Tick += new System.EventHandler(this.tmrDiem_Tick);
            // 
            // tmrChimRoiKhiThua
            // 
            this.tmrChimRoiKhiThua.Interval = 1;
            this.tmrChimRoiKhiThua.Tick += new System.EventHandler(this.tmrChimRoiKhiThua_Tick);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.SystemColors.Control;
            this.plMain.BackgroundImage = global::Fllappy.Properties.Resources.anh;
            this.plMain.Controls.Add(this.plScore);
            this.plMain.Controls.Add(this.picHuongDan);
            this.plMain.Controls.Add(this.picPlay);
            this.plMain.Controls.Add(this.ptbChim);
            this.plMain.Controls.Add(this.pictureBox3);
            this.plMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plMain.Location = new System.Drawing.Point(0, 0);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(814, 499);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.plMain_PreviewKeyDown);
            // 
            // plScore
            // 
            this.plScore.BackColor = System.Drawing.Color.Transparent;
            this.plScore.BackgroundImage = global::Fllappy.Properties.Resources.socre;
            this.plScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plScore.Controls.Add(this.lbBest);
            this.plScore.Controls.Add(this.labScore);
            this.plScore.Location = new System.Drawing.Point(287, 151);
            this.plScore.Name = "plScore";
            this.plScore.Size = new System.Drawing.Size(214, 120);
            this.plScore.TabIndex = 6;
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbBest.Location = new System.Drawing.Point(172, 74);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(16, 16);
            this.lbBest.TabIndex = 0;
            this.lbBest.Text = "0";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labScore.Location = new System.Drawing.Point(172, 36);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(16, 16);
            this.labScore.TabIndex = 0;
            this.labScore.Text = "0";
            // 
            // picHuongDan
            // 
            this.picHuongDan.BackColor = System.Drawing.Color.Transparent;
            this.picHuongDan.BackgroundImage = global::Fllappy.Properties.Resources.HuongDan1;
            this.picHuongDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHuongDan.ErrorImage = null;
            this.picHuongDan.Location = new System.Drawing.Point(99, 123);
            this.picHuongDan.Name = "picHuongDan";
            this.picHuongDan.Size = new System.Drawing.Size(119, 90);
            this.picHuongDan.TabIndex = 5;
            this.picHuongDan.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::Fllappy.Properties.Resources.playbtn;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Location = new System.Drawing.Point(344, 289);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(100, 50);
            this.picPlay.TabIndex = 4;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbChim
            // 
            this.ptbChim.BackColor = System.Drawing.Color.Transparent;
            this.ptbChim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbChim.Location = new System.Drawing.Point(35, 172);
            this.ptbChim.Name = "ptbChim";
            this.ptbChim.Size = new System.Drawing.Size(58, 41);
            this.ptbChim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbChim.TabIndex = 3;
            this.ptbChim.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(920, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 499);
            this.Controls.Add(this.plMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plMain.ResumeLayout(false);
            this.plScore.ResumeLayout(false);
            this.plScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHuongDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrCot;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer tmrDat;
        private System.Windows.Forms.PictureBox ptbChim;
        private System.Windows.Forms.Timer tmrThua;
        private System.Windows.Forms.Timer tmrXuatCot;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Timer tmrChayHinhBird;
        private System.Windows.Forms.Timer tmrRoi;
        private System.Windows.Forms.Timer tmrXoaCot;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Timer tmrDiem;
        private System.Windows.Forms.PictureBox picHuongDan;
        private System.Windows.Forms.Panel plScore;
        private System.Windows.Forms.Label lbBest;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Timer tmrChimRoiKhiThua;
    }
}

