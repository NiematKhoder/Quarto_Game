
namespace Quarto_Game
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.winner_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ok_bt = new System.Windows.Forms.Button();
            this.counts_nb = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winner_name
            // 
            this.winner_name.AutoSize = true;
            this.winner_name.BackColor = System.Drawing.Color.Transparent;
            this.winner_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winner_name.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winner_name.Location = new System.Drawing.Point(272, 121);
            this.winner_name.Name = "winner_name";
            this.winner_name.Size = new System.Drawing.Size(425, 57);
            this.winner_name.TabIndex = 0;
            this.winner_name.Text = "Niemat is the WINNER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(151, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rounds Won :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(178, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Time :";
            // 
            // ok_bt
            // 
            this.ok_bt.BackColor = System.Drawing.Color.Transparent;
            this.ok_bt.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.ok_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok_bt.FlatAppearance.BorderSize = 0;
            this.ok_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ok_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ok_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_bt.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_bt.Location = new System.Drawing.Point(726, 468);
            this.ok_bt.Name = "ok_bt";
            this.ok_bt.Size = new System.Drawing.Size(150, 60);
            this.ok_bt.TabIndex = 3;
            this.ok_bt.Text = "OK";
            this.ok_bt.UseVisualStyleBackColor = false;
            this.ok_bt.Click += new System.EventHandler(this.ok_bt_Click);
            // 
            // counts_nb
            // 
            this.counts_nb.AutoSize = true;
            this.counts_nb.BackColor = System.Drawing.Color.Transparent;
            this.counts_nb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.counts_nb.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counts_nb.ForeColor = System.Drawing.Color.Green;
            this.counts_nb.Location = new System.Drawing.Point(358, 265);
            this.counts_nb.Name = "counts_nb";
            this.counts_nb.Size = new System.Drawing.Size(28, 33);
            this.counts_nb.TabIndex = 4;
            this.counts_nb.Text = "2";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Green;
            this.time.Location = new System.Drawing.Point(358, 369);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(234, 33);
            this.time.TabIndex = 5;
            this.time.Text = "X minutes & Y seconds";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quarto_Game.Properties.Resources.fatoumaaaaaaaaaaaaaaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.time);
            this.Controls.Add(this.counts_nb);
            this.Controls.Add(this.ok_bt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winner_name);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarto Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Result_FormClosed);
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winner_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok_bt;
        private System.Windows.Forms.Label counts_nb;
        private System.Windows.Forms.Label time;
    }
}