using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using WMPLib;
namespace Quarto_Game
{
    public partial class Form1 : Form
    {
        int _ticks = 0, volume;
        LOADING lOADING;
        string lang; OPTIONS oPTIONS;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();

        bool isopening = true;
        public bool ISOPENING
        {
            set
            {
                isopening = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
             oPTIONS = new OPTIONS();
             lang= oPTIONS.LANGUAGE;
            // sound_button.URL = "button.sound.wav";
             volume = oPTIONS.VOLUME;
        }
        
         
        private void multiPlayer_MouseHover(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.BackgroundImage = Properties.Resources.Changed_b1;
                b.BackgroundImageLayout = ImageLayout.Stretch;

            }
            catch { };
        }

        private void multiPlayer_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                b.BackgroundImage = Properties.Resources.GoLD_b;
                b.BackgroundImageLayout = ImageLayout.Stretch;
            
                
            }
            catch { };
        }

        private void options_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            oPTIONS.ISOPEN = true;
            oPTIONS.ShowDialog();
            while (oPTIONS.ISOPEN)
            {
                Application.DoEvents();
            }
            volume = oPTIONS.VOLUME;
            lang = oPTIONS.LANGUAGE;
            change_lang();
        }

        private void multiPlayer_Click(object sender, EventArgs e)
        {
            int c;
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            if (File.Exists("general_info"))
            {
                FileStream fr = new FileStream("general_info", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fr);

                c = br.ReadInt32();
                br.Close();fr.Close();
                if (c <= 3)
                {
                    continue_newGame continue_New = new continue_newGame(this);
                    continue_newGame.set_language(lang, volume,c);
                    continue_New.ShowDialog();
                }
                else
                {
                    File.Delete("general_info");
                    players_names players_Names = new players_names(this);
                    players_names.set_language(lang, volume);
                    this.Hide();
                    players_Names.ShowDialog();
                }
           
            }
            else
            {
                players_names players_Names = new players_names(this);
                players_names.set_language(lang, volume);
                this.Hide();
                players_Names.ShowDialog();
            }
          
          
        }

        private void options_Click_1(object sender, EventArgs e)
        {
            OPTIONS oPTIONS = new OPTIONS();
            this.Hide();
            oPTIONS.ShowDialog();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
             lOADING = new LOADING();
            lOADING.ShowDialog();
            change_lang();

        }

        private void change_lang()
        {
            if (lang == "english")
            {
                multiPlayer.Text = "Multiplayer";
                againstCpu.Text = "Against CPU";
                quit.Text = "Quit";
                score.Text = "High Score";
                options.Text = "Options";
                guide.Text = "Guide";
                groupBox1.Text = "Main Menu";
         
              
            }
            else if (lang == "francais")
            {
                multiPlayer.Text = "Multijoueur";
                againstCpu.Text = "Contre CPU";
                quit.Text = "Quitter";
                score.Text = "Score Elevé";
                options.Text = "Options";
                guide.Text = "Guide";
                groupBox1.Text = "Menu principal";
              
      
            }
        }

        private void score_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            HIGH_SCORE hIGH_SCORE = new HIGH_SCORE(this);
            HIGH_SCORE.set_language(lang,volume);
            this.Hide();
            hIGH_SCORE.ShowDialog();
        }

        private void againstCpu_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            PLAYERNAME pLAYERNAME = new PLAYERNAME(this);
            PLAYERNAME.set_language(lang,volume);
            this.Hide();
            pLAYERNAME.ShowDialog();
        }

        private void guide_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            GUIDE gUIDE = new GUIDE(this);
            GUIDE.set_language(lang,volume);
            this.Hide();
            gUIDE.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 2)
            {
                timer1.Stop();
                lOADING.Close();
                lOADING.Hide();
            }
        }

        private void player_nm1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MORE mORE = new MORE(lang, this);
            mORE.ShowDialog();

        }

        private void about_Click(object sender, EventArgs e)
        {
       
        }

        private void quit_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            if (lang == "english")
            {
                DialogResult rep = MessageBox.Show("Do you want to exit", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes) Application.Exit();
            }
          else if (lang == "francais")
            {
                DialogResult rep = MessageBox.Show("Est ce que tu veux quitter", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes) Application.Exit();
            }
        }
    }
}
