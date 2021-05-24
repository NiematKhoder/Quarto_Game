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
    public partial class players_names : Form
    {
        string selected_text = "First Player";
         static  string lang;
        static int volume;
        Form form;
   
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        public players_names(Form f)
        {
            InitializeComponent();
            form = f;
        }
        public static void set_language (string l,int v)
        {
            lang = l;
            volume = v;
        }
        private void change_language()
        {
            if (lang == "english")
            {
                label1.Text = "Second Player:";
                label2.Text = "First pLayer:";
                label3.Text = "play using the keyboard";
                label4.Text = "play using the mouse";
                label5.Text = "First Move:";
                cancel.Text = "Cancel";
                start.Text = "PLAY";
                comboBox1.Items.Clear();
                this.comboBox1.Items.AddRange(new object[]
                {
                  "First Player",
                 "Second Player",
                 "Take turns"
                });
            }
            else if (lang == "francais")
            {
                label1.Text = "Deuxième Joueur:";
                label1.Left -= 25;
                label2.Text = "Premier Joueur:";
                label2.Left -= 25;
                label3.Text = "jouer avec le clavier";
                label4.Text = "jouer avec la souris";
                label5.Text = "Premier Mouvement:";
                comboBox1.Width += 50;
                cancel.Text = "Annuler";
                start.Text = "JOUER";
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(new object[]
                {
                   "Premier Joueur",
                 "Deuxieme Joueur",
                 "Prendre les tours" 
                });

            }
        }
        private void cancel_Click(object sender, EventArgs e)
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
        private void start_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            Name1.Text.Trim(); Name2.Text.Trim();

            if ((Name1.Text == string.Empty) || (Name2.Text == string.Empty))
            {
                MessageBox.Show("Enter Players'Names!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                bool check_second = false;
                bool continuer = true;
                int i = 0, j = 0;
                while ((i < Name1.Text.Length) && (continuer))
                {
                    {
                        if (!char.IsLetter(Name1.Text[i]))
                        {

                            MessageBox.Show("Only letters are allowed", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            continuer = false;
                            check_second = false;

                        }
                        else i++;
                    }
                }
                if (i == Name1.Text.Length)
                {
                    check_second = true;

                    while ((j < Name2.Text.Length) && (continuer) && (check_second))
                    {
                        if (!char.IsLetter(Name2.Text[j]))
                        {
                            MessageBox.Show("Only letters are allowed", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            continuer = false;
                        }
                        else j++;
                    }
                }
                if (j == Name2.Text.Length)
                {
                    Multi_Player.set_static_variables(Name1.Text.Trim(), Name2.Text.Trim(),0,0,1,selected_text,0,0,lang,form,1,volume,false);
                     Multi_Player multi_Player = new Multi_Player(this);
                    this.Hide();
                    multi_Player.ShowDialog();
                }
            }
        }

        private void players_names_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void players_names_Load(object sender, EventArgs e)
        {
            change_language();
        }

        private void players_names_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

            }
            if (e.KeyCode == Keys.Enter)
            {
                start.PerformClick();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_text = comboBox1.Text;
            if (selected_text == "Premier Joueur") selected_text = "First Player";
            else if (selected_text == "Deuxieme Joueur") selected_text = "Second Player";
            else if (selected_text == "Prendre les tours") selected_text = "Take turns";
        }

        private void players_names_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            cancel.PerformClick();
        }
    }
}
