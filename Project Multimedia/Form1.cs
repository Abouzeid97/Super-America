using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Multimedia
{
    public class picsnor
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int felev;
        public int elevct;
        public Bitmap img;
    };

    public class picslist
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int j;
        public int fmove;
        public int flive;
        public List<Bitmap> img;
        public List<Bitmap> right;
        public List<Bitmap> left;
        public List<Bitmap> fire;
        public List<Bitmap> end;
    };

    public class anim
    {
        public List<Bitmap> img;
        public List<Bitmap> standRknife;
        public List<Bitmap> moveright;
        public List<Bitmap> standLknife;
        public List<Bitmap> moveleft;
        public List<Bitmap> Rjump;
        public List<Bitmap> Ljump;
        public List<Bitmap> Rgravity;
        public List<Bitmap> Lgravity;
        public List<Bitmap> Rknife;
        public List<Bitmap> Lknife;
        public List<Bitmap> standRpistol;
        public List<Bitmap> standLpistol;
        public List<Bitmap> Rpistol;
        public List<Bitmap> Lpistol;
        public List<Bitmap> shr;
        public List<Bitmap> shl;
        public int x;
        public int y;
        public int w;
        public int h;
        public int j;
        public int fdiren;
    }

    public partial class Form1 : Form
    {
        Bitmap off;
        List<anim> hero = new List<anim>();
        List<picsnor> des = new List<picsnor>();
        List<picslist> coins = new List<picslist>();
        List<picslist> crates = new List<picslist>();
        List<picsnor> cratestands = new List<picsnor>();
        List<picsnor> grass = new List<picsnor>();
        List<picsnor> bck = new List<picsnor>();
        List<picsnor> gun = new List<picsnor>();
        List<picsnor> laser = new List<picsnor>();
        List<picslist> e1 = new List<picslist>();
        List<picsnor> bullet = new List<picsnor>();
        List<picsnor> sh = new List<picsnor>();
        List<picslist> k = new List<picslist>();
        List<picslist> mons = new List<picslist>();
        List<picsnor> b = new List<picsnor>();
        int fgravity = 0;
        int down;
        int fj;
        int jumpdiren;
        int fgravj;
        int fjump;
        int fpent;
        int jumpct;
        int coinsct;
        int cratect;
        int healhero;
        int fpress;
        int fpistol;
        int fshield;
        int weaponchange;
        int e01ct;
        int fe1fire;
        int ctenmys;
        int bridgect;
        int fbosfire;
        int flaser;
        int ct;
        int fstart;
        int bossct;
        Timer tt = new Timer();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += new EventHandler(Form1_Load);
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            tt.Tick += new EventHandler(tt_Tick);
            tt.Start();
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (fstart == 0)
            {
                if (e.X >= 575 && e.X <= 955 && e.Y >= 245 && e.Y <= 560)
                {
                    fstart = 1;
                }
            }
        }

        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (hero[0].fdiren == 1 && fgravity == 1)
            {
                if (weaponchange == 0)
                {
                    hero[0].j = 0;
                    hero[0].img = hero[0].standRpistol;
                }
                else
                {
                    hero[0].img = hero[0].standRknife;
                }
            }
            if (hero[0].fdiren == 2 && fgravity == 1)
            {
                if (weaponchange == 0)
                {
                    hero[0].j = 0;
                    hero[0].img = hero[0].standLpistol;
                }
                else
                {
                    hero[0].img = hero[0].standLknife;
                }
            }
            fj = 0;
            fpent = 0;
            fpress = 0;
        }

        void tt_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < e1.Count; i++)
            {
                if (e1[0].fmove == 1)
                {
                    e1[0].x += 5;
                    e01ct++;
                    if (e01ct == 80)
                    {
                        e01ct = 0;
                        e1[0].fmove = 2;
                        e1[0].img = e1[0].left;
                    }
                }
                if (e1[0].fmove == 2)
                {
                    e1[0].x -= 5;
                    e01ct++;
                    if (e01ct == 80)
                    {
                        e01ct = 0;
                        e1[0].fmove = 1;
                        e1[0].img = e1[0].right;
                    }
                }
                if (e1[0].fmove == 3)
                {
                    e1[0].j = 0;
                    e1[0].y -= 5;
                    bossct++;
                    if (bossct == 40)
                    {
                        bossct = 0;
                        e1[0].fmove = 4;
                        e1[0].img = e1[0].left;
                    }
                }
                if (e1[0].fmove == 4)
                {
                    e1[0].j = 0;
                    e1[0].y += 5;
                    bossct++;
                    if (bossct == 40)
                    {
                        bossct = 0;
                        e1[0].fmove = 3;
                        e1[0].img = e1[0].right;
                    }
                }
            }
            for (int i = 0; i < k.Count; i++)
            {
                k[i].j++;
                if (k[i].j == k[i].img.Count)
                {
                    k[i].j = 0;
                }
            }
            for (int i = 0; i < e1.Count; i++)
            {
                e1[i].j++;
                if (e1[i].j == e1[i].img.Count)
                {
                    e1[i].j = 0;
                }
            }
            for (int i = 0; i < coins.Count; i++)
            {
                coins[i].j++;
                if (coins[i].j == coins[i].img.Count)
                {
                    coins[i].j = 0;
                }
            }
            for (int i = 0; i < crates.Count; i++)
            {
                crates[i].j++;
                if (crates[i].j == crates[i].img.Count && crates[i].img != crates[i].end)
                {
                    crates[i].j = 0;
                }
                else
                {
                    if (crates[i].j == crates[i].img.Count)
                    {
                        cratect++;

                        if (cratect == 1)
                        {
                            CreatePistol(crates[i].x + 10, crates[i].y);
                        }
                        else
                        {
                            CreateCrateCoin(crates[i].x + 10, crates[i].y);
                            Createfood(crates[i].x + 30, crates[i].y);
                        }

                        crates.RemoveAt(i);
                    }
                }
            }
            PistolBullet();
            BulletMove();
            CheckEnemy();
            CheckEnemy1Death();
            Enemy1fire();
            CreateLaser();
            MoveLaser();
            gravity();
            Jump();
            Coinscheck();
            CheckCrates();
            CheckPistol();
            GrassElev();
            CreateShieldfire();
            MoveShieldfire();
            CheckKey();
            CheckMonitor();
            BossBullet();
            if (fgravity == 1)
            {
                hero[0].j++;
                if (hero[0].img == hero[0].Rknife)
                {
                    if (hero[0].j == 2 || hero[0].j == 3 || hero[0].j == 4)
                    {
                        hero[0].w = 150;
                        hero[0].h = 120;
                    }
                    else
                    {
                        hero[0].w = 120;
                        hero[0].h = 120;
                    }
                }
                if (hero[0].j == hero[0].img.Count)
                {
                    hero[0].j = 0;
                }
            }
            if (healhero <= 0)
            {
                fstart = 1;
            }
            drawdubb(this.CreateGraphics());
        }

        void CreateBackground()
        {
            picsnor pnn = new picsnor();
            pnn.x = 0;
            pnn.y = 0;
            pnn.w = this.ClientSize.Width;
            pnn.h = this.ClientSize.Height;
            pnn.img = new Bitmap("bkg.jpg");
            b.Add(pnn);
        }

        void Createhealth()
        {
            picsnor pmm = new picsnor();
            pmm.x = 100;
            pmm.y = 10;
            pmm.w = 40;
            pmm.h = 40;
            pmm.img = new Bitmap("heart.png");
            des.Add(pmm);
        }

        void CreateHero()
        {
            anim pnn = new anim();
            pnn.standRknife = new List<Bitmap>();
            pnn.img = new List<Bitmap>();
            for (int i = 0; i < 11; i++)
            {
                Bitmap pnm = new Bitmap("hkr" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.standRknife.Add(pnm);
            }
            pnn.standLknife = new List<Bitmap>();
            for (int i = 0; i < 11; i++)
            {
                Bitmap pnm = new Bitmap("hkl" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.standLknife.Add(pnm);
            }
            pnn.moveright = new List<Bitmap>();
            for (int i = 1; i < 6; i++)
            {
                Bitmap pnm = new Bitmap("hmoveR" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.moveright.Add(pnm);
            }
            pnn.moveleft = new List<Bitmap>();
            for (int i = 1; i < 6; i++)
            {
                Bitmap pnm = new Bitmap("hmoveL" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.moveleft.Add(pnm);
            }
            pnn.Rjump = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap pnm = new Bitmap("hjumpR" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Rjump.Add(pnm);
            }
            pnn.Ljump = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap pnm = new Bitmap("hjumpL" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Ljump.Add(pnm);
            }
            pnn.Rgravity = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pnm = new Bitmap("hjumpR4.png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Rgravity.Add(pnm);
            }
            pnn.Lgravity = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pnm = new Bitmap("hjumpL4.png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Lgravity.Add(pnm);
            }
            pnn.Rknife = new List<Bitmap>();
            for (int i = 0; i < 7; i++)
            {
                Bitmap pnm = new Bitmap("hkrh" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Rknife.Add(pnm);
            }
            pnn.Lknife = new List<Bitmap>();
            for (int i = 0; i < 7; i++)
            {
                Bitmap pnm = new Bitmap("hklh" + i + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Lknife.Add(pnm);
            }
            pnn.Rpistol = new List<Bitmap>();
            for (int i = 0; i < 5; i++)
            {
                Bitmap pnm = new Bitmap("hrphk" + (i + 1) + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Rpistol.Add(pnm);
            }
            pnn.Lpistol = new List<Bitmap>();
            for (int i = 0; i < 5; i++)
            {
                Bitmap pnm = new Bitmap("hlph" + (i + 1) + ".png");
                pnm.MakeTransparent(pnm.GetPixel(0, 0));
                pnn.Lpistol.Add(pnm);
            }
            pnn.standRpistol = new List<Bitmap>();
            Bitmap pmm = new Bitmap("hpr.png");
            pmm.MakeTransparent(pmm.GetPixel(0, 0));
            pnn.standRpistol.Add(pmm);
            pnn.standLpistol = new List<Bitmap>();
            pmm = new Bitmap("hpl.png");
            pmm.MakeTransparent(pmm.GetPixel(0, 0));
            pnn.standLpistol.Add(pmm);
            pnn.x = 25;
            pnn.y = 400;
            pnn.w = 120;
            pnn.h = 120;
            pnn.img = pnn.standRknife;
            hero.Add(pnn);
        }

        void CreateHero2(int x, int y)
        {
            anim pnn = new anim();
            pnn.x = x;
            pnn.y = y;
            pnn.w = 130;
            pnn.h = 130;
            pnn.standRknife = new List<Bitmap>();
            for (int i = 0; i < 9; i++)
            {
                Bitmap pmm = new Bitmap("standR" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.standRknife.Add(pmm);
            }
            pnn.standLknife = new List<Bitmap>();
            for (int i = 0; i < 9; i++)
            {
                Bitmap pmm = new Bitmap("standL" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.standLknife.Add(pmm);
            }
            pnn.moveright = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap pmm = new Bitmap("Rrun" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.moveright.Add(pmm);
            }
            pnn.moveleft = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap pmm = new Bitmap("Lrun" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.moveleft.Add(pmm);
            }
            pnn.Rjump = new List<Bitmap>();
            for (int i = 0; i < 7; i++)
            {
                Bitmap pmm = new Bitmap("Rjump" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.Rjump.Add(pmm);
            }
            pnn.Ljump = new List<Bitmap>();
            for (int i = 0; i < 7; i++)
            {
                Bitmap pmm = new Bitmap("Ljump" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.Ljump.Add(pmm);
            }
            pnn.Rgravity = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("Rjump7.png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.Rgravity.Add(pmm);
            }
            pnn.Lgravity = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("Ljump7.png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.Lgravity.Add(pmm);
            }
            pnn.Rknife = new List<Bitmap>();
            for (int i = 0; i < 8; i++)
            {
                Bitmap pmm = new Bitmap("Rfire" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.Rknife.Add(pmm);
            }
            pnn.Lknife = new List<Bitmap>();
            for (int i = 0; i < 8; i++)
            {
                Bitmap pmm = new Bitmap("Lfire" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.Lknife.Add(pmm);
            }
            pnn.standRpistol = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("Rcover.png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.standRpistol.Add(pmm);
            }
            pnn.standLpistol = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("Lcover.png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.standLpistol.Add(pmm);
            }
            pnn.shr = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("shR.png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.shr.Add(pmm);
            }
            pnn.shl = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("shL.png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.shl.Add(pmm);
            }
            pnn.Rpistol = pnn.Rknife;
            pnn.Lpistol = pnn.Lknife;
            pnn.img = pnn.standRknife;
            hero.Add(pnn);
        }

        void Jump()
        {
            int s = this.ClientSize.Width;
            if (fjump == 1)
            {
                if (jumpdiren == 1)
                {
                    if (hero[0].x + 25 > s / 2 && hero[0].x < s / 2)
                    {
                        Scrolling();
                    }
                    else
                    {
                        hero[0].x += 25;
                    }
                }
                if (jumpdiren == 2)
                {
                    if (hero[0].x + 25 > s / 2 && hero[0].x < s / 2 && grass[0].x < 0)
                    {
                        Scrolling();
                    }
                    else
                    {
                        hero[0].x -= 25;
                    }
                }
                hero[0].y -= 25;
                jumpct++;
                hero[0].img = hero[0].Rjump;
                if (hero[0].fdiren == 2)
                {
                    hero[0].img = hero[0].Ljump;
                }
                if (jumpct > 5)
                {
                    fjump = 0;
                    jumpct = 0;
                }

            }
        }

        void gravity()
        {
            if (fjump == 0)
            {
                fgravity = 0;
                for (int i = 0; i < grass.Count; i++)
                {
                    if (hero[0].x + hero[0].w - 20 >= grass[i].x && grass[i].x + grass[i].w >= hero[0].x)
                    {
                        if (hero[0].y + hero[0].h >= grass[i].y)
                        {
                            fgravity = 1;
                            down = 1;
                            break;
                        }
                    }
                }
                if (fgravity == 0)
                {
                    hero[0].j = 0;
                    hero[0].img = hero[0].Rgravity;
                    if (hero[0].fdiren == 2)
                    {
                        hero[0].img = hero[0].Lgravity;
                    }
                    fgravity = 0;
                    down += 5;
                    hero[0].y += down;
                }
                if (fgravj == 0 && fgravity == 1)
                {
                    fgravj = 1;
                    hero[0].img = hero[0].standRknife;
                    if (hero[0].fdiren == 2)
                    {
                        hero[0].img = hero[0].standLknife;
                    }
                    fj = 0;
                }
            }
        }

        void CreateCoins()
        {
            picsnor pmm = new picsnor();
            pmm.x = 10;
            pmm.y = 10;
            pmm.w = 40;
            pmm.h = 40;
            pmm.img = new Bitmap("Gold_1.png");
            des.Add(pmm);
            int x = 100;
            for (int i = 0; i < 3; i++)
            {

                picslist pnn = new picslist();
                pnn.img = new List<Bitmap>();
                for (int k = 1; k < 11; k++)
                {
                    Bitmap pnm = new Bitmap("Gold_" + k + ".png");
                    pnn.img.Add(pnm);
                }
                pnn.x = x;
                pnn.y = 600;
                pnn.w = 40;
                pnn.h = 40;
                coins.Add(pnn);
                x += 70;
            }
        }

        void Coinscheck()
        {
            for (int i = 0; i < coins.Count; i++)
            {
                if (hero[0].fdiren == 1)
                {
                    if (hero[0].y + hero[0].h >= coins[i].y + coins[i].h && hero[0].y <= coins[i].h + coins[i].y)
                    {
                        if (hero[0].x + hero[0].w > coins[i].x && hero[0].x < coins[i].x + coins[i].w)
                        {
                            coins.RemoveAt(i);
                            coinsct++;
                            break;
                        }
                    }
                }
            }
        }

        void CreateGrass()
        {
            picsnor pnn;
            int x = -100;
            for (int i = 0; i < 2; i++)
            {
                pnn = new picsnor();
                pnn.img = new Bitmap("grass.png");
                pnn.x = x;
                pnn.y = 670;
                pnn.w = 700;
                pnn.h = 200;
                grass.Add(pnn);
                x += 1400;
            }
            pnn = new picsnor();
            pnn.img = new Bitmap("stand1.png");
            pnn.x = 720;
            pnn.y = 550;
            pnn.w = 200;
            pnn.h = 100;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("grasselev.png");
            pnn.x = 2000;
            pnn.y = 600;
            pnn.w = pnn.img.Width;
            pnn.h = pnn.img.Height;
            pnn.felev = 1;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("bridge.png");
            pnn.x = 2600;
            pnn.y = 720;
            pnn.w = 500;
            pnn.h = 100;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("bridge2.png");
            pnn.x = 3050;
            pnn.y = 720;
            pnn.w = 500;
            pnn.h = 100;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("stand1.png");
            pnn.x = 3600;
            pnn.y = 700;
            pnn.w = 200;
            pnn.h = 100;
            pnn.felev = 3;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("wall.png");
            pnn.x = 4000;
            pnn.y = 300;
            pnn.w = 100;
            pnn.h = 500;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("grass.png");
            pnn.x = 4150;
            pnn.y = 560;
            pnn.w = 700;
            pnn.h = 200;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("grass.png");
            pnn.x = 4800;
            pnn.y = 560;
            pnn.w = 700;
            pnn.h = 200;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("bridge.png");
            pnn.x = 5000;
            pnn.y = 600;
            pnn.w = 600;
            pnn.h = 100;
            grass.Add(pnn);

            pnn = new picsnor();
            pnn.img = new Bitmap("grass.png");
            pnn.x = 6500;
            pnn.y = 600;
            pnn.w = 700;
            pnn.h = 200;
            grass.Add(pnn);
        }

        void Grasscheck()
        {
            for (int i = 0; i < grass.Count; i++)
            {
                if (hero[0].fdiren == 1)
                {
                    if (hero[0].y + hero[0].h - 30 > grass[i].y && hero[0].y <= grass[i].h + grass[i].y)
                    {
                        if (hero[0].x + hero[0].w >= grass[i].x && hero[0].x < grass[i].x)
                        {
                            fpent = 1;
                            break;
                        }
                    }
                }
                if (hero[0].fdiren == 2)
                {
                    if (hero[0].y + hero[0].h - 30 > grass[i].y && hero[0].y <= grass[i].h + grass[i].y)
                    {
                        if (hero[0].x <= grass[i].x + grass[i].w && hero[0].x > grass[i].x)
                        {
                            fpent = 1;
                            break;
                        }
                    }
                }
            }
        }

        void GrassElev()
        {
            int s = this.ClientSize.Width;
            for (int i = 0; i < grass.Count; i++)
            {
                if (grass[i].felev == 1)
                {
                    if (hero[0].x + hero[0].w - 20 >= grass[i].x && grass[i].x + grass[i].w >= hero[0].x)
                    {
                        if (hero[0].y + hero[0].h >= grass[i].y)
                        {
                            hero[0].fdiren = 1;
                            Scrolling();
                        }
                    }
                    grass[i].x += 10;
                    grass[i].elevct++;
                    if (grass[i].elevct == 30)
                    {
                        grass[i].felev = 2;
                        grass[i].elevct = 0;
                    }
                }
                if (grass[i].felev == 2)
                {
                    if (hero[0].x + hero[0].w - 20 >= grass[i].x && grass[i].x + grass[i].w >= hero[0].x)
                    {
                        if (hero[0].y + hero[0].h >= grass[i].y)
                        {
                            hero[0].fdiren = 2;
                            Scrolling();
                        }
                    }
                    grass[i].x -= 10;
                    grass[i].elevct++;
                    if (grass[i].elevct == 30)
                    {
                        grass[i].felev = 1;
                        grass[i].elevct = 0;
                    }
                }
                if (grass[i].felev == 3)
                {
                    if (hero[0].x + hero[0].w > grass[i].x && hero[0].x < grass[i].x + grass[i].w)
                    {
                        if (hero[0].y + hero[0].h - 10 <= grass[i].y && fjump == 0)
                        {
                            hero[0].y -= 10;
                        }
                    }
                    grass[i].y -= 10;
                    grass[i].elevct++;
                    if (grass[i].elevct == 60)
                    {
                        grass[i].elevct = 0;
                        grass[i].felev = 4;
                    }
                }
                if (grass[i].felev == 4)
                {
                    if (hero[0].x + hero[0].w > grass[i].x && hero[0].x < grass[i].x + grass[i].w)
                    {
                        if (hero[0].y + hero[0].h - 10 <= grass[i].y && fjump == 0)
                        {
                            hero[0].y += 10;
                        }
                    }
                    grass[i].y += 10;
                    grass[i].elevct++;
                    if (grass[i].elevct == 60)
                    {
                        grass[i].elevct = 0;
                        grass[i].felev = 3;
                    }
                }
            }
        }

        void Scrolling()
        {
            if (hero[0].fdiren == 1)
            {
                for (int i = 0; i < mons.Count; i++)
                {
                    if (fjump == 1)
                    {
                        mons[i].x -= 25;
                    }
                    else
                    {
                        mons[i].x -= 10;
                    }
                }
                for (int i = 0; i < k.Count; i++)
                {
                    if (fjump == 1)
                    {
                        k[i].x -= 25;
                    }
                    else
                    {
                        k[i].x -= 10;
                    }
                }
                for (int i = 0; i < e1.Count; i++)
                {
                    if (fjump == 1)
                    {
                        e1[i].x -= 25;
                    }
                    else
                    {
                        e1[i].x -= 10;
                    }
                }
                for (int i = 0; i < gun.Count; i++)
                {
                    if (fjump == 1)
                    {
                        gun[i].x -= 25;
                    }
                    else
                    {
                        gun[i].x -= 10;
                    }
                }
                for (int i = 0; i < grass.Count; i++)
                {
                    if (fjump == 1)
                    {
                        grass[i].x -= 25;
                    }
                    else
                    {
                        grass[i].x -= 10;
                    }
                }
                for (int i = 0; i < coins.Count; i++)
                {
                    if (fjump == 1)
                    {
                        coins[i].x -= 25;
                    }
                    else
                    {
                        coins[i].x -= 10;
                    }
                }
                for (int i = 0; i < crates.Count; i++)
                {
                    if (fjump == 1)
                    {
                        crates[i].x -= 25;
                    }
                    else
                    {
                        crates[i].x -= 10;
                    }
                }
                for (int i = 0; i < cratestands.Count; i++)
                {
                    if (fjump == 1)
                    {
                        cratestands[i].x -= 25;
                    }
                    else
                    {
                        cratestands[i].x -= 10;
                    }
                }
            }
            if (hero[0].fdiren == 2)
            {
                for (int i = 0; i < mons.Count; i++)
                {
                    if (fjump == 1)
                    {
                        mons[i].x += 25;
                    }
                    else
                    {
                        mons[i].x += 10;
                    }
                }
                for (int i = 0; i < k.Count; i++)
                {
                    if (fjump == 1)
                    {
                        k[i].x += 25;
                    }
                    else
                    {
                        k[i].x += 10;
                    }
                }
                for (int i = 0; i < e1.Count; i++)
                {
                    if (fjump == 1)
                    {
                        e1[i].x += 25;
                    }
                    else
                    {
                        e1[i].x += 10;
                    }
                }
                for (int i = 0; i < gun.Count; i++)
                {
                    if (fjump == 1)
                    {
                        gun[i].x += 25;
                    }
                    else
                    {
                        gun[i].x += 10;
                    }
                }
                for (int i = 0; i < grass.Count; i++)
                {
                    if (fjump == 1)
                    {
                        grass[i].x += 25;
                    }
                    else
                    {
                        grass[i].x += 10;
                    }
                }
                for (int i = 0; i < coins.Count; i++)
                {
                    if (fjump == 1)
                    {
                        coins[i].x += 25;
                    }
                    else
                    {
                        coins[i].x += 10;
                    }
                }
                for (int i = 0; i < crates.Count; i++)
                {
                    if (fjump == 1)
                    {
                        crates[i].x += 25;
                    }
                    else
                    {
                        crates[i].x += 10;
                    }
                }
                for (int i = 0; i < cratestands.Count; i++)
                {
                    if (fjump == 1)
                    {
                        cratestands[i].x += 25;
                    }
                    else
                    {
                        cratestands[i].x += 10;
                    }
                }
            }
        }

        void CreateCrates()
        {
            picslist pnn = new picslist();
            pnn.x = 1450;
            pnn.y = 590;
            pnn.w = 60;
            pnn.h = 60;
            pnn.img = new List<Bitmap>();
            for (int i = 0; i < 8; i++)
            {
                Bitmap pnm = new Bitmap("crate(1)" + i + ".png");
                pnn.img.Add(pnm);
            }
            pnn.end = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap pnm = new Bitmap("cratesend" + (i + 1) + ".png");
                pnn.end.Add(pnm);
            }
            crates.Add(pnn);
            picsnor pm = new picsnor();
            pm.x = 1445;
            pm.y = 640;
            pm.w = 60;
            pm.h = 60;
            pm.img = new Bitmap("cratestand.png");
            cratestands.Add(pm);

            pnn = new picslist();
            pnn.x = 4300;
            pnn.y = 480;
            pnn.w = 60;
            pnn.h = 80;
            pnn.img = new List<Bitmap>();
            for (int i = 0; i < 8; i++)
            {
                Bitmap pnm = new Bitmap("crate(1)" + i + ".png");
                pnn.img.Add(pnm);
            }
            pnn.end = new List<Bitmap>();
            for (int i = 0; i < 6; i++)
            {
                Bitmap pnm = new Bitmap("cratesend" + (i + 1) + ".png");
                pnn.end.Add(pnm);
            }
            crates.Add(pnn);
        }

        void CheckCrates()
        {
            for (int i = 0; i < crates.Count; i++)
            {
                if (hero[0].fdiren == 1 && fpress == 1)
                {
                    if (crates[i].y + crates[i].h < hero[0].y + hero[0].h && crates[i].y + crates[i].h > hero[0].y)
                    {
                        if (crates[i].x <= hero[0].x + hero[0].w + 10 && hero[0].x < crates[i].x + crates[i].w)
                        {
                            crates[i].j = 0;
                            crates[i].img = crates[i].end;
                        }
                    }
                }
            }
        }

        void CreateCrateCoin(int x, int y)
        {
            picslist pnn = new picslist();
            pnn.img = new List<Bitmap>();
            for (int k = 1; k < 11; k++)
            {
                Bitmap pnm = new Bitmap("Gold_" + k + ".png");
                pnn.img.Add(pnm);
            }
            pnn.x = x;
            pnn.y = y;
            pnn.w = 40;
            pnn.h = 40;
            coins.Add(pnn);
        }

        void CreatePistol(int x, int y)
        {
            picsnor pnn = new picsnor();
            pnn.x = x + 5;
            pnn.y = y;
            pnn.w = 50;
            pnn.h = 50;
            pnn.img = new Bitmap("pistol.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            gun.Add(pnn);
        }

        void CheckPistol()
        {
            for (int i = 0; i < gun.Count; i++)
            {
                if (hero[0].fdiren == 1)
                {
                    if (gun[i].y + gun[i].h < hero[0].y + hero[0].h && gun[i].y + gun[i].h > hero[0].y)
                    {
                        if (gun[i].x <= hero[0].x + hero[0].w + 10 && hero[0].x < gun[i].x + gun[i].w)
                        {
                            fpistol = 1;
                            gun.RemoveAt(i);
                            fshield++;
                            if (fshield == 2)
                            {
                                CreateHero2(hero[0].x, hero[0].y);
                                hero.RemoveAt(0);
                                fshield++;
                            }
                            if (fshield == 4)
                            {
                                fshield++;
                                healhero = 200;
                            }
                        }
                    }
                }
            }
        }

        void PistolBullet()
        {
            if (fpistol == 1 && weaponchange == 0)
            {
                if (hero[0].img == hero[0].Rpistol && hero[0].j == 2)
                {
                    picsnor pnn = new picsnor();
                    pnn.img = new Bitmap("bullet.png");
                    pnn.y = hero[0].y + 20;
                    pnn.w = 20;
                    pnn.h = 10;
                    if (hero[0].fdiren == 1)
                    {
                        pnn.felev = 1;
                        pnn.x = hero[0].x + hero[0].w;
                    }
                    if (hero[0].fdiren == 2)
                    {
                        pnn.x = hero[0].x;
                        pnn.felev = 2;
                    }
                    bullet.Add(pnn);
                }
            }
        }

        void BulletMove()
        {
            for (int i = 0; i < bullet.Count; i++)
            {
                if (bullet[i].felev == 1)
                {
                    bullet[i].x += 12;
                }
                if (bullet[i].felev == 2)
                {
                    bullet[i].x -= 12;
                }
            }
        }

        void CreateEnemy1()
        {
            picslist pnn = new picslist();

            pnn.right = new List<Bitmap>();
            for (int i = 0; i < 19; i++)
            {
                Bitmap pmm = new Bitmap("Rwalk" + (i + 1) + ".png");
                pnn.right.Add(pmm);
            }
            pnn.left = new List<Bitmap>();
            for (int i = 0; i < 19; i++)
            {
                Bitmap pmm = new Bitmap("walk" + (i + 1) + ".png");
                pnn.left.Add(pmm);
            }
            pnn.fire = new List<Bitmap>();
            for (int i = 0; i < 13; i++)
            {
                Bitmap pmm = new Bitmap("attack" + (i + 1) + ".png");
                pnn.fire.Add(pmm);
            }
            pnn.end = new List<Bitmap>();
            for (int i = 0; i < 13; i++)
            {
                Bitmap pmm = new Bitmap("death" + (i + 1) + ".png");
                pnn.end.Add(pmm);
            }
            pnn.x = 2900;
            pnn.w = 150;
            pnn.h = 120;
            pnn.y = 630;
            pnn.fmove = 1;
            pnn.img = pnn.right;
            e1.Add(pnn);
            pnn = new picslist();

            pnn.right = new List<Bitmap>();
            for (int i = 0; i < 19; i++)
            {
                Bitmap pmm = new Bitmap("Rwalk" + (i + 1) + ".png");
                pnn.right.Add(pmm);
            }
            pnn.left = new List<Bitmap>();
            for (int i = 0; i < 19; i++)
            {
                Bitmap pmm = new Bitmap("walk" + (i + 1) + ".png");
                pnn.left.Add(pmm);
            }
            pnn.fire = new List<Bitmap>();
            for (int i = 0; i < 13; i++)
            {
                Bitmap pmm = new Bitmap("attack" + (i + 1) + ".png");
                pnn.fire.Add(pmm);
            }
            pnn.end = new List<Bitmap>();
            for (int i = 0; i < 13; i++)
            {
                Bitmap pmm = new Bitmap("death" + (i + 1) + ".png");
                pnn.end.Add(pmm);
            }
            pnn.x = 4800;
            pnn.w = 150;
            pnn.h = 120;
            pnn.y = 440;
            pnn.fmove = 1;
            pnn.img = pnn.right;
            e1.Add(pnn);
        }

        void Enemy1fire()
        {
            for (int i = 0; i < e1.Count; i++)
            {
                if (e1[i].flive == 0)
                {
                    if (hero[0].x + 500 > e1[i].x && hero[0].y + hero[0].h > e1[i].y)
                    {
                        e1[i].fmove = 0;
                        if (fe1fire == 0)
                        {
                            fe1fire = 1;
                            e1[i].j = 0;
                        }
                        e1[i].img = e1[i].fire;
                    }
                }
            }
        }

        void CheckEnemy()
        {
            int f = 0;
            int k;
            for (int i = 0; i < bullet.Count; i++)
            {
                for (k = 0; k < e1.Count; k++)
                {
                    if (bullet[i].x + bullet[i].w > e1[k].x && bullet[i].x + bullet[i].w < e1[k].x + e1[k].w)
                    {
                        if (bullet[i].y > e1[k].y && bullet[i].y + bullet[i].h < e1[k].y + e1[k].h)
                        {
                            f = i;
                            break;
                        }
                    }
                }
                if (f != 0)
                {
                    e1[k].flive = 1;
                    bullet.RemoveAt(f);
                    e1[k].j = 0;
                    e1[k].img = e1[k].end;
                    f = 0;
                    break;
                }

            }
        }

        void CheckEnemy1Death()
        {
            for (int i = 0; i < e1.Count; i++)
            {
                if (e1[i].img == e1[i].end)
                {
                    if (e1[i].j == 12)
                    {
                        ctenmys++;
                        if (ctenmys == 1)
                        {
                            CreateCrateCoin(e1[i].x, e1[i].y + 10);
                            CreateShield(e1[i].x + 5, e1[i].y + 10);
                        }
                        if (ctenmys == 2)
                        {
                            CreateKey(e1[i].x + 20, e1[i].y);
                        }
                        e1.RemoveAt(i);
                        fe1fire = 0;
                    }
                    if (e1.Count == 1 && e1[i].j == 1)
                    {
                        e1.RemoveAt(i);
                    }
                }
            }
        }

        void CreateLaser()
        {
            for (int i = 0; i < e1.Count; i++)
            {
                if (e1[i].img == e1[i].fire && e1[i].j == 7)
                {
                    picsnor pnn = new picsnor();
                    pnn.x = e1[i].x - 30;
                    pnn.y = e1[i].y + 30;
                    pnn.w = 40;
                    pnn.h = 10;
                    pnn.felev = 0;
                    pnn.img = new Bitmap("laser1.png");
                    laser.Add(pnn);
                }
            }
        }

        void MoveLaser()
        {
            for (int i = 0; i < laser.Count; i++)
            {
                if (flaser == 1)
                {
                    laser[i].x -= 10;
                    laser[i].y -= 5;
                }
                if (fbosfire == 0)
                {
                    laser[i].x -= 10;
                }
                else
                {
                    laser[i].x -= 10;
                    laser[i].y += 10;
                    flaser = 1;
                }
                if (laser[i].x < hero[0].x + hero[0].w && laser[i].x > hero[0].x
                    && hero[0].y <= laser[i].y && hero[0].y + hero[0].h > laser[i].y)
                {
                    if (hero[0].img != hero[0].standRpistol)
                    {
                        healhero -= 10;
                    }
                    laser.RemoveAt(i);
                    break;
                }
            }
        }

        void CreateShieldfire()
        {
            if (hero[0].img == hero[0].Rpistol && hero.Count == 1)
            {
                if (hero[0].j == 7)
                {
                    picsnor pnn = new picsnor();
                    pnn.img = new Bitmap("firing.png");
                    pnn.x = hero[0].x + hero[0].w;
                    pnn.y = hero[0].y + 10;
                    pnn.w = pnn.img.Width;
                    pnn.h = pnn.img.Height;
                    pnn.felev = 1;
                    sh.Add(pnn);
                }
            }
            if (hero[0].img == hero[0].Lpistol && hero.Count == 1)
            {
                if (hero[0].j == 7)
                {
                    picsnor pnn = new picsnor();
                    pnn.img = new Bitmap("Lfiring.png");
                    pnn.x = hero[0].x;
                    pnn.y = hero[0].y + 10;
                    pnn.w = pnn.img.Width;
                    pnn.h = pnn.img.Height;
                    pnn.felev = 1;
                    sh.Add(pnn);
                }
            }
        }

        void MoveShieldfire()
        {
            if (sh.Count != 0)
            {
                if (hero[0].fdiren == 1 && sh[0].felev == 1)
                {
                    hero[0].j = 0;
                    sh[0].img = new Bitmap("firing.png");
                    hero[0].img = hero[0].shr;
                    sh[0].x += 30;
                    for (int i = 0; i < e1.Count; i++)
                    {
                        if (sh[0].x + sh[0].w > e1[i].x)
                        {
                            e1[i].j = 0;
                            e1[i].img = e1[i].end;
                            break;
                        }
                    }
                    sh[0].elevct++;
                    if (sh[0].elevct == 15)
                    {
                        sh[0].elevct = 0;
                        sh[0].felev = 2;
                    }
                }
                if (hero[0].fdiren == 1 && sh[0].felev == 2)
                {
                    sh[0].img = new Bitmap("Lfiring.png");
                    sh[0].x -= 30;
                    if (sh[0].x <= hero[0].x + hero[0].w)
                    {
                        hero[0].img = hero[0].standRknife;
                        sh.RemoveAt(0);
                    }
                }
                if (hero[0].fdiren == 2 && sh[0].felev == 1)
                {
                    hero[0].j = 0;
                    sh[0].img = new Bitmap("Lfiring.png");
                    hero[0].img = hero[0].shl;
                    sh[0].x -= 30;
                    sh[0].elevct++;
                    if (sh[0].elevct == 15)
                    {
                        sh[0].elevct = 0;
                        sh[0].felev = 2;
                    }
                }
                if (hero[0].fdiren == 2 && sh[0].felev == 2)
                {
                    sh[0].img = new Bitmap("firing.png");
                    sh[0].x += 30;
                    if (sh[0].x >= hero[0].x)
                    {
                        hero[0].img = hero[0].standLknife;
                        sh.RemoveAt(0);
                    }
                }
            }
        }

        void Createfood(int x, int y)
        {
            picsnor pnn = new picsnor();
            pnn.img = new Bitmap("food.png");
            pnn.x = x;
            pnn.y = y;
            pnn.w = 60;
            pnn.h = 60;
            gun.Add(pnn);
        }

        void CreateShield(int x, int y)
        {
            picsnor pnn = new picsnor();
            pnn.x = x + 50;
            pnn.y = y;
            pnn.img = new Bitmap("shield1.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.w = 50;
            pnn.h = 50;
            gun.Add(pnn);
        }

        void CreateKey(int x, int y)
        {
            picslist pnn = new picslist();
            pnn.img = new List<Bitmap>();
            for (int i = 0; i < 11; i++)
            {
                Bitmap pmm = new Bitmap("Key" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.img.Add(pmm);
            }
            pnn.x = x;
            pnn.y = y + 20;
            pnn.w = 60;
            pnn.h = 60;
            k.Add(pnn);
        }

        void CheckKey()
        {
            for (int i = 0; i < k.Count; i++)
            {
                if (k[i].x < hero[0].x + hero[0].w && k[i].x > hero[0].x
                   && hero[0].y <= k[i].y && hero[0].y + hero[0].h > k[i].y)
                {
                    k.RemoveAt(i);
                }
            }
        }

        void CreateMonitor()
        {
            picsnor pnn = new picsnor();
            pnn.img = new Bitmap("monitor.png");
            pnn.x = 5300;
            pnn.y = 500;
            pnn.w = 60;
            pnn.h = 60;
            cratestands.Add(pnn);
        }

        void CheckMonitor()
        {
            if (hero[0].x > cratestands[cratestands.Count - 1].x && k.Count == 0)
            {
                if (bridgect < 13)
                {
                    grass[grass.Count - 2].x += 50;
                    bridgect++;
                }
            }
        }

        void CreateBoss()
        {
            picslist pnn = new picslist();
            pnn.left = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("boss" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.left.Add(pmm);
            }
            pnn.right = new List<Bitmap>();
            for (int i = 0; i < 1; i++)
            {
                Bitmap pmm = new Bitmap("boss" + (i + 2) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.right.Add(pmm);
            }
            pnn.fire = new List<Bitmap>();
            for (int i = 0; i < 4; i++)
            {
                Bitmap pmm = new Bitmap("bossfire" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.fire.Add(pmm);
            }
            pnn.end = new List<Bitmap>();
            for (int i = 0; i < 2; i++)
            {
                Bitmap pmm = new Bitmap("bossdead" + (i + 1) + ".png");
                pmm.MakeTransparent(pmm.GetPixel(0, 0));
                pnn.end.Add(pmm);
            }
            pnn.fmove = 3;
            pnn.img = pnn.left;
            pnn.x = 7000;
            pnn.y = 500;
            pnn.w = 200;
            pnn.h = 150;
            e1.Add(pnn);
        }

        void BossBullet()
        {
            if (e1.Count == 1)
            {
                if (e1[0].img == e1[0].fire && e1[0].j == 3)
                {
                    picsnor pnn = new picsnor();
                    pnn.img = new Bitmap("bossbullet.png");
                    pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                    pnn.x = e1[0].x;
                    pnn.y = e1[0].y + 30;
                    pnn.w = 20;
                    pnn.h = 10;
                    pnn.felev = 0;
                    laser.Add(pnn);
                }
            }
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int s = this.ClientSize.Width;
            if (e.KeyCode == Keys.Right)
            {
                jumpdiren = 1;
                hero[0].fdiren = 1;
                if (fj == 0)
                {
                    hero[0].j = 0;
                    fj = 1;
                }
                Grasscheck();
                if (fpent == 0)
                {
                    if (hero[0].x + 10 > s / 2 && hero[0].x < s / 2)
                    {
                        Scrolling();
                        hero[0].img = hero[0].moveright;
                    }
                    else
                    {
                        hero[0].img = hero[0].moveright;
                        hero[0].x += 10;
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                jumpdiren = 2;
                hero[0].fdiren = 2;
                if (fj == 0)
                {
                    hero[0].j = 0;
                    fj = 1;
                }
                Grasscheck();
                if (fpent == 0)
                {
                    if (hero[0].x + 10 > s / 2 && hero[0].x < s / 2 && grass[0].x < 0)
                    {
                        Scrolling();
                        hero[0].img = hero[0].moveleft;
                    }
                    else
                    {
                        hero[0].img = hero[0].moveleft;
                        hero[0].x -= 10;
                    }
                }
            }
            if (e.KeyCode == Keys.F)
            {
                fpress = 1;
                if (fj == 0)
                {
                    hero[0].j = 0;
                    fj = 1;
                }
                if (weaponchange == 1)
                {
                    hero[0].img = hero[0].Rknife;
                    if (hero[0].fdiren == 2)
                    {
                        hero[0].img = hero[0].Lknife;
                    }
                }
                else
                {
                    hero[0].img = hero[0].Rpistol;
                    if (hero[0].fdiren == 2)
                    {
                        hero[0].img = hero[0].Lpistol;
                    }
                }
            }


            if (e.KeyCode == Keys.Up)
            {
                jumpdiren = 0;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (fj == 0)
                {
                    fjump = 1;
                    hero[0].j = 0;
                    fj = 1;
                    fgravj = 0;
                }
                hero[0].img = hero[0].Rjump;
                if (hero[0].fdiren == 2)
                {
                    hero[0].img = hero[0].Ljump;
                }
            }
            if (e.KeyCode == Keys.E)
            {
                if (fpistol == 1)
                {
                    if (weaponchange == 0)
                    {
                        weaponchange = 1;
                    }
                    else
                    {
                        weaponchange = 0;
                    }
                    if (weaponchange == 0)
                    {
                        if (fj == 0)
                        {
                            hero[0].j = 0;
                            fj = 1;
                        }
                        hero[0].img = hero[0].standRpistol;
                        if (hero[0].fdiren == 2)
                        {
                            hero[0].img = hero[0].standLpistol;
                        }
                    }
                    if (weaponchange == 1)
                    {
                        if (fj == 0)
                        {
                            hero[0].j = 0;
                            fj = 1;
                        }
                        hero[0].img = hero[0].standRknife;
                        if (hero[0].fdiren == 2)
                        {
                            hero[0].img = hero[0].standLknife;
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.B)
            {
                int h = 1;
            }
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawdubb(this.CreateGraphics());
        }

        void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            CreateBackground();
            picsnor pnn = new picsnor();
            pnn.img = new Bitmap("background1.png");
            pnn.x = 0;
            pnn.y = 0;
            pnn.w = this.ClientSize.Width;
            pnn.h = this.ClientSize.Height;
            bck.Add(pnn);
            healhero = 100;
            cratect = 0;
            weaponchange = 1;
            CreateHero();
            CreateCoins();
            CreateGrass();
            CreateCrates();
            Createhealth();
            CreateEnemy1();
            CreateMonitor();
            CreateBoss();
        }

        void drawscene(Graphics g)
        {
            if (fstart == 0)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    g.DrawImage(b[i].img, b[i].x, b[i].y, b[i].w, b[i].h);
                }
            }
            else
            {
                for (int i = 0; i < bck.Count; i++)
                {
                    g.DrawImage(bck[i].img, bck[i].x, bck[i].y, bck[i].w, bck[i].h);
                }
                g.DrawString(" " + coinsct, new Font("system", 20), Brushes.Black, des[0].x + 50, des[0].y + 5);
                g.DrawString(" " + healhero, new Font("system", 20), Brushes.Black, des[1].x + 30, des[1].y + 5);
                for (int i = 0; i < des.Count; i++)
                {
                    g.DrawImage(des[i].img, des[i].x, des[i].y, des[i].w, des[i].h);
                }
                for (int i = 0; i < cratestands.Count; i++)
                {
                    g.DrawImage(cratestands[i].img, cratestands[i].x, cratestands[i].y, cratestands[i].w, cratestands[i].h);
                }
                for (int i = 0; i < grass.Count; i++)
                {
                    g.DrawImage(grass[i].img, grass[i].x, grass[i].y, grass[i].w, grass[i].h);
                }
                g.DrawImage(hero[0].img[hero[0].j], hero[0].x, hero[0].y, hero[0].w, hero[0].h);
                for (int i = 0; i < coins.Count; i++)
                {
                    g.DrawImage(coins[i].img[coins[i].j], coins[i].x, coins[i].y, coins[i].w, coins[i].h);
                }
                for (int i = 0; i < crates.Count; i++)
                {
                    g.DrawImage(crates[i].img[crates[i].j], crates[i].x, crates[i].y, crates[i].w, crates[i].h);
                }
                for (int i = 0; i < gun.Count; i++)
                {
                    g.DrawImage(gun[i].img, gun[i].x, gun[i].y, gun[i].w, gun[i].h);
                }
                for (int i = 0; i < e1.Count; i++)
                {
                    g.DrawImage(e1[i].img[e1[i].j], e1[i].x, e1[i].y, e1[i].w, e1[i].h);
                }
                for (int i = 0; i < laser.Count; i++)
                {
                    g.DrawImage(laser[i].img, laser[i].x, laser[i].y, laser[i].w, laser[i].h);
                }
                for (int i = 0; i < bullet.Count; i++)
                {
                    g.DrawImage(bullet[i].img, bullet[i].x, bullet[i].y, bullet[i].w, bullet[i].h);
                }
                for (int i = 0; i < sh.Count; i++)
                {
                    g.DrawImage(sh[i].img, sh[i].x, sh[i].y, sh[i].w, sh[i].h);
                }
                for (int i = 0; i < k.Count; i++)
                {
                    g.DrawImage(k[i].img[k[i].j], k[i].x, k[i].y, k[i].w, k[i].h);
                }
            }
        }

        void drawdubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            drawscene(g2);
            g.DrawImage(off, 0, 0);
        }
    }
}