using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Fllappy
{

    public partial class Form1 : Form
    {

        bool chimBay = false;
        int demchim = 0;
        int demLoadChim = 0;
        bool demthua = false;
        bool demstart = false;
        bool choilai = false;
        int diem = 0;
        Random t = new Random();
        int m;
        Point pointChim;
        List<PictureBox> taocottren = new List<PictureBox>();
        List<PictureBox> taocotduoi = new List<PictureBox>();
        List<PictureBox> refresh_over = new List<PictureBox>();
        Label lb = new Label();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pointChim = new Point(ptbChim.Location.X,ptbChim.Location.Y);
            
            this.plMain.Controls.Remove(plScore);

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "04B_19__.TTF"));
            lb.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            lb.BackColor = Color.Transparent;
            lb.Location = new Point(389, 41);
            this.plMain.Controls.Add(this.lb);
        }
        void diemchay(int n)
        {
            
            lb.Width = 35;
            lb.Height = 20;
            lb.Text = n.ToString();
            this.lb.BringToFront();
        }
        void refresh()
        {
            demchim = 0;
            demthua = false;
            //demstart = false;
            choilai = false;
            diem = 0;
            this.lb.ResetText();
        }
        void Start()
        {
            
            //this.tmrChay.Start();
            this.tmrCot.Start();
            this.tmrXuatCot.Start();
            //this.tmrXoaCot.Start();
            this.tmrRoi.Start();
            this.tmrDat.Start();
            this.tmrThua.Start();
            this.tmrDiem.Start();
            demstart = true;
            this.plMain.Controls.Remove(picHuongDan);
            this.plMain.Controls.Remove(plScore);
        }
        void GameOver()
        {
            tmrCot.Stop();
            tmrDat.Stop();
            tmrRoi.Stop();
            //tmrXoaCot.Stop();
            tmrXuatCot.Stop();
            tmrThua.Stop();
            tmrDiem.Stop();
            choilai = true;
            int diembest = Int32.Parse(lbBest.Text);
            if (diembest <= diem)
            {
                lbBest.Text = diem.ToString();
            }
            labScore.Text = lb.Text;
            this.plMain.Controls.Add(plScore);
            plScore.BringToFront();
        }
        void songoku(int t)
        {
            switch (t)
            {
                case 1:
                    ptbChim.BackgroundImage = Properties.Resources.c0;
                    break;
                case 2:
                    ptbChim.BackgroundImage = Properties.Resources.c1;
                    break;
                case 3:
                    ptbChim.BackgroundImage = Properties.Resources.c2;
                    break;
                case 4:
                    ptbChim.BackgroundImage = Properties.Resources.c3;
                    break;
                case 5:
                    ptbChim.BackgroundImage = Properties.Resources.c4;
                    break;
                case 6:
                    ptbChim.BackgroundImage = Properties.Resources.c5;
                    break;
            }
        }
        void ChimBay(int t)
        {
            switch (t)
            {
                case 1:
                    ptbChim.BackgroundImage = Properties.Resources.c6;
                    break;
                case 2:
                    ptbChim.BackgroundImage = Properties.Resources.c7;
                    break;
                case 3:
                    ptbChim.BackgroundImage = Properties.Resources.c8;
                    break;
                case 4:
                    ptbChim.BackgroundImage = Properties.Resources.c9;
                    break;
            }
        }
        void LoadChim(int t)
        {
            switch (t)
            {
                case 1:
                    ptbChim.BackgroundImage = Properties.Resources.a1;
                    break;
                case 2:
                    ptbChim.BackgroundImage = Properties.Resources.a2;
                    break;
                case 3:
                    ptbChim.BackgroundImage = Properties.Resources.a3;
                    break;
                case 4:
                    ptbChim.BackgroundImage = Properties.Resources.a1;
                    break;
                case 5:
                    ptbChim.BackgroundImage = Properties.Resources.a2;
                    break;
                case 6:
                    ptbChim.BackgroundImage = Properties.Resources.a3;
                    break;
                case 7:
                    ptbChim.BackgroundImage = Properties.Resources.a1;
                    break;
                case 8:
                    ptbChim.BackgroundImage = Properties.Resources.a2;
                    break;
                case 9:
                    ptbChim.BackgroundImage = Properties.Resources.a3;
                    break;
                case 10:
                    ptbChim.BackgroundImage = Properties.Resources.a1;
                    break;
            }
        }
        void xuatcottren()
        {
            PictureBox cottren = new PictureBox();            
            cottren.BackgroundImageLayout = ImageLayout.Stretch;            
            cottren.BackgroundImage = Properties.Resources._4;
            cottren.Width = 58;
            cottren.Height = 335;
            cottren.BackColor = Color.Transparent;           
            cottren.Location = new Point(plMain.Size.Width - 1, -205 + m);           
            taocottren.Add(cottren);
            plMain.Controls.Add(cottren);            
        }
        void xuatcoiduoi()
        {
            PictureBox cotduoi = new PictureBox();
            cotduoi.BackgroundImageLayout = ImageLayout.Stretch;
            cotduoi.BackgroundImage = Properties.Resources._3;
            cotduoi.Width = 58;
            cotduoi.Height = 335;
            cotduoi.BackColor = Color.Transparent;
            cotduoi.Location = new Point(plMain.Size.Width - 1, 260 + m);
            taocotduoi.Add(cotduoi);
            plMain.Controls.Add(cotduoi);
        }
        void xoacot()
        {
            for (int i = 0; i < taocottren.Count; i++)
            {
                if (taocottren[i].Location.X + taocottren[i].Size.Width <= 0)
                {
                    plMain.Controls.Remove(taocottren[i]);
                    taocottren.RemoveAt(i);
                    plMain.Controls.Remove(taocotduoi[i]);
                    taocotduoi.RemoveAt(i);                  

                }
            }            
        }
        void refreshcot()
        {
            for (int i = 0; i < taocottren.Count; i++)
            {
                taocottren.RemoveAt(i);
            }
            for (int i = 0; i < taocotduoi.Count; i++)
            {
                taocotduoi.RemoveAt(i);
            }
        }
        void xoaanh()
        {
            foreach (PictureBox xoaanh in taocottren)
            {
                xoaanh.Dispose();
            }
            foreach (PictureBox xoaanh in taocotduoi)
            {
                xoaanh.Dispose();
            }
            foreach (PictureBox xoaanh in refresh_over)
            {
                xoaanh.Dispose();
            }
            refreshcot();
        }
        void hinhgameover()
        {
            PictureBox gameover = new PictureBox();            
            gameover.BackgroundImageLayout = ImageLayout.Stretch;
            gameover.BackgroundImage = Properties.Resources.GameOver;            
            gameover.Width = 152;
            gameover.Height = 60;
            gameover.BackColor = Color.Transparent;
            gameover.Location = new Point(320, 94);            
            refresh_over.Add(gameover);
            plMain.Controls.Add(gameover);
            gameover.BringToFront();
        }
        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            this.plMain.Focus();
        }        
        private void tmrCot_Tick(object sender, EventArgs e)
        {
            tmrCot.Interval = 100;
            foreach (PictureBox item in taocottren)
            {
                item.Location = new Point(item.Location.X - 10, item.Location.Y);
            }
            foreach (PictureBox item1 in taocotduoi)
            {
                item1.Location = new Point(item1.Location.X - 10, item1.Location.Y);
            }
            this.plMain.Refresh();
        }
        private void tmrDat_Tick(object sender, EventArgs e)
        {
            tmrDat.Interval = 100;        
            pictureBox3.Image = Properties.Resources._Dat1;
            Point toado = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
            toado.X -= 10;
            if (toado.X < -50)
            {
                toado.X = 0;
            }
            pictureBox3.Location = toado;
            xoacot();

        }     
        private void plMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (demstart == true && demthua == false && pointChim.Y > 15)
            {
                switch (e.KeyCode)
                {
                    case Keys.Space:
                        pointChim.Y -= 40;
                        chimBay = true;
                        demchim = 0;
                        break;
                    default:
                        break;
                }
            }           
            ptbChim.Location = pointChim;
            this.plMain.Refresh();
        }
        private void tmrThua_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox item in taocottren)
            {
                if (pointChim.X >= item.Location.X - ptbChim.Size.Width - 5 && pointChim.Y <= item.Location.Y + item.Size.Height && pointChim.X <= item.Location.X + item.Size.Width)
                {
                    demthua = true;
                }
            }
            foreach (PictureBox item1 in taocotduoi)
            {
                if (pointChim.X >= item1.Location.X - ptbChim.Size.Width - 5 && pointChim.Y >= item1.Location.Y - ptbChim.Size.Height && pointChim.X <= item1.Location.X + item1.Size.Width)
                {
                    demthua = true;
                }
            }
            if (demthua == true)
            {
                GameOver();
                tmrChimRoiKhiThua.Start();
                this.plMain.Controls.Add(picPlay);
                this.plMain.Controls.Remove(lb);
                hinhgameover();                           
            }
            this.picPlay.BringToFront();

        }
        private void tmrChay_Tick(object sender, EventArgs e)
        {            
            if (demstart ==false)
            {
                demLoadChim++;
                LoadChim(demLoadChim);
                if (demLoadChim == 10)
                {
                    demLoadChim = 1;
                }
            }
            else
            {
                demchim++;
                if (chimBay)
                {
                    ChimBay(demchim);
                }
                else
                {
                    songoku(demchim);
                }
                if (demchim == 4 && chimBay == true)
                {
                    demchim = 1;
                    chimBay = false;
                }
            }
        }
        private void tmrRoi_Tick(object sender, EventArgs e)
        {
            tmrRoi.Interval = 100;
            pointChim.Y += 10;
            if (pointChim.Y > 335 )
            {
                tmrRoi.Stop();
                demthua = true;
            }
            ptbChim.Location = pointChim;
        }
        private void tmrXuatCot_Tick(object sender, EventArgs e)
        {
            m = t.Next(-70, 70);
            tmrXuatCot.Interval = 3500;            
          
            xuatcottren();
            xuatcoiduoi();             
        }
        private void tmrXoaCot_Tick(object sender, EventArgs e)
        {
            //xoacot();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start();
            this.plMain.Controls.Remove(picPlay);
            if (choilai == true)
            {
                pointChim.X = 35;
                pointChim.Y = 172;                
                refresh();
                xoaanh();
                refreshcot();
                this.plMain.Controls.Add(lb);
                taocottren.Clear();
                taocotduoi.Clear();
            }
            ptbChim.Location = pointChim;
        }         
        private void tmrDiem_Tick(object sender, EventArgs e)
        {
            tmrDiem.Interval = 80;
            foreach (PictureBox item in taocottren)
            {
                if (pointChim.X >= item.Location.X + item.Size.Width - 10 && pointChim.Y >= item.Location.Y + item.Size.Height + 5 && pointChim.X <= item.Location.X + item.Size.Width)
                {
                    foreach (PictureBox item1 in taocotduoi)
                    {
                        if (pointChim.X >= item1.Location.X + item1.Size.Width - 10 && pointChim.Y <= item1.Location.Y - ptbChim.Size.Height - 5 && pointChim.X <= item1.Location.X + item1.Size.Width)
                        {
                            diem++;
                        }
                    }
                }
            }
            diemchay(diem);
        }        
        private void tmrChimRoiKhiThua_Tick(object sender, EventArgs e)
        {
            
            if (pointChim.Y <= 380 - ptbChim.Size.Height)
            {
                pointChim.Y += 7;
                ptbChim.Location = pointChim;
            }
            else
            {
                tmrChimRoiKhiThua.Stop();
            }
        }
    }
}
