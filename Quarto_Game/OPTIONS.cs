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
    public partial class OPTIONS : Form
    {
        string languages="english";
        int vol =50;
        bool isopen = false;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
      
        public int VOLUME
        {
            get { return vol; }
        }
        public string LANGUAGE
        {
            get { return languages; }
        }
        public bool ISOPEN
        {
            get
            {
                return isopen;
            }
            set { isopen = value; }
        }

        public OPTIONS()
        {
            InitializeComponent();
            load_options();
        }

        private void OPTIONS_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancel_b.PerformClick();
        }

        private void ok_Paint(object sender, PaintEventArgs e) { }

        private void load_options()
        {
            if (File.Exists("language"))
            {
                FileStream fr = new FileStream("language", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fr);
                groupBox1.Text = br.ReadString();
                groupBox2.Text = br.ReadString();
                english.Text = br.ReadString();
                francais.Text = br.ReadString();
                ok.Text = br.ReadString();
                cancel_b.Text = br.ReadString();
                languages = br.ReadString();
                groupBox3.Text = br.ReadString(); 
                br.Close();
                fr.Close();
            }
            if (File.Exists("sounds"))
            {
                FileStream FR = new FileStream(Application.StartupPath + "\\sounds", FileMode.Open, FileAccess.Read);
                BinaryReader BR = new BinaryReader(FR);
                vol = BR.ReadInt32();
                BR.Close();FR.Close();
                trackBar1.Value = vol;
            }

        }

        private void ok_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = trackBar1.Value;
            if (english.Checked)
            {
                groupBox1.Text = "OPTIONS";
                groupBox2.Text = "Language";
                english.Text = "English";
                francais.Text = "French";
                ok.Text = "OK";
                cancel_b.Text = "Cancel";
       
                languages = "english";
                groupBox3.Text = "Sound";

            }
            else if (francais.Checked)
            {
                groupBox1.Text = "OPTIONS";
                groupBox2.Text = "Langue";
                english.Text = "Anglais";
                francais.Text = "Français";
                ok.Text = "OK";
               
                cancel_b.Text = "Annuler";
                
                languages = "francais";
                groupBox3.Text = "Volume";
            }

            FileStream fs = new FileStream("language", FileMode.Create, FileAccess.Write);

            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(groupBox1.Text);
            bw.Write(groupBox2.Text);
            bw.Write(english.Text);
            bw.Write(francais.Text);
            bw.Write(ok.Text);
            bw.Write(cancel_b.Text);
            
            bw.Write(languages);
            bw.Write(groupBox3.Text);
            bw.Close(); fs.Close();


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

        private void cancel_b_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = trackBar1.Value;
            //  Form1 f1 = new Form1();
            isopen = false;
            this.Hide();
           // f1.ShowDialog();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            vol = trackBar1.Value;
            FileStream fm = new FileStream("sounds", FileMode.Create, FileAccess.Write);
            BinaryWriter bm = new BinaryWriter(fm);
            bm.Write(vol);
            bm.Close();fm.Close();
            sound.Image = Properties.Resources.sound_on;
            if (trackBar1.Value == 0)
                sound.Image = Properties.Resources.sound_off;
        }

        private void OPTIONS_Load(object sender, EventArgs e)
        {
            if (vol != 0) 
                sound.Image = Properties.Resources.sound_on;
           else  if (vol == 0)
                sound.Image = Properties.Resources.sound_off;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
           // trackBar1.Value = vol;
        }

        private void trackBar1_VisibleChanged(object sender, EventArgs e)
        {
           // trackBar1.Value = vol;
        }
    }
}
