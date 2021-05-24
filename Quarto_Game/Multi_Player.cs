using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WMPLib;
using System.IO;
using System.Xml;
namespace Quarto_Game
{
    public partial class Multi_Player : Form
    {
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        WindowsMediaPlayer pieces_sound = new WindowsMediaPlayer();
       public  static WindowsMediaPlayer music = new WindowsMediaPlayer();

       // DataSet ds;
        static string player1, player2;
        int s;
        int m;
        PictureBox selectedcase;
        PictureBox selectedpiece;
        PictureBox[,] board;
        PictureBox[,] board1;
        ArrayList arrboard = new ArrayList();//for selected case in board
        PictureBox[] p;
        PictureBox[] k;
        PictureBox[] ee;
        ArrayList arrpieces = new ArrayList();//for selected pieces 
        int t=-1;
        string txt;
        int end_ticks = 0;
        static int counts1, counts2, Round_count, minutes, seconds;
        bool there_is_a_winner = false;
        bool turn1 , turn2;
         static string First_Move;
        static string lang;
        static Form form1, form2;
        static int count_sound;
        static int volume;
        static bool continue_game;
        int turn_count;
        public Multi_Player()
        {
            InitializeComponent();
         
        }
        public Multi_Player(Form f)
        {
            InitializeComponent();
            form1 = f;//players name

        }
        struct figure
        {
            public string color, shape, size, hole;
            public int index;
        }
        public static void set_static_variables(string n1, string n2,int countss1,int countss2,int rounds_count,string first_move,int min,int sec,string l,Form f2,int s_count,int v,bool continu)
        {
            player1 = n1;
            player2 = n2;
            counts1 = countss1;
            counts2 = countss2;
            Round_count = rounds_count;
            First_Move = first_move;
            minutes = min;
            seconds = sec;
            lang = l;
            continue_game = continu;
            form2 = f2;//Main Menu
            count_sound = s_count;
            volume = v;
        }

        private void invisible()
        {
            foreach( Control c in this.Controls)
            {
                try
                {
                    PictureBox p = (PictureBox)c;
                   
                    p.Visible = false;
                }
                catch { };
            }
        }
        private void visible()
        {
            foreach (Control c in this.Controls)
            {

                try
                {
                    PictureBox p = (PictureBox)c;
                    p.Enabled = true;
                    p.Visible = true;
                }
                catch { };
            }
        }

