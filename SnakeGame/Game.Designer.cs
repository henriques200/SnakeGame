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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_txt_1 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label_game_over = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 397);
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
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.label_game_over);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_txt_1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Game";
            this.Text = "Form1";
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
    }
}

