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
    public partial class Form4 : Form
    {
        bool ok, sfarsit = false;
        bool[] bup = new bool[7];
        bool[] bdown = new bool[7];
        bool[] blt = new bool[7];
        bool[] brt = new bool[7];
        bool c1lt, c1rt, c1up = true, c2up = true;
        int Scor, Banuti, Ciuperci;
        int[] forceb = new int[50];
        bool[] md = new bool[50];
        bool[] jumpb = new bool[50];
        int[] bara = new int[7];

        int deplasare = 10;
        string nowC = "right";
        bool left, right;
        bool jump;
        int G = 30, Force;

        int nBlock, nPamant, nCer, nMonstru, nBanut, nCiuperca, nPatratgol, nGol, nBila;
        PictureBox[] block = new PictureBox[50];
        PictureBox[] pamant = new PictureBox[50];
        PictureBox[] cer = new PictureBox[50];
        PictureBox[] monstru = new PictureBox[50];
        PictureBox[] banut = new PictureBox[50];
        PictureBox[] ciuperca = new PictureBox[50];
        PictureBox[] patratgol = new PictureBox[50];
        PictureBox[] gol = new PictureBox[50];
        PictureBox[] bila = new PictureBox[50];

        void init()
        {
            timer1.Enabled = true;
            ok = false;
            button1.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button2.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);
            button3.Font = new Font("Comic Sans MS", 8, FontStyle.Bold);

            for (int i = 1; i <= 3; ++i )
            {
                bara[i] = 3;
            }

            mario.Top = screen.Height - mario.Height;
            mario.Left = 342;

            monstru[1] = monstru1;
            monstru[2] = monstru2;
            monstru[3] = monstru3;
            monstru[4] = monstru4;
            monstru[5] = monstru5;
            monstru[6] = monstru6;
            monstru[7] = monstru7;
            nMonstru = 7;
            for (int i = 1; i <= nMonstru; ++i)
                md[i] = true;

            bila[1] = bila1;
            bila[2] = bila2;
            bila[3] = bila3;
            bila[4] = bila4;
            bila[5] = bila5;
            nBila = 5;

            banut[1] = banut1;
            banut[2] = banut2;
            banut[3] = banut3;
            nBanut = 3;

            ciuperca[1] = ciuperca1;
            ciuperca[2] = ciuperca2;
            nCiuperca = 2;

            patratgol[1] = patratgol1;
            patratgol[2] = patratgol2;
            patratgol[3] = patratgol3;
            patratgol[4] = patratgol4;
            patratgol[5] = patratgol5;
            nPatratgol = 5;

            pamant[1] = pamant1;
            pamant[2] = pamant2;
            pamant[3] = pamant3;
            nPamant = 3;

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
            nCer = 12;

            block[1] = pamant1;
            block[2] = cer1;
            block[3] = cer2;
            block[4] = cer3;
            block[5] = cer4;
            block[6] = cer5;
            block[7] = cer6;
            block[8] = cer7;
            block[9] = cer8;
            block[10] = cer9;
            block[11] = cer10;
            block[12] = cer11;
            block[13] = pamant2;
            block[14] = pamant3;
            block[15] = cer12;
            nBlock = 15;

            gol[1] = gol1;
            gol[2] = gol2;
            gol[3] = gol3;
            gol[4] = gol4;
            gol[5] = gol5;
            gol[6] = gol6;
            gol[7] = gol7;
            nGol = 7;

            gol[1].Left = mario.Left + 300;
            pamant[1].Left = gol[1].Right + 350;
            pamant[1].Top = screen.Height - pamant[1].Height;
            gol[2].Left = pamant[1].Right;
            gol[3].Left = gol[2].Right + 400;
            cer[1].Left = gol[2].Right + 80;
            cer[1].Top = screen.Bottom - 138;
            cer[2].Left = cer[1].Left + cer[1].Width;
            cer[3].Left = cer[2].Left + cer[2].Width;
            cer[4].Left = cer[3].Left + cer[3].Width;
            cer[5].Left = cer[4].Left + cer[4].Width;
            cer[2].Top = cer[1].Top;
            cer[3].Top = cer[1].Top;
            cer[4].Top = cer[1].Top;
            cer[5].Top = cer[1].Top;
            patratgol[1].Left = cer[3].Left;
            patratgol[1].Top = cer[3].Top;
            patratgol[2].Left = cer[4].Left;
            patratgol[2].Top = cer[4].Top;
            banut[1].Left = cer[4].Left + 12;
            banut[1].Top = cer[4].Top + 13;
            ciuperca[1].Left = cer[3].Left + 4;
            ciuperca[1].Top = cer[3].Top - 7;

            cer[6].Left = gol[3].Left + 60;
            cer[6].Top = screen.Bottom - 100;
            gol[4].Left = gol[3].Right + 250;
            cer[7].Left = gol[4].Left + 60;
            cer[7].Top = screen.Bottom - 100;

            bdown[1] = true;
            bup[1] = false;
            blt[1] = false;
            brt[1] = false;
            bila[1].Left = gol[4].Right + 200;
            bila[1].Top = 277;
            blt[2] = true;
            bdown[2] = false;
            bup[2] = false;
            brt[2] = false;
            bila[2].Left = gol[4].Right + 450 + 250;
            bila[2].Top = 277;
            gol[5].Left = gol[4].Right + 700 + 300;
            monstru[1].Left = gol[4].Right + 20;
            monstru[2].Left = monstru[1].Left + 100;
            monstru[1].Top = screen.Height - monstru[1].Height;
            monstru[2].Top = monstru[1].Top;

            gol[6].Left = gol[5].Right + 450;
            cer[8].Left = gol[5].Right + 110;
            cer[9].Left = cer[8].Left + cer[8].Width;
            cer[8].Top = screen.Bottom - 138;
            cer[9].Top = cer[8].Top;
            banut[2].Left = cer[8].Left + 12;
            banut[2].Top = cer[8].Top + 13;
            banut[3].Left = cer[9].Left + 12;
            banut[3].Top = cer[9].Top + 13;
            monstru[3].Left = gol[5].Right + 20;
            monstru[4].Left = monstru[3].Left + 100;
            monstru[3].Top = screen.Height - monstru[3].Height;
            monstru[4].Top = monstru[3].Top;
            patratgol[3].Left = cer[8].Left;
            patratgol[3].Top = cer[8].Top;
            patratgol[4].Left = cer[9].Left;
            patratgol[4].Top = cer[9].Top;

            bdown[3] = true;
            bup[3] = false;
            blt[3] = false;
            brt[3] = false;
            bila[3].Left = gol[6].Right + 200;
            bila[3].Top = 277;
            blt[4] = true;
            bdown[4] = false;
            bup[4] = false;
            brt[4] = false;
            bila[4].Left = gol[6].Right + 450 + 250;
            bila[4].Top = 277;
            bup[5] = true;
            bdown[5] = false;
            blt[5] = false;
            brt[5] = false;
            bila[5].Left = gol[6].Right + 450 + 250 + 250;
            bila[5].Top = screen.Bottom - bila[5].Height;
            gol[7].Left = gol[6].Right + 1401;
            cer[10].Left = gol[7].Left - 200;
            cer[10].Top = screen.Bottom - 138;
            ciuperca[2].Left = cer[10].Left + 4;
            ciuperca[2].Top = cer[10].Top - 7;
            patratgol[5].Left = cer[10].Left;
            patratgol[5].Top = cer[10].Top;
            monstru[5].Left = gol[6].Right + 20;
            monstru[6].Left = monstru[5].Left + 100;
            monstru[7].Left = monstru[6].Left + 100;
            monstru[5].Top = screen.Height - monstru[5].Height;
            monstru[6].Top = monstru[5].Top;
            monstru[7].Top = monstru[5].Top;
            cer[11].Left = gol[7].Left + 60;
            cer[11].Top = screen.Bottom - 100;

            pamant[2].Left = gol[7].Right + 500;
            pamant[2].Top = screen.Bottom - pamant[2].Height;
            cer[12].Left = pamant[2].Left + pamant[2].Width;
            cer[12].Top = pamant[2].Top;
            pamant[3].Left = cer[12].Left + cer[12].Width;
            pamant[3].Top = screen.Bottom - pamant[3].Height;
            printesa.Left = pamant[3].Right - printesa.Width - 50;
            printesa.Top = pamant[3].Top - printesa.Height;

            for (int i = 1; i <= nMonstru; ++i)
            {
                monstru[i].Visible = true;
                md[i] = true;
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
            cer[8].Visible = true;
            cer[9].Visible = true;
            cer[10].Visible = true;
            cer[3].Visible = true;
            cer[4].Visible = true;

            c1lt = false;
            c1rt = false;
            c1up = true;
            c2up = true;

            Scor = 0;
            Banuti = 0;
            Ciuperci = 0;
            button1.Text = "SCOR: 0";
            button2.Text = "BANUTI: 0";
            button3.Text = "CIUPERCI: 0";
        }

        public Form4()
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
                    else if (i == 12)
                    {
                        if (bara[3] > 0)
                            --bara[3];
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

        void bilee()
        {
            for (int i = 1; i <= nBila; ++i)
            {
                if (!(mario.Left + mario.Width > bila[i].Left && mario.Left + mario.Width < bila[i].Left + bila[i].Width + mario.Width && mario.Top + mario.Height >= bila[i].Top && mario.Top < bila[i].Top))
                {
                    // pentru sus - cer
                    if (mario.Right >= bila[i].Left && mario.Left <= bila[i].Right - mario.Width && mario.Bottom < bila[i].Bottom && mario.Bottom > bila[i].Top)
                    {
                        if (Ciuperci >= 1)
                        {
                            --Ciuperci;
                            button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                        }
                        else
                            init();

                        bila[i].Top = 101;
                        if (i == 1)
                            bila[i].Left = gol[4].Right + 200;
                        if (i == 2)
                            bila[i].Left = gol[4].Right + 450;
                        if (i == 3)
                            bila[i].Left = gol[6].Right + 200;
                        if (i == 4)
                            bila[i].Left = gol[6].Right + 450;
                        if (i == 5)
                            bila[i].Left = gol[6].Right + 700;
                        bup[i] = false;
                        bdown[i] = true;
                        blt[i] = false;
                        brt[i] = false;
                        continue;
                    }
                    if (mario.Left <= bila[i].Right && mario.Right >= bila[i].Left + mario.Width && mario.Bottom < bila[i].Bottom && mario.Bottom > bila[i].Top)
                    {
                        if (Ciuperci >= 1)
                        {
                            --Ciuperci;
                            button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                        }
                        else
                            init();

                        bila[i].Top = 101;
                        if (i == 1)
                            bila[i].Left = gol[4].Right + 200;
                        if (i == 2)
                            bila[i].Left = gol[4].Right + 450;
                        if (i == 3)
                            bila[i].Left = gol[6].Right + 200;
                        if (i == 4)
                            bila[i].Left = gol[6].Right + 450;
                        if (i == 5)
                            bila[i].Left = gol[6].Right + 700;
                        bup[i] = false;
                        bdown[i] = true;
                        blt[i] = false;
                        brt[i] = false;
                        continue;
                    }
                }
                if (mario.Left + mario.Width > bila[i].Left && mario.Left + mario.Width < bila[i].Left + bila[i].Width + mario.Width && mario.Top - bila[i].Bottom <= 10 && mario.Top - bila[i].Top > -10)
                {
                    if (Ciuperci >= 1)
                    {
                        --Ciuperci;
                        button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    }
                    else
                        init();

                    bila[i].Top = 101;
                    if (i == 1)
                        bila[i].Left = gol[4].Right + 200;
                    if (i == 2)
                        bila[i].Left = gol[4].Right + 450;
                    if (i == 3)
                        bila[i].Left = gol[6].Right + 200;
                    if (i == 4)
                        bila[i].Left = gol[6].Right + 450;
                    if (i == 5)
                        bila[i].Left = gol[6].Right + 700;
                    bup[i] = false;
                    bdown[i] = true;
                    blt[i] = false;
                    brt[i] = false;
                    continue;
                }
                if (mario.Left + mario.Width > bila[i].Left && mario.Left + mario.Width < bila[i].Left + bila[i].Width + mario.Width && mario.Top + mario.Height >= bila[i].Top && mario.Top < bila[i].Top)
                {
                    if (Ciuperci >= 1)
                    {
                        --Ciuperci;
                        button3.Text = "CIUPERCI: " + Convert.ToString(Ciuperci);
                    }
                    else
                        init();

                    bila[i].Top = 101;
                    if (i == 1)
                        bila[i].Left = gol[4].Right + 200;
                    if (i == 2)
                        bila[i].Left = gol[4].Right + 450;
                    if (i == 3)
                        bila[i].Left = gol[6].Right + 200;
                    if (i == 4)
                        bila[i].Left = gol[6].Right + 450;
                    if (i == 5)
                        bila[i].Left = gol[6].Right + 700;
                    bup[i] = false;
                    bdown[i] = true;
                    blt[i] = false;
                    brt[i] = false;
                    continue;
                }
            }

            for (int i = 1; i <= nBila; ++i)
            {
                if (bup[i] == true)
                    bila[i].Top -= 2;
                if (bdown[i] == true)
                    bila[i].Top += 2;
                if (blt[i] == true)
                    bila[i].Left -= 2;
                if (brt[i] == true)
                    bila[i].Left += 2;
            }

            if (bila[1].Top >= screen.Bottom - bila[1].Height && bdown[1] == true)
            {
                bdown[1] = false;
                brt[1] = true;
            }
            if (bila[1].Right >= gol[4].Right + 450 && brt[1] == true)
            {
                brt[1] = false;
                bup[1] = true;
            }
            if (bila[1].Top <= 277 && bup[1] == true)
            {
                bup[1] = false;
                blt[1] = true;
            }
            if (bila[1].Left <= gol[4].Right + 200 && blt[1] == true)
            {
                blt[1] = false;
                bdown[1] = true;
            }

            if (bila[2].Left <= gol[4].Right + 450 && blt[2] == true)
            {
                blt[2] = false;
                bdown[2] = true;
            }
            if (bila[2].Top >= screen.Bottom - bila[2].Height && bdown[2] == true)
            {
                bdown[2] = false;
                brt[2] = true;
            }
            if (bila[2].Right >= gol[4].Right + 450 + 250 && brt[2] == true)
            {
                brt[2] = false;
                bup[2] = true;
            }
            if (bila[2].Top <= 277 && bup[2] == true)
            {
                bup[2] = false;
                blt[2] = true;
            }

            if (bila[3].Top >= screen.Bottom - bila[3].Height && bdown[3] == true)
            {
                bdown[3] = false;
                brt[3] = true;
            }
            if (bila[3].Right >= gol[6].Right + 450 && brt[3] == true)
            {
                brt[3] = false;
                bup[3] = true;
            }
            if (bila[3].Top <= 277 && bup[3] == true)
            {
                bup[3] = false;
                blt[3] = true;
            }
            if (bila[3].Left <= gol[6].Right + 200 && blt[3] == true)
            {
                blt[3] = false;
                bdown[3] = true;
            }

            if (bila[4].Left <= gol[6].Right + 450 && blt[4] == true)
            {
                blt[4] = false;
                bdown[4] = true;
            }
            if (bila[4].Top >= screen.Bottom - bila[4].Height && bdown[4] == true)
            {
                bdown[4] = false;
                brt[4] = true;
            }
            if (bila[4].Right >= gol[6].Right + 450 + 250 && brt[4] == true)
            {
                brt[4] = false;
                bup[4] = true;
            }
            if (bila[4].Top <= 277 && bup[4] == true)
            {
                bup[4] = false;
                blt[4] = true;
            }

            if (bila[5].Left <= gol[6].Right + 450 + 250 && blt[5] == true)
            {
                blt[5] = false;
                bdown[5] = true;
            }
            if (bila[5].Top >= screen.Bottom - bila[5].Height && bdown[5] == true)
            {
                bdown[5] = false;
                brt[5] = true;
            }
            if (bila[5].Right >= gol[6].Right + 450 + 250 + 250 && brt[5] == true)
            {
                brt[5] = false;
                bup[5] = true;
            }
            if (bila[5].Top <= 277 && bup[5] == true)
            {
                bup[5] = false;
                blt[5] = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mario.Right >= printesa.Left)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                mesaj.Visible = true;
                buton.Visible = true;
                buton.Left = pamant[2].Right + 2;
                buton.Top = cer[12].Bottom + 37;
                sfarsit = true;
                timer1.Enabled = false;
                mario.Left = printesa.Left - mario.Width;
                mario.Image = Properties.Resources.stand_r;
                return;
            }

            if (screen.Right >= printesa.Right)
                ok = true;

            bilee();

            if (cer[6].Top <= screen.Bottom && bara[1] == 0)
            {
                cer[6].Top += 5;
                if (jump != true && cer[6].Left - mario.Width <= mario.Left && mario.Right <= cer[6].Right + mario.Width)
                    mario.Top += 5;
            }
            if (cer[7].Top <= screen.Bottom && bara[2] == 0)
            {
                cer[7].Top += 5;
                if (jump != true && cer[7].Left - mario.Width <= mario.Left && mario.Right <= cer[7].Right + mario.Width)
                    mario.Top += 5;
            }
            if (cer[11].Top <= screen.Bottom && bara[3] == 0)
            {
                cer[11].Top += 5;
                if (jump != true && cer[11].Left - mario.Width <= mario.Left && mario.Right <= cer[11].Right + mario.Width)
                    mario.Top += 5;
            }

            for (int i = 1; i <= nCer; ++i)
            {
                if (i == 1 || i == 2 || i == 5)
                {
                    if (jumpb[i] == true)
                    {
                        cer[i].Top -= forceb[i];
                        forceb[i] -= 1;
                    }
                    if (cer[i].Top >= 359)
                    {
                        cer[i].Top = 359;
                        jumpb[i] = false;
                    }
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
                if (ok == true)
                {
                    mario.Left += deplasare;
                    nBlock -= 3;
                }
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left -= deplasare;
                }
                if (ok == true)
                {
                    nBlock += 3;
                }
                for (int i = 1; i <= nGol; ++i)
                {
                    gol[i].Left -= deplasare;
                }
                for (int i = 1; i <= nPatratgol; ++i)
                {
                    patratgol[i].Left -= deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left -= deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left -= deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left -= deplasare;
                }
                bila1.Left -= deplasare;
                bila2.Left -= deplasare;
                bila3.Left -= deplasare;
                bila4.Left -= deplasare;
                bila5.Left -= deplasare;
                if (ok == false)
                {
                    printesa.Left -= deplasare;
                }
            }
            if (left == true)
            {
                if (ok == true)
                {
                    mario.Left -= deplasare;
                    nBlock -= 3;
                }
                for (int i = 1; i <= nBlock; ++i)
                {
                    block[i].Left += deplasare;
                }
                if (ok == true)
                {
                    nBlock += 3;
                }
                for (int i = 1; i <= nGol; ++i)
                {
                    gol[i].Left += deplasare;
                }
                for (int i = 1; i <= nPatratgol; ++i)
                {
                    patratgol[i].Left += deplasare;
                }
                for (int i = 1; i <= nCiuperca; ++i)
                {
                    ciuperca[i].Left += deplasare;
                }
                for (int i = 1; i <= nBanut; ++i)
                {
                    banut[i].Left += deplasare;
                }
                for (int i = 1; i <= nMonstru; ++i)
                {
                    monstru[i].Left += deplasare;
                }
                bila1.Left += deplasare;
                bila2.Left += deplasare;
                bila3.Left += deplasare;
                bila4.Left += deplasare;
                bila5.Left += deplasare;
                if (ok == false)
                {
                    printesa.Left += deplasare;
                }
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
                    if (block[i].Visible == true)
                    {
                        if (i == 2 || i == 3 || i == 6)
                        {
                            int nowi = i;
                            if (i == 2)
                                nowi = 1;
                            else if (i == 3)
                                nowi = 2;
                            else if (i == 6)
                                nowi = 5;

                            jumpb[nowi] = true;
                            block[i].Top -= 10;
                            forceb[nowi] = 2;
                        }
                    }
                    if (i == 4 && block[i].Visible == true) // ciuperca
                    {
                        block[4].Visible = false;
                        patratgol[1].Visible = true;
                        ciuperca[1].Visible = true;
                    }
                    if (i == 11 && block[i].Visible == true)
                    {
                        block[11].Visible = false;
                        patratgol[5].Visible = true;
                        ciuperca[2].Visible = true;
                    }
                    if (i == 5 || i == 9 || i == 10)
                    {
                        if (block[i].Visible == true)
                        {
                            if (i == 5)
                            {
                                block[5].Visible = false;
                                patratgol[2].Visible = true;
                                banut[1].Visible = true;
                            }
                            else if (i == 9)
                            {
                                block[9].Visible = false;
                                patratgol[3].Visible = true;
                                banut[2].Visible = true;
                            }
                            else if (i == 10)
                            {
                                block[10].Visible = false;
                                patratgol[4].Visible = true;
                                banut[3].Visible = true;
                            }
                        }
                    }
                    else if (i != 4 && i != 5 && i != 9 && i != 10 && i != 11)
                    {
                        for (int j = 1; j <= 1; ++j)
                        {
                            if (j == 1 && ciuperca[j].Bottom != 359)
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

            for (int i = 1; i <= nGol; ++i)
                if (mario.Left >= gol[i].Left && mario.Right <= gol[i].Right && mario.Bottom == gol[i].Top)
                {
                    //Application.Restart();
                    init();
                }

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

                if (c1up == true && ciuperca[1].Bottom <= cer[3].Top)
                {
                    ciuperca[1].Top = cer[3].Top - ciuperca[1].Height;
                    c1up = false;
                    c1rt = true;
                }

                if (ciuperca[1].Left + ciuperca[1].Width >= block[6].Right)
                {
                    c1rt = false;
                    c1lt = true;
                }
                if (ciuperca[1].Left <= block[2].Left)
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
                if (c2up == true && ciuperca[2].Top + ciuperca[2].Height <= cer[10].Top)
                {
                    ciuperca[2].Top = cer[10].Top - ciuperca[2].Height;
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
                    if (i == 1 && banut[i].Top + banut[i].Height < cer[4].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 2 && banut[i].Top + banut[i].Height < cer[8].Top - 10)
                    {
                        banut[i].Visible = false;
                        ++Banuti;
                        Scor += 100;
                        button1.Text = "SCOR: " + Convert.ToString(Scor);
                        button2.Text = "BANUTI: " + Convert.ToString(Banuti);
                    }
                    else if (i == 3 && banut[i].Top + banut[i].Height < cer[9].Top - 10)
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
                        if (monstru[i].Left + monstru[i].Width >= gol[5].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[4].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 2)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[5].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[4].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 3)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[6].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[5].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 4)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[6].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[5].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 5)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[7].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[6].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 6)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[7].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[6].Right)
                        {
                            md[i] = true;
                        }
                    }
                    else if (i == 7)
                    {
                        if (monstru[i].Left + monstru[i].Width >= gol[7].Left)
                        {
                            md[i] = false;
                        }
                        if (monstru[i].Left <= gol[6].Right)
                        {
                            md[i] = true;
                        }
                    }

                    if (monstru[1].Visible == true && monstru[2].Visible == true && monstru[1].Left + monstru[1].Width >= monstru[2].Left)
                    {
                        md[1] = false;
                        md[2] = true;
                    }
                    if (monstru[3].Visible == true && monstru[4].Visible == true && monstru[3].Left + monstru[3].Width >= monstru[4].Left)
                    {
                        md[3] = false;
                        md[4] = true;
                    }
                    if (monstru[5].Visible == true && monstru[6].Visible == true && monstru[5].Left + monstru[5].Width >= monstru[6].Left)
                    {
                        md[5] = false;
                        md[6] = true;
                    }
                    if (monstru[5].Visible == true && monstru[7].Visible == true && monstru[5].Left + monstru[5].Width >= monstru[7].Left)
                    {
                        md[5] = false;
                        md[7] = true;
                    }
                    if (monstru[6].Visible == true && monstru[7].Visible == true && monstru[6].Left + monstru[6].Width >= monstru[7].Left)
                    {
                        md[6] = false;
                        md[7] = true;
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
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (sfarsit == false)
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
                if (e.KeyCode == Keys.Escape)
                {
                    Form5 f5 = new Form5();
                    this.Hide();
                    timer1.Enabled = false;
                    f5.Show();
                }
                if (e.KeyCode == Keys.R)
                {
                    init();
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
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (sfarsit == false)
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

        private void buton_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            timer1.Enabled = false;
            f5.Show();
        }
    }
}