        private void timer1_load_Tick(object sender, EventArgs e)
        {
            t++;
            if (lang == "english")
            {
                if (Round_count == 1) txt = "FIRST ROUND.";
                if (Round_count == 2) txt = "SECOND ROUND.";
                if (Round_count == 3) txt = "THIRD ROUND.";
            }
            else if (lang == "francais")
            {
                if (Round_count == 1) txt = "PREMIER TOUR.";
                if (Round_count == 2) txt = "DEUXIEME TOUR.";
                if (Round_count == 3) txt = "TROISIEME TOUR.";
            }
            if ((Round_count == 1) && (label1.Text.Length != txt.Length))
            {
                if (t < txt.Length + 1)
                {
                    label1.Text += txt[t].ToString();
                }
            }

            if ((Round_count == 2) && (label1.Text.Length != txt.Length))
            {

                if (t < txt.Length + 1)
                {
                    label1.Text = label1.Text + txt[t].ToString();
                }
            }

            if ((Round_count == 3) && (label1.Text.Length != txt.Length))
            {
                if (t < txt.Length + 1)
                {
                    label1.Text = label1.Text + txt[t].ToString();
                }
            }
            if (label1.Text.Length == txt.Length)
            {
                music.URL = "Quarto_Music.wav";
                if (volume != 0)
                {
                    sound.Visible = true;
                    if (count_sound % 2 == 1)
                    {
                        music.controls.play();
                        sound.Image = Properties.Resources.sound1_on;
                        music.settings.volume = volume;
                    }
                    else if (count_sound % 2 == 0)
                    {
                        music.controls.play();
                        sound.Image = Properties.Resources.sound2_off;
                        music.settings.volume = 0;
                    }
                }
                else
                {
                    sound.Visible = false;
                }

                timer1_load.Stop();

                this.Controls.Remove(label1);
                this.BackgroundImage = null;
                this.BackgroundImage = Properties.Resources.backgd;

                visible();
                disable(arrboard);

                player_nm1.Visible = true;
                player_nm2.Visible = true;
                count1.Visible = true;
                count2.Visible = true;
                label_key.Visible = true;
                label_mouse.Visible = true;
                game_time.Visible = true;
                restart.Visible = true;
                cancel.Visible = true;

                player_nm1.Text = player1;
                player_nm2.Text = player2;

                count1.Text = counts1.ToString();
                count2.Text = counts2.ToString();

                if (lang == "english")
                {
                    restart.Text = "Restart";
                    cancel.Text = "Cancel";
                }
                else if (lang == "francais")
                {
                    restart.Text = "Repartir";
                    cancel.Text = "Annuler";
                }
                if (!continue_game)
                {
                    game_time.Text = "00:00";
                    if (First_Move == "First Player")

                    {
                        try
                        {
                            this.KeyDown -= Multi_Player_KeyDown;
                        }
                        catch { };
                        this.KeyDown += Multi_Player_KeyDown;
                        turn1 = false;
                        turn2 = true;
                        key.Visible = false;
                        this.KeyPreview = true;
                        ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                        selectedpiece = (PictureBox)arrpieces[0];
                        selectedpiece.Refresh();
                        if (lang == "english")
                        {
                            label_mouse.Text = "Waiting...";
                            label_key.Text = "choose a piece for " + player2;
                            this.Refresh();
                        }
                        else if (lang == "francais")
                        {

                            label_mouse.Text = "Attendre...";
                            label_key.Text = "Choisir une pièce pour " + player2;

                        }

                    }
                    else if (First_Move == "Second Player")
                    {
                        this.KeyDown -= Multi_Player_KeyDown;
                        try
                        {
                            this.KeyDown -= Multi_Player_KeyDown;
                        }
                        catch { };
                        this.KeyPreview = false;
                        mouse.Visible = false;
                        turn1 = true;
                        turn2 = false;
                        if (lang == "english")
                        {
                            label_mouse.Text = "choose a piece for " + player1;
                            label_key.Text = "Waiting...";
                            this.Refresh();
                        }
                        else if (lang == "francais")
                        {
                            label_mouse.Text = "Choisir une pièce pour " + player1;
                            label_key.Text = "Attendre...";
                            this.Refresh();
                        }


                    }
                    else if (First_Move == "Take turns")
                    {
                        if (Round_count % 2 == 1)
                        {
                            this.KeyDown -= Multi_Player_KeyDown;
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            mouse.Visible = false;
                            turn1 = true;
                            turn2 = false;
                            if (lang == "english")
                            {
                                label_mouse.Text = "choose a piece for " + player1;
                                label_key.Text = "Waiting...";
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {
                                label_mouse.Text = "Choisir une pièce pour " + player1;
                                label_key.Text = "Attendre...";
                                this.Refresh();
                            }
                        }
                        else
                        {
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            this.KeyDown += Multi_Player_KeyDown;
                            turn1 = false;
                            turn2 = true;
                            key.Visible = false;
                            ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[0];
                            selectedpiece.Refresh();
                            if (lang == "english")
                            {
                                label_mouse.Text = "Waiting...";
                                label_key.Text = "choose a piece for " + player2;
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {

                                label_mouse.Text = "Attendre...";
                                label_key.Text = "Choisir une pièce pour " + player2;

                            }
                        }
                    }

                    s = 0;
                    m = 0;
                    this.Refresh();
                }
                else if (continue_game)
                {
                    cancel.Visible = false;
                    restart.Top -= 40;
                    sound.Top -= 40;
                    string time;
                    int ind;
                    string tt1 = "";
                    string seatt;
                     FileStream fq = new FileStream(Application.StartupPath + "\\quarto_stones", FileMode.Open, FileAccess.Read);
                    BinaryReader bq = new BinaryReader(fq);
                    while (fq.Position != fq.Length)
                    {
                        string b = bq.ReadString();
                        ind = bq.ReadInt32();
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (board[i, j].Name == b)
                                {
                                    board[i, j].Enabled = false;
                                    arrboard.Remove(board[i, j]);
                                    arrpieces.Remove(p[ind]);
                                    this.Controls.Remove(p[ind]);
                                    board[i, j].Tag = p[ind].Tag;
                                    board[i, j].Image = k[ind].Image;
                                    board[i, j].SizeMode = PictureBoxSizeMode.AutoSize;
                                    if (board[i, j].Height == 55)
                                    {
                                        board[i, j].Top -= 20;
                                    }
                                    if (board[i, j].Height == 40)
                                    {
                                        board[i, j].Top -= 7;
                                    }
                                    board[i, j].SendToBack();

                                    this.Refresh();
                                }

                            }

                        }


                    }
                    bq.Close(); fq.Close();



                    FileStream fr = new FileStream(Application.StartupPath + "\\turns", FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fr);

                    tt1 = br.ReadString();
                    time = br.ReadString();
                    br.Close(); fr.Close();
                    game_time.Text = time;
                    m = int.Parse(game_time.Text.Substring(0, 2));
                    s = int.Parse(game_time.Text.Substring(3, 2));

                    if (File.Exists("seat"))
                    {
                        turn_count = 0;
                        int indseat;
                        FileStream fst = new FileStream(Application.StartupPath + "\\seat", FileMode.Open, FileAccess.Read);
                        BinaryReader bst = new BinaryReader(fst);
                        seatt = bst.ReadString();
                        indseat = bst.ReadInt32();
                        bst.Close(); fst.Close();
                        if (seatt == "k")
                        {
                            selectedcase = (PictureBox)arrboard[0];
                            selectedcase.Image = Properties.Resources.selection_gray;
                            enable(arrboard);
                            turn2 = false;
                            turn1 = true;
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            this.KeyDown += Multi_Player_KeyDown;
                            mouse.Visible = false;
                            key.Visible = true;
                            key.Tag = p[indseat].Tag;
                            arrpieces.Remove(p[indseat]);
                            this.Controls.Remove(p[indseat]);
                            key.Image = k[indseat].Image;
                            disable(arrpieces);

                            this.Refresh();
                            if (lang == "english")
                            {
                                label_mouse.Text = "Waiting...";
                                label_key.Text = "Put the piece on the board";
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {
                                label_mouse.Text = "Attendre...";
                                label_key.Text = "Mettre la pièce sur le plateau";
                                this.Refresh();
                            }
                        }
                        else if (seatt == "m")
                        {
                            turn1 = false;
                            turn2 = true;
                            enable(arrboard);

                            this.KeyDown -= Multi_Player_KeyDown;
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            key.Visible = false;
                            mouse.Visible = true;
                            mouse.Tag = p[indseat].Tag;
                            arrpieces.Remove(p[indseat]);
                            this.Controls.Remove(p[indseat]);
                            mouse.Image = k[indseat].Image;
                            disable(arrpieces);
                            this.Refresh();
                            if (lang == "english")
                            {
                                label_key.Text = "Waiting...";
                                label_mouse.Text = "Put the piece on the board";
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {
                                label_key.Text = "Attendre...";
                                label_mouse.Text = "Mettre la pièce sur le plateau";
                                this.Refresh();
                            }
                        }
                    }
                    else
                    {
                        if (tt1 == "t")
                        {
                            this.KeyDown -= Multi_Player_KeyDown;
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            mouse.Visible = false;
                            key.Visible = true;
                            turn1 = true;
                            turn2 = false;
                            if (lang == "english")
                            {
                                label_mouse.Text = "choose a piece for " + player1;
                                label_key.Text = "Waiting...";
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {
                                label_mouse.Text = "Choisir une pièce pour " + player1;
                                label_key.Text = "Attendre...";
                                this.Refresh();
                            }
                        }
                        else
                        {
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            this.KeyDown += Multi_Player_KeyDown;
                            turn1 = false;
                            turn2 = true;
                            key.Visible = false;
                            mouse.Visible = true;
                            ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[0];
                            selectedpiece.Refresh();
                            if (lang == "english")
                            {
                                label_mouse.Text = "Waiting...";
                                label_key.Text = "choose a piece for " + player2;
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {

                                label_mouse.Text = "Attendre...";
                                label_key.Text = "Choisir une pièce pour " + player2;

                            }
                        }

                    }

                    File.Delete(Application.StartupPath + "\\turns");
                    File.Delete(Application.StartupPath + "\\quarto_stones");
                    File.Delete(Application.StartupPath + "\\seat");
                }

            }

        }

        private void Multi_Player_Load(object sender, EventArgs e)
        {
          
            count1.Text = counts1.ToString();
            count2.Text = counts2.ToString();

            end_timer.Stop();
            key.Enabled = false;
            mouse.Enabled = false;
            label1.Text = "";
            timer1_load.Enabled = true;
            timer1_load.Start();
            if (timer1_load.Enabled)
            {
                this.BackgroundImage = Properties.Resources.fatoumaaaaaaaaaaaaaaa;
                label1.Enabled = true;
                invisible();
                player_nm1.Visible = false;
                player_nm2.Visible = false;
                count1.Visible = false;
                count2.Visible = false;
                label_key.Visible = false;
                label_mouse.Visible = false;
                game_time.Visible = false;
                restart.Visible = false;
                cancel.Visible = false;
            }

            board = new PictureBox[4, 4];
            board[0, 0] = b0;
            board[0, 1] = b1;
            board[0, 2] = b2;
            board[0, 3] = b3;
            board[1, 0] = b4;
            board[1, 1] = b5;
            board[1, 2] = b6;
            board[1, 3] = b7;
            board[2, 0] = b8;
            board[2, 1] = b9;
            board[2, 2] = b10;
            board[2, 3] = b11;
            board[3, 0] = b12;
            board[3, 1] = b13;
            board[3, 2] = b14;
            board[3, 3] = b15;

            board1 = new PictureBox[4, 4];
            board1[0, 0] = b15;
            board1[0, 1] = b14;
            board1[0, 2] = b13;
            board1[0, 3] = b12;
            board1[1, 0] = b11;
            board1[1, 1] = b10;
            board1[1, 2] = b9;
            board1[1, 3] = b8;
            board1[2, 0] = b7;
            board1[2, 1] = b6;
            board1[2, 2] = b5;
            board1[2, 3] = b4;
            board1[3, 0] = b3;
            board1[3, 1] = b2;
            board1[3, 2] = b1;
            board1[3, 3] = b0;


            arrboard.Add(b0); arrboard.Add(b1); arrboard.Add(b2); arrboard.Add(b3); arrboard.Add(b4);
            arrboard.Add(b5); arrboard.Add(b6); arrboard.Add(b7); arrboard.Add(b8); arrboard.Add(b9);
            arrboard.Add(b10); arrboard.Add(b11); arrboard.Add(b12); arrboard.Add(b13); arrboard.Add(b14);
            arrboard.Add(b15);

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    int[] Coordinates = { i, j };
                    board[i, j].Tag = Coordinates;
                }
            }
        
            //brown pieces
            figure piece0;
            piece0.color = "brown"; piece0.shape = "circle"; piece0.size = "short"; piece0.hole = "no"; piece0.index = 0;
            figure piece1;
            piece1.color = "brown"; piece1.shape = "circle"; piece1.size = "short"; piece1.hole = "yes"; piece1.index = 1;
            figure piece2;
            piece2.color = "brown"; piece2.shape = "circle"; piece2.size = "tall"; piece2.hole = "no"; piece2.index = 2;
            figure piece3;
            piece3.color = "brown"; piece3.shape = "circle"; piece3.size = "tall"; piece3.hole = "yes"; piece3.index = 3;
            figure piece4;
            piece4.color = "brown"; piece4.shape = "carre"; piece4.size = "short"; piece4.hole = "no"; piece4.index = 4;
            figure piece5;
            piece5.color = "brown"; piece5.shape = "carre"; piece5.size = "short"; piece5.hole = "yes"; piece5.index = 5;
            figure piece6;
            piece6.color = "brown"; piece6.shape = "carre"; piece6.size = "tall"; piece6.hole = "no"; piece6.index = 6;
            figure piece7;
            piece7.color = "brown"; piece7.shape = "carre"; piece7.size = "tall"; piece7.hole = "yes"; piece7.index = 7;

            //beige pieces
            figure piece8;
            piece8.color = "beige"; piece8.shape = "circle"; piece8.size = "short"; piece8.hole = "no"; piece8.index = 8;
            figure piece9;
            piece9.color = "beige"; piece9.shape = "circle"; piece9.size = "short"; piece9.hole = "yes"; piece9.index = 9;
            figure piece10;
            piece10.color = "beige"; piece10.shape = "circle"; piece10.size = "tall"; piece10.hole = "no"; piece10.index = 10;
            figure piece11;
            piece11.color = "beige"; piece11.shape = "circle"; piece11.size = "tall"; piece11.hole = "yes"; piece11.index = 11;
            figure piece12;
            piece12.color = "beige"; piece12.shape = "carre"; piece12.size = "short"; piece12.hole = "no"; piece12.index = 12;
            figure piece13;
            piece13.color = "beige"; piece13.shape = "carre"; piece13.size = "short"; piece13.hole = "yes"; piece13.index = 13;
            figure piece14;
            piece14.color = "beige"; piece14.shape = "carre"; piece14.size = "tall"; piece14.hole = "no"; piece14.index = 14;
            figure piece15;
            piece15.color = "beige"; piece15.shape = "carre"; piece15.size = "tall"; piece15.hole = "yes"; piece15.index = 15;

            p0.Tag = piece0;
            p1.Tag = piece1;
            p2.Tag = piece2;
            p3.Tag = piece3;
            p4.Tag = piece4;
            p5.Tag = piece5;
            p6.Tag = piece6;
            p7.Tag = piece7;
            p8.Tag = piece8;
            p9.Tag = piece9;
            p10.Tag = piece10;
            p11.Tag = piece11;
            p12.Tag = piece12;
            p13.Tag = piece13;
            p14.Tag = piece14;
            p15.Tag = piece15;

            p = new PictureBox[16];
            p[0] = p0; p[1] = p1; p[2] = p2; p[3] = p3; p[4] = p4; p[5] = p5; p[6] = p6; p[7] = p7;
            p[8] = p8; p[9] = p9; p[10] = p10; p[11] = p11; p[12] = p12; p[13] = p13; p[14] = p14; p[15] = p15;

            k = new PictureBox[16];
            k[0] = k0; k[1] = k1; k[2] = k2; k[3] = k3; k[4] = k4; k[5] = k5; k[6] = k6; k[7] = k7;
            k[8] = k8; k[9] = k9; k[10] = k10; k[11] = k11; k[12] = k12; k[13] = k13; k[14] = k14; k[15] = k15;

            ee = new PictureBox[16];
            ee[0] = e0; ee[1] = e1; ee[2] = e2; ee[3] = e3; ee[4] = e4; ee[5] = e5; ee[6] = e6; ee[7] = e7;
            ee[8] = e8; ee[9] = e9; ee[10] = e10; ee[11] = e11; ee[12] = e12; ee[13] = e13; ee[14] = e14; ee[15] = e15;

            arrpieces.Add(p0); arrpieces.Add(p1); arrpieces.Add(p2); arrpieces.Add(p3);
            arrpieces.Add(p4); arrpieces.Add(p5); arrpieces.Add(p6); arrpieces.Add(p7);
            arrpieces.Add(p8); arrpieces.Add(p9); arrpieces.Add(p10); arrpieces.Add(p11);
            arrpieces.Add(p12); arrpieces.Add(p13); arrpieces.Add(p14); arrpieces.Add(p15);
           
            //label_key.Text = "Waiting...";
            //label_mouse.Text = "choose a piece for" + " " + player1;
            //this.Refresh();


        }

        private void pictureBox17_Click(object sender, EventArgs e) { }
        private void game_timer_Tick(object sender, EventArgs e)
        {
            s++;
            if ((s < 10) && (m < 10)) game_time.Text = "0" + m.ToString() + ":"+"0" + s.ToString();
            if ((s >= 10)&&(s<60) && (m == 0)) game_time.Text = "00" + ":" + s.ToString();
            if (s == 60)
            {
                m ++;
                s = 0;
            }
            if ((s < 10) && (m < 10)) game_time.Text = "0" + m.ToString() + ":" + "0" + s.ToString();
            if ((s >= 10) && (m < 10)) game_time.Text = "0" + m.ToString() + ":" + s.ToString();
            if ((m == 10)) game_time.Text = "10:00";
            if(game_time.Text == "10:00")
            {
                File.Delete("turns");
                File.Delete("quarto_stones");
                File.Delete("seat");
                continue_game = false;
                music.controls.stop();
                game_timer.Enabled = false;
                game_timer.Stop();
               
                minutes += 10;
                seconds += 0;
                Round_count += 1;
                Disable_Buttons();
                label_key.Enabled = true;
                label_mouse.Enabled = true;
                label_key.ForeColor = Color.Red;
                label_mouse.ForeColor = Color.Red;
                if (lang == "english")
                {
                    label_key.Text = "LOSER";
                    label_mouse.Text = "LOSER";
                }
                else if (lang == "francais")
                {
                    label_key.Text = "PERDANT";
                    label_mouse.Text = "PERDANT";
                }
                if (Round_count < 4)
                {
                    end_timer.Start();

                }
                else
                {
                    FileStream fs = new FileStream("general_info", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(4);
                    bw.Close(); fs.Close();
                    if (counts1 > counts2)
                    {
                        Result result = new Result(player1, counts1, minutes, seconds, form2, lang, player2,volume);
                        result.ShowDialog();
                    }
                    else
                    {
                        Result result = new Result(player2, counts1, minutes, seconds, form2, lang, player1,volume);
                        result.ShowDialog();
                    }
                }
            }
        }

        private void p0_Click(object sender, EventArgs e)
        {
            figure m;
            PictureBox p = (PictureBox)sender;
            m = (figure)p.Tag;
            int x = m.index;
            if ((!continue_game) || ((continue_game) && (!File.Exists("seat"))))
            {
                if (turn1)
                {
                    pieces_sound.URL = "piece_sound.wav";
                    pieces_sound.controls.play();
                    pieces_sound.settings.volume = volume;
                    this.Controls.Remove(p);
                    arrpieces.Remove(p);
                    key.Image = k[x].Image;
                    key.SizeMode = PictureBoxSizeMode.AutoSize;
                    key.Tag = p.Tag;
                    key.Enabled = true;
                    selectedcase = (PictureBox)arrboard[0];
                    selectedcase.Image = Properties.Resources.selection_gray;
                    if (lang == "english")
                    {
                        label_mouse.Text = "Waiting...";
                        label_key.Text = "put the piece on the board";
                    }
                    else if (lang == "francais")
                    {
                        label_mouse.Text = "Attendre...";
                        label_key.Text = "mettre la pièce sur le plateau";
                    }
                    this.Refresh();

                    turn1 = !turn1;

                    enable(arrboard);
                    disable(arrpieces);
                    this.KeyPreview = true;
                    try
                    {
                        this.KeyDown -= Multi_Player_KeyDown;
                    }
                    catch { };
                    this.KeyDown += Multi_Player_KeyDown;
                }
            }//end of if
            else
            {
                if ((turn1)&&(turn_count %2==1))
                {
                    pieces_sound.URL = "piece_sound.wav";
                    pieces_sound.controls.play();
                    pieces_sound.settings.volume = volume;
                    this.Controls.Remove(p);
                    arrpieces.Remove(p);
                    key.Image = k[x].Image;
                    key.SizeMode = PictureBoxSizeMode.AutoSize;
                    key.Tag = p.Tag;
                    key.Enabled = true;
                    selectedcase = (PictureBox)arrboard[0];
                    selectedcase.Image = Properties.Resources.selection_gray;
                    if (lang == "english")
                    {
                        label_mouse.Text = "Waiting...";
                        label_key.Text = "put the piece on the board";
                    }
                    else if (lang == "francais")
                    {
                        label_mouse.Text = "Attendre...";
                        label_key.Text = "mettre la pièce sur le plateau";
                    }
                    this.Refresh();

                    turn2 = false;
                    turn1 = true;
                    turn_count += 1;
                    enable(arrboard);
                    disable(arrpieces);
                    this.KeyPreview = true;
                    try
                    {
                        this.KeyDown -= Multi_Player_KeyDown;
                    }
                    catch { };
                    this.KeyDown += Multi_Player_KeyDown;
                }
            }

        }

        private void b0_Click(object sender, EventArgs e)
        {

            PictureBox b = (PictureBox)sender;

            if((!continue_game)||((continue_game)&&(!File.Exists("seat"))))
            {
                if (turn2)
                {
                    sound_button.URL = "button_sound.wav";
                    sound_button.controls.play();
                    sound_button.settings.volume = volume;
                    mouse.Visible = false;
                    key.Visible = true;
                    key.Enabled = false;
                    mouse.Enabled = false;
                    b.Image = mouse.Image;
                    b.Tag = mouse.Tag;
                    mouse.Tag = null;
                    b.SizeMode = PictureBoxSizeMode.AutoSize;
                    if (b.Height == 55)
                    {
                        b.Top -= 20;
                    }
                    if (b.Height == 40)
                    {
                        b.Top -= 7;
                    }
                    b.SendToBack();
                    b.Enabled = false;
                    arrboard.Remove(b);
                    mouse.Image = Properties.Resources.cerceau2;
                    this.Refresh();


                    if (lang == "english")
                    {
                        label_key.Text = "Waiting...";
                        label_mouse.Text = "choose a piece for" + " " + player1;
                    }
                    else if (lang == "francais")
                    {
                        label_key.Text = "Attendre...";
                        label_mouse.Text = "Choisir une pièce pour " + " " + player1;
                    }
                    check_For_Winner();
                    this.Refresh();

                    turn2 = !turn2;


                    disable(arrboard);
                    enable(arrpieces);
                    this.KeyDown -= Multi_Player_KeyDown;
                    try
                    {
                        this.KeyDown -= Multi_Player_KeyDown;
                    }
                    catch { };
                }
            }
            else 
            {
                if ((turn_count % 2 == 0) &&(turn2))
                {
                    sound_button.URL = "button_sound.wav";
                    sound_button.controls.play();
                    sound_button.settings.volume = volume;
                    mouse.Visible = false;
                    key.Visible = true;
                    key.Enabled = false;
                    mouse.Enabled = false;
                    b.Image = mouse.Image;
                    b.Tag = mouse.Tag;
                    mouse.Tag = null;
                    b.SizeMode = PictureBoxSizeMode.AutoSize;
                    if (b.Height == 55)
                    {
                        b.Top -= 20;
                    }
                    if (b.Height == 40)
                    {
                        b.Top -= 7;
                    }
                    b.SendToBack();
                    b.Enabled = false;
                    arrboard.Remove(b);
                    mouse.Image = Properties.Resources.cerceau2;
                    this.Refresh();


                    if (lang == "english")
                    {
                        label_key.Text = "Waiting...";
                        label_mouse.Text = "choose a piece for" + " " + player1;
                    }
                    else if (lang == "francais")
                    {
                        label_key.Text = "Attendre...";
                        label_mouse.Text = "Choisir une pièce pour " + " " + player1;
                    }
                    check_For_Winner();
                    this.Refresh();
                    turn2 = false;
                    turn1 = true;
                    turn_count += 1;
                    disable(arrboard);
                    enable(arrpieces);
                    this.KeyDown -= Multi_Player_KeyDown;
                    try
                    {
                        this.KeyDown -= Multi_Player_KeyDown;
                    }
                    catch { };
                }
            }
           
        }

        private void p0_Paint(object sender, PaintEventArgs e)
        {
                PictureBox p = (PictureBox)sender;
                Graphics g = e.Graphics;
                g.DrawRectangle(new Pen(Color.Goldenrod, 2), new Rectangle(0, 0, p.Width, p.Height));
        }

        private void end_timer_Tick(object sender, EventArgs e)
        {
            if (end_ticks <3) end_ticks++;
            else
            {
                end_timer.Stop();
                this.Hide();
                this.Close();
                Multi_Player multi_Player = new Multi_Player();
                multi_Player.ShowDialog();

            }
        }

        private void label_mouse_Click(object sender, EventArgs e) { }

        private void restart_Click(object sender, EventArgs e)
        {
           
            File.Delete("turns");
            File.Delete("quarto_stones");
            File.Delete("seat");
            continue_game = false;
            music.controls.stop();
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            Round_count = 1;
            counts1 = 0;
            counts2 = 0;
            Multi_Player multi_Player = new Multi_Player();
            this.Close();
           // this.Hide();
          
            multi_Player.ShowDialog();
        }

        private void Multi_Player_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            GUIDE gUIDE = new GUIDE(this);
            gUIDE.ShowDialog();

        }

        private void Multi_Player_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //File.Delete("turns");
            //File.Delete("quarto_stones");
            //File.Delete("seat");
            this.Close();
            music.controls.stop();
            form2.Show();
        }

        private void b0_MouseHover(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            if (turn2)
            {
                b.Cursor = Cursors.Hand;
                b.Image = Properties.Resources.selection_gray;
            }
            else if ( (!turn1)||(!turn2))
            {
                b.Cursor = Cursors.Default;
            }
        }

        private void b0_MouseLeave(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            if (turn2)
            {
                if (b.Enabled)
                {
                    b.Cursor = Cursors.Default;
                    b.Image = Properties.Resources.cerceau2;
                }
            }
 
        }

        private void p0_MouseHover(object sender, EventArgs e)
        {
            if (turn1)
            {
                PictureBox p = (PictureBox)sender;
                p.Cursor = Cursors.Hand;
            }
           
        }

        private void p0_MouseLeave(object sender, EventArgs e)
        {
            if (turn1)
            {
                PictureBox p = (PictureBox)sender;
                p.Cursor = Cursors.Default;
            }
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            music.controls.stop();
            // this.Close();
            this.Hide();
            form2.Show();
            form1.Show();
           
        }

        private void Multi_Player_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if ((!continue_game) || ((continue_game) && (!File.Exists("seat"))))
            {
                if (!turn2)
                {
                    figure f;
                    int indice;
                    int x = 0, y = 0;
                    int x1 = 0, y1 = 0;
                    int l = 0, l1 = 0;
                    int c, c1;
                    bool found = false;
                    bool found1 = false;
                    while ((l < 4) && (!found))
                    {
                        c = 0;
                        while ((c < 4) && (!found))
                        {
                            if (selectedcase == board[l, c])
                            {
                                x = l;
                                y = c;
                                found = true;
                            }
                            else c++;
                        }
                        l++;
                    }

                    while ((l1 < 4) && (!found1))
                    {
                        c1 = 0;
                        while ((c1 < 4) && (!found1))
                        {
                            if (selectedcase == board1[l1, c1])
                            {
                                x1 = l1;
                                y1 = c1;
                                found1 = true;
                            }
                            else c1++;
                        }
                        l1++;
                    }

                    if (e.KeyCode == Keys.Left)
                    {
                        if (y + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board[x, i].Enabled) continue;
                            //    else if (board[x, i].Enabled)
                            //    {
                            //        y = i - 1;
                            //        break;
                            //    }
                            //}
                            y = -1;
                        }

                        if (board[x, y + 1].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }

                            board[x, y + 1].Image = Properties.Resources.selection_gray;
                            selectedcase = board[x, y + 1];
                            continue_game = false;
                            this.Refresh();
                           
                        }
                        else if (!board[x, y + 1].Enabled)
                        {
                            f = (figure)(board[x, y + 1].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board[x, y + 1].Tag);
                            indice = f.index;
                            board[x, y + 1].Image = ee[indice].Image;
                            selectedcase = board[x, y + 1];
                            continue_game = false;
                            this.Refresh();
                          
                        }
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        if (x + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board[i, y].Enabled) continue;
                            //    else if (board[i, y].Enabled)
                            //    {
                            //        x = i - 1;
                            //        break;
                            //    }
                            //}
                            x = -1;
                        }

                        if (board[x + 1, y].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            board[x + 1, y].Image = Properties.Resources.selection_gray;
                            selectedcase = board[x + 1, y];
                            continue_game = false;
                            this.Refresh();
                        }
                        else if (!board[x + 1, y].Enabled)
                        {
                            f = (figure)(board[x + 1, y].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board[x + 1, y].Tag);
                            indice = f.index;
                            board[x + 1, y].Image = ee[indice].Image;
                            selectedcase = board[x + 1, y];
                            continue_game = false;
                            this.Refresh();
                        }
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        if (y1 + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board1[x1, i].Enabled) continue;
                            //    else if (board1[x1, i].Enabled)
                            //    {
                            //        y1 = i - 1;
                            //        break;
                            //    }
                            //}
                            y1 = -1;
                        }

