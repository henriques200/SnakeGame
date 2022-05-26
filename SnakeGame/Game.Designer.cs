namespace SnakeGame
{
    partial class Game
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_txt_1 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label_game_over = new System.Windows.Forms.Label();
            this.pause_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label_txt_1
            // 
            this.label_txt_1.AutoSize = true;
            this.label_txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_txt_1.Location = new System.Drawing.Point(12, 9);
            this.label_txt_1.Name = "label_txt_1";
            this.label_txt_1.Size = new System.Drawing.Size(90, 20);
            this.label_txt_1.TabIndex = 1;
            this.label_txt_1.Text = "Pontuação:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(108, 9);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(29, 20);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "----";
            // 
            // label_game_over
            // 
            this.label_game_over.AutoSize = true;
            this.label_game_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_game_over.Location = new System.Drawing.Point(22, 51);
            this.label_game_over.Name = "label_game_over";
            this.label_game_over.Size = new System.Drawing.Size(51, 20);
            this.label_game_over.TabIndex = 4;
            this.label_game_over.Text = "label1";
            this.label_game_over.Visible = false;
            this.label_game_over.Click += new System.EventHandler(this.label1_Click);
            // 
            // pause_label
            // 
            this.pause_label.AutoSize = true;
            this.pause_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_label.Location = new System.Drawing.Point(124, 264);
            this.pause_label.Name = "pause_label";
            this.pause_label.Size = new System.Drawing.Size(309, 24);
            this.pause_label.TabIndex = 5;
            this.pause_label.Text = "PAUSA - Usa as setas para retomar.";
            this.pause_label.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 500);
            this.Controls.Add(this.pause_label);
            this.Controls.Add(this.label_game_over);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_txt_1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Jogo da Cobra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_txt_1;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label_game_over;
        private System.Windows.Forms.Label pause_label;
    }
}

