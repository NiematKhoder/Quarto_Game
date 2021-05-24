
namespace Quarto_Game
{
    partial class OPTIONS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPTIONS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.sound = new System.Windows.Forms.PictureBox();
            this.cancel_b = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ok = new System.Windows.Forms.Button();
            this.francais = new System.Windows.Forms.RadioButton();
            this.english = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cancel_b);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(125, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTIONS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.sound);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(68, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 112);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sound";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(40, 44);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(352, 56);
            this.trackBar1.TabIndex = 58;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.VisibleChanged += new System.EventHandler(this.trackBar1_VisibleChanged);
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sound.Image = global::Quarto_Game.Properties.Resources.sound_on;
            this.sound.Location = new System.Drawing.Point(409, 44);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(50, 50);
            this.sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sound.TabIndex = 57;
            this.sound.TabStop = false;
            this.sound.Tag = "00";
            // 
            // cancel_b
            // 
            this.cancel_b.BackColor = System.Drawing.Color.Transparent;
            this.cancel_b.BackgroundImage = global::Quarto_Game.Properties.Resources.ok_b1;
            this.cancel_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel_b.FlatAppearance.BorderSize = 0;
            this.cancel_b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancel_b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancel_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_b.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_b.ForeColor = System.Drawing.Color.Black;
            this.cancel_b.Location = new System.Drawing.Point(30, 374);
            this.cancel_b.Name = "cancel_b";
            this.cancel_b.Size = new System.Drawing.Size(90, 50);
            this.cancel_b.TabIndex = 4;
            this.cancel_b.Text = "cancel";
            this.cancel_b.UseVisualStyleBackColor = false;
            this.cancel_b.Click += new System.EventHandler(this.cancel_b_Click);
            this.cancel_b.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            this.cancel_b.MouseHover += new System.EventHandler(this.ok_MouseHover);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ok);
            this.groupBox2.Controls.Add(this.francais);
            this.groupBox2.Controls.Add(this.english);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(68, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 166);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Language";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.BackgroundImage = global::Quarto_Game.Properties.Resources.ok_b1;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.Black;
            this.ok.Location = new System.Drawing.Point(420, 99);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(90, 50);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            this.ok.MouseHover += new System.EventHandler(this.ok_MouseHover);
            // 
            // francais
            // 
            this.francais.AutoSize = true;
            this.francais.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.francais.ForeColor = System.Drawing.Color.White;
            this.francais.Location = new System.Drawing.Point(253, 73);
            this.francais.Name = "francais";
            this.francais.Size = new System.Drawing.Size(130, 39);
            this.francais.TabIndex = 4;
            this.francais.TabStop = true;
            this.francais.Text = "Francais";
            this.francais.UseVisualStyleBackColor = true;
            this.francais.Paint += new System.Windows.Forms.PaintEventHandler(this.ok_Paint);
            // 
            // english
            // 
            this.english.AutoSize = true;
            this.english.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.english.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.english.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.english.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.english.ForeColor = System.Drawing.Color.White;
            this.english.Location = new System.Drawing.Point(64, 73);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(116, 39);
            this.english.TabIndex = 3;
            this.english.TabStop = true;
            this.english.Text = "English";
            this.english.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.english.UseVisualStyleBackColor = true;
            // 
            // OPTIONS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Quarto_Game.Properties.Resources.fatoumaaaaaaaaaaaaaaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "OPTIONS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarto Game";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OPTIONS_FormClosed);
            this.Load += new System.EventHandler(this.OPTIONS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton francais;
        private System.Windows.Forms.RadioButton english;
        private System.Windows.Forms.Button cancel_b;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox sound;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}