using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1 : Form
    {
        void fraktál(int lvl, int m)
        {
            if (lvl == 1)
            {
                Előre(m);
            }
            else if (lvl > 1)
            {
                fraktál(lvl - 1, m / 2);
                Jobbra(60);
                fraktál(lvl - 1, m / 2);
                Balra(120);
                fraktál(lvl - 1, m / 2);
                fraktál(lvl - 1, m / 2);
                Jobbra(120);
                fraktál(lvl - 1, m / 2);
                Balra(60);


            }
        }
        void szigetj(int m, int sz, int lvl, bool belul)
        {
            for (int i = 0; i < sz; i++)
            {
                fraktál(lvl, m);

                if (belul == true)
                {
                    Balra(360 / sz);
                }
                else
                {
                    Jobbra(360 / sz);
                }

            }
        }
        void otszogesfraktal(int lvl, double h)
        {
            if (lvl == 1)
            {
                Előre(h);
            }
            if (lvl > 1)
            {
                otszogesfraktal(lvl - 1, h / 2);
                Fordulj(72);
                otszogesfraktal(lvl - 1, h / 2);
                Fordulj(72);
                otszogesfraktal(lvl - 1, h / 2);
                Fordulj(-72);
                otszogesfraktal(lvl - 1, h / 2);
                Fordulj(-144);
                otszogesfraktal(lvl - 1, h / 2);
                Fordulj(72);
                otszogesfraktal(lvl - 1, h / 2);
            }



        }
        void fra5(int lvl, double h)
        {
            for (int i = 0; i < 5; i++)
            {
                otszogesfraktal(lvl, h);
                Fordulj(360 / 5);
            }
        }
        void törések(int lvl, double h)
        {
            if (lvl == 1)
            {
                Előre(h);
            }
            if (lvl > 1)
            {
                Fordulj(30);
                törések(lvl - 1, h / 2);
                Fordulj(-60);
                törések(lvl - 1, h / 2);
                Fordulj(60);
                törések(lvl - 1, h / 2);
                Fordulj(-30);
            }
        }
        void abra1(int lvl, double h)
        {
            Fordulj(30);
            for (int i = 0; i < 3; i++)
            {
                törések(lvl, h);
                Fordulj(-120);
            }
            Fordulj(-30);
        }

        void cgörbe(int lvl, double h)
        {
            if (lvl == 1)
            {
                Előre(h);
            }
            if (lvl > 1)
            {
                Fordulj(90);
                cgörbe(lvl - 1, h / 2);
                Fordulj(90);
                cgörbe(lvl - 1, h / 2);
                cgörbe(lvl - 1, h / 2);
                Fordulj(90);
                cgörbe(lvl - 1, h / 2);
                Fordulj(90);
            }
        }
        void nyilhegy(int lvl, double m)
        {
            if (lvl==2)
            {
                Jobbra(60);
                Előre(m);
                Jobbra(60);
                Előre(m);
                Jobbra(60);
                Előre(m);
            }
            if (lvl>2)
            {
                
            }
        }


        void FELADAT()
            {
                Tollat(fel);
                Előre(100);
                Tollat(le);
            using(new Frissítés(false))
            {
                abra1(5, 50);

                cgörbe(5, 30);
            }
            


            }
        
    }
}
