
namespace Quarto_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.options = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.againstCpu = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.guide = new System.Windows.Forms.Button();
            this.multiPlayer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player_nm1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.options);
            this.groupBox1.Controls.Add(this.quit);
            this.groupBox1.Controls.Add(this.againstCpu);
            this.groupBox1.Controls.Add(this.score);
            this.groupBox1.Controls.Add(this.guide);
            this.groupBox1.Controls.Add(this.multiPlayer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(102, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 404);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Menu";
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.options.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options.FlatAppearance.BorderSize = 0;
            this.options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.options.Location = new System.Drawing.Point(62, 192);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(150, 60);
            this.options.TabIndex = 10;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = false;
            this.options.Click += new System.EventHandler(this.options_Click);
            this.options.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.options.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quit.Location = new System.Drawing.Point(295, 301);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(150, 60);
            this.quit.TabIndex = 9;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            this.quit.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.quit.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // againstCpu
            // 
            this.againstCpu.BackColor = System.Drawing.Color.Transparent;
            this.againstCpu.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.againstCpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.againstCpu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.againstCpu.FlatAppearance.BorderSize = 0;
            this.againstCpu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.againstCpu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.againstCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.againstCpu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.againstCpu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.againstCpu.Location = new System.Drawing.Point(295, 192);
            this.againstCpu.Name = "againstCpu";
            this.againstCpu.Size = new System.Drawing.Size(150, 60);
            this.againstCpu.TabIndex = 8;
            this.againstCpu.Text = "Against CPU";
            this.againstCpu.UseVisualStyleBackColor = false;
            this.againstCpu.Click += new System.EventHandler(this.againstCpu_Click);
            this.againstCpu.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.againstCpu.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.score.FlatAppearance.BorderSize = 0;
            this.score.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.score.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score.Location = new System.Drawing.Point(528, 301);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(150, 60);
            this.score.TabIndex = 7;
            this.score.Text = "High Score";
            this.score.UseVisualStyleBackColor = false;
            this.score.Click += new System.EventHandler(this.score_Click);
            this.score.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.score.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // guide
            // 
            this.guide.BackColor = System.Drawing.Color.Transparent;
            this.guide.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.guide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guide.FlatAppearance.BorderSize = 0;
            this.guide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guide.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guide.Location = new System.Drawing.Point(62, 301);
            this.guide.Name = "guide";
            this.guide.Size = new System.Drawing.Size(150, 60);
            this.guide.TabIndex = 6;
            this.guide.Text = "Guide";
            this.guide.UseVisualStyleBackColor = false;
            this.guide.Click += new System.EventHandler(this.guide_Click);
            this.guide.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.guide.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // multiPlayer
            // 
            this.multiPlayer.BackColor = System.Drawing.Color.Transparent;
            this.multiPlayer.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.multiPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.multiPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiPlayer.FlatAppearance.BorderSize = 0;
            this.multiPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.multiPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.multiPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiPlayer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiPlayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.multiPlayer.Location = new System.Drawing.Point(295, 91);
            this.multiPlayer.Name = "multiPlayer";
            this.multiPlayer.Size = new System.Drawing.Size(150, 60);
            this.multiPlayer.TabIndex = 2;
            this.multiPlayer.Text = "Multiplayer";
            this.multiPlayer.UseVisualStyleBackColor = false;
            this.multiPlayer.Click += new System.EventHandler(this.multiPlayer_Click);
            this.multiPlayer.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.multiPlayer.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Quarto_Game.Properties.Resources._2021_03_04__6_;
            this.pictureBox1.Location = new System.Drawing.Point(756, 539);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "00";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Image = global::Quarto_Game.Properties.Resources._2021_03_04__5_;
            this.cancel.Location = new System.Drawing.Point(809, 539);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(35, 35);
            this.cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cancel.TabIndex = 58;
            this.cancel.TabStop = false;
            this.cancel.Tag = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Quarto_Game.Properties.Resources._2021_03_04__4_;
            this.pictureBox2.Location = new System.Drawing.Point(706, 539);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "00";
            // 
            // player_nm1
            // 
            this.player_nm1.AutoSize = true;
            this.player_nm1.BackColor = System.Drawing.Color.Transparent;
            this.player_nm1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_nm1.ForeColor = System.Drawing.Color.Goldenrod;
            this.player_nm1.Location = new System.Drawing.Point(850, 545);
            this.player_nm1.Name = "player_nm1";
            this.player_nm1.Size = new System.Drawing.Size(73, 29);
            this.player_nm1.TabIndex = 61;
            this.player_nm1.Text = "more...";
            this.player_nm1.Click += new System.EventHandler(this.player_nm1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(109, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Niemat and  Khouloud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(120, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Dr. Bassam EL Eter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quarto_Game.Properties.Resources.fatoumaaaaaaaaaaaaaaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player_nm1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarto Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button multiPlayer;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button againstCpu;
        private System.Windows.Forms.Button score;
        private System.Windows.Forms.Button guide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label player_nm1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

