using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace Quarto_Game
{
    public partial class RESULT_CPUcs : Form
    {
        Form form;
        int volume;
        string lang;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        public RESULT_CPUcs(string n, int c1, int c2, Form f, string l,int v)
        {
            InitializeComponent();
            label5.Text = n;
            counts_nb.Text = c1.ToString();
            label2.Text = c2.ToString();
            form = f;
            lang = l;
            volume = v;
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            form.Show();
            this.Close();
            this.Hide();
        }
        private void start_MouseHover(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.BackgroundImage = Properties.Resources.Changed_b1;
                b.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { };
        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.BackgroundImage = Properties.Resources.GoLD_b;
                b.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { };
        }

        private void RESULT_CPUcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            ok_bt.PerformClick();
        }

        private void RESULT_CPUcs_Load(object sender, EventArgs e)
        {
            if (lang == "english")
            {
                label4.Text = "Player's name :";
                label1.Text = "Rounds Won :";
            }
            else if (lang == "francais")
            {
                label4.Text = "Nom du joueur :";
                label1.Text = "tours gagnants :";
            }
        }
    }
}
