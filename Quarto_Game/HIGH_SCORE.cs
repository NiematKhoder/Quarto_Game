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
using WMPLib;
namespace Quarto_Game
{
    public partial class HIGH_SCORE : Form
    {
        int minutess, secondss;
        string winner, loser;
        int rounds_won, minutes, seconds;
        static string lang;
        static int volume;
         Form form;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        public HIGH_SCORE(Form f)
        {
            InitializeComponent();
            form = f;
           // read_file();
        }
        public HIGH_SCORE(string namew, int count, int min, int sec,string namel)
        {
            InitializeComponent();

            read_file();
            winner = namew;
            rounds_won = count;
            minutes = min;
            seconds = sec;
            loser = namel;
            High_Score();
        }
        public static void set_language(string l,int v)
        {
            lang = l;
            volume = v;
        }

        private void High_Score()
        {
            if (rounds_won >= int.Parse(high_count.Text))
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\highscore", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                if (minutes < int.Parse(lowest_time.Text.Substring(0, 2)))
                {
                    bw.Write(winner);
                    bw.Write(rounds_won);
                    bw.Write(minutes);
                    bw.Write(seconds);
                    bw.Write(loser);
                }
                else if (minutes == int.Parse(lowest_time.Text.Substring(0, 2)))
                {
                    if (seconds < int.Parse(lowest_time.Text.Substring(11, 2)))
                    {
                        bw.Write(winner);
                        bw.Write(rounds_won);
                        bw.Write(minutes);
                        bw.Write(seconds);
                        bw.Write(loser);
                    }
                }
                bw.Close(); fs.Close();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            form.Show();
            this.Close();
            //this.Hide();
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



        private void HIGH_SCORE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HIGH_SCORE_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            ok.PerformClick();
        }

        private void HIGH_SCORE_Load(object sender, EventArgs e)
        {
            change_language();
            read_file();
        }
        private void change_language()
        {
            if (lang == "english")
            {
                label1.Text = "Winner's name :";
                label4.Text = "Rounds won :";
                label2.Text = "Total time :";
                label5.Text = "Opponent's name :";
                winner_name.Text = "Unknown";
                label3.Text = "Unknown";
                high_count.Text = "0";
                lowest_time.Text = "30 minutes_00 seconds";
            }
            else if (lang == "francais")
            {
                label1.Text = "Nom du gagnant :";
                label4.Text = "Tours gangnants :";
                label4.Left -= 12;
                label2.Text = "Temps total :";
                label5.Text = "Nom du opposant :";
                winner_name.Text = "Inconnu";
                label3.Text = "Inconnu";
                high_count.Text = "0";
                lowest_time.Text = "30 minutes_00 seconds";
            }
        }

        private void read_file()
        {
            if (File.Exists(Application.StartupPath + "\\highscore"))
            {
                FileStream fr = new FileStream(Application.StartupPath + "\\highscore", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fr);
              //  MessageBox.Show(fr.Length.ToString());
                string s = br.ReadString();
                int a= br.ReadInt32();
                minutess = br.ReadInt32();
                secondss = br.ReadInt32();
                string ss = br.ReadString();
                br.Close(); fr.Close();
                winner_name.Text = s;
                high_count.Text = a.ToString();
                label3.Text = ss;
                lowest_time.Text = minutess.ToString() + " minutes_" + secondss.ToString() + " seconds";
                
            }
            else
            {
                if (lang == "english")
                {
                    winner_name.Text = "Unknown";
                    label3.Text = "Unknown";
                    high_count.Text = "0";
                    lowest_time.Text = "30 minutes_00 seconds";
                }
                else if (lang == "francais")
                {
                    winner_name.Text = "Iconnu";
                    label3.Text = "Iconnu";
                    high_count.Text = "0";
                    lowest_time.Text = "30 minutes_00 seconds";
                }
            }
        }
    }
}