                        if (board1[x1, y1 + 1].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            board1[x1, y1 + 1].Image = Properties.Resources.selection_gray;
                            selectedcase = board1[x1, y1 + 1];
                            continue_game = false;
                            this.Refresh();
                        }
                        else if (!board1[x1, y1 + 1].Enabled)
                        {
                            f = (figure)(board1[x1, y1 + 1].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board1[x1, y1 + 1].Tag);
                            indice = f.index;
                            board1[x1, y1 + 1].Image = ee[indice].Image;
                            selectedcase = board1[x1, y1 + 1];
                            continue_game = false;
                            this.Refresh();
                        }
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        if (x1 + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board1[i, x1].Enabled) continue;
                            //    else if (board1[i, x1].Enabled)
                            //    {
                            //        x1 = i - 1;
                            //        break;
                            //    }
                            //}
                            x1 = -1;
                        }
                        if (board1[x1 + 1, y1].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            board1[x1 + 1, y1].Image = Properties.Resources.selection_gray;
                            selectedcase = board1[x1 + 1, y1];
                            continue_game = false;
                            this.Refresh();
                        }
                        else if (!board1[x1 + 1, y1].Enabled)
                        {
                            f = (figure)(board1[x1 + 1, y1].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board1[x1 + 1, y1].Tag);
                            indice = f.index;
                            board1[x1 + 1, y1].Image = ee[indice].Image;
                            selectedcase = board1[x1 + 1, y1];
                            continue_game = false;
                              this.Refresh();
                        }
                    }

                    else if (e.KeyCode == Keys.Space)
                    {
                        if ((turn2 == false) && (selectedcase.Enabled))
                        {
                            sound_button.URL = "button_sound.wav";
                            sound_button.controls.play();
                            sound_button.settings.volume = volume;
                            mouse.Visible = true;
                            key.Visible = false;
                            selectedcase.Image = key.Image;
                            selectedcase.Tag = key.Tag;
                            key.Tag = null;
                            selectedcase.SizeMode = PictureBoxSizeMode.AutoSize;
                            if (selectedcase.Height == 55)
                            {
                                selectedcase.Top -= 20;
                            }
                            if (selectedcase.Height == 40)
                            {
                                selectedcase.Top -= 7;
                            }
                            selectedcase.SendToBack();
                            selectedcase.Enabled = false;
                            arrboard.Remove(selectedcase);
                            key.Image = Properties.Resources.cerceau2;
                            this.Refresh();
                            ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[0];
                            selectedpiece.Refresh();
                            if (lang == "english")
                            {
                                label_mouse.Text = "Waiting...";
                                label_key.Text = "choose a piece for" + " " + player2;
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {
                                label_mouse.Text = "Attendre...";
                                label_key.Text = "Choisir une pièce pour " + player2;
                                this.Refresh();
                            }
                            check_For_Winner();

                            turn2 = !turn2;

                            disable(arrboard);
                            enable(arrpieces);
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            this.KeyDown += Multi_Player_KeyDown;
                            continue_game = false;

                        }
                    }
                }

                else if (!turn1)
                {

                    int z = arrpieces.IndexOf(selectedpiece);
                    selectedpiece.Paint -= p0_Paint;
                    if (e.KeyCode == Keys.Right)
                    {
                        if (z + 1 < arrpieces.Count)
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[z + 1]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[z + 1];
                            continue_game = false;
                            this.Refresh();
                        }
                        else
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                            selectedpiece = ((PictureBox)arrpieces[0]);
                            
                            this.Refresh();
                        }
                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        if (z - 1 > -1)
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[z - 1]).Paint += p0_Paint;
                            continue_game = false;
                            selectedpiece = (PictureBox)arrpieces[z - 1];
                            this.Refresh();
                        }
                        else
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[arrpieces.Count - 1]).Paint += p0_Paint;
                            selectedpiece = ((PictureBox)arrpieces[arrpieces.Count - 1]);
                            continue_game = false;
                            this.Refresh();
                        }
                    }
                    else if ((e.KeyCode == Keys.Space) && (turn1 == false) && (turn2 == true))
                    {
                        // if (turn1=false)
                        // {
                        pieces_sound.URL = "piece_sound.wav";
                        pieces_sound.controls.play();
                        pieces_sound.settings.volume = volume;
                        key.Enabled = false;
                        mouse.Enabled = false;
                        figure m;
                        m = (figure)selectedpiece.Tag;
                        int x = m.index;
                        this.Controls.Remove(selectedpiece);
                        arrpieces.Remove(selectedpiece);
                        mouse.Image = k[x].Image;
                        mouse.Tag = selectedpiece.Tag;
                        mouse.SizeMode = PictureBoxSizeMode.AutoSize;
                        if (lang == "english")
                        {
                            label_key.Text = "Waiting...";
                            label_mouse.Text = "put the piece on the board";
                        }

                        else if (lang == "francais")
                        {
                            label_key.Text = "Attendre...";
                            label_mouse.Text = " mettre la pièce sur le plateau";
                        }
                        continue_game = false;
                        this.Refresh();

                        turn1 = !turn1;

                        enable(arrboard);
                        disable(arrpieces);

                        //   }

                    }


                }
            }
            else 
            {
                if ((!turn2)&&(turn_count%2==0))
                {

                    figure f;
                    int indice;

                    int x = 0, y = 0;
                    int x1 = 0, y1 = 0;
                    int l = 0, l1 = 0;
                    int c, c1;
                    bool found = false;
                    bool found1 = false;
                    while ((l < 4) && (!found))
                    {
                        c = 0;
                        while ((c < 4) && (!found))
                        {
                            if (selectedcase == board[l, c])
                            {
                                x = l;
                                y = c;
                                found = true;
                            }
                            else c++;
                        }
                        l++;
                    }

                    while ((l1 < 4) && (!found1))
                    {
                        c1 = 0;
                        while ((c1 < 4) && (!found1))
                        {
                            if (selectedcase == board1[l1, c1])
                            {
                                x1 = l1;
                                y1 = c1;
                                found1 = true;
                            }
                            else c1++;
                        }
                        l1++;
                    }

                    if (e.KeyCode == Keys.Left)
                    {
                        if (y + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board[x, i].Enabled) continue;
                            //    else if (board[x, i].Enabled)
                            //    {
                            //        y = i - 1;
                            //        break;
                            //    }
                            //}
                            y = -1;
                        }

                        if (board[x, y + 1].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }

                            board[x, y + 1].Image = Properties.Resources.selection_gray;
                            selectedcase = board[x, y + 1];
                            this.Refresh();
                        }
                        else if (!board[x, y + 1].Enabled)
                        {
                            f = (figure)(board[x, y + 1].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board[x, y + 1].Tag);
                            indice = f.index;
                            board[x, y + 1].Image = ee[indice].Image;
                            selectedcase = board[x, y + 1];
                            this.Refresh();
                        }
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        if (x + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board[i, y].Enabled) continue;
                            //    else if (board[i, y].Enabled)
                            //    {
                            //        x = i - 1;
                            //        break;
                            //    }
                            //}
                            x = -1;
                        }

                        if (board[x + 1, y].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            board[x + 1, y].Image = Properties.Resources.selection_gray;
                            selectedcase = board[x + 1, y];
                            this.Refresh();
                        }
                        else if (!board[x + 1, y].Enabled)
                        {
                            f = (figure)(board[x + 1, y].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board[x + 1, y].Tag);
                            indice = f.index;
                            board[x + 1, y].Image = ee[indice].Image;
                            selectedcase = board[x + 1, y];
                            this.Refresh();
                        }
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        if (y1 + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board1[x1, i].Enabled) continue;
                            //    else if (board1[x1, i].Enabled)
                            //    {
                            //        y1 = i - 1;
                            //        break;
                            //    }
                            //}
                            y1 = -1;
                        }

                        if (board1[x1, y1 + 1].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            board1[x1, y1 + 1].Image = Properties.Resources.selection_gray;
                            selectedcase = board1[x1, y1 + 1];
                            this.Refresh();
                        }
                        else if (!board1[x1, y1 + 1].Enabled)
                        {
                            f = (figure)(board1[x1, y1 + 1].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board1[x1, y1 + 1].Tag);
                            indice = f.index;
                            board1[x1, y1 + 1].Image = ee[indice].Image;
                            selectedcase = board1[x1, y1 + 1];
                            this.Refresh();
                        }
                    }
                    else if (e.KeyCode == Keys.Up)
                    {
                        if (x1 + 1 == 4)
                        {
                            //for (int i = 0; i < 4; i++)
                            //{
                            //    if (!board1[i, x1].Enabled) continue;
                            //    else if (board1[i, x1].Enabled)
                            //    {
                            //        x1 = i - 1;
                            //        break;
                            //    }
                            //}
                            x1 = -1;
                        }
                        if (board1[x1 + 1, y1].Enabled)
                        {
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            board1[x1 + 1, y1].Image = Properties.Resources.selection_gray;
                            selectedcase = board1[x1 + 1, y1];
                            this.Refresh();
                        }
                        else if (!board1[x1 + 1, y1].Enabled)
                        {
                            f = (figure)(board1[x1 + 1, y1].Tag);
                            indice = f.index;
                            if (selectedcase.Enabled)
                                selectedcase.Image = Properties.Resources.cerceau2;
                            else
                            {
                                f = (figure)(selectedcase.Tag);
                                indice = f.index;
                                selectedcase.Image = k[indice].Image;
                            }
                            f = (figure)(board1[x1 + 1, y1].Tag);
                            indice = f.index;
                            board1[x1 + 1, y1].Image = ee[indice].Image;
                            selectedcase = board1[x1 + 1, y1];
                            this.Refresh();
                        }
                    }

                    else if (e.KeyCode == Keys.Space)
                    {
                        if ((turn2 == false) && (selectedcase.Enabled)&&(turn_count%2==0))
                        {
                            sound_button.URL = "button_sound.wav";
                            sound_button.controls.play();
                            sound_button.settings.volume = volume;
                            mouse.Visible = true;
                            key.Visible = false;
                            selectedcase.Image = key.Image;
                            selectedcase.Tag = key.Tag;
                            key.Tag = null;
                            selectedcase.SizeMode = PictureBoxSizeMode.AutoSize;
                            if (selectedcase.Height == 55)
                            {
                                selectedcase.Top -= 20;
                            }
                            if (selectedcase.Height == 40)
                            {
                                selectedcase.Top -= 7;
                            }
                            selectedcase.SendToBack();
                            selectedcase.Enabled = false;
                            arrboard.Remove(selectedcase);
                            key.Image = Properties.Resources.cerceau2;
                            this.Refresh();
                            ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[0];
                            selectedpiece.Refresh();
                            if (lang == "english")
                            {
                                label_mouse.Text = "Waiting...";
                                label_key.Text = "choose a piece for" + " " + player2;
                                this.Refresh();
                            }
                            else if (lang == "francais")
                            {
                                label_mouse.Text = "Attendre...";
                                label_key.Text = "Choisir une pièce pour " + player2;
                                this.Refresh();
                            }
                            check_For_Winner();
                            turn2 = true;
                            turn1 = false;
                            turn_count += 1;
                            disable(arrboard);
                            enable(arrpieces);
                            try
                            {
                                this.KeyDown -= Multi_Player_KeyDown;
                            }
                            catch { };
                            this.KeyDown += Multi_Player_KeyDown;


                        }
                    }
                }

                else if( (!turn1)&&(turn_count %2==1))
                {

                    int z = arrpieces.IndexOf(selectedpiece);
                    selectedpiece.Paint -= p0_Paint;
                    if (e.KeyCode == Keys.Right)
                    {
                        if (z + 1 < arrpieces.Count)
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[z + 1]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[z + 1];
                            this.Refresh();
                        }
                        else
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[0]).Paint += p0_Paint;
                            selectedpiece = ((PictureBox)arrpieces[0]);
                            this.Refresh();
                        }
                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        if (z - 1 > -1)
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[z - 1]).Paint += p0_Paint;
                            selectedpiece = (PictureBox)arrpieces[z - 1];
                            this.Refresh();
                        }
                        else
                        {
                            selectedpiece.Paint -= p0_Paint;
                            ((PictureBox)arrpieces[arrpieces.Count - 1]).Paint += p0_Paint;
                            selectedpiece = ((PictureBox)arrpieces[arrpieces.Count - 1]);
                            this.Refresh();
                        }
                    }
                    else if ((e.KeyCode == Keys.Space) && (turn1 == false) && (turn2 == true))
                    {
                        // if (turn1=false)
                        // {
                        pieces_sound.URL = "piece_sound.wav";
                        pieces_sound.controls.play();
                        pieces_sound.settings.volume = volume;
                        key.Enabled = false;
                        mouse.Enabled = false;
                        figure m;
                        m = (figure)selectedpiece.Tag;
                        int x = m.index;
                        this.Controls.Remove(selectedpiece);
                        arrpieces.Remove(selectedpiece);
                        mouse.Image = k[x].Image;
                        mouse.Tag = selectedpiece.Tag;
                        mouse.SizeMode = PictureBoxSizeMode.AutoSize;
                        if (lang == "english")
                        {
                            label_key.Text = "Waiting...";
                            label_mouse.Text = "put the piece on the board";
                        }

                        else if (lang == "francais")
                        {
                            label_key.Text = "Attendre...";
                            label_mouse.Text = " mettre la pièce sur le plateau";
                        }

                        this.Refresh();
                        turn2 = true;
                        turn1 = false;
                        turn_count += 1;
                        enable(arrboard);
                        disable(arrpieces);

                        //   }

                    }


                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count_sound += 1;
            if (count_sound % 2 == 1)
            {
                music.settings.volume = volume;
                sound.Image = Properties.Resources.sound1_on;
            }

            else if (count_sound % 2 == 0)
            {
                music.settings.volume = 0;
                sound.Image = Properties.Resources.sound2_off;
            }
        }

        private void Multi_Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            continue_game = false;
            string s = game_time.Text;
            FileStream fs = new FileStream(Application.StartupPath + "\\general_info", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(Round_count);
            bw.Close(); fs.Close();
            FileStream FS = new FileStream(Application.StartupPath + "\\other_info", FileMode.Create, FileAccess.Write);
            BinaryWriter BW = new BinaryWriter(FS);
            BW.Write(counts1);
            BW.Write(counts2);
            BW.Write(count_sound);
            BW.Write(minutes);
            BW.Write(seconds);
            BW.Write(First_Move);
            BW.Write(player1);
            BW.Write(player2);
            BW.Close(); FS.Close();
            FileStream ft = new FileStream(Application.StartupPath + "\\turns", FileMode.Create, FileAccess.Write);
            BinaryWriter bt = new BinaryWriter(ft);
            if (turn1)
            {
                bt.Write("t");
            }
            else if (!turn1)
            {
                bt.Write("f");
            }
            bt.Write(s);
            bt.Close(); ft.Close();
            figure fi;
            int xi;
            if (!there_is_a_winner)
            {
                enable(arrboard);
                FileStream fq = new FileStream(Application.StartupPath + "\\quarto_stones", FileMode.Create, FileAccess.Write);
                BinaryWriter bq = new BinaryWriter(fq);
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (board[i, j].Enabled == false)
                        {
                            fi = (figure)(board[i, j].Tag);
                            xi = fi.index;
                            bq.Write(board[i, j].Name);
                            bq.Write(xi);
                        }
                        else continue;
                    }
                }
                bq.Close(); fq.Close();
                disable(arrboard);
            }
            figure fseat;
            int xseat;
            if (key.Tag != null)
            {
                fseat = (figure)(key.Tag);
                xseat = fseat.index;
                FileStream Fseat = new FileStream(Application.StartupPath + "\\seat", FileMode.Create, FileAccess.Write);
                BinaryWriter bseat = new BinaryWriter(Fseat);
                bseat.Write("k");
                bseat.Write(xseat);
                bseat.Close(); Fseat.Close();
            }
            else if (mouse.Tag != null)
            {
                fseat = (figure)(mouse.Tag);
                xseat = fseat.index;
                FileStream Fseat = new FileStream(Application.StartupPath + "\\seat", FileMode.Create, FileAccess.Write);
                BinaryWriter bseat = new BinaryWriter(Fseat);
                bseat.Write("m");
                bseat.Write(xseat);
                bseat.Close(); Fseat.Close();
            }

            //ds = new DataSet();
            //DataTable quarto = new DataTable();
            //ds.Tables.Add(quarto);

            //DataColumn dc = new DataColumn("pieces",typeof(PictureBox));
            //quarto.Columns.Add(dc);
            //dc = new DataColumn("cases", typeof(PictureBox));
            //quarto.Columns.Add(dc);
            //dc = new DataColumn("pieces_tag", typeof(figure));
            //quarto.Columns.Add(dc);
            //dc = new DataColumn("cases_tag", typeof(figure));
            //quarto.Columns.Add(dc);
            //DataRow dr;
            //for(int i = 0; i < arrpieces.Count; i++)
            //{
            //    dr = quarto.NewRow();
            //    dr["pieces"] =(PictureBox) arrpieces[i];
            //}
            //for (int i = 0; i <4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (!board[i, j].Enabled)
            //        {
            //            dr = quarto.NewRow();
            //            dr["cases"] = board[i, j];
            //            dr["cases_tag"] =(figure) board[i, j].Tag;
            //        }
            //    }
            //}
            //ds.WriteXml(Application.StartupPath + "\\quarto_save");
        }

        private void check_For_Winner()
        {
            figure m, n, o, p;
            int l = 0;
            while ((l < 4) && (!there_is_a_winner))
            {
                int c = 0;
                while (c < 4)
                {
                    if (!board[l, c].Enabled) c++;
                    else
                    {
                        l++;
                        break;
                    }
                }
                if (c == 4)
                {
                    m = (figure)(board[l, 0].Tag);
                    n = (figure)(board[l, 1].Tag);
                    o = (figure)(board[l, 2].Tag);
                    p = (figure)(board[l, 3].Tag);
                    if ((m.color == n.color) && (n.color == o.color) && (o.color == p.color))
                    {
                        there_is_a_winner = true;
                        //int a = 0;
                        //while (a < 4)
                        //{
                        //    int b = 0;

                        //}

                    }
                    else if ((m.shape == n.shape) && (n.shape == o.shape) && (o.shape == p.shape))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.size == n.size) && (n.size == o.size) && (o.size == p.size))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.hole == n.hole) && (n.hole == o.hole) && (o.hole == p.hole))
                    {
                        there_is_a_winner = true;
                    }
                    else
                    {
                        there_is_a_winner = false;
                        l++;
                    }
                }
            }
            int c1 = 0;
            while ((c1 < 4) && (!there_is_a_winner))
            {
                int l1 = 0;
                while (l1 < 4)
                {
                    if (!board[l1, c1].Enabled) l1++;
                    else
                    {
                        c1++;
                        break;
                    }
                }
                if (l1 == 4)
                {
                    m = (figure)(board[0, c1].Tag);
                    n = (figure)(board[1, c1].Tag);
                    o = (figure)(board[2, c1].Tag);
                    p = (figure)(board[3, c1].Tag);
                    if ((m.color == n.color) && (n.color == o.color) && (o.color == p.color))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.shape == n.shape) && (n.shape == o.shape) && (o.shape == p.shape))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.size == n.size) && (n.size == o.size) && (o.size == p.size))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.hole == n.hole) && (n.hole == o.hole) && (o.hole == p.hole))
                    {
                        there_is_a_winner = true;
                    }
                    else
                    {
                        there_is_a_winner = false;
                        c1++;
                    }
                }
            }

            if ((!b0.Enabled) && (!b5.Enabled) && (!b10.Enabled) && (!b15.Enabled))
            {
                figure a1 = (figure)board[0, 0].Tag;
                figure a6 = (figure)board[1, 1].Tag;
                figure a11 = (figure)board[2, 2].Tag;
                figure a16 = (figure)board[3, 3].Tag;
                if ((a1.color == a6.color) && (a6.color == a11.color) && (a11.color == a16.color))
                    there_is_a_winner = true;
                if ((a1.shape == a6.shape) && (a6.shape == a11.shape) && (a11.shape == a16.shape))
                    there_is_a_winner = true;
                if ((a1.size == a6.size) && (a6.size == a11.size) && (a11.size == a16.size))
                    there_is_a_winner = true;
                if ((a1.hole == a6.hole) && (a6.hole == a11.hole) && (a11.hole == a16.hole))
                    there_is_a_winner = true;
            }

            if ((!b3.Enabled) && (!b6.Enabled) && (!b9.Enabled) && (!b12.Enabled))
            {
                figure a4 = (figure)board[0, 3].Tag;
                figure a7 = (figure)board[1, 2].Tag;
                figure a10 = (figure)board[2, 1].Tag;
                figure a13 = (figure)board[3, 0].Tag;
                if ((a4.color == a7.color) && (a7.color == a10.color) && (a10.color == a13.color))
                    there_is_a_winner = true;
                if ((a4.shape == a7.shape) && (a7.shape == a10.shape) && (a10.shape == a13.shape))
                    there_is_a_winner = true;
                if ((a4.size == a7.size) && (a7.size == a10.size) && (a10.size == a13.size))
                    there_is_a_winner = true;
                if ((a4.hole == a7.hole) && (a7.hole == a10.hole) && (a10.hole == a13.hole))
                    there_is_a_winner = true;
            }

            if ((there_is_a_winner) && (game_time.Enabled))
            {
                File.Delete(Application.StartupPath + "\\turns");
                File.Delete(Application.StartupPath + "\\quarto_stones");
                File.Delete(Application.StartupPath + "\\seat");
                continue_game = false;
                music.controls.pause();
                minutes += int.Parse(game_time.Text.Substring(0, 2));
                seconds += int.Parse(game_time.Text.Substring(3, 2));
                if (seconds >= 60)
                {
                    minutes += (int)(seconds / 60);
                    seconds = seconds % 60;
                }


                Round_count += 1;
                Disable_Buttons();
                game_timer.Stop();

                if (!turn2)
                {
                    counts1 += 1;
                    count1.Text = counts1.ToString();
                    label_key.ForeColor = Color.LightGreen;
                    label_key.Font = new Font("Arial", 14, FontStyle.Bold);
                    label_mouse.ForeColor = Color.Red;
                    label_mouse.Font = new Font("Arial", 14, FontStyle.Bold);
                    label_key.Enabled = true;
                    label_mouse.Enabled = true;
                    if (lang == "english")
                    {
                        label_key.Text = "WINNER";
                        label_mouse.Text = "LOSER";
                    }
                    else if (lang == "francais")
                    {
                        label_key.Text = "GAGNANT";
                        label_mouse.Text = "PERDANT";
                    }

                }
                if (turn2)
                {
                    counts2 += 1;
                    count2.Text = counts2.ToString();
                    label_mouse.ForeColor = Color.LightGreen;
                    label_mouse.Font = new Font("Arial", 14, FontStyle.Bold);
                    label_key.ForeColor = Color.Red;
                    label_key.Font = new Font("Arial", 14, FontStyle.Bold);

                    label_key.Enabled = true;
                    label_mouse.Enabled = true;
                    if (lang == "english")
                    {
                        label_mouse.Text = "WINNER";
                        label_key.Text = "LOSER";
                    }
                    else if (lang == "francais")
                    {
                        label_mouse.Text = "GAGNANT";
                        label_key.Text = "PERDANT";
                    }

                }

                if (Round_count < 4)
                {
                    end_timer.Start();

                }
                else
                {
                    File.Delete(Application.StartupPath + "\\turns");
                    File.Delete(Application.StartupPath + "\\quarto_stones");
                    File.Delete(Application.StartupPath + "\\seat");
                    FileStream fs = new FileStream(Application.StartupPath +"\\general_info", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(4);
                    bw.Close();fs.Close();
                    if (counts1 > counts2)
                    {
                        this.Hide();
                        this.Close();
                        Result result = new Result(player1, counts1, minutes, seconds, form2, lang, player2,volume);
                        result.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        this.Close();
                        Result result = new Result(player2, counts2, minutes, seconds, form2, lang, player1,volume);
                        result.ShowDialog();
                    }
                }
            }
            else if (game_time.Text == "09:59")
            {
                music.controls.stop();
                game_time.Text = "10:00";
                minutes += 10;
                seconds += 0;
                Round_count += 1;
                Disable_Buttons();
                music.enabled = true;
                label_key.Enabled = true;
                label_mouse.Enabled = true;
                if (lang == "english")
                {
                    label_key.Text = "LOSER";
                    label_mouse.Text = "LOSER";
                }
                else if (lang == "francais")
                {
                    label_key.Text = "PERDANT";
                    label_mouse.Text = "PERDANT";
                }
                if (Round_count < 4)
                {
                    continue_game = false;
                    end_timer.Start();

                }
                else
                {
                    continue_game = false;
                    if (counts1 > counts2)
                    {
                        Result result = new Result(player1, counts1, minutes, seconds, form2, lang, player2,volume);
                        result.ShowDialog();
                    }
                    else
                    {
                        Result result = new Result(player2, counts1, minutes, seconds, form2, lang, player1,volume);
                        result.ShowDialog();
                    }
                }
            }

        }
        private void Disable_Buttons()
        {
            try
            {
                foreach (Control con in this.Controls) con.Enabled = false;
            }
            catch
            {
                music.enabled = true; 
            }
            
        }
       
        private void Multi_Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ok_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackgroundImage = Properties.Resources.Changed_b1;
            b.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            b.BackgroundImage = Properties.Resources.ok_b1;
            b.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void disable(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                ((PictureBox)arr[i]).Enabled = false;
            }
        }
        private void enable(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                ((PictureBox)arr[i]).Enabled = true;
            }
        }
    }
}
