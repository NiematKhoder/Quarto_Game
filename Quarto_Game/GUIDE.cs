using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WMPLib;
using AxWMPLib;
namespace Quarto_Game
{
    public partial class GUIDE : Form
    {
        Form form;
        static string lang;
        static int volume;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        public GUIDE(Form f)
        {
            InitializeComponent();
            form = f;
        }
        public static void set_language(string l,int v)
        {
            lang = l;
            volume = v;
        }
        public GUIDE()
        {
            InitializeComponent();
        }
        private void GUIDE_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "quarto_video.mp4";
            axWindowsMediaPlayer1.settings.volume = volume;

            if (lang == "english")
            {
                ok.Text = "Cancel";
                button1.Text = Settings1.Default.guide_text_eng;
            }
            else if (lang == "francais")
            {
                ok.Text = "Annuler";
                button1.Text = Settings1.Default.guide_text_french;
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            axWindowsMediaPlayer1.URL = null;
            this.Hide();
            form.Show();
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
       

        private void GUIDE_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            ok.PerformClick();
        }
    }
}
