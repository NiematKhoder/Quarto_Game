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
    public partial class Result : Form
    {
        string winner, loser;
        int rounds_won, minutes, seconds;
        Form form;
        string lang;
        int volume;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        private void Result_FormClosed(object sender, FormClosedEventArgs e)
        {
            ok_bt.PerformClick();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            HIGH_SCORE hIGH_SCORE= new HIGH_SCORE(winner, int.Parse(counts_nb.Text), minutes, seconds,loser);
            this.Hide();
            form.Show();
            this.Close();
           
           
        }

        public Result(string namew,int count,int min,int sec,Form f,string l,string namel,int v)
        {
            InitializeComponent();
            winner = namew;
            rounds_won = count;
            minutes = min;
            seconds = sec;
            form = f;
            lang = l;
            loser = namel;
            volume = v;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (lang == "english")
            {
                label1.Text = "Rounds Won :";
                label2.Text = "Total Time :";
                winner_name.Text = winner + " Won";
                counts_nb.Text = rounds_won.ToString();
                time.Text = minutes.ToString() + " minutes_" + seconds.ToString() + " seconds";
            }
            else if (lang == "francais")
            {
                label1.Text = "Tours Gangnants :";
                label2.Text = "Temps Total :";
                winner_name.Text = winner + " a Gagné";
                counts_nb.Text = rounds_won.ToString();
                time.Text = minutes.ToString() + " minutes_" + seconds.ToString() + " seconds";
            }


        }
    }
}
