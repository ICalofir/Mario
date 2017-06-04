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
    public partial class Form1 : Form
    {
        int Ciuperci, Scor, Banuti;
        bool c1lt, c1rt, c1up = true, c2up = true, f1down, f1up = true, f2down, f2up = true;
        bool[] md = new bool[50];
        bool[] jumpb = new bool[50];
        int[] forceb = new int[50];

        int deplasare = 10;
        string nowC = "right";
        bool left, right;
        bool jump;
        int G = 30, Force;
        int nCer, nPamant, nBlock, nCiuperca, nBanut, nGol, nMonstru, nBanutAer;
        PictureBox[] block = new PictureBox[50];
        PictureBox[] cer = new PictureBox[50];
        PictureBox[] pamant = new PictureBox[50];
        PictureBox[] ciuperca = new PictureBox[50];
        PictureBox[] banut = new PictureBox[50];
        PictureBox[] gol = new PictureBox[50];
        PictureBox[] monstru = new PictureBox[50];
        PictureBox[] banutaer = new PictureBox[50];

        void init()
        {
            timer1.Enabled = true;
            button1.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button2.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button3.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);

            monstru[1] = monstru1;
            monstru[2] = monstru2;
            monstru[3] = monstru3;
            monstru[4] = monstru4;
            monstru[5] = monstru5;
            monstru[6] = monstru6;
            monstru[7] = monstru7;
            monstru[8] = monstru8;
            monstru[9] = monstru9;
            nMonstru = 9;
            for (int i = 1; i <= nMonstru; ++i)
            {
                md[i] = true;
            }

            banut[1] = banut1;
            banut[2] = banut2;
            banut[3] = banut9;
            banut[4] = banut10;
            banut[5] = banut23;
            banut[6] = banut24;
            banut[7] = banut25;
            banut[8] = banut26;
            banut[9] = banut27;
            banut[10] = banut28;
            banut[11] = banut29;
            nBanut = 11;

            banutaer[1] = banut3;
            banutaer[2] = banut4;
            banutaer[3] = banut5;
            banutaer[4] = banut6;
            banutaer[5] = banut7;
            banutaer[6] = banut8;
            banutaer[7] = banut11;
            banutaer[8] = banut12;
            banutaer[9] = banut13;
            banutaer[10] = banut14;
            banutaer[11] = banut15;
            banutaer[12] = banut16;
            banutaer[13] = banut17;
            banutaer[14] = banut18;
            banutaer[15] = banut19;
            banutaer[16] = banut20;
            banutaer[17] = banut21;
            banutaer[18] = banut22;
            nBanutAer = 18;

            ciuperca[1] = ciuperca1;
            ciuperca[2] = ciuperca2;
            nCiuperca = 2;

            gol[1] = gol1;
            gol[2] = gol2;
            gol[3] = gol3;
            gol[4] = gol4;
            gol[5] = gol5;
            gol[6] = gol6;
            gol[7] = gol7;
            nGol = 7;

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
            cer[33] = cer33;
            nCer = 33;

            pamant[1] = pamant1;
            pamant[2] = pamant2;
            pamant[3] = tub1;
            pamant[4] = tub2;
            pamant[5] = tub3;
            pamant[6] = pamant3;
            pamant[7] = pamant4;
            pamant[8] = tub4;
            pamant[9] = tub5;
            pamant[10] = tub6;
            pamant[11] = tub7;
            pamant[12] = tub8;
            nPamant = 12;

            block[1] = cer1;
            block[2] = cer2;
            block[3] = cer3;
            block[4] = cer4;
            block[5] = cer5;
            block[6] = cer6;
            block[7] = cer7;
            block[8] = cer8;
            block[9] = pamant1;
            block[10] = pamant2;
            block[11] = tub1;
            block[12] = tub2;
            block[13] = tub3;
            block[14] = cer9;
            block[15] = cer10;
            block[16] = cer11;
            block[17] = cer12;
            block[18] = cer13;
            block[19] = cer14;
            block[20] = cer15;
            block[21] = cer16;
            block[22] = cer17;
            block[23] = cer18;
            block[24] = cer19;
            block[25] = tub4;
            block[26] = pamant3;
            block[27] = pamant4;
            block[28] = cer20;
            block[29] = cer21;
            block[30] = cer22;
            block[31] = tub5;
            block[32] = tub6;
            block[33] = cer23;
            block[34] = cer24;
            block[35] = cer25;
            block[36] = cer26;
            block[37] = tub7;
            block[38] = tub8;
            block[39] = cer[27];
            block[40] = cer[28];
            block[41] = cer[29];
            block[42] = cer[30];
            block[43] = cer[31];
            block[44] = cer[32];
            block[45] = cer[33];
            nBlock = 45;

            //initializare
            tub1.Top = screen.Height - tub1.Height;
            tub2.Top = screen.Height - tub2.Height;
            tub3.Top = screen.Height - tub3.Height;
            for (int i = 1; i <= 3; ++i)
            {
                monstru[i].Top = screen.Height - monstru[i].Height;
            }

            mario.Top = screen.Height - mario.Height;
            mario.Left = 342;

            cer[1].Left = 632;
            for (int i = 2; i <= 5; ++i)
            {
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            cer[6].Left = cer[2].Left;
            cer[6].Top = cer[2].Top - 140;
            for (int i = 7; i <= 8; ++i)
            {
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
                cer[i].Top = cer[i - 1].Top;
            }
            ciuperca[1].Top = cer[4].Top - 7;
            ciuperca[1].Left = cer[4].Left + 4;
            banut[1].Left = cer[2].Left + 12;
            banut[1].Top = cer[2].Top + 13;
            banut[2].Left = cer[7].Left + 12;
            banut[2].Top = cer[7].Top + 13;
            patratgol1.Left = cer[4].Left;
            patratgol1.Top = cer[4].Top;
            patratgol2.Left = cer[2].Left;
            patratgol2.Top = cer[2].Top;
            patratgol3.Left = cer[7].Left;
            patratgol3.Top = cer[7].Top;
            pamant[1].Left = cer[5].Left + 300;
            gol[1].Left = pamant[1].Left + pamant[1].Width;

            pamant[2].Left = pamant[1].Left + pamant[1].Width + gol[1].Width;
            tub1.Left = pamant[2].Left + 200;
            monstru[1].Left = tub1.Left + tub1.Width + 10;
            tub2.Left = tub1.Left + 250;
            monstru[2].Left = tub2.Left + tub2.Width + 10;
            monstru[3].Left = monstru[2].Left + monstru[2].Width + 40;
            tub3.Left = tub2.Left + 320;
            gol[2].Left = tub3.Left + 200;
            banutaer[1].Top = tub1.Top - 150;
            banutaer[1].Left = tub1.Left + 14;
            banutaer[2].Top = tub1.Top - 150;
            banutaer[2].Left = banutaer[1].Left + banutaer[1].Width + 14;
            banutaer[3].Top = tub2.Top - 150;
            banutaer[3].Left = tub2.Left + 14;
            banutaer[4].Top = tub2.Top - 150;
            banutaer[4].Left = banutaer[3].Left + banutaer[3].Width + 14;
            banutaer[5].Top = tub3.Top - 150;
            banutaer[5].Left = tub3.Left + 14;
            banutaer[6].Top = tub3.Top - 150;
            banutaer[6].Left = banutaer[5].Left + banutaer[5].Width + 14;

            cer[9].Left = gol[2].Left + gol[2].Width + 300;
            for (int i = 10; i <= 16; ++i)
            {
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            for (int i = 9; i <= 16; ++i)
            {
                cer[i].Top = cer[1].Top;
            }
            cer[17].Left = cer[13].Left;
            for (int i = 18; i <= 19; ++i)
            {
                cer[i].Left = cer[i - 1].Left + cer[i - 1].Width;
            }
            for (int i = 17; i <= 19; ++i)
            {
                cer[i].Top = cer[7].Top;
            }
            banutaer[7].Top = cer[17].Top + 7;
            banutaer[7].Left = cer[16].Left + 14;
            banutaer[8].Top = cer[17].Top + 7;
            banutaer[8].Left = cer[12].Left + 14;
            banutaer[9].Top = cer[17].Top + 7;
            banutaer[9].Left = cer[11].Left + 14;
            banutaer[10].Top = cer[17].Top + 7;
            banutaer[10].Left = cer[10].Left + 14;
            banutaer[11].Top = cer[17].Top + 7;
            banutaer[11].Left = cer[9].Left + 14;
            banut[3].Left = cer[11].Left + 12;
            banut[3].Top = cer[11].Top + 13;
            banut[4].Left = cer[14].Left + 12;
            banut[4].Top = cer[14].Top + 13;
            patratgol4.Left = cer[11].Left;
            patratgol4.Top = cer[11].Top;
            patratgol5.Left = cer[14].Left;
            patratgol5.Top = cer[14].Top;
            monstru[6].Left = cer[17].Left + 10;
            monstru[5].Left = cer[9].Left + 10;
            monstru[4].Left = monstru[5].Left + monstru[5].Width + 40;
            monstru[6].Top = cer[17].Top - monstru[6].Height;
            monstru[5].Top = cer[9].Top - monstru[5].Height;
            monstru[4].Top = monstru[5].Top;

            gol[3].Left = cer[16].Left + 300;
            block[25].Left = gol[3].Left + gol[3].Width + 350;
            block[25].Top = screen.Height - block[25].Height;
            monstru[7].Left = gol[3].Left + gol[3].Width + 20;
            monstru[7].Top = screen.Height - monstru[7].Height;
            banutaer[12].Left = block[25].Left;
            banutaer[12].Top = block[25].Top - 150;
            banutaer[13].Left = banutaer[12].Left - 50;
            banutaer[13].Top = block[25].Top - 150;
            banutaer[14].Left = banutaer[13].Left - 50;
            banutaer[14].Top = block[25].Top - 150;

            gol[4].Left = block[25].Left + 300;
            block[26].Left = gol[4].Left + gol[4].Width;
            banutaer[15].Left = block[26].Left + 12;
            banutaer[16].Left = block[26].Left + 12;
            banutaer[15].Top = block[26].Top - 100;
            banutaer[16].Top = banutaer[15].Top - 50;
            block[28].Top = 347;
            block[29].Top = 347;
            block[30].Top = 347;
            block[28].Left = block[26].Left + block[26].Width + 257;
            block[29].Left = block[28].Left + block[28].Width;
            block[30].Left = block[29].Left + block[29].Width;
            banut[5].Left = cer[20].Left + 12;
            banut[5].Top = cer[20].Top + 13;
            banut[6].Left = cer[21].Left + 12;
            banut[6].Top = cer[21].Top + 13;
            banut[7].Left = cer[22].Left + 12;
            banut[7].Top = cer[22].Top + 13;
            patratgol6.Left = cer[20].Left;
            patratgol6.Top = cer[20].Top;
            patratgol7.Left = cer[21].Left;
            patratgol7.Top = cer[21].Top;
            patratgol8.Left = cer[22].Left;
            patratgol8.Top = cer[22].Top;
            monstru[8].Top = screen.Height - monstru[8].Height;
            monstru[8].Left = block[26].Left + block[26].Width + 20;
            block[27].Left = cer[22].Left + 300;
            banutaer[17].Left = block[27].Left + 12;
            banutaer[18].Left = block[27].Left + 12;
            banutaer[17].Top = block[27].Top - 100;
            banutaer[18].Top = banutaer[17].Top - 50;

            gol[5].Left = block[27].Left + block[27].Width;
            gol[6].Left = gol[5].Left + gol[5].Width + 200;

            block[31].Top = screen.Height - block[31].Height;
            block[32].Top = screen.Height - block[32].Height;
            block[31].Left = gol[6].Left + gol[6].Width + 300;
            block[32].Left = block[31].Left + 150;
            block[35].Left = block[32].Left + 270;
            block[35].Top = 347;
            block[36].Left = block[35].Left + block[35].Width;
            block[36].Top = 347;
            block[33].Left = block[35].Left - block[33].Width;
            block[34].Left = block[36].Left + block[36].Width;
            block[33].Top = block[35].Top - 140;
            block[34].Top = block[35].Top - 140;
            patratgol9.Left = block[33].Left;
            patratgol9.Top = block[33].Top;
            patratgol10.Left = block[34].Left;
            patratgol10.Top = block[34].Top;
            banut[8].Left = block[33].Left + 12;
            banut[8].Top = block[33].Top + 13;
            ciuperca[2].Left = block[34].Left + 4;
            ciuperca[2].Top = block[34].Top - 7;
            block[37].Left = block[34].Left + 400;
            floare1.Left = block[37].Left + 22;
            block[37].Top = screen.Height - block[37].Height;
            floare1.Top = screen.Height - floare1.Top;

            gol[7].Left = block[37].Left + 300;
            block[39].Top = 347;
            block[40].Top = 347;
            block[41].Top = 347;
            block[42].Top = 347;
            block[43].Top = 347;
            block[44].Top = 347;
            block[45].Top = 347;
            block[39].Left = gol[7].Left + gol[7].Width + 350;
            block[40].Left = block[39].Left + block[39].Width;
            block[41].Left = block[40].Left + block[40].Width;
            block[42].Left = block[41].Left + block[41].Width;
            block[43].Left = block[42].Left + block[42].Width;
            block[44].Left = block[43].Left + block[43].Width;
            block[45].Left = block[44].Left + block[44].Width;
            banut[9].Left = block[42].Left + 12;
            banut[9].Top = block[42].Top + 13;
            banut[10].Left = block[43].Left + 12;
            banut[10].Top = block[43].Top + 13;
            banut[11].Left = block[44].Left + 12;
            banut[11].Top = block[44].Top + 13;
            patratgol11.Left = block[42].Left;
            patratgol12.Left = block[43].Left;
            patratgol13.Left = block[44].Left;
            patratgol11.Top = block[42].Top;
            patratgol12.Top = block[43].Top;
            patratgol13.Top = block[44].Top;
            block[38].Left = block[45].Left + 200;
            block[38].Top = screen.Height - block[38].Height;
            floare2.Left = block[38].Left + 22;
            floare2.Tag = screen.Height - floare2.Height;
            monstru[9].Top = screen.Height - monstru[9].Height;
            monstru[9].Left = gol[7].Left + gol[7].Width + 20;

            //initial
            for (int i = 1; i <= nMonstru; ++i)
                monstru[i].Visible = true;
            for (int i = 1; i <= nBanut; ++i)
                banut[i].Visible = false;
            for (int i = 1; i <= nCiuperca; ++i)
                ciuperca[i].Visible = false;
            for (int i = 1; i <= nBanutAer; ++i)
                banutaer[i].Visible = true;
            cer[2].Visible = true;
            cer[4].Visible = true;
            cer[30].Visible = true;
            cer[31].Visible = true;
            cer[32].Visible = true;
            cer[11].Visible = true;
            cer[14].Visible = true;
            cer[7].Visible = true;
            cer[20].Visible = true;
            cer[21].Visible = true;
            cer[22].Visible = true;
            cer[23].Visible = true;
            cer[24].Visible = true;
            patratgol1.Visible = false;
            patratgol2.Visible = false;
            patratgol3.Visible = false;
            patratgol4.Visible = false;
            patratgol5.Visible = false;
            patratgol6.Visible = false;
            patratgol7.Visible = false;
            patratgol8.Visible = false;
            patratgol9.Visible = false;
            patratgol10.Visible = false;
            patratgol11.Visible = false;
            patratgol12.Visible = false;
            patratgol13.Visible = false;
            c1lt = false;
            c1rt = false;
            c1up = true;
            c2up = true;
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

            steag.Left = pamant[12].Left + 450;
            steag.Top = screen.Bottom - steag.Height + 10;
        }

        public Form1()
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
                Form2 f2 = new Form2();
                this.Hide();
                timer1.Enabled = false;
                f2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            e_steag();

            for (int i = 1; i <= nCer; ++i)
            {
                if (jumpb[i] == true)
                {
                    cer[i].Top -= forceb[i];
                    forceb[i] -= 1;
                }
                if (i == 6 || i == 7 || i == 8 || i == 17 || i == 18 || i == 19)
                {
                    if (cer[i].Top >= 207)
                    {
                        cer[i].Top = 207;
                        jumpb[i] = false;
                    }
                }
                else if (cer[i].Top >= 347)
                {
                    cer[i].Top = 347;
                    jumpb[i] = false;
                }
            }

            // oprire pe parti: stanga - dreapta
            // daca nu sunt pe block, atunci verific stanga dreapta, altfel nu
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
                //mario.Left += 5;
                //block1.Left -= 5;
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left -= deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left -= deplasare;
                }
                for (int i = 1; i <= nGol; ++i)
                {
                    gol[i].Left -= deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanutAer; ++i)
                {
                    banutaer[i].Left -= deplasare;
                }
                patratgol1.Left -= deplasare;
                patratgol2.Left -= deplasare;
                patratgol3.Left -= deplasare;
                patratgol4.Left -= deplasare;
                patratgol5.Left -= deplasare;
                patratgol6.Left -= deplasare;
                patratgol7.Left -= deplasare;
                patratgol8.Left -= deplasare;
                patratgol9.Left -= deplasare;
                patratgol10.Left -= deplasare;
                patratgol11.Left -= deplasare;
                patratgol12.Left -= deplasare;
                patratgol13.Left -= deplasare;
                floare1.Left -= deplasare;
                floare2.Left -= deplasare;
                steag.Left -= deplasare;
            }
            if (left == true)
            {
                //mario.Left -= 5;
                //block1.Left += 5;
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left += deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left += deplasare;
                }
                for (int i = 1; i <= nGol; ++i)
                {
                    gol[i].Left += deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanutAer; ++i)
                {
                    banutaer[i].Left += deplasare;
                }
                patratgol1.Left += deplasare;
                patratgol2.Left += deplasare;
                patratgol3.Left += deplasare;
                patratgol4.Left += deplasare;
                patratgol5.Left += deplasare;
                patratgol6.Left += deplasare;
                patratgol7.Left += deplasare;
                patratgol8.Left += deplasare;
                patratgol9.Left += deplasare;
                patratgol10.Left += deplasare;
                patratgol11.Left += deplasare;
                patratgol12.Left += deplasare;
                patratgol13.Left += deplasare;
                floare1.Left += deplasare;
                floare2.Left += deplasare;
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
                //mario.Top = screen.Height - block1.Height - mario.Height;
                //mario.Top = block1.Location.Y - mario.Height;
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

            //oprire in sus
            for (int i = 1; i <= nBlock; ++i)
            {
                if (mario.Left + mario.Width > block[i].Left && mario.Left + mario.Width < block[i].Left + block[i].Width + mario.Width && mario.Top - block[i].Bottom <= 10 && mario.Top - block[i].Top > -10)
                {
                    if (block[i].Visible == true)
                    {
                        if (i <= 8 || (i >= 14 && i <= 24) || i == 39 || i == 40 || i == 41 || i == 45)
                        {
                            int nowi = i;
                            if (i >= 14 && i <= 24)
                                nowi = i - 5;
                            else if (i == 39)
                                nowi = 27;
                            else if (i == 40)
                                nowi = 28;
                            else if (i == 41)
                                nowi = 29;
                            else if (i == 45)
                                nowi = 33;
                            jumpb[nowi] = true;
                            block[i].Top -= 10;
                            forceb[nowi] = 2;
                        }
                    }
                    
                    if (i == 4 && block[i].Visible == true) // ciuperca1
                    {
                        block[4].Visible = false;
                        patratgol1.Visible = true;
                        ciuperca1.Visible = true;
                    }
                    if (i == 34 && block[i].Visible == true)
                    {
                        block[34].Visible = false;
                        patratgol10.Visible = true;
                        ciuperca[2].Visible = true;
                    }
                    if (i == 2 || i == 7 || i == 16 || i == 19 || i == 28 || i == 29 || i == 30 || i == 33 || i == 42 || i == 43 || i == 44) // banuti
                    {
                        if (block[i].Visible == true)
                        {
                            //block[i].Visible = false;
                            if (i == 2)
                            {
                                block[2].Visible = false;
                                patratgol2.Visible = true;
                                banut[1].Visible = true;
                            }
                            else if (i == 7)
                            {
                                block[7].Visible = false;
                                patratgol3.Visible = true;
                                banut[2].Visible = true;
                            }
                            else if (i == 16)
                            {
                                block[16].Visible = false;
                                patratgol4.Visible = true;
                                banut[3].Visible = true;
                            }
                            else if (i == 19)
                            {
                                block[19].Visible = false;
                                patratgol5.Visible = true;
                                banut[4].Visible = true;
                            }
                            else if (i == 28)
                            {
                                block[28].Visible = false;
                                patratgol6.Visible = true;
                                banut[5].Visible = true;
                            }
                            else if (i == 29)
                            {
                                block[29].Visible = false;
                                patratgol7.Visible = true;
                                banut[6].Visible = true;
                            }
                            else if (i == 30)
                            {
                                block[30].Visible = false;
                                patratgol8.Visible = true;
                                banut[7].Visible = true;
                            }
                            else if (i == 33)
                            {
                                block[33].Visible = false;
                                patratgol9.Visible = true;
                                banut[8].Visible = true;
                            }
                            else if (i == 42)
                            {
                                block[42].Visible = false;
                                patratgol11.Visible = true;
                                banut[9].Visible = true;
                            }
                            else if (i == 43)
                            {
                                block[43].Visible = false;
                                patratgol12.Visible = true;
                                banut[10].Visible = true;
                            }
                            else if (i == 44)
                            {
                                block[44].Visible = false;
                                patratgol13.Visible = true;
                                banut[11].Visible = true;
                            }
                        }
                    }
                    else if (i != 2 && i != 4 && i != 7 && i != 16 && i != 19 && i != 28 && i != 29 && i != 30 && i != 33 && i != 34 && i != 42 && i != 43 && i != 44)
                    {
                        for (int j = 4; j <= 6; ++j)
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
                            if (j == 1 && ciuperca[j].Bottom != 347)
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
                    Force = -3;
                }
            }



            // gol
            for (int i = 1; i <= nGol; ++i)
                if (mario.Left >= gol[i].Left && mario.Right <= gol[i].Right && mario.Bottom == gol[i].Top)
                //if (mario.Left + mario.Width > gol[i].Left && mario.Left + mario.Width < gol[i].Left + gol[i].Width + mario.Width && mario.Top + mario.Height >= gol[i].Top && mario.Top < gol[i].Top)
                {
                    //Application.Restart();
                    init();
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

                if (c1up == true && ciuperca[1].Top + ciuperca[1].Height <= cer[4].Top)
                {
                    ciuperca[1].Top = block[4].Top - ciuperca[1].Height;
                    c1up = false;
                    c1rt = true;
                }

                if (ciuperca[1].Left + ciuperca[1].Width >= block[5].Left + block[5].Width)
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
                if (c2up == true && ciuperca[2].Top + ciuperca[2].Height <= block[34].Top)
                {
                    ciuperca[2].Top = block[34].Top - ciuperca[2].Height;
                    c2up = false;
                }
                if (c2up == true)
                {
                    ciuperca2.Top -= 2;
                }
            }
            for (int i = 1; i <= nBanut; ++i)
            {
                if (banut[i].Visible == true)
                {
                    if (i == 1 && banut[i].Top + banut[i].Height < cer[2].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 2 && banut[i].Top + banut[i].Height < cer[7].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 3 && banut[i].Top + banut[i].Height < cer[11].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 4 && banut[i].Top + banut[i].Height < cer[14].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if ((i == 5 || i == 6 || i == 7) && banut[i].Top + banut[i].Height < cer[20].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 8 && banut[i].Top + banut[i].Height < cer[23].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 9 && banut[i].Top + banut[i].Height < cer[30].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 10 && banut[i].Top + banut[i].Height < cer[31].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 11 && banut[i].Top + banut[i].Height < cer[32].Top - 10)
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
                        if (monstru[i].Left + monstru[i].Width >= block[12].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[11].Left + block[11].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 2)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[13].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[12].Left + block[12].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 3)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[13].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[12].Left + block[12].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else  if (i == 4)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[21].Left + block[21].Width)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[14].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 5)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[21].Left + block[21].Width)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[14].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 6)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[24].Left + block[24].Width)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[22].Left)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 7)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[25].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[3].Left + gol[3].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 8)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[27].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= block[26].Left + block[26].Width)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 9)
                    {
                        if (monstru[i].Left + monstru[i].Width >= block[38].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[7].Left + gol[7].Width)
                        {
                            md[i] = true;
                        }
                    }

                    if (monstru[2].Visible == true && monstru[3].Visible == true && monstru[2].Left + monstru[2].Width >= monstru[3].Left)
                    {
                        md[2] = false;
                        md[3] = true;
                    }
                    if (monstru[4].Visible == true && monstru[5].Visible == true && monstru[4].Left + monstru[4].Width >= monstru[5].Left)
                    {
                        md[4] = false;
                        md[5] = true;
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

            // flori

            if ((floare1.Left + floare1.Width >= mario.Left && floare1.Left <= mario.Left + mario.Width) && mario.Bottom <= floare1.Bottom && mario.Bottom >= floare1.Top)
            {
                if (Ciuperci >= 1)
                {
                    --Ciuperci;
                    button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    floare1.Top = block[37].Top + 4;
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
                    floare1.Top = block[37].Top + 4;
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
            if (floare1.Bottom <= block[37].Top)
            {
                f1up = false;
                f1down = true;
            }
            if (floare1.Bottom >= block[37].Bottom)
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
                    floare2.Top = block[38].Top + 4;
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
                    floare2.Top = block[38].Top + 4;
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
            if (floare2.Bottom <= block[38].Top)
            {
                f2up = false;
                f2down = true;
            }
            if (floare2.Bottom >= block[38].Bottom)
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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
