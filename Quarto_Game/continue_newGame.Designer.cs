
namespace Quarto_Game
{
    partial class continue_newGame
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
            this.newg = new System.Windows.Forms.Button();
            this.continu = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newg
            // 
            this.newg.BackColor = System.Drawing.Color.Transparent;
            this.newg.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.newg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newg.FlatAppearance.BorderSize = 0;
            this.newg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newg.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newg.Location = new System.Drawing.Point(281, 122);
            this.newg.Name = "newg";
            this.newg.Size = new System.Drawing.Size(150, 60);
            this.newg.TabIndex = 3;
            this.newg.Text = "New Game";
            this.newg.UseVisualStyleBackColor = false;
            this.newg.Click += new System.EventHandler(this.newg_Click);
            this.newg.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.newg.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // continu
            // 
            this.continu.BackColor = System.Drawing.Color.Transparent;
            this.continu.BackgroundImage = global::Quarto_Game.Properties.Resources.GoLD_b;
            this.continu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.continu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continu.FlatAppearance.BorderSize = 0;
            this.continu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.continu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.continu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.continu.Location = new System.Drawing.Point(281, 33);
            this.continu.Name = "continu";
            this.continu.Size = new System.Drawing.Size(150, 60);
            this.continu.TabIndex = 4;
            this.continu.Text = "Continue";
            this.continu.UseVisualStyleBackColor = false;
            this.continu.Click += new System.EventHandler(this.continu_Click);
            this.continu.MouseLeave += new System.EventHandler(this.multiPlayer_MouseLeave);
            this.continu.MouseHover += new System.EventHandler(this.multiPlayer_MouseHover);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.BackgroundImage = global::Quarto_Game.Properties.Resources.ok_b1;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.Black;
            this.ok.Location = new System.Drawing.Point(64, 87);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(90, 50);
            this.ok.TabIndex = 7;
            this.ok.Text = "Cancel";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            this.ok.MouseLeave += new System.EventHandler(this.ok_MouseLeave);
            this.ok.MouseHover += new System.EventHandler(this.ok_MouseHover);
            // 
            // continue_newGame
            // 
            this.AcceptButton = this.continu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quarto_Game.Properties.Resources.fatoumaaaaaaaaaaaaaaa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ok;
            this.ClientSize = new System.Drawing.Size(498, 211);
            this.ControlBox = false;
            this.Controls.Add(this.ok);
            this.Controls.Add(this.continu);
            this.Controls.Add(this.newg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "continue_newGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.continue_newGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newg;
        private System.Windows.Forms.Button continu;
        private System.Windows.Forms.Button ok;
    }
}