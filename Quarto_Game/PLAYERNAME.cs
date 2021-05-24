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
   
    public partial class PLAYERNAME : Form
    {
        string selected_text = "Computer";
        Form form;
        static string lang;
        static int volume;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        public PLAYERNAME(Form f)
        {
            InitializeComponent();
            form = f;
        }
        public static void set_language(string l,int v)
        {
            lang = l;
            volume = v;
        }
        private void start_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            Name1.Text.Trim();

            if (Name1.Text == string.Empty)
            {
                MessageBox.Show("Enter Players'Names!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                bool continuer = true;
                int i = 0;
                while ((i < Name1.Text.Length) && (continuer))
                {
                    {
                        if (!char.IsLetter(Name1.Text[i]))
                        {

                            MessageBox.Show("Only letters are allowed", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            continuer = false;
                        }
                        else i++;
                    }
                }
                if (i == Name1.Text.Length)
                {
                    AGAINST_CPU.set_static_variables(Name1.Text.Trim(),0, 0, 1, selected_text, 0, 0,this,form,volume,lang,1);
                    AGAINST_CPU aGAINST_CPU = new AGAINST_CPU();
                    this.Hide();
                    aGAINST_CPU.ShowDialog();

                }
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            form.Show();
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
        private void players_names_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_text = comboBox1.Text;
            if (selected_text == "Joueur") selected_text = "Player";
            else if (selected_text == "Ordinateur") selected_text = "Computer";
            else if (selected_text == "Prendre les tours") selected_text = "Take turns";
        }

        private void PLAYERNAME_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancel.PerformClick();
        }

        private void PLAYERNAME_Load(object sender, EventArgs e)
        {
            if (lang == "english")
            {
                label2.Text = "Player's name :";
                label5.Text = "First Move :";
                cancel.Text = "Cancel";
                start.Text = "PLAY";
                comboBox1.Items.Clear();
                this.comboBox1.Items.AddRange(new object[]
                {
                  "Player",
                 "Computer",
                 "Take turns"
                });
            }
            else if (lang == "francais")
            {
                label2.Text = "Nom du joueur :";
                label5.Text = "Premier Mouvement :";
                cancel.Text = "Annuler";
                start.Text = "JOUER";
                comboBox1.Width += 50;
                comboBox1.Items.Clear();
                this.comboBox1.Items.AddRange(new object[]
                {
                  "Joueur",
                 "Ordinateur",
                 "Prendre les tours"
                });
            }
        }
    }
}
