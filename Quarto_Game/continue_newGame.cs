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
using System.Xml;
using WMPLib;
namespace Quarto_Game
{
    public partial class continue_newGame : Form
    {
        int counts1, counts2, minutes, seconds,count_sound;
        string player1, player2, first_move;
        Form form;
        
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
        private void newg_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            File.Delete("general_info");
            File.Delete("other_info");
            File.Delete("turns");
            File.Delete("quarto_stones");
            File.Delete("seat");
            players_names players_Names = new players_names(this);
            players_names.set_language(lang, volume);
            this.Hide();
            this.Close();
            players_Names.ShowDialog();
          
           
        }

        private void continue_newGame_Load(object sender, EventArgs e)
        {
            if (lang == "english")
            {
                ok.Text = "Cancel";
                continu.Text = "Continue";
                newg.Text = "New Game";
            }
            else if (lang == "francais")
            {
                ok.Text = "Annuler";
                continu.Text = "Continuer";
                newg.Text = "Nouveau Jeu";
            }
        }

        private void continu_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            if(File.Exists("other_info"))
            {
                FileStream fr = new FileStream(Application .StartupPath +"\\other_info", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fr);
                counts1 = br.ReadInt32();
                counts2 = br.ReadInt32();
                count_sound = br.ReadInt32();
                minutes = br.ReadInt32();
                seconds = br.ReadInt32();
                first_move = br.ReadString();
                player1 = br.ReadString();
                player2 = br.ReadString();
                br.Close();fr.Close();
            }
            File.Delete("general_info");
            File.Delete("other_info");
            Multi_Player.set_static_variables(player1,player2, counts1, counts2 , Round_count , first_move , minutes , seconds , lang, form, count_sound , volume, true );

            Multi_Player multi_Player = new Multi_Player();
            this.Hide();
            this.Close();
            
            multi_Player.ShowDialog ();

        }

        private void ok_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            this.Close();
            form.Show();
        }

        static string lang;
        static int volume, Round_count;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        public static void set_language(string l, int v,int c)
        {
            lang = l;
            volume = v;
            Round_count = c;
        }
        public continue_newGame(Form f)
        {
            InitializeComponent();
            form = f;
        }
        
    }
}
