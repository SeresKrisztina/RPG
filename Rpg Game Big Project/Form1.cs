using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg_Game_Big_Project
{
    public partial class Form1 : Form
    {
        Persistance p;
        public Form1()
        {
            p = new Persistance();
            InitializeComponent();
            KeyDown += (s, e) =>
              {
                  if(e.KeyCode==Keys.Space)
                  {
                      MessageBox.Show(Convert.ToString(p.Import()));
                  }
              };
            PictureBox start = new PictureBox();
            PictureBox starts = new PictureBox();
            PictureBox quitgame = new PictureBox();
            PictureBox quitgames = new PictureBox();
            PictureBox picture = new PictureBox();
            PictureBox pictures = new PictureBox();
            this.BackColor = Color.Red;
            start.Image = new Bitmap("start.png");
            starts.BackColor = Color.DarkBlue;
            picture.Image = new Bitmap("standc.png");
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Padding = new Padding(30, 30, 30, 30);
            picture.BackColor = Color.White;
            pictures.BackColor = Color.DarkBlue;
            quitgame.Image = new Bitmap("quite.png");
            quitgames.BackColor = Color.DarkBlue;
            start.SizeMode = PictureBoxSizeMode.StretchImage;
            quitgame.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.07));
            start.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.4));
            quitgame.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.52));
            picture.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
            start.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            quitgame.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            this.Controls.Add(start);
            this.Controls.Add(quitgame);
            this.Controls.Add(picture);
            starts.SizeMode = PictureBoxSizeMode.StretchImage;
            quitgames.SizeMode = PictureBoxSizeMode.StretchImage;
            pictures.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.07) + 10);
            starts.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.4) + 10);
            quitgames.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.52) + 10);
            pictures.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
            starts.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            quitgames.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            this.Controls.Add(starts);
            this.Controls.Add(quitgames);
            this.Controls.Add(pictures);
            this.Resize += (s, e) =>
              {
                  picture.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.07));
                  start.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.4));
                  quitgame.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.52));
                  picture.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
                  start.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
                  quitgame.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
                  pictures.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.07) + 10);
                  starts.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.4) + 10);
                  quitgames.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.52) + 10);
                  pictures.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
                  starts.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
                  quitgames.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
              };
            start.Cursor = Cursors.Hand;
            quitgame.Cursor = Cursors.Hand;
            Timer a = new Timer();
            a.Interval = 16;
            a.Start();
            a.Tick += (s, e) =>
            {
                if (Cursor.Current == start.Cursor && Cursor.Position.Y - this.Location.Y < quitgame.Location.Y + this.Height * 0.04)
                {
                    picture.Image = new Bitmap("startc.png");
                    starts.BackColor = Color.DarkGreen;
                    quitgames.BackColor = Color.DarkGreen;
                    pictures.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
                else if (Cursor.Current == start.Cursor)
                {
                    picture.Image = new Bitmap("quitc.png");
                    starts.BackColor = Color.DarkRed;
                    quitgames.BackColor = Color.DarkRed;
                    pictures.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else
                {
                    picture.Image = new Bitmap("standc.png");
                    starts.BackColor = Color.DarkBlue;
                    quitgames.BackColor = Color.DarkBlue;
                    pictures.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
            };
            quitgame.Click += (s, e) =>
              {
                  Application.Exit();
              };
            //Game engine
            start.Click += (s, e) =>
            {

                a.Stop();
                this.Controls.Clear();
                GameEngine();
            };
        }
        public void GameEngine()
        {
            p = new Persistance();
            Timer b = new Timer();
            Form1 f = new Form1();
            Model m = new Model();
            PictureBox returne = new PictureBox();
            PictureBox returnes = new PictureBox();
            PictureBox quitgame = new PictureBox();
            PictureBox quitgames = new PictureBox();
            PictureBox picture = new PictureBox();
            PictureBox pictures = new PictureBox();
            this.BackColor = Color.Red;
            returne.Image = Properties.Resources._return;
            returnes.BackColor = Color.DarkBlue;
            picture.Image = new Bitmap("standc.png");
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Padding = new Padding(30, 30, 30, 30);
            picture.BackColor = Color.White;
            pictures.BackColor = Color.DarkBlue;
            quitgame.Image = new Bitmap("quite.png");
            quitgames.BackColor = Color.DarkBlue;
            returne.SizeMode = PictureBoxSizeMode.StretchImage;
            quitgame.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.07));
            returne.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.4));
            quitgame.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.52));
            picture.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
            returne.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            quitgame.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            this.Controls.Add(returne);
            this.Controls.Add(quitgame);
            this.Controls.Add(picture);
            returnes.SizeMode = PictureBoxSizeMode.StretchImage;
            quitgames.SizeMode = PictureBoxSizeMode.StretchImage;
            pictures.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.07) + 10);
            returnes.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.4) + 10);
            quitgames.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.52) + 10);
            pictures.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
            returnes.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            quitgames.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            this.Controls.Add(returnes);
            this.Controls.Add(quitgames);
            this.Controls.Add(pictures);
            this.Resize += (s, e) =>
            {
                picture.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.07));
                returne.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.4));
                quitgame.Location = new Point(Convert.ToInt32(this.Width * 0.35), Convert.ToInt32(this.Height * 0.52));
                picture.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
                returne.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
                quitgame.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
                pictures.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.07) + 10);
                returnes.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.4) + 10);
                quitgames.Location = new Point(Convert.ToInt32(this.Width * 0.35) + 10, Convert.ToInt32(this.Height * 0.52) + 10);
                pictures.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.31));
                returnes.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
                quitgames.Size = new Size(Convert.ToInt32(this.Width * 0.3), Convert.ToInt32(this.Height * 0.1));
            };
            returne.Cursor = Cursors.Hand;
            quitgame.Cursor = Cursors.Hand;
            Timer a = new Timer();
            a.Interval = 16;
            a.Tick += (s, e) =>
            {
                if (Cursor.Current == returne.Cursor && Cursor.Position.Y - this.Location.Y < quitgame.Location.Y + this.Height * 0.04)
                {
                    picture.Image = new Bitmap("startc.png");
                    returnes.BackColor = Color.DarkGreen;
                    quitgames.BackColor = Color.DarkGreen;
                    pictures.BackColor = Color.DarkGreen;
                    this.BackColor = Color.Green;
                }
                else if (Cursor.Current == returne.Cursor)
                {
                    picture.Image = new Bitmap("quitc.png");
                    returnes.BackColor = Color.DarkRed;
                    quitgames.BackColor = Color.DarkRed;
                    pictures.BackColor = Color.DarkRed;
                    this.BackColor = Color.Red;
                }
                else
                {
                    picture.Image = new Bitmap("standc.png");
                    returnes.BackColor = Color.DarkBlue;
                    quitgames.BackColor = Color.DarkBlue;
                    pictures.BackColor = Color.DarkBlue;
                    this.BackColor = Color.Blue;
                }
            };
            quitgame.Click += (s, e) =>
            {
                Application.Exit();
            };            
            returne.Click += (s, e) =>
            {
                a.Stop();
                returne.Hide();
                returnes.Hide();
                picture.Hide();
                pictures.Hide();
                quitgame.Hide();
                quitgames.Hide();
                m.xp = 0;
                m.hp = Convert.ToInt32(m.maxhp * 0.3);
                m.pposition[0] = 0;
                m.pposition[1] = 0;
                b.Start();
            };
            returne.Hide();
            returnes.Hide();
            picture.Hide();
            pictures.Hide();
            quitgame.Hide();
            quitgames.Hide();
            this.BackColor = Color.Green;
            b.Interval = 15;
            b.Start();
            PictureBox bars = new PictureBox();
            bars.Image = new Bitmap("bar.png");
            bars.SizeMode = PictureBoxSizeMode.StretchImage;
            bars.Location = new Point(0, 0);
            bars.Size = new Size(Convert.ToInt32(this.Height / 2), Convert.ToInt32(this.Height * 0.16));
            Label label1 = new Label();
            label1.Font = new System.Drawing.Font("Forte", bars.Height / 4, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(Convert.ToInt32(bars.Width * 0.08), Convert.ToInt32(bars.Height * 0.3));
            label1.BackColor = Color.Transparent;
            label1.Size = new System.Drawing.Size(Convert.ToInt32(bars.Width * 0.175), Convert.ToInt32(bars.Height * 0.3));
            label1.TabIndex = 0;
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Forte", bars.Height / 5, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(0, bars.Height);
            label2.BackColor = Color.Transparent;
            label2.TabIndex = 0;
            label2.Text = "Congratulation you are reached " + Convert.ToString(m.level) + " level";
            this.Controls.Add(label2);
            label2.Hide();
            PictureBox hpbar = new PictureBox();
            hpbar.Image = new Bitmap("hpb.png");
            hpbar.SizeMode = PictureBoxSizeMode.StretchImage;
            hpbar.Location = new Point(Convert.ToInt32(bars.Width * 0.36), Convert.ToInt32(bars.Height * 0.09375));
            hpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.hp / m.maxhp), Convert.ToInt32(bars.Height * 0.18));
            PictureBox xpbar = new PictureBox();
            xpbar.Image = new Bitmap("xpb.png");
            xpbar.SizeMode = PictureBoxSizeMode.StretchImage;
            xpbar.Location = new Point(Convert.ToInt32(bars.Width * 0.36), Convert.ToInt32(bars.Height * 0.422));
            xpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.xp / m.maxxp), Convert.ToInt32(bars.Height * 0.18));
            PictureBox mpbar = new PictureBox();
            mpbar.Image = new Bitmap("mpb.png");
            mpbar.SizeMode = PictureBoxSizeMode.StretchImage;
            mpbar.Location = new Point(Convert.ToInt32(bars.Width * 0.36), Convert.ToInt32(bars.Height * 0.734375));
            mpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.sp / m.maxsp), Convert.ToInt32(bars.Height * 0.18));
            this.Controls.Add(label1);
            this.Controls.Add(mpbar);
            this.Controls.Add(xpbar);
            this.Controls.Add(hpbar);
            this.Controls.Add(bars);
            m.kp = Convert.ToInt32((this.Width - this.Height) / 2);
            PictureBox player = new PictureBox();
            player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
            player.Image = Properties.Resources.stand2;
            this.Controls.Add(player);
            List<PictureBox> slime = new List<PictureBox>();
            PictureBox[] fa1 = new PictureBox[30];
            for (int i = 0; i < 30; i++)
            {
                PictureBox fa = new PictureBox();
                m.fagen(m.fa1);
                fa.Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fa1[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fa1[i][1] - m.pposition[1])));
                fa.Size = new Size(Convert.ToInt32(this.Height * 0.39375), Convert.ToInt32(this.Height * 0.4));
                fa.Image = Properties.Resources.fa1;
                fa.SizeMode = PictureBoxSizeMode.StretchImage;
                fa1[i] = fa;
                this.Controls.Add(fa1[i]);
            }
            PictureBox[] fa0 = new PictureBox[10];
            for (int i = 0; i < 10; i++)
            {
                PictureBox fa = new PictureBox();
                m.fagen(m.fa0);
                fa.Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fa0[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fa0[i][1] - m.pposition[1])));
                fa.Size = new Size(Convert.ToInt32(this.Height * 0.321875), Convert.ToInt32(this.Height * 0.328125));
                fa.Image = Properties.Resources.fa0;
                fa.SizeMode = PictureBoxSizeMode.StretchImage;
                fa0[i] = fa;
                this.Controls.Add(fa0[i]);
            }
            PictureBox[] fu = new PictureBox[100];
            for (int i = 0; i < 100; i++)
            {
                PictureBox fa = new PictureBox();
                m.fagen(m.fu);
                fa.Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fu[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fu[i][1] - m.pposition[1])));
                fa.Size = new Size(Convert.ToInt32(this.Height * 0.078125), Convert.ToInt32(this.Height * 0.071875));
                fa.Image = Properties.Resources.fu;
                fa.SizeMode = PictureBoxSizeMode.StretchImage;
                fu[i] = fa;
                this.Controls.Add(fu[i]);
            }
            PictureBox[] kisvirag = new PictureBox[50];
            for (int i = 0; i < 50; i++)
            {
                PictureBox fa = new PictureBox();
                m.fagen(m.kisvirag);
                fa.Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.kisvirag[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.kisvirag[i][1] - m.pposition[1])));
                fa.Size = new Size(Convert.ToInt32(this.Height * 0.065625), Convert.ToInt32(this.Height * 0.040625));
                fa.Image = Properties.Resources.kisvirag;
                fa.SizeMode = PictureBoxSizeMode.StretchImage;
                kisvirag[i] = fa;
                this.Controls.Add(kisvirag[i]);
            }
            PictureBox[] ronk = new PictureBox[10];
            for (int i = 0; i < 10; i++)
            {
                PictureBox fa = new PictureBox();
                m.fagen(m.ronk);
                fa.Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.ronk[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.ronk[i][1] - m.pposition[1])));
                fa.Size = new Size(Convert.ToInt32(this.Height * 0.20625), Convert.ToInt32(this.Height * 0.071875));
                fa.Image = Properties.Resources.ronk;
                fa.SizeMode = PictureBoxSizeMode.StretchImage;
                ronk[i] = fa;
                this.Controls.Add(ronk[i]);
            }
            this.Resize += (s, e) =>
              {
                  bars.Size = new Size(Convert.ToInt32(this.Height / 2), Convert.ToInt32(this.Height * 0.16));
                  hpbar.Location = new Point(Convert.ToInt32(bars.Width * 0.36), Convert.ToInt32(bars.Height * 0.09375));
                  hpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.hp / m.maxhp), Convert.ToInt32(bars.Height * 0.18));
                  xpbar.Location = new Point(Convert.ToInt32(bars.Width * 0.36), Convert.ToInt32(bars.Height * 0.421875));
                  xpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.xp / m.maxxp), Convert.ToInt32(bars.Height * 0.18));
                  mpbar.Location = new Point(Convert.ToInt32(bars.Width * 0.36), Convert.ToInt32(bars.Height * 0.734375));
                  mpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.sp / m.maxsp), Convert.ToInt32(bars.Height * 0.18));
                  label1.Font = new System.Drawing.Font("Forte", bars.Height / 4, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  label1.Location = new System.Drawing.Point(Convert.ToInt32(bars.Width * 0.08), Convert.ToInt32(bars.Height * 0.3));
                  label1.Size = new System.Drawing.Size(Convert.ToInt32(bars.Width * 0.175), Convert.ToInt32(bars.Height * 0.3));
                  label2.Location = new System.Drawing.Point(0, bars.Height);
                  label2.Font = new System.Drawing.Font("Forte", bars.Height / 5, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  m.kp = Convert.ToInt32((this.Width - this.Height) / 2);
                  player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                  player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                  player.SizeMode = PictureBoxSizeMode.StretchImage;
                  for (int i = 0; i < 30; i++)
                  {
                      fa1[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fa1[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fa1[i][1] - m.pposition[1])));
                      fa1[i].Size = new Size(Convert.ToInt32(this.Height * 0.39375), Convert.ToInt32(this.Height * 0.4));
                  }
                  for (int i = 0; i < 10; i++)
                  {
                      fa0[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fa0[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fa0[i][1] - m.pposition[1])));
                      fa0[i].Size = new Size(Convert.ToInt32(this.Height * 0.321875), Convert.ToInt32(this.Height * 0.328125));
                  }
                  for (int i = 0; i < 100; i++)
                  {
                      fu[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fu[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fu[i][1] - m.pposition[1])));
                      fu[i].Size = new Size(Convert.ToInt32(this.Height * 0.078125), Convert.ToInt32(this.Height * 0.071875));
                  }
                  for (int i = 0; i < 50; i++)
                  {
                      kisvirag[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.kisvirag[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.kisvirag[i][1] - m.pposition[1])));
                      kisvirag[i].Size = new Size(Convert.ToInt32(this.Height * 0.065625), Convert.ToInt32(this.Height * 0.040625));
                  }
                  for (int i = 0; i < 10; i++)
                  {
                      ronk[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.ronk[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.ronk[i][1] - m.pposition[1])));
                      ronk[i].Size = new Size(Convert.ToInt32(this.Height * 0.20625), Convert.ToInt32(this.Height * 0.071875));
                  }
                  for (int i = 0; i < slime.Count(); i++)
                  {
                      slime[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.slime[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.slime[i][1] - m.pposition[1])));
                      slime[i].Size = new Size(Convert.ToInt32(this.Height * 0.05), Convert.ToInt32(this.Height * 0.05));
                  }
              };
            int lvuptimer = 0;
            bool lvup = false;
            string mozgas = "none";
            int poz = 9;
            bool ut = true;
            int timera = 0;
            MouseClick += (s, e) =>
              {
                  if (m.sp > 49)
                  {
                      double px = Cursor.Position.X;
                      double py = Cursor.Position.Y;
                      m.pposition[0] = m.pposition[0] + ((px - this.Location.X - player.Location.X) / this.Height);
                      m.pposition[1] = m.pposition[1] + ((py - this.Location.Y - player.Location.Y) / this.Height);
                      m.sp -= 50;
                  }
              };

            KeyDown += (s, e) =>
              {
                  if (e.KeyCode == Keys.A)
                  {
                      mozgas = "left";
                      if (poz != 0)
                      {
                          player.Image = Properties.Resources.move3;
                          player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                          player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      }
                      poz = 0;
                  }
                  if (e.KeyCode == Keys.W)
                  {
                      mozgas = "up";
                      if (poz != 1)
                      {
                          player.Image = Properties.Resources.move0;
                          player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                          player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      }
                      poz = 1;
                  }
                  if (e.KeyCode == Keys.S)
                  {
                      mozgas = "down";
                      if (poz != 2)
                      {
                          player.Image = Properties.Resources.move2;
                          player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                          player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      }
                      poz = 2;
                  }
                  if (e.KeyCode == Keys.D)
                  {
                      mozgas = "right";
                      if (poz != 3)
                      {
                          player.Image = Properties.Resources.move1;
                          player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                          player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      }
                      poz = 3;
                  }
                  if (e.KeyCode == Keys.F && m.sp > 19)
                  {
                      if (ut == true)
                      {
                          ut = false;
                          if (mozgas == "none" && poz == 4)
                          {
                              timera = 45;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes23;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "none" && poz == 5)
                          {
                              timera = 45;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes20;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "none" && poz == 6)
                          {
                              timera = 45;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes22;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "none" && poz == 7)
                          {
                              timera = 45;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes21;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "left")
                          {
                              timera = 15;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes13;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "right")
                          {
                              timera = 15;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes11;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "up")
                          {
                              timera = 15;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes10;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          else if (mozgas == "down")
                          {
                              timera = 15;
                              m.sp -= 20;
                              player.Image = Properties.Resources.utes12;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.11875), Convert.ToInt32(this.Height * 0.15));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                      }
                  }
              };
            KeyUp += (s, e) =>
              {
                  if (e.KeyCode == Keys.A && mozgas == "left")
                  {
                      mozgas = "none";
                      player.Image = Properties.Resources.stand3;
                      player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                      player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      poz = 4;
                  }
                  if (e.KeyCode == Keys.W && mozgas == "up")
                  {
                      mozgas = "none";
                      player.Image = Properties.Resources.stand0;
                      player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                      player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      poz = 5;
                  }
                  if (e.KeyCode == Keys.S && mozgas == "down")
                  {
                      mozgas = "none";
                      player.Image = Properties.Resources.stand2;
                      player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                      player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      poz = 6;
                  }
                  if (e.KeyCode == Keys.D && mozgas == "right")
                  {
                      mozgas = "none";
                      player.Image = Properties.Resources.stand1;
                      player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                      player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                      poz = 7;
                  }

              };
            int cucc = 0;
            b.Tick += (s, e) =>
              {
                  if (slime.Count() < 7 + m.level)
                  {
                      PictureBox slim = new PictureBox();
                      m.fagen(m.slime);
                      slim.Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.slime[slime.Count()][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.slime[slime.Count()][1] - m.pposition[1])));
                      slim.Size = new Size(Convert.ToInt32(this.Height * 0.05), Convert.ToInt32(this.Height * 0.05));
                      int szam = m.r.Next(0, 4);
                      if (szam == 0)
                      {
                          slim.Image = Properties.Resources.orangeslime;
                      }
                      else if (szam == 1)
                      {
                          slim.Image = Properties.Resources.redslime;
                      }
                      else
                      {
                          slim.Image = Properties.Resources.blueslime;
                      }
                      m.slimehp.Add(Convert.ToInt32(m.r.Next(80,120)*(1+(m.level*0.08))));
                      slim.SizeMode = PictureBoxSizeMode.StretchImage;
                      slime.Add(slim);
                      this.Controls.Add(slime[slime.Count() - 1]);
                  }
                  for (int i = 0; i < slime.Count(); i++)
                  {
                      if (slime[i].Location.X < player.Location.X)
                      {
                          m.slime[i][0] += 0.006;
                      }
                      else
                      {
                          m.slime[i][0] -= 0.006;
                      }
                      if (slime[i].Location.Y < player.Location.Y + 0.08125 * this.Height)
                      {
                          m.slime[i][1] += 0.006;
                      }
                      else
                      {
                          m.slime[i][1] -= 0.006;
                      }
                      if (player.Location.X + 0.015625 * this.Height < slime[i].Location.X + slime[i].Width && player.Location.X + 0.065625 * this.Height > slime[i].Location.X && player.Location.Y + 0.08125 * this.Height < slime[i].Location.Y + slime[i].Height && player.Location.Y + 0.1 * this.Height > slime[i].Location.Y)
                      {
                          if (timera < 25 && timera > 1)
                          {
                              m.slimehp[i] -= Convert.ToInt32(m.r.Next(2,6) *(1+m.level*0.2));
                          }
                          else
                          {
                              m.hp-= Convert.ToInt32(m.r.Next(0, 3) * (1 + m.level * 0.05));
                          }
                      }
                  }
                  for (int i = 0; i < slime.Count(); i++)
                  {
                      if (m.slimehp[i] < 0)
                      {
                          this.Controls.Remove(slime[i]);
                          slime.Remove(slime[i]);
                          m.slime.Remove(m.slime[i]);
                          m.slimehp.Remove(m.slimehp[i]);
                          m.xp += m.r.Next(7,13) + m.level * 2;
                      }
                  }
                  if (m.hp < 1)
                  {
                      b.Stop();
                      p.Export(m.level);
                      returne.Show();
                      returnes.Show();
                      picture.Show();
                      pictures.Show();
                      quitgame.Show();
                      quitgames.Show();
                      a.Start();
                  }
                  for (int i = 0; i < 30; i++)
                  {
                      if (player.Location.X + 0.015625 * this.Height < fa1[i].Location.X + 0.259375 * this.Height && player.Location.X + 0.065625 * this.Height > fa1[i].Location.X + 0.140625 * this.Height && player.Location.Y + 0.1 * this.Height < fa1[i].Location.Y + (0.31875 + 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > fa1[i].Location.Y + 0.31875 * this.Height)
                      {
                          m.pposition[1] -= 0.016;
                      }
                      else if (player.Location.X + 0.015625 * this.Height < fa1[i].Location.X + 0.259375 * this.Height && player.Location.X + 0.065625 * this.Height > fa1[i].Location.X + 0.140625 * this.Height && player.Location.Y + 0.08125 * this.Height > fa1[i].Location.Y + (0.38125 - 0.017) * this.Height && player.Location.Y + 0.08125 * this.Height < fa1[i].Location.Y + 0.38125 * this.Height)
                      {
                          m.pposition[1] += 0.016;
                      }
                      else if (player.Location.X + 0.065625 * this.Height > fa1[i].Location.X + 0.140625 * this.Height && player.Location.X + 0.065625 * this.Height < fa1[i].Location.X + (0.140625 + 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > fa1[i].Location.Y + 0.31875 * this.Height && player.Location.Y + 0.08125 * this.Height < fa1[i].Location.Y + 0.38125 * this.Height)
                      {
                          m.pposition[0] -= 0.016;
                      }
                      else if (player.Location.X + 0.015625 * this.Height < fa1[i].Location.X + 0.259375 * this.Height && player.Location.X + 0.015625 * this.Height > fa1[i].Location.X + (0.259375 - 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > fa1[i].Location.Y + 0.31875 * this.Height && player.Location.Y + 0.08125 * this.Height < fa1[i].Location.Y + 0.38125 * this.Height)
                      {
                          m.pposition[0] += 0.016;
                      }
                      fa1[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fa1[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fa1[i][1] - m.pposition[1])));
                  }
                  for (int i = 0; i < 10; i++)
                  {
                      if (player.Location.X + 0.015625 * this.Height < fa0[i].Location.X + 0.221875 * this.Height && player.Location.X + 0.065625 * this.Height > fa0[i].Location.X + 0.096875 * this.Height && player.Location.Y + 0.1 * this.Height < fa0[i].Location.Y + (0.246875 + 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > fa0[i].Location.Y + 0.246875 * this.Height)
                      {
                          m.pposition[1] -= 0.016;
                      }
                      else if (player.Location.X + 0.015625 * this.Height < fa0[i].Location.X + 0.221875 * this.Height && player.Location.X + 0.065625 * this.Height > fa0[i].Location.X + 0.096875 * this.Height && player.Location.Y + 0.08125 * this.Height > fa0[i].Location.Y + (0.31875 - 0.017) * this.Height && player.Location.Y + 0.08125 * this.Height < fa0[i].Location.Y + 0.31875 * this.Height)
                      {
                          m.pposition[1] += 0.016;
                      }
                      else if (player.Location.X + 0.065625 * this.Height > fa0[i].Location.X + 0.096875 * this.Height && player.Location.X + 0.065625 * this.Height < fa0[i].Location.X + (0.096875 + 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > fa0[i].Location.Y + 0.246875 * this.Height && player.Location.Y + 0.08125 * this.Height < fa0[i].Location.Y + 0.31875 * this.Height)
                      {
                          m.pposition[0] -= 0.016;
                      }
                      else if (player.Location.X + 0.015625 * this.Height < fa0[i].Location.X + 0.221875 * this.Height && player.Location.X + 0.015625 * this.Height > fa0[i].Location.X + (0.221875 - 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > fa0[i].Location.Y + 0.246875 * this.Height && player.Location.Y + 0.08125 * this.Height < fa0[i].Location.Y + 0.31875 * this.Height)
                      {
                          m.pposition[0] += 0.016;
                      }
                      fa0[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fa0[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fa0[i][1] - m.pposition[1])));
                  }
                  for (int i = 0; i < 100; i++)
                  {
                      fu[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.fu[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.fu[i][1] - m.pposition[1])));
                  }
                  for (int i = 0; i < 50; i++)
                  {
                      kisvirag[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.kisvirag[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.kisvirag[i][1] - m.pposition[1])));
                  }
                  for (int i = 0; i < 10; i++)
                  {
                      if (player.Location.X + 0.015625 * this.Height < ronk[i].Location.X + 0.18125 * this.Height && player.Location.X + 0.065625 * this.Height > ronk[i].Location.X + 0.009375 * this.Height && player.Location.Y + 0.1 * this.Height < ronk[i].Location.Y + (0.00625 + 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > ronk[i].Location.Y + 0.00625 * this.Height)
                      {
                          m.pposition[1] -= 0.016;
                      }
                      else if (player.Location.X + 0.015625 * this.Height < ronk[i].Location.X + 0.18125 * this.Height && player.Location.X + 0.065625 * this.Height > ronk[i].Location.X + 0.009375 * this.Height && player.Location.Y + 0.08125 * this.Height > ronk[i].Location.Y + (0.06875 - 0.017) * this.Height && player.Location.Y + 0.08125 * this.Height < ronk[i].Location.Y + 0.06875 * this.Height)
                      {
                          m.pposition[1] += 0.016;
                      }
                      else if (player.Location.X + 0.065625 * this.Height > ronk[i].Location.X + 0.009375 * this.Height && player.Location.X + 0.065625 * this.Height < ronk[i].Location.X + (0.009375 + 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > ronk[i].Location.Y + 0.00625 * this.Height && player.Location.Y + 0.08125 * this.Height < ronk[i].Location.Y + 0.06875 * this.Height)
                      {
                          m.pposition[0] -= 0.016;
                      }
                      else if (player.Location.X + 0.015625 * this.Height < ronk[i].Location.X + 0.18125 * this.Height && player.Location.X + 0.015625 * this.Height > ronk[i].Location.X + (0.18125 - 0.017) * this.Height && player.Location.Y + 0.1 * this.Height > ronk[i].Location.Y + 0.00625 * this.Height && player.Location.Y + 0.08125 * this.Height < ronk[i].Location.Y + 0.06875 * this.Height)
                      {
                          m.pposition[0] += 0.016;
                      }
                      ronk[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.ronk[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.ronk[i][1] - m.pposition[1])));
                  }
                  for (int i = 0; i < slime.Count(); i++)
                  {
                      slime[i].Location = new Point(Convert.ToInt32(m.kp + this.Height * (m.slime[i][0] - m.pposition[0])), Convert.ToInt32(this.Height * (m.slime[i][1] - m.pposition[1])));
                      slime[i].Size = new Size(Convert.ToInt32(this.Height * 0.05), Convert.ToInt32(this.Height * 0.05));
                  }
                  hpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.hp / m.maxhp), Convert.ToInt32(bars.Height * 0.18));
                  xpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.xp / m.maxxp), Convert.ToInt32(bars.Height * 0.18));
                  mpbar.Size = new Size(Convert.ToInt32(bars.Width * 0.52 * m.sp / m.maxsp), Convert.ToInt32(bars.Height * 0.18));
                  label1.Text = Convert.ToString(m.level);
                  player.Location = new Point(Convert.ToInt32(m.kp + this.Height * 0.434375), Convert.ToInt32(this.Height * 0.4));
                  if (m.xp > m.maxxp)//level up
                  {
                      m.xp = 0;
                      m.maxxp += Convert.ToInt32(m.maxxp * 0.2);
                      m.level++;
                      m.maxhp += Convert.ToInt32(m.maxhp * 0.1);
                      m.hp = m.maxhp;
                      m.maxsp += Convert.ToInt32(m.maxsp * 0.1);
                      m.sp = m.maxsp;
                      label2.Text = "Congratulation you are reached " + Convert.ToString(m.level) + " level";
                      label2.Show();
                      lvup = true;
                      lvuptimer = 200;
                  }
                  cucc++;
                  if (cucc == 20)
                  {
                      m.sp++;
                      cucc = 0;
                  }
                  if (m.hp > m.maxhp)//hpmax
                  {
                      m.hp = m.maxhp;
                  }
                  if (m.sp > m.maxsp)//mannamax
                  {
                      m.sp = m.maxsp;
                  }
                  if (mozgas == "left")//mozgás
                  {
                      m.pposition[0] -= 0.016;
                  }
                  else if (mozgas == "right")
                  {
                      m.pposition[0] += 0.016;
                  }
                  else if (mozgas == "up")
                  {
                      m.pposition[1] -= 0.016;
                  }
                  else if (mozgas == "down")
                  {
                      m.pposition[1] += 0.016;
                  }
                  if (m.pposition[0] < -5)//mozgéshatár(teleport)
                  {
                      m.pposition[0] = -4.9;
                  }
                  else if (m.pposition[0] > 5)
                  {
                      m.pposition[0] = 4.9;
                  }
                  else if (m.pposition[1] < -5)
                  {
                      m.pposition[1] = -4.9;
                  }
                  else if (m.pposition[1] > 5)
                  {
                      m.pposition[1] = 4.9;
                  }
                  if (timera > 0)
                  {
                      if (timera == 1)
                      {
                          if (mozgas == "none" && poz == 4)
                          {
                              player.Image = Properties.Resources.stand3;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "none" && poz == 5)
                          {
                              player.Image = Properties.Resources.stand0;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "none" && poz == 6)
                          {
                              player.Image = Properties.Resources.stand2;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "none" && poz == 7)
                          {
                              player.Image = Properties.Resources.stand1;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "left")
                          {
                              player.Image = Properties.Resources.move3;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "right")
                          {
                              player.Image = Properties.Resources.move1;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "up")
                          {
                              player.Image = Properties.Resources.move0;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                          if (mozgas == "down")
                          {
                              player.Image = Properties.Resources.move2;
                              player.Size = new Size(Convert.ToInt32(this.Height * 0.08125), Convert.ToInt32(this.Height * 0.10625));
                              player.Location = new Point(Convert.ToInt32(m.kp + this.Height * (this.Height / 2 - player.Width / 2)), Convert.ToInt32(this.Height * 0.4 * (this.Height / 2 - player.Height / 2)));
                          }
                      }
                      timera--;
                  }
                  else
                  {
                      ut = true;
                  }
                  if (lvup == true)//felirat
                  {
                      if (lvuptimer == 0)
                      {
                          lvup = false;
                          label2.Hide();
                      }
                      lvuptimer--;
                  }
              };
        }
    }
}