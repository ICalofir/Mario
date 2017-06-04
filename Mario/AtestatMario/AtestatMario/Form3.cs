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
    public partial class Form3 : Form
    {
        int Ciuperci, Scor, Banuti;
        bool c1lt, c1rt, c1up = true, c2lt, c2rt, c2up = true, b1d, b2d;
        bool[] md = new bool[50];
        int[] bara = new int[7];

        int deplasare = 10;
        string nowC = "right";
        bool left, right, jump;
        int G = 30, Force;

        int nBanut, nBanutAer, nMonstru, nCiuperca, nBlock, nTulpina, nPatratgol;
        PictureBox[] banut = new PictureBox[50];
        PictureBox[] banutaer = new PictureBox[50];
        PictureBox[] monstru = new PictureBox[50];
        PictureBox[] ciuperca = new PictureBox[50];
        PictureBox[] cer = new PictureBox[50];
        PictureBox[] block = new PictureBox[50];
        PictureBox[] tulpina = new PictureBox[50];
        PictureBox[] patratgol = new PictureBox[50];

        void init()
        {
            timer1.Enabled = true;
            button1.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button2.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button3.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);

            mario.Left = 342;

            for (int i = 1; i <= 4; ++i)
                bara[i] = 3;
            b1d = true;
            b2d = false;

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
            monstru[14] = monstru14;
            monstru[15] = monstru15;
            nMonstru = 15;
            for (int i = 1; i <= nMonstru; ++i)
                md[i] = true;

            ciuperca[1] = ciuperca1;
            ciuperca[2] = ciuperca2;
            nCiuperca = 2;

            banut[1] = banut1;
            banut[2] = banut2;
            banut[3] = banut3;
            banut[4] = banut4;
            nBanut = 4;

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
            nBanutAer = 15;

            patratgol[1] = patratgol1;
            patratgol[2] = patratgol2;
            patratgol[3] = patratgol3;
            patratgol[4] = patratgol4;
            patratgol[5] = patratgol5;
            patratgol[6] = patratgol6;
            nPatratgol = 6;

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
            cer[30] = cer30;
            cer[31] = cer31;
            cer[32] = cer32;

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
            block[15] = cer15;
            block[16] = cer16;
            block[17] = cer17;
            block[18] = cer18;
            block[19] = cer19;
            block[20] = cer20;
            block[21] = cer21;
            block[22] = cer22;
            block[23] = cer23;
            block[24] = cer24;
            block[25] = cer25;
            block[26] = cer26;
            block[27] = cer27;
            block[28] = cer28;
            block[29] = cer29;
            block[30] = cer30;
            block[31] = cer31;
            block[32] = cer32;
            nBlock = 32;

            tulpina[1] = tulpina1;
            tulpina[2] = tulpina2;
            tulpina[3] = tulpina3;
            tulpina[4] = tulpina4;
            tulpina[5] = tulpina5;
            tulpina[6] = tulpina6;
            tulpina[7] = tulpina7;
            tulpina[8] = tulpina8;
            tulpina[9] = tulpina9;
            tulpina[10] = tulpina10;
            tulpina[11] = tulpina11;
            tulpina[12] = tulpina12;
            tulpina[13] = tulpina13;
            tulpina[14] = tulpina14;
            tulpina[15] = tulpina15;
            tulpina[16] = tulpina16;
            tulpina[17] = tulpina17;
            nTulpina = 17;

            tulpina[1].Left = 310;
            tulpina[1].Top = screen.Height - tulpina[1].Height;
            cer[1].Left = tulpina[1].Left - 29;
            cer[1].Top = tulpina[1].Top - cer[1].Height;
            mario.Top = cer[1].Top - mario.Height;
            tulpina[2].Left = tulpina[1].Left + 300;
            tulpina[2].Top = screen.Height - tulpina[2].Height;
            cer[2].Left = tulpina[2].Left - 22;
            cer[2].Top = tulpina[2].Top - cer[2].Height;
            tulpina[3].Left = tulpina[2].Left + 300;
            tulpina[3].Width = 358;
            tulpina[3].Height = 267;
            cer[3].Width = 418;
            cer[3].Height = 40;
            cer[3].Left = tulpina[3].Left - 30;
            cer[3].Top = tulpina[3].Top - cer[3].Height;
            cer[4].Width = 200;
            cer[4].Left = cer[3].Left + 170;
            cer[4].Top = cer[3].Top - 135;
            banutaer[1].Top = cer[4].Top + 2;
            banutaer[1].Left = cer[4].Right + 10;
            cer[5].Left = cer[4].Left - cer[5].Width;
            cer[5].Top = cer[4].Top;
            patratgol[1].Left = cer[5].Left;
            patratgol[1].Top = cer[5].Top;
            ciuperca[1].Left = cer[5].Left + 4;
            ciuperca[1].Top = cer[5].Top - 7;
            monstru[1].Top = cer[4].Top - monstru[1].Height;
            monstru[1].Left = cer[5].Right + 20;

            tulpina[4].Left = tulpina[3].Right + 220;
            tulpina[4].Width = 300;
            tulpina[4].Height = 230;
            tulpina[4].Top = screen.Height - tulpina[4].Height;
            cer[6].Width = 340;
            cer[6].Height = 35;
            cer[6].Left = tulpina[4].Left - 20;
            cer[6].Top = tulpina[4].Top - cer[6].Height;
            monstru[2].Left = cer[6].Left + 20;
            monstru[3].Left = monstru[2].Left + 100;
            monstru[2].Top = cer[6].Top - monstru[2].Height;
            monstru[3].Top = monstru[2].Top;

            cer[7].Left = cer[6].Right + 170;
            cer[7].Top = cer[6].Top + 20;
            cer[8].Left = cer[7].Right + 100;
            cer[8].Top = cer[7].Top - 20;
            cer[9].Left = cer[8].Right + 100;
            cer[9].Top = cer[8].Top - 20;
            banutaer[2].Left = cer[7].Left + 42;
            banutaer[3].Left = cer[8].Left + 42;
            banutaer[4].Left = cer[9].Left + 42;
            banutaer[2].Top = cer[7].Top - 70;
            banutaer[3].Top = cer[8].Top - 70;
            banutaer[4].Top = cer[9].Top - 70;
            tulpina[5].Width = tulpina[3].Width;
            tulpina[5].Height = tulpina[3].Height;
            tulpina[5].Top = screen.Height - tulpina[5].Height;
            tulpina[5].Left = cer[9].Right + 190;
            cer[10].Width = cer[3].Width;
            cer[10].Height = cer[3].Height;
            cer[10].Left = tulpina[5].Left - 30;
            cer[10].Top = tulpina[5].Top - cer[10].Height;
            cer[11].Width = 200;
            cer[11].Left = cer[10].Left + 170;
            cer[11].Top = cer[10].Top - 135;
            monstru[4].Left = cer[11].Left + 20;
            monstru[4].Top = cer[11].Top - monstru[4].Height;
            monstru[6].Left = cer[10].Right - 20;
            monstru[5].Left = monstru[6].Left - 100;
            monstru[5].Top = cer[10].Top - monstru[5].Height;
            monstru[6].Top = monstru[5].Top;

            tulpina[6].Width = 91;
            tulpina[6].Height = tulpina[5].Height - 20;
            tulpina[6].Top = screen.Height - tulpina[6].Height;
            tulpina[6].Left = tulpina[5].Right + 220;
            cer[12].Width = 121;
            cer[12].Height = 20;
            cer[12].Left = tulpina[6].Left - 15;
            cer[12].Top = tulpina[6].Top - cer[12].Height;
            tulpina[7].Width = 91;
            tulpina[7].Height = tulpina[5].Height - 20;
            tulpina[7].Top = screen.Height - tulpina[6].Height;
            tulpina[7].Left = tulpina[6].Right + 200;
            cer[13].Width = 121;
            cer[13].Height = 20;
            cer[13].Left = tulpina[7].Left - 15;
            cer[13].Top = tulpina[7].Top - cer[13].Height;

            tulpina[8].Width = tulpina[4].Width;
            tulpina[8].Height = tulpina[4].Height + 50;
            tulpina[8].Top = screen.Height - tulpina[8].Height;
            tulpina[8].Left = tulpina[7].Right + 200;
            cer[14].Width = cer[6].Width;
            cer[14].Height = cer[6].Height;
            cer[14].Top = tulpina[8].Top - cer[14].Height;
            cer[14].Left = tulpina[8].Left - 20;
            monstru[7].Left = cer[14].Left + 20;
            monstru[8].Left = monstru[7].Left + 100;
            monstru[7].Top = cer[14].Top - monstru[7].Height;
            monstru[8].Top = monstru[7].Top;
            banutaer[5].Left = cer[10].Right + (cer[12].Left - cer[10].Right) / 2 - 8;
            banutaer[6].Left = cer[12].Right + (cer[13].Left - cer[12].Right) / 2 - 8;
            banutaer[7].Left = cer[13].Right + (cer[14].Left - cer[13].Right) / 2 - 8;
            banutaer[5].Top = cer[10].Top - 170;
            banutaer[6].Top = cer[12].Top - 170;
            banutaer[7].Top = cer[14].Top - 150;

            tulpina[9].Width = 300;
            tulpina[9].Height = tulpina[8].Height + 50;
            tulpina[9].Left = tulpina[8].Right + 600;
            tulpina[9].Top = screen.Height - tulpina[9].Height;
            cer[17].Width = 340;
            cer[17].Height = 35;
            cer[17].Left = tulpina[9].Left - 20;
            cer[17].Top = tulpina[9].Top - cer[17].Height;
            cer[15].Top = cer[17].Top + 20;
            cer[16].Top = cer[15].Top;
            cer[15].Left = cer[14].Right;
            cer[16].Left = cer[17].Left - cer[16].Width;
            monstru[9].Left = cer[17].Left + 20;
            monstru[9].Top = cer[17].Top - monstru[9].Height;
            cer[18].Left = cer[17].Right + 150;
            cer[18].Top = cer[17].Top;

            tulpina[10].Width = tulpina[5].Width;
            tulpina[10].Height = tulpina[5].Height + 20;
            tulpina[10].Top = screen.Height - tulpina[10].Height;
            tulpina[10].Left = cer[18].Right + 150;
            cer[19].Width = cer[10].Width;
            cer[19].Height = cer[10].Height;
            cer[19].Left = tulpina[10].Left - 30;
            cer[19].Top = tulpina[10].Top - cer[19].Height;
            cer[20].Width = 200;
            cer[20].Left = cer[19].Left + 170;
            cer[20].Top = cer[19].Top - 135;
            monstru[10].Left = cer[20].Left + 20;
            monstru[10].Top = cer[20].Top - monstru[10].Height;
            monstru[11].Left = cer[19].Left + 20;
            monstru[11].Top = cer[19].Top - monstru[11].Height;
            banutaer[8].Top = cer[20].Top + 2;
            banutaer[8].Left = cer[20].Right + 10;

            tulpina[11].Width = 200;
            tulpina[11].Height = tulpina[10].Height - 75;
            tulpina[11].Left = cer[19].Right + 200;
            tulpina[11].Top = screen.Height - tulpina[11].Height;
            cer[21].Width = 240;
            cer[21].Height = 30;
            cer[21].Left = tulpina[11].Left - 20;
            cer[21].Top = tulpina[11].Top - cer[21].Height;

            tulpina[12].Width = 250;
            tulpina[12].Height = tulpina[11].Height - 75;
            tulpina[12].Left = cer[21].Right + 200;
            tulpina[12].Top = screen.Height - tulpina[12].Height;
            cer[22].Width = 280;
            cer[22].Height = 25;
            cer[22].Left = tulpina[12].Left - 15;
            cer[22].Top = tulpina[12].Top - cer[22].Height;
            cer[23].Left = cer[22].Left + 100;
            cer[23].Top = cer[22].Top - 137;
            cer[24].Left = cer[23].Left + cer[23].Width;
            cer[24].Top = cer[23].Top;
            banut[1].Left = cer[23].Left + 12;
            banut[1].Top = cer[23].Top + 13;
            ciuperca[2].Left = cer[24].Left + 4;
            ciuperca[2].Top = cer[24].Top - 7;
            monstru[12].Top = cer[22].Top - monstru[12].Height;
            monstru[12].Left = cer[22].Left + 20;
            patratgol[2].Left = cer[23].Left;
            patratgol[2].Top = cer[23].Top;
            patratgol[3].Left = cer[24].Left;
            patratgol[3].Top = cer[24].Top;

            tulpina[13].Width = 100;
            tulpina[13].Height = tulpina[12].Height - 75;
            tulpina[13].Left = cer[22].Right + 200;
            tulpina[13].Top = screen.Height - tulpina[13].Height;
            cer[25].Width = 120;
            cer[25].Height = 20;
            cer[25].Left = tulpina[13].Left - 10;
            cer[25].Top = tulpina[13].Top - cer[25].Height;

            tulpina[14].Width = 250;
            tulpina[14].Height = tulpina[12].Height;
            tulpina[14].Left = cer[25].Right + 150;
            tulpina[14].Top = screen.Height - tulpina[14].Height;
            cer[26].Width = 280;
            cer[26].Height = 25;
            cer[26].Left = tulpina[14].Left - 15;
            cer[26].Top = tulpina[14].Top - cer[26].Height;
            cer[27].Left = cer[26].Left + 80;
            cer[27].Top = cer[26].Top - 137;
            cer[28].Left = cer[27].Left + cer[27].Width;
            cer[28].Top = cer[27].Top;
            cer[29].Left = cer[28].Left + cer[28].Width;
            cer[29].Top = cer[27].Top;
            banut[2].Left = cer[27].Left + 12;
            banut[2].Top = cer[27].Top + 13;
            banut[3].Left = cer[28].Left + 12;
            banut[3].Top = cer[28].Top + 13;
            banut[4].Left = cer[29].Left + 12;
            banut[4].Top = cer[29].Top + 13;
            patratgol[4].Left = cer[27].Left;
            patratgol[4].Top = cer[27].Top;
            patratgol[5].Left = cer[28].Left;
            patratgol[5].Top = cer[28].Top;
            patratgol[6].Left = cer[29].Left;
            patratgol[6].Top = cer[29].Top;
            banutaer[9].Left = cer[27].Left + 12;
            banutaer[10].Left = cer[28].Left + 12;
            banutaer[11].Left = cer[29].Left + 12;
            banutaer[9].Top = cer[27].Top - 135;
            banutaer[10].Top = cer[28].Top - 135;
            banutaer[11].Top = cer[29].Top - 135;

            tulpina[15].Width = 200;
            tulpina[15].Height = tulpina[11].Height;
            tulpina[15].Left = cer[26].Right + 150;
            tulpina[15].Top = screen.Height - tulpina[15].Height;
            cer[30].Width = 240;
            cer[30].Height = 30;
            cer[30].Left = tulpina[15].Left - 20;
            cer[30].Top = tulpina[15].Top - cer[30].Height;

            tulpina[16].Width = 500;
            tulpina[16].Height = tulpina[15].Height + 75;
            tulpina[16].Left = cer[30].Right + 150;
            tulpina[16].Top = screen.Height - tulpina[16].Height;
            cer[31].Width = 550;
            cer[31].Height = 35;
            cer[31].Left = tulpina[16].Left - 25;
            cer[31].Top = tulpina[16].Top - cer[31].Height;
            monstru[13].Left = cer[31].Left + 20;
            monstru[14].Left = monstru[13].Left + 100;
            monstru[15].Left = monstru[14].Left + 100;
            monstru[13].Top = cer[31].Top - monstru[13].Height;
            monstru[14].Top = monstru[13].Top;
            monstru[15].Top = monstru[13].Top;
            banutaer[12].Left = cer[31].Left + 198;
            banutaer[12].Top = cer[31].Top - 135;
            banutaer[13].Left = banutaer[12].Right + 10;
            banutaer[14].Left = banutaer[13].Right + 10;
            banutaer[15].Left = banutaer[14].Right + 10;
            banutaer[13].Top = banutaer[12].Top;
            banutaer[14].Top = banutaer[12].Top;
            banutaer[15].Top = banutaer[12].Top;

            tulpina[17].Width = 200;
            tulpina[17].Height = tulpina[15].Height;
            tulpina[17].Left = cer[31].Right + 200;
            tulpina[17].Top = screen.Height - tulpina[17].Height;
            cer[32].Width = 240;
            cer[32].Height = 30;
            cer[32].Left = tulpina[17].Left - 20;
            cer[32].Top = tulpina[17].Top - cer[32].Height;

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
            cer[5].Visible = true;
            cer[23].Visible = true;
            cer[24].Visible = true;
            cer[27].Visible = true;
            cer[28].Visible = true;
            cer[29].Visible = true;
            c1lt = false;
            c1rt = false;
            c1up = true;
            c2up = true;
            c2lt = false;
            c2rt = false;

            Scor = 0;
            Banuti = 0;
            Ciuperci = 0;
            button1.Text = "SCOR: 0";
            button2.Text = "BANUTI: 0";
            button3.Text = "CIUPERCI: 0";

            steag.Left = cer[32].Right - 40;
            steag.Top = cer[32].Top - steag.Height + 10;
        }

        public Form3()
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
                    if (i == 7)
                    {
                        if (bara[1] > 0)
                            --bara[1];
                    }
                    else if (i == 8)
                    {
                        if (bara[2] > 0)
                            --bara[2];
                    }
                    else if (i == 9)
                    {
                        if (bara[3] > 0)
                            --bara[3];
                    }
                    else if (i == 18)
                    {
                        if (bara[4] > 0)
                            --bara[4];
                    }
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
                Form4 f4 = new Form4();
                this.Hide();
                timer1.Enabled = false;
                f4.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            e_steag();

            if (mario.Bottom == screen.Bottom)
                init();

            if (cer[7].Top <= screen.Bottom && bara[1] == 0)
            {
                cer[7].Top += 5;
                if (jump != true && cer[7].Left - mario.Width <= mario.Left && mario.Right <= cer[7].Right + mario.Width)
                    mario.Top += 5;
            }
            if (cer[8].Top <= screen.Bottom && bara[2] == 0)
            {
                cer[8].Top += 5;
                if (jump != true && cer[8].Left - mario.Width <= mario.Left && mario.Right <= cer[8].Right + mario.Width)
                    mario.Top += 5;
            }
            if (cer[9].Top <= screen.Bottom && bara[3] == 0)
            {
                cer[9].Top += 5;
                if (jump != true && cer[9].Left - mario.Width <= mario.Left && mario.Right <= cer[9].Right + mario.Width)
                    mario.Top += 5;
            }
            if (cer[18].Top <= screen.Bottom && bara[4] == 0)
            {
                cer[18].Top += 5;
                if (jump != true && cer[18].Left - mario.Width <= mario.Left && mario.Right <= cer[18].Right + mario.Width)
                    mario.Top += 5;
            }

            if (cer[15].Left + cer[15].Width >= cer[14].Right + (cer[17].Left - cer[14].Right) / 2)
                b1d = false;
            if (cer[15].Left <= cer[14].Right)
                b1d = true;
            if (cer[16].Left <= cer[14].Right + (cer[17].Left - cer[14].Right) / 2)
                b2d = true;
            if (cer[16].Left + cer[16].Width >= cer[17].Left)
                b2d = false;

            if (b1d == true)
                cer[15].Left += 2;
            if (b1d == false)
                cer[15].Left -= 2;
            if (b2d == true)
                cer[16].Left += 2;
            if (b2d == false)
                cer[16].Left -= 2;

            if (right == true)
            {
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left -= deplasare;
                }
                for (int i = 1; i <= nTulpina; ++i)
                {
                    tulpina[i].Left -= deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanutAer; ++i)
                {
                    banutaer[i].Left -= deplasare;
                }
                for (int i = 1; i <= nPatratgol; ++i)
                {
                    patratgol[i].Left -= deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left -= deplasare;
                }
                steag.Left -= deplasare;
            }
            if (left == true)
            {
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left += deplasare;
                }
                for (int i = 1; i <= nTulpina; ++i)
                {
                    tulpina[i].Left += deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanutAer; ++i)
                {
                    banutaer[i].Left += deplasare;
                }
                for (int i = 1; i <= nPatratgol; ++i)
                {
                    patratgol[i].Left += deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left += deplasare;
                }
                steag.Left += deplasare;
            }

            if (jump == true)
            {
                // cade daca jump == true
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

            for (int i = 1; i <= nBlock; ++i)
            {
                if (mario.Left + mario.Width > block[i].Left && mario.Left + mario.Width < block[i].Left + block[i].Width + mario.Width && mario.Top - block[i].Bottom <= 10 && mario.Top - block[i].Top > -10)
                {
                    if (i == 5 && block[i].Visible == true) // ciuperca
                    {
                        block[5].Visible = false;
                        patratgol[1].Visible = true;
                        ciuperca[1].Visible = true;
                    }
                    else if (i == 24 && block[i].Visible == true)
                    {
                        block[24].Visible = false;
                        patratgol[3].Visible = true;
                        ciuperca[2].Visible = true;
                    }
                    else if (i == 23 && block[i].Visible == true)
                    {
                        block[23].Visible = false;
                        patratgol[2].Visible = true;
                        banut[1].Visible = true;
                    }
                    else if (i == 27 && block[i].Visible == true)
                    {
                        block[27].Visible = false;
                        patratgol[4].Visible = true;
                        banut[2].Visible = true;
                    }
                    else if (i == 28 && block[i].Visible == true)
                    {
                        block[28].Visible = false;
                        patratgol[5].Visible = true;
                        banut[3].Visible = true;
                    }
                    else if (i == 29 && block[i].Visible == true)
                    {
                        block[29].Visible = false;
                        patratgol[6].Visible = true;
                        banut[4].Visible = true;
                    }

                    Force = -3;
                }
            }

            // ciuperca si banut
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

                if (c1up == true && ciuperca[1].Bottom <= cer[5].Top)
                {
                    ciuperca[1].Top = cer[5].Top - ciuperca[1].Height;
                    c1up = false;
                    c1rt = true;
                }

                if (ciuperca[1].Left + ciuperca[1].Width >= block[4].Right)
                {
                    c1rt = false;
                    c1lt = true;
                }
                if (ciuperca[1].Left <= block[5].Left)
                {
                    c1rt = true;
                    c1lt = false;
                }

                if (c1up == true)
                {
                    ciuperca[1].Top -= 2;
                }
                else if (c1rt == true)
                {
                    ciuperca[1].Left += 2;
                }
                else if (c1lt == true)
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

                if (c2up == true && ciuperca[2].Bottom <= cer[24].Top)
                {
                    ciuperca[2].Top = cer[24].Top - ciuperca[2].Height;
                    c2up = false;
                    c2rt = true;
                }

                if (ciuperca[2].Left + ciuperca[2].Width >= block[24].Right)
                {
                    c2rt = false;
                    c2lt = true;
                }
                if (ciuperca[2].Left <= block[23].Left)
                {
                    c2rt = true;
                    c2lt = false;
                }

                if (c2up == true)
                {
                    ciuperca[2].Top -= 2;
                }
                else if (c2rt == true)
                {
                    ciuperca[2].Left += 2;
                }
                else if (c2lt == true)
                {
                    ciuperca[2].Left -= 2;
                }
            }
            for (int i = 1; i <= nBanut; ++i)
            {
                if (banut[i].Visible == true)
                {
                    if (i == 1 && banut[i].Top + banut[i].Height < cer[23].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 2 && banut[i].Top + banut[i].Height < cer[27].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 3 && banut[i].Top + banut[i].Height < cer[28].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 4 && banut[i].Top + banut[i].Height < cer[29].Top - 10)
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

            // monstru
            for (int i = 1; i <= nMonstru; ++i)
            {
                if (monstru[i].Visible == true)
                {
                    if (i == 1)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[4].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[4].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 2)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[6].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[6].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 3)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[6].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[6].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 4)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[11].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[11].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 5)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[10].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[10].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 6)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[10].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[10].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 7)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[14].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[14].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 8)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[14].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[14].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 9)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[17].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[17].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 10)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[20].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[20].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 11)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[19].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[19].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 12)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[22].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[22].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 13)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[31].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[31].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 14)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[31].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[31].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 15)
                    {
                        if (monstru[i].Left + monstru[i].Width >= cer[31].Right)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= cer[31].Left)
                        {
                            md[i] = true;
                        }
                    }

                    if (ciuperca[1].Visible == true && monstru[1].Visible == true && ciuperca[1].Left + ciuperca[1].Width >= monstru[1].Left)
                    {
                        c1rt = false;
                        c1lt = true;
                        md[1] = true;
                    }
                    if (monstru[2].Visible == true && monstru[3].Visible == true && monstru[2].Left + monstru[2].Width >= monstru[3].Left)
                    {
                        md[2] = false;
                        md[3] = true;
                    }
                    if (monstru[5].Visible == true && monstru[6].Visible == true && monstru[5].Left + monstru[5].Width >= monstru[6].Left)
                    {
                        md[5] = false;
                        md[6] = true;
                    }
                    if (monstru[7].Visible == true && monstru[8].Visible == true && monstru[7].Left + monstru[7].Width >= monstru[8].Left)
                    {
                        md[7] = false;
                        md[8] = true;
                    }
                    if (monstru[14].Visible == true && monstru[15].Visible == true && monstru[14].Left + monstru[14].Width >= monstru[15].Left)
                    {
                        md[14] = false;
                        md[15] = true;
                    }
                    if (monstru[13].Visible == true && monstru[14].Visible == true && monstru[13].Left + monstru[13].Width >= monstru[14].Left)
                    {
                        md[13] = false;
                        md[14] = true;
                    }
                    if (monstru[13].Visible == true && monstru[15].Visible == true && monstru[13].Left + monstru[13].Width >= monstru[15].Left)
                    {
                        md[13] = false;
                        md[15] = true;
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
                    //if (monstru[i].Visible == true && (monstru[i].Left + monstru[i].Width >= mario.Left && monstru[i].Left <= mario.Left + mario.Width) && mario.Bottom <= monstru[i].Bottom && mario.Bottom >= monstru[i].Top)
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
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
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

        private void Form3_KeyUp(object sender, KeyEventArgs e)
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
