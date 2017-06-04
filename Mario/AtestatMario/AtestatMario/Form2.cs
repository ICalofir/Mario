using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        bool c1lt, c1rt, c1up = true, c2lt, c2rt, c2up = true, f1down, f1up = true, f2down, f2up = true, b1up = true, b2up = true;
        int Scor, Banuti, Ciuperci;
        int[] forceb = new int[50];
        bool[] md = new bool[50];
        bool[] jumpb = new bool[50];

        int deplasare = 10;
        string nowC = "right";
        bool left, right, jump;
        int G = 30, Force;
        int nCer, nPamant, nBlock, nMonstru, nBanut, nPatratgol, nCiuperca, nGol, nBanutAer;
        PictureBox[] block = new PictureBox[50];
        PictureBox[] cer = new PictureBox[50];
        PictureBox[] pamant = new PictureBox[50];
        PictureBox[] monstru = new PictureBox[50];
        PictureBox[] banut = new PictureBox[50];
        PictureBox[] patratgol = new PictureBox[50];
        PictureBox[] ciuperca = new PictureBox[50];
        PictureBox[] gol = new PictureBox[50];
        PictureBox[] banutaer = new PictureBox[50];

        void init()
        {
            timer1.Enabled = true;
            button1.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button2.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button3.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            Scor = 0;
            Banuti = 0;
            Ciuperci = 0;
            button1.Text = "SCOR: 0";
            button2.Text = "BANUTI: 0";
            button3.Text = "CIUPERCI: 0";

            mario.Top = screen.Height - mario.Height;
            mario.Left = 342;

            banutaer[1] = banutaer1;
            banutaer[2] = banutaer2;
            banutaer[3] = banutaer3;
            banutaer[4] = banutaer4;
            banutaer[5] = banutaer5;
            banutaer[6] = banutaer6;
            banutaer[7] = banutaer7;
            banutaer[8] = banutaer8;
            banutaer[9] = banutaer9;
            banutaer[10] = banutaer10;
            banutaer[11] = banutaer11;
            banutaer[12] = banutaer12;
            banutaer[13] = banutaer13;
            banutaer[14] = banutaer14;
            banutaer[15] = banutaer15;
            banutaer[16] = banutaer16;
            nBanutAer = 16;

            gol[1] = gol1;
            gol[2] = gol2;
            gol[3] = gol3;
            gol[4] = gol4;
            gol[5] = gol5;
            gol[6] = gol6;
            gol[7] = gol7;
            gol[8] = gol8;
            gol[9] = gol9;
            nGol = 9;

            monstru[1] = monstru1;
            monstru[2] = monstru2;
            monstru[3] = monstru3;
            monstru[4] = monstru4;
            monstru[5] = monstru5;
            monstru[6] = monstru6;
            monstru[7] = monstru7;
            monstru[8] = monstru8;
            monstru[9] = monstru9;
            monstru[10] = monstru10;
            monstru[11] = monstru11;
            monstru[12] = monstru12;
            monstru[13] = monstru13;
            nMonstru = 13;
            for (int i = 1; i <= nMonstru; ++i)
                md[i] = true;

            ciuperca[1] = ciuperca1;
            ciuperca[2] = ciuperca2;
            nCiuperca = 2;

            banut[1] = banut1;
            banut[2] = banut2;
            banut[3] = banut3;
            banut[4] = banut4;
            banut[5] = banut5;
            nBanut = 5;

            patratgol[1] = patratgol1;
            patratgol[2] = patratgol2;
            patratgol[3] = patratgol3;
            patratgol[4] = patratgol4;
            patratgol[5] = patratgol5;
            patratgol[6] = patratgol6;
            patratgol[7] = patratgol7;
            nPatratgol = 7;

            cer[1] = cer1;
            cer[2] = cer2;
            cer[3] = cer3;
            cer[4] = cer4;
            cer[5] = cer5;
            cer[6] = cer6;
            cer[7] = cer7;
            cer[8] = cer8;
            cer[9] = cer9;
            cer[10] = cer10;
            cer[11] = cer11;
            cer[12] = cer12;
            cer[13] = cer13;
            cer[14] = cer14;
            cer[15] = cer15;
            cer[16] = cer16;
            cer[17] = cer17;
            cer[18] = cer18;
            cer[19] = cer19;
            cer[20] = cer20;
            cer[21] = cer21;
            cer[22] = cer22;
            cer[23] = cer23;
            cer[24] = cer24;
            cer[25] = cer25;
            cer[26] = cer26;
            cer[27] = cer27;
            cer[28] = cer28;
            cer[29] = cer29;
            nCer = 29;

            block[1] = cer1;
            block[2] = cer2;
            block[3] = cer3;
            block[4] = cer4;
            block[5] = cer5;
            block[6] = cer6;
            block[7] = cer7;
            block[8] = cer8;
            block[9] = cer9;
            block[10] = cer10;
            block[11] = cer11;
            block[12] = cer12;
            block[13] = cer13;
            block[14] = cer14;
            block[15] = pamant1;
            block[16] = pamant2;
            block[17] = pamant3;
            block[18] = pamant4;
            block[19] = pamant5;
            block[20] = pamant6;
            block[21] = pamant7;
            block[22] = cer15;
            block[23] = pamant8;
            block[24] = cer16;
            block[25] = cer17;
            block[26] = cer18;
            block[27] = cer19;
            block[28] = cer20;
            block[29] = cer21;
            block[30] = pamant9;
            block[31] = tub1;
            block[32] = tub2;
            block[33] = tub3;
            block[34] = tub4;
            block[35] = cer22;
            block[36] = bara1;
            block[37] = bara2;
            block[38] = cer23;
            block[39] = cer24;
            block[40] = cer25;
            block[41] = cer26;
            block[42] = cer27;
            block[43] = cer28;
            block[44] = cer29;
            nBlock = 44;

            pamant[1] = pamant1;
            pamant[2] = pamant2;
            pamant[3] = pamant3;
            pamant[4] = pamant4;
            pamant[5] = pamant5;
            pamant[6] = pamant6;
            pamant[7] = pamant7;
            pamant[8] = pamant8;
            pamant[9] = pamant9;
            pamant[10] = tub1;
            pamant[11] = tub2;
            pamant[12] = tub3;
            pamant[13] = tub4;
            nPamant = 13;

            cer[1].Top = 316;
            cer[1].Left = mario.Left + 300;
            for (int i = 2; i <= 10; ++i)
            {
                cer[i].Top = cer[i - 1].Top;
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            cer[11].Top = 185;
            cer[11].Left = cer[4].Left;
            for (int i = 12; i <= 14; ++i)
            {
                cer[i].Top = cer[i - 1].Top;
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            for (int i = 4; i <= 6; ++i)
            {
                banut[i - 3].Left = cer[i].Left + 12;
                banut[i - 3].Top = cer[i].Top + 13;
                patratgol[i - 3].Left = cer[i].Left;
                patratgol[i - 3].Top = cer[i].Top;
            }
            ciuperca[1].Left = cer[7].Left + 4;
            ciuperca[1].Top = cer[7].Top - 7;
            patratgol[4].Left = cer[7].Left;
            patratgol[4].Top = cer[7].Top;
            monstru[1].Left = block[1].Left;
            monstru[2].Left = monstru[1].Left + 100;
            monstru[3].Left = block[11].Left;
            monstru[1].Top = block[1].Top - monstru[1].Height;
            monstru[2].Top = block[2].Top - monstru[2].Height;
            monstru[3].Top = block[11].Top - monstru[3].Height;
            pamant[1].Left = cer[10].Left + 250;
            pamant[1].Top = screen.Height - pamant[1].Height;
            for (int i = 2; i <= 6; ++i)
            {
                pamant[i].Left = pamant[i - 1].Left + 150;
                pamant[i].Top = screen.Height - pamant[i].Height;
            }
            pamant[7].Left = pamant[6].Left + 200;
            pamant[7].Top = screen.Height - pamant[7].Height;
            monstru[4].Left = pamant[6].Left + pamant[6].Width + 60;
            monstru[4].Top = screen.Height - monstru[4].Height;
            cer[15].Left = pamant[6].Left + pamant[6].Width + 60;
            cer[15].Top = pamant[6].Top - 2;
            patratgol[5].Left = cer[15].Left;
            patratgol[5].Top = cer[15].Top;
            banut[4].Left = cer[15].Left + 12;
            banut[4].Top = cer[15].Top + 13;
            pamant[8].Left = 0;
            pamant[8].Top = screen.Height - pamant[8].Height;
            monstru[5].Top = screen.Height - monstru[5].Height;
            monstru[5].Left = pamant[1].Left - 20;
            gol[1].Left = pamant[7].Left + 250;

            cer[16].Top = 316;
            cer[16].Left = gol[1].Left + gol[1].Width + 300;
            for (int i = 17; i <= 19; ++i)
            {
                cer[i].Top = 316;
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            cer[20].Top = 185;
            cer[20].Left = cer[17].Left;
            cer[21].Top = 185;
            cer[21].Left = cer[18].Left;
            monstru[6].Left = gol[1].Left + gol[1].Width + 20;
            monstru[6].Top = screen.Height - monstru[6].Height;
            gol[2].Left = cer[19].Left + cer[19].Width + 300;
            banutaer[1].Left = cer[20].Left + 10;
            banutaer[2].Left = cer[21].Left + 10;
            banutaer[1].Top = cer[20].Top - 120;
            banutaer[2].Top = cer[21].Top - 120;
            banutaer[3].Left = banutaer[1].Left;
            banutaer[4].Left = banutaer[2].Left;
            banutaer[3].Top = banutaer[1].Top - 50;
            banutaer[4].Top = banutaer[2].Top - 50;

            banutaer[5].Left = gol[2].Left + gol[2].Width + 150;
            banutaer[5].Top = screen.Bottom - 50;
            block[30].Left = banutaer[5].Left + 200;
            block[30].Top = screen.Height - block[30].Height;
            banutaer[6].Left = banutaer[5].Left;
            banutaer[7].Left = banutaer[5].Left;
            banutaer[8].Left = banutaer[5].Left;
            banutaer[6].Top = banutaer[5].Top - 50;
            banutaer[7].Top = banutaer[6].Top - 50;
            banutaer[8].Top = banutaer[7].Top - 50;
            banutaer[9].Left = block[30].Right + 100;
            banutaer[9].Top = screen.Bottom - 150;
            banutaer[10].Left = banutaer[9].Left + 50;
            banutaer[10].Top = banutaer[9].Top;
            banutaer[11].Left = banutaer[9].Left;
            banutaer[11].Top = banutaer[9].Top - 50;
            banutaer[12].Left = banutaer[10].Left;
            banutaer[12].Top = banutaer[10].Top - 50;
            banutaer[13].Left = banutaer[10].Right + 150;
            banutaer[13].Top = screen.Bottom - 150;
            banutaer[14].Left = banutaer[13].Left + 50;
            banutaer[14].Top = banutaer[13].Top;
            banutaer[15].Left = banutaer[13].Left;
            banutaer[15].Top = banutaer[13].Top - 50;
            banutaer[16].Left = banutaer[14].Left;
            banutaer[16].Top = banutaer[14].Top - 50;
            gol[3].Left = banutaer[14].Right + 220;
            monstru[7].Left = block[30].Left + 20;
            monstru[7].Top = block[30].Top - monstru[7].Height;
            monstru[8].Left = block[30].Right + 20;
            monstru[8].Top = screen.Height - monstru[8].Height;
            monstru[9].Left = monstru[8].Left + 100;
            monstru[9].Top = monstru[8].Top;
            gol[4].Left = gol[3].Left + gol[3].Width + 100;

            block[31].Left = gol[4].Right;
            block[31].Top = screen.Height - block[31].Height;
            block[32].Left = block[31].Left + block[31].Width + 200;
            block[33].Left = block[32].Left + block[32].Width + 200;
            block[34].Left = block[33].Left + block[33].Width + 150;
            block[32].Top = screen.Height - block[32].Height;
            block[33].Top = screen.Height - block[33].Height;
            block[34].Top = screen.Height - block[34].Height;
            floare1.Top = screen.Height - floare1.Height;
            floare2.Top = screen.Height - floare2.Height;
            floare1.Left = block[32].Left + 30;
            floare2.Left = block[33].Left + 30;
            gol[5].Left = block[34].Left + 250;
            gol[6].Left = gol[5].Left + gol[5].Width + 100;
            gol[7].Left = gol[6].Left + gol[6].Width + 100;
            cer[22].Left = gol[7].Left + 40;
            cer[22].Top = 316;
            monstru[10].Top = cer[22].Top - monstru[10].Height;
            monstru[10].Left = cer[22].Left + 20;
            gol[8].Left = gol[7].Right + 500;

            monstru[11].Left = gol[7].Right + 20;
            monstru[12].Left = monstru[11].Left + 100;
            monstru[13].Left = monstru[12].Left + 100;
            monstru[11].Top = screen.Height - monstru[11].Height;
            monstru[12].Top = monstru[11].Top;
            monstru[13].Top = monstru[11].Top;
            bara1.Left = gol[8].Left + 90;
            bara1.Top = gol[8].Top;
            cer[23].Top = 316;
            cer[23].Left = gol[8].Right + 150;
            for (int i = 24; i <= 29; ++i)
            {
                cer[i].Top = cer[i - 1].Top;
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            gol[9].Left = cer[29].Right + 150;
            bara2.Left = gol[9].Left + 90;
            bara2.Top = gol[9].Top;
            banut[5].Left = cer[24].Left + 12;
            banut[5].Top = cer[24].Top + 13;
            ciuperca[2].Left = cer[26].Left + 4;
            ciuperca[2].Top = cer[26].Top - 7;
            patratgol[6].Left = cer[24].Left;
            patratgol[6].Top = cer[24].Top;
            patratgol[7].Left = cer[26].Left;
            patratgol[7].Top = cer[26].Top;

            for (int i = 1; i <= nMonstru; ++i)
            {
                monstru[i].Visible = true;
                md[i] = true;
            }
            for (int i = 1; i <= nBanutAer; ++i)
            {
                banutaer[i].Visible = true;
            }
            for (int i = 1; i <= nBanut; ++i)
            {
                banut[i].Visible = false;
            }
            for (int i = 1; i <= nCiuperca; ++i)
            {
                ciuperca[i].Visible = false;
            }
            for (int i = 1; i <= nPatratgol; ++i)
            {
                patratgol[i].Visible = false;
            }
            cer[4].Visible = true;
            cer[5].Visible = true;
            cer[6].Visible = true;
            cer[7].Visible = true;
            cer[15].Visible = true;
            cer[24].Visible = true;
            cer[26].Visible = true;
            c1lt = false;
            c1rt = false;
            c1up = true;
            c2up = true;
            c2lt = false;
            c2rt = false;
            f1down = false;
            f1up = true;
            f2down = false;
            f2up = true;

            Scor = 0;
            Banuti = 0;
            Ciuperci = 0;
            button1.Text = "SCOR: 0";
            button2.Text = "BANUTI: 0";
            button3.Text = "CIUPERCI: 0";

            steag.Left = gol[9].Right + 450;
            steag.Top = screen.Bottom - steag.Height + 10;
        }

        public Form2()
        {
            InitializeComponent();
            init();
        }

        int verify()
        {
            for (int i = 1; i <= nBlock; ++i)
            {
                if (mario.Left + mario.Width > block[i].Left && mario.Left + mario.Width < block[i].Left + block[i].Width + mario.Width && mario.Top + mario.Height >= block[i].Top && mario.Top < block[i].Top)
                {
                    mario.Top = block[i].Location.Y - mario.Height;
                    return 1;
                }
            }
            return 0;
        }

        int cadere()
        {
            for (int i = 1; i <= nBlock; ++i)
            {
                if (!(mario.Left + mario.Width > block[i].Left && mario.Left + mario.Width < block[i].Left + block[i].Width + mario.Width) && mario.Top + mario.Height >= block[i].Top && mario.Top < block[i].Top)
                    return 1;
            }
            return 0;
        }

        void e_steag()
        {
            if (mario.Right >= steag.Left)
            {
                Form3 f3 = new Form3();
                this.Hide();
                timer1.Enabled = false;
                f3.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            e_steag();

            // bara
            if (bara1.Top <= screen.Top)
                b1up = false;
            if (bara2.Top <= screen.Top)
                b2up = false;
            if (bara1.Bottom >= screen.Bottom)
                b1up = true;
            if (bara2.Bottom >= screen.Bottom)
                b2up = true;
            if (b1up == true)
            {
                if (mario.Bottom == bara1.Top)
                    mario.Top -= 2;
                bara1.Top -= 2;
            }
            if (b2up == true)
            {
                if (mario.Bottom == bara2.Top)
                    mario.Top -= 2;
                bara2.Top -= 2;
            }
            if (b1up == false)
            {
                if (mario.Bottom == bara1.Top)
                    mario.Top += 2;
                bara1.Top += 2;
            }
            if (b2up == false)
            {
                if (mario.Bottom == bara2.Top)
                    mario.Top += 2;
                bara2.Top += 2;
            }

            for (int i = 1; i <= nCer; ++i)
            {
                if (jumpb[i] == true)
                {
                    cer[i].Top -= forceb[i];
                    forceb[i] -= 1;
                }
                if ((i >= 11 && i <= 14) || (i >= 20 && i <= 21))
                {
                    if (cer[i].Top >= 185)
                    {
                        cer[i].Top = 185;
                        jumpb[i] = false;
                    }
                }
                else if (cer[i].Top >= 316)
                {
                    cer[i].Top = 316;
                    jumpb[i] = false;
                }
            }

            for (int i = 1; i <= nPamant; ++i)
            {
                if (!(mario.Left + mario.Width > pamant[i].Left && mario.Left + mario.Width < pamant[i].Left + pamant[i].Width + mario.Width && mario.Top + mario.Height >= pamant[i].Top && mario.Top < pamant[i].Top))
                {
                    // pentru jos - pamant
                    if (mario.Right >= pamant[i].Left && mario.Left <= pamant[i].Right - mario.Width && mario.Bottom > pamant[i].Top)
                    {
                        mario.Left = pamant[i].Left - mario.Width;
                        right = false;
                    }
                    if (mario.Left <= pamant[i].Right && mario.Right >= pamant[i].Left + mario.Width && mario.Bottom > pamant[i].Top)
                    {
                        mario.Left = pamant[i].Right;
                        left = false;
                    }
                }
            }
            for (int i = 1; i <= nCer; ++i)
            {
                if (!(mario.Left + mario.Width > cer[i].Left && mario.Left + mario.Width < cer[i].Left + cer[i].Width + mario.Width && mario.Top + mario.Height >= cer[i].Top && mario.Top < cer[i].Top))
                {
                    // pentru sus - cer
                    if (mario.Right > cer[i].Left && mario.Left < cer[i].Right - mario.Width && mario.Bottom < cer[i].Bottom && mario.Bottom > cer[i].Top)
                    {
                        mario.Left = cer[i].Left - mario.Width;
                        right = false;
                    }
                    if (mario.Left < cer[i].Right && mario.Right > cer[i].Left + mario.Width && mario.Bottom < cer[i].Bottom && mario.Bottom > cer[i].Top)
                    {
                        mario.Left = cer[i].Right;
                        left = false;
                    }
                }
            }

            if (right == true)
            {
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left -= deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left -= deplasare;
                }
                for (int i = 1; i <= nPatratgol; ++i)
                {
                    patratgol[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left -= deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left -= deplasare;
                }
                for (int i = 1; i <= nGol; ++i)
                {
                    gol[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanutAer; ++i)
                {
                    banutaer[i].Left -= deplasare;
                }
                floare1.Left -= deplasare;
                floare2.Left -= deplasare;
                steag.Left -= deplasare;
            }
            if (left == true)
            {
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left += deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left += deplasare;
                }
                for (int i = 1; i <= nPatratgol; ++i)
                {
                    patratgol[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left += deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left += deplasare;
                }
                for (int i = 1; i <= nGol; ++i)
                {
                    gol[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanutAer; ++i)
                {
                    banutaer[i].Left += deplasare;
                }
                floare1.Left += deplasare;
                floare2.Left += deplasare;
                steag.Left += deplasare;
            }
            if (jump == true)
            {
                mario.Top -= Force;
                Force -= 3;
            }

            if (mario.Top + mario.Height >= screen.Height)
            {
                mario.Top = screen.Height - mario.Height; // sa nu mai cada
                if (jump == true)
                {
                    if (left == false && right == false)
                    {
                        if (nowC == "right")
                        {
                            mario.Image = Properties.Resources.stand_r;
                        }
                        else if (nowC == "left")
                        {
                            mario.Image = Properties.Resources.stand_l;
                        }
                    }
                    else
                    {
                        if (nowC == "right")
                        {
                            mario.Image = Properties.Resources.fugit_r;
                        }
                        else if (nowC == "left")
                        {
                            mario.Image = Properties.Resources.fugit_l;
                        }
                    }
                }
                jump = false;
            }
            // oprire pe
            else if (verify() == 1)
            {
                Force = 0;
                if (jump == true)
                {
                    if (left == false && right == false)
                    {
                        if (nowC == "right")
                        {
                            mario.Image = Properties.Resources.stand_r;
                        }
                        else if (nowC == "left")
                        {
                            mario.Image = Properties.Resources.stand_l;
                        }
                    }
                    else
                    {
                        if (nowC == "right")
                        {
                            mario.Image = Properties.Resources.fugit_r;
                        }
                        else if (nowC == "left")
                        {
                            mario.Image = Properties.Resources.fugit_l;
                        }
                    }
                }
                jump = false;
            }
            else if (cadere() == 1)
            {
                jump = true;
            }
            else
            {
                mario.Top += 2; // cade
            }

            // oprire in sus
            for (int i = 1; i <= nBlock; ++i)
            {
                if (mario.Left + mario.Width > block[i].Left && mario.Left + mario.Width < block[i].Left + block[i].Width + mario.Width && mario.Top - block[i].Bottom <= 10 && mario.Top - block[i].Top > -10)
                {
                    if (block[i].Visible == true)
                    {
                        if ((i >= 1 && i <= 3) || (i >= 8 && i <= 10) || (i >= 11 && i <= 14) || (i >= 24 && i <= 29) || i == 38 || i == 40 || (i >= 42 && i <= 44))
                        {
                            int nowi = i;
                            if (i >= 24 && i <= 29)
                                nowi = i - 8;
                            if (i == 38)
                                nowi = 23;
                            if (i == 40)
                                nowi = 25;
                            if (i >= 42 && i <= 44)
                                nowi = i - 15;
                            jumpb[nowi] = true;
                            block[i].Top -= 10;
                            forceb[nowi] = 2;
                        }
                        else if (i == 7 || i == 41) // ciuperca
                        {
                            if (i == 7)
                            {
                                block[i].Visible = false;
                                patratgol[4].Visible = true;
                                ciuperca[1].Visible = true;
                            }
                            else if (i == 41)
                            {
                                block[i].Visible = false;
                                patratgol[7].Visible = true;
                                ciuperca[2].Visible = true;
                            }
                        }
                        else if (i == 4 || i == 5 || i == 6 || i == 22 || i == 39)
                        {
                            block[i].Visible = false;
                            if (i == 4)
                            {
                                patratgol[1].Visible = true;
                                banut[1].Visible = true;
                            }
                            else if (i == 5)
                            {
                                patratgol[2].Visible = true;
                                banut[2].Visible = true;
                            }
                            else if (i == 6)
                            {
                                patratgol[3].Visible = true;
                                banut[3].Visible = true;
                            }
                            else if (i == 22)
                            {
                                patratgol[5].Visible = true;
                                banut[4].Visible = true;
                            }
                            else if (i == 39)
                            {
                                patratgol[6].Visible = true;
                                banut[5].Visible = true;
                            }
                        }
                        if (i != 4 && i != 5 && i != 6 && i != 7 && i != 22 && i != 39 && i != 41)
                        {
                            for (int j = 1; j <= 3; ++j)
                            {
                                if (monstru[j].Visible == true)
                                {
                                    if (monstru[j].Bottom >= block[i].Top && ((monstru[j].Left >= block[i].Left && monstru[j].Right <= block[i].Right) || (monstru[j].Left <= block[i].Right && monstru[j].Right >= block[i].Right) || (monstru[j].Right >= block[i].Left && monstru[j].Left <= block[i].Left)))
                                    {
                                        monstru[j].Visible = false;
                                        Scor += 100;
                                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                                    }
                                }
                            }
                            for (int j = 1; j <= nCiuperca; ++j)
                            {
                                if (j == 1 && ciuperca[j].Bottom != 316)
                                    continue;
                                if (j == 2 && ciuperca[j].Bottom != 316)
                                    continue;
                                if (ciuperca[j].Visible == true)
                                {
                                    if (ciuperca[j].Bottom >= block[i].Top && ((ciuperca[j].Left >= block[i].Left && ciuperca[j].Right <= block[i].Right) || (ciuperca[j].Left <= block[i].Right && ciuperca[j].Right >= block[i].Right) || (ciuperca[j].Right >= block[i].Left && ciuperca[j].Left <= block[i].Left)))
                                    {
                                        ciuperca[j].Visible = false;
                                        Scor += 100;
                                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                                    }
                                }
                            }
                        }
                    }
                    Force = -3;
                }
            }

            //gol
            for (int i = 1; i <= nGol; ++i)
                if (mario.Left >= gol[i].Left && mario.Right <= gol[i].Right && mario.Bottom == gol[i].Top)
                {
                    //Application.Restart();
                    init();
                }

            // banuti si ciuperci
            if (ciuperca[1].Visible == true)
            {
                if (ciuperca[1].Visible == true && (ciuperca[1].Left + ciuperca[1].Width >= mario.Left && ciuperca[1].Left <= mario.Left + mario.Width) && mario.Bottom <= ciuperca[1].Bottom && mario.Bottom >= ciuperca[1].Top)
                {
                    ciuperca[1].Visible = false;
                    ++Ciuperci;
                    Scor += 100;
                    button1.Text = "SCOR: " + Convert.ToString(Scor);
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                }
                if (ciuperca[1].Visible == true && mario.Left + mario.Width >= ciuperca[1].Left && mario.Left + mario.Width <= ciuperca[1].Left + ciuperca[1].Width + mario.Width && mario.Top + mario.Height >= ciuperca[1].Top && mario.Top < ciuperca[1].Top)
                {
                    ciuperca[1].Visible = false;
                    ++Ciuperci;
                    Scor += 100;
                    button1.Text = "SCOR: " + Convert.ToString(Scor);
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                }

                if (c1up == true && ciuperca[1].Top + ciuperca[1].Height <= cer[7].Top)
                {
                    ciuperca[1].Top = cer[7].Top - ciuperca[1].Height;
                    c1up = false;
                    c1rt = true;
                }

                if (ciuperca[1].Left + ciuperca[1].Width >= block[10].Left + block[10].Width)
                {
                    c1rt = false;
                    c1lt = true;
                }
                if (ciuperca[1].Left <= block[1].Left)
                {
                    c1rt = true;
                    c1lt = false;
                }

                if (c1up == true)
                {
                    ciuperca[1].Top -= 2;
                }
                if (c1rt == true)
                {
                    ciuperca[1].Left += 2;
                }
                if (c1lt == true)
                {
                    ciuperca[1].Left -= 2;
                }
            }
            if (ciuperca[2].Visible == true)
            {
                if (ciuperca[2].Visible == true && (ciuperca[2].Left + ciuperca[2].Width >= mario.Left && ciuperca[2].Left <= mario.Left + mario.Width) && mario.Bottom <= ciuperca[2].Bottom && mario.Bottom >= ciuperca[2].Top)
                {
                    ciuperca[2].Visible = false;
                    ++Ciuperci;
                    Scor += 100;
                    button1.Text = "SCOR: " + Convert.ToString(Scor);
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                }
                if (ciuperca[2].Visible == true && mario.Left + mario.Width >= ciuperca[2].Left && mario.Left + mario.Width <= ciuperca[2].Left + ciuperca[2].Width + mario.Width && mario.Top + mario.Height >= ciuperca[2].Top && mario.Top < ciuperca[2].Top)
                {
                    ciuperca[2].Visible = false;
                    ++Ciuperci;
                    Scor += 100;
                    button1.Text = "SCOR: " + Convert.ToString(Scor);
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                }

                if (c2up == true && ciuperca[2].Top + ciuperca[2].Height <= cer[26].Top)
                {
                    ciuperca[2].Top = cer[26].Top - ciuperca[2].Height;
                    c2up = false;
                    c2rt = true;
                }

                if (ciuperca[2].Left + ciuperca[2].Width >= block[44].Left + block[44].Width)
                {
                    c2rt = false;
                    c2lt = true;
                }
                if (ciuperca[2].Left <= block[38].Left)
                {
                    c2rt = true;
                    c2lt = false;
                }

                if (c2up == true)
                {
                    ciuperca[2].Top -= 2;
                }
                if (c2rt == true)
                {
                    ciuperca[2].Left += 2;
                }
                if (c2lt == true)
                {
                    ciuperca[2].Left -= 2;
                }
            }
            for (int i = 1; i <= nBanut; ++i)
            {
                if (banut[i].Visible == true)
                {
                    if (i == 1 && banut[i].Top + banut[i].Height < cer[4].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 2 && banut[i].Top + banut[i].Height < cer[5].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 3 && banut[i].Top + banut[i].Height < cer[6].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 4 && banut[i].Top + banut[i].Height < cer[15].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 5 && banut[i].Top + banut[i].Height < cer[24].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    banut[i].Top -= 2;
                }
            }

            // monstru
            for (int i = 1; i <= nMonstru; ++i)
            {
                if (monstru[i].Visible == true)
                {
                    if (i == 1)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[10].Left + block[10].Width)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[1].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 2)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[10].Left + block[10].Width)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[1].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 3)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[14].Left + block[14].Width)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[11].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 4)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[21].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[20].Left + block[20].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 5)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[15].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < block[23].Left + block[23].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 6)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[2].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < gol[1].Left + gol[1].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 7)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[30].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < block[30].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 8)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[3].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < block[30].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 9)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[3].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < block[30].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 10)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[22].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < cer[22].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 11)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[8].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < gol[7].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 12)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[8].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < gol[7].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 13)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[8].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left < gol[7].Right)
                        {
                            md[i] = true;
                        }
                    }

                    if (monstru[1].Visible == true && monstru[2].Visible == true && monstru[1].Left + monstru[1].Width >= monstru[2].Left)
                    {
                        md[1] = false;
                        md[2] = true;
                    }
                    if (monstru[8].Visible == true && monstru[9].Visible == true && monstru[8].Left + monstru[8].Width >= monstru[9].Left)
                    {
                        md[8] = false;
                        md[9] = true;
                    }
                    if (monstru[12].Visible == true && monstru[13].Visible == true && monstru[12].Left + monstru[12].Width >= monstru[13].Left)
                    {
                        md[12] = false;
                        md[13] = true;
                    }
                    if (monstru[11].Visible == true && monstru[12].Visible == true && monstru[11].Left + monstru[11].Width >= monstru[12].Left)
                    {
                        md[11] = false;
                        md[12] = true;
                    }
                    if (monstru[11].Visible == true && monstru[13].Visible == true && monstru[11].Left + monstru[11].Width >= monstru[13].Left)
                    {
                        md[11] = false;
                        md[13] = true;
                    }
                    if (monstru[1].Visible == true && ciuperca[1].Visible == true && ciuperca[1].Bottom == 316 && ciuperca[1].Right >= monstru[1].Left && ciuperca[1].Left <= monstru[1].Right - ciuperca[1].Width)
                    {
                        md[1] = true;
                        c1rt = false;
                        c1lt = true;
                    }
                    if (monstru[1].Visible == true && ciuperca[1].Visible == true && ciuperca[1].Bottom == 316 && ciuperca[1].Left <= monstru[1].Right && ciuperca[1].Right >= monstru[1].Left + ciuperca[1].Width)
                    {
                        md[1] = false;
                        c1rt = true;
                        c1lt = false;
                    }
                    if (monstru[2].Visible == true && ciuperca[1].Visible == true && ciuperca[1].Bottom == 316 && ciuperca[1].Right >= monstru[2].Left && ciuperca[1].Left <= monstru[2].Right - ciuperca[1].Width)
                    {
                        md[2] = true;
                        c1rt = false;
                        c1lt = true;
                    }
                    if (monstru[2].Visible == true && ciuperca[1].Visible == true && ciuperca[1].Bottom == 316 && ciuperca[1].Left <= monstru[2].Right && ciuperca[1].Right >= monstru[2].Left + ciuperca[1].Width)
                    {
                        md[2] = false;
                        c1rt = true;
                        c1lt = false;
                    }

                    if (monstru[i].Visible == true && mario.Left + mario.Width > monstru[i].Left && mario.Left + mario.Width < monstru[i].Left + monstru[i].Width + mario.Width && mario.Top + mario.Height >= monstru[i].Top && mario.Top < monstru[i].Top && mario.Bottom != monstru[i].Bottom)
                    {
                        monstru[i].Visible = false;
                        jump = true;
                        Force = 10;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                    }
                    else if (monstru[i].Visible == true && monstru[i].Left + monstru[i].Width >= mario.Left && monstru[i].Left <= mario.Left + mario.Width && mario.Bottom == monstru[i].Bottom)
                    {
                        if (Ciuperci >= 1)
                        {
                            --Ciuperci;
                            button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                            monstru[i].Visible = false;
                        }
                        else
                            init();
                    }

                    if (md[i] == true) // merg spre dreapta
                    {
                        monstru[i].Left += 2;
                    }
                    if (md[i] == false)
                    {
                        monstru[i].Left -= 2;
                    }
                }
            }

            // banut
            for (int i = 1; i <= nBanutAer; ++i)
            {
                if (banutaer[i].Visible == true)
                {
                    if (!(mario.Left + mario.Width > banutaer[i].Left && mario.Left + mario.Width < banutaer[i].Left + banutaer[i].Width + mario.Width && mario.Top + mario.Height >= banutaer[i].Top && mario.Top < banutaer[i].Top))
                    {
                        // pentru sus - cer
                        if (mario.Right >= banutaer[i].Left && mario.Left <= banutaer[i].Right - mario.Width && mario.Bottom < banutaer[i].Bottom && mario.Bottom > banutaer[i].Top)
                        {
                            ++Banuti;
                            Scor += 100;
                            button1.Text = "SCOR: " + Convert.ToString(Scor);
                            button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                            banutaer[i].Visible = false;
                            continue;
                        }
                        if (mario.Left <= banutaer[i].Right && mario.Right >= banutaer[i].Left + mario.Width && mario.Bottom < banutaer[i].Bottom && mario.Bottom > banutaer[i].Top)
                        {
                            ++Banuti;
                            Scor += 100;
                            button1.Text = "SCOR: " + Convert.ToString(Scor);
                            button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                            banutaer[i].Visible = false;
                            continue;
                        }
                    }
                    if (mario.Left + mario.Width > banutaer[i].Left && mario.Left + mario.Width < banutaer[i].Left + banutaer[i].Width + mario.Width && mario.Top - banutaer[i].Bottom <= 10 && mario.Top - banutaer[i].Top > -10)
                    {
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                        banutaer[i].Visible = false;
                        continue;
                    }
                    if (mario.Left + mario.Width > banutaer[i].Left && mario.Left + mario.Width < banutaer[i].Left + banutaer[i].Width + mario.Width && mario.Top + mario.Height >= banutaer[i].Top && mario.Top < banutaer[i].Top)
                    {
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                        banutaer[i].Visible = false;
                        continue;
                    }
                }
            }

            // flori

            if ((floare1.Left + floare1.Width >= mario.Left && floare1.Left <= mario.Left + mario.Width) && mario.Bottom <= floare1.Bottom && mario.Bottom >= floare1.Top)
            {
                if (Ciuperci >= 1)
                {
                    --Ciuperci;
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    floare1.Top = block[32].Top + 4;
                    f1down = true;
                    f1up = false;
                }
                else
                {
                    f1up = false;
                    f1down = false;
                }
            }
            if (mario.Left + mario.Width >= floare1.Left && mario.Left + mario.Width <= floare1.Left + floare1.Width + mario.Width && mario.Top + mario.Height >= floare1.Top && mario.Top < floare1.Top)
            {
                if (Ciuperci >= 1)
                {
                    --Ciuperci;
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    floare1.Top = block[32].Top + 4;
                    f1down = true;
                    f1up = false;
                }
                else
                {
                    f1up = false;
                    f1down = false;
                }
            }
            if (f1up == false && f1down == false)
            {
                init();
            }
            if (floare1.Bottom <= block[32].Top)
            {
                f1up = false;
                f1down = true;
            }
            if (floare1.Bottom >= block[32].Bottom)
            {
                f1up = true;
                f1down = false;
            }

            if (f1up == true)
            {
                floare1.Top -= 2;
            }
            if (f1down == true)
            {
                floare1.Top += 2;
            }

            if ((floare2.Left + floare2.Width >= mario.Left && floare2.Left <= mario.Left + mario.Width) && mario.Bottom <= floare2.Bottom && mario.Bottom >= floare2.Top)
            {
                if (Ciuperci >= 1)
                {
                    --Ciuperci;
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    floare2.Top = block[33].Top + 4;
                    f2down = true;
                    f2up = false;
                }
                else
                {
                    f2up = false;
                    f2down = false;
                }
            }
            if (mario.Left + mario.Width >= floare2.Left && mario.Left + mario.Width <= floare2.Left + floare2.Width + mario.Width && mario.Top + mario.Height >= floare2.Top && mario.Top < floare2.Top)
            {
                if (Ciuperci >= 1)
                {
                    --Ciuperci;
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    floare2.Top = block[33].Top + 4;
                    f2down = true;
                    f2up = false;
                }
                else
                {
                    f2up = false;
                    f2down = false;
                }
            }
            if (f2up == false && f2down == false)
            {
                init();
            }
            if (floare2.Bottom <= block[33].Top)
            {
                f2up = false;
                f2down = true;
            }
            if (floare2.Bottom >= block[33].Bottom)
            {
                f2up = true;
                f2down = false;
            }

            if (f2up == true)
            {
                floare2.Top -= 2;
            }
            if (f2down == true)
            {
                floare2.Top += 2;
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && right != true)
            {
                right = true;
                nowC = "right";
                mario.Image = Properties.Resources.fugit_r;
            }
            if (e.KeyCode == Keys.Left && left != true)
            {
                left = true;
                nowC = "left";
                mario.Image = Properties.Resources.fugit_l;
            }
            if (e.KeyCode == Keys.R)
            {
                init();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Form5 f5 = new Form5();
                this.Hide();
                timer1.Enabled = false;
                f5.Show();
            }

            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                    if (nowC == "right")
                    {
                        mario.Image = Properties.Resources.jump_r;
                    }
                    else if (nowC == "left")
                    {
                        mario.Image = Properties.Resources.jump_l;
                    }
                }
            }
            else if (jump == true)
            {
                if (nowC == "right")
                {
                    mario.Image = Properties.Resources.jump_r;
                }
                else if (nowC == "left")
                {
                    mario.Image = Properties.Resources.jump_l;
                }
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                if (left == false)
                {
                    mario.Image = Properties.Resources.stand_r;
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                if (right == false)
                {
                    mario.Image = Properties.Resources.stand_l;
                }
            }
        }
    }
}
