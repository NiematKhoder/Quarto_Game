using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Media;
using System.Diagnostics;

namespace Quarto_Game
{
    public partial class MORE : Form
    {
        string lang;
        Form form;
        public MORE(string l,Form f)
        {
            InitializeComponent();
            lang = l;
            form = f;
        }

        private void MORE_Load(object sender, EventArgs e)
        {
            if (lang == "english")
            {
                board.Text = "Board Games";
            }
            else if (lang == "francais")
            {
                board.Text = "Jeux De Plateau";
            }
        }

        private void MORE_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel)sender;
            Process.Start(link.Text);
        }
    }
}
